Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.Services

Public Class _003_05_Cancel_Transaction
    Private _authorizationForm As _006_04_Authorization_Form

    Public Sub New()
        InitializeComponent()

        SubmitBtn.DataBindings.Add("Enabled", TransactionDetailView, "HasResult", False, DataSourceUpdateMode.Never)

        TransactionDetailView.PerformBinding()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        If TransactionDetailView.TransactionHeaderDataTable.Rows.Count = 0 Then
            ErrorInput(TransactionIdTxt, "No selected transaction")
        ElseIf String.IsNullOrEmpty(RemarkTxt.Text) Then
            ErrorInput(RemarkTxt, "Remark is required")
        Else
            _authorizationForm = New _006_04_Authorization_Form(AuthorizationLevel.Supervisor)

            AddHandler _authorizationForm.AuthorizationFailed, AddressOf AuthorizationFailed
            AddHandler _authorizationForm.AuthorizationSuccess, AddressOf AuthorizationSuccess

            _authorizationForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub AuthorizationSuccess(ByVal sender As Object, ByVal e As AuthorizationSuccessEventArgs)
        If MsgBox("Cancelling transaction. This action cannot be reversed! Are you sure?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "Confirmation") = DialogResult.Yes Then
            Try
                Dim journalDataTable As DataTable = AccountingService.FindTransactionJournal(TransactionIdTxt.Text, AccountingService.JournalStatusNotCancelled)

                If (journalDataTable.Rows.Count = 0 OrElse (journalDataTable.Rows.Count > 0 AndAlso Not String.IsNullOrEmpty(journalDataTable.Rows(0)("docid")) AndAlso MsgBox("This transaction is already journaled. Cancelling will result to a reversal of that journal. Are you sure?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = DialogResult.Yes)) Then
                    DoInTransaction(
                        Function(command As MySqlCommand) As Boolean
                            command.CommandText = "UPDATE htransaction SET trstat = 'CANCELLED', updatedBy = @authorizedUserId, remrk = @remark WHERE trsid = @transactionId"
                            command.CreateParameter()

                            command.Parameters.Clear()
                            command.Parameters.AddWithValue("authorizedUserId", e.AuthorizedUser.Item("Id"))
                            command.Parameters.AddWithValue("remark", RemarkTxt.Text)
                            command.Parameters.AddWithValue("transactionId", TransactionIdTxt.Text)

                            command.ExecuteNonQuery()

                            If journalDataTable.Rows.Count > 0 Then
                                Dim journalDocId As String = journalDataTable.Rows(0)("docid")

                                AccountingService.ReverseAJournal(command, journalDocId, e.AuthorizedUser.Item("Id"))
                            End If

                            Return True
                        End Function)

                    MessageBox.Show("Transaction cancelled", "Success", MessageBoxButtons.OK)

                    Dispose()
                End If
            Catch ex As Exception
                Throw
            End Try
        End If
    End Sub

    Private Shared Sub AuthorizationFailed()
        MessageBox.Show("Cannot cancel transaction. Admin level authorization required", "Notice")
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Dispose()
    End Sub

    Private Sub TransactionIdTxt_TextChanged(sender As Object, e As EventArgs) Handles TransactionIdTxt.TextChanged
        TransactionDetailView.FindTransaction(TransactionIdTxt.Text, "NOT CANCELLED")
    End Sub
End Class