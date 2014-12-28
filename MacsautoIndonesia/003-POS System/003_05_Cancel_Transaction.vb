Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class _003_05_Cancel_Transaction
    Private ReadOnly _headerBindingSource As BindingSource
    Private ReadOnly _worker As New BackgroundWorker
    Private ReadOnly _detailDataTable As New DataTable()
    Private _authorizationForm As _006_04_Authorization_Form

    Public Sub New()
        InitializeComponent()

        AddHandler _worker.DoWork, AddressOf worker_DoWork
        AddHandler _worker.RunWorkerCompleted, AddressOf worker_RunWorkerCompleted

        _headerBindingSource = New BindingSource()

        _detailDataTable.Columns.Add("TrItem")
        _detailDataTable.Columns.Add("TrItemPrice")
        _detailDataTable.Columns.Add("TrItemQty")
        _detailDataTable.Columns.Add("TrItemDiscount")
        _detailDataTable.Columns.Add("TrItemSubtotal")
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If Not String.IsNullOrEmpty(TransactionIdTxt.Text) Then
            _worker.RunWorkerAsync()
        End If
    End Sub

    Private Sub worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Dim result As Collection = CType(e.Result, Collection)

        _headerBindingSource.DataSource = result.Item("header")

        If (CustomerNameTxt.DataBindings.Count = 0) Then
            CustomerNameTxt.DataBindings.Add("Text", _headerBindingSource, "cname", True, DataSourceUpdateMode.OnPropertyChanged)
            VehicleTypeTxt.DataBindings.Add("Text", _headerBindingSource, "vtype", True, DataSourceUpdateMode.OnPropertyChanged)
            LicenseTxt.DataBindings.Add("Text", _headerBindingSource, "linum", True, DataSourceUpdateMode.OnPropertyChanged)
            VehicleBrandTxt.DataBindings.Add("Text", _headerBindingSource, "vbrnd", True, DataSourceUpdateMode.OnPropertyChanged)
            VehicleModelTxt.DataBindings.Add("Text", _headerBindingSource, "vmodl", True, DataSourceUpdateMode.OnPropertyChanged)
            VehicleColorTxt.DataBindings.Add("Text", _headerBindingSource, "vcolr", True, DataSourceUpdateMode.OnPropertyChanged)
            CreatedTxt.DataBindings.Add("Text", _headerBindingSource, "trdat", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "dd FF YY")
            AdminTxt.DataBindings.Add("Text", _headerBindingSource, "name")
        End If

        If Not String.IsNullOrEmpty(LicenseTxt.Text) Then
            Dim query As String = "SELECT * FROM dtransaction" & _
            " LEFT JOIN hproduct ON dtransaction.idpdt = hproduct.idpdt" & _
            " LEFT JOIN hservice ON dtransaction.idsvc = hservice.idsvc" & _
            " WHERE trsid = '" & TransactionIdTxt.Text & "'"
            Dim detailReader As MySqlDataReader = ExecQueryReader(query)

            DataGridView1.Rows.Clear()

            While detailReader.Read()
                Dim subTotal As Double = (detailReader("trqty") * detailReader("price"))

                If detailReader("idisc") <> 0 Then
                    subTotal = (subTotal - (subTotal * detailReader("idisc") / 100))
                End If

                DataGridView1.Rows.Add({
                    If(Not IsDBNull(detailReader("idsvc")), detailReader("svcdc"), detailReader("pdtds")),
                    detailReader("price"),
                    detailReader("trqty"),
                    detailReader("idisc"),
                    subTotal
                })
            End While
        End If

        UpdateLabel((result.Item("header").Rows.Count & " transaction(s) found"))
    End Sub

    Private Sub worker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim result As New Collection()
        Dim query As String = "SELECT * FROM htransaction" & _
            " LEFT JOIN payment ON htransaction.trsid = payment.trsid" & _
            " LEFT JOIN hcustomer ON htransaction.idcus = hcustomer.idcus" & _
            " LEFT JOIN dcustomer ON htransaction.idcus = dcustomer.idcus AND htransaction.linum = dcustomer.linum" & _
            " LEFT JOIN employee ON htransaction.createdBy = employee.id" & _
            " LEFT JOIN jourhd ON htransaction.trsid = jourhd.rfdoc AND (jourhd.cancl = '' OR jourhd.cancl IS NULL)" & _
            " WHERE htransaction.trsid = '" & TransactionIdTxt.Text & "'" & _
            " AND htransaction.trstat = 'PAID'"
        Dim reader As MySqlDataReader = ExecQueryReader(query)
        Dim dataTable As New DataTable()

        dataTable.Load(reader)

        result.Add(dataTable, "header")

        e.Result = result
    End Sub

    Private Sub UpdateLabel(ByVal textToShow As String)
        ResultCountLabel.Text = textToShow
        SubmitBtn.Enabled = _headerBindingSource.DataSource.Rows.Count > 0
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click, SubmitBtn.Click
        If String.IsNullOrEmpty(LicenseTxt.Text) Then
            MessageBox.Show("No selected transaction", "Error")
        ElseIf String.IsNullOrEmpty(RemarkTxt.Text) Then
            MessageBox.Show("Remark is required", "Error")
        Else
            _authorizationForm = New _006_04_Authorization_Form(AuthorizationLevel.Admin)

            AddHandler _authorizationForm.AuthorizationFailed, AddressOf AuthorizationFailed
            AddHandler _authorizationForm.AuthorizationSuccess, AddressOf AuthorizationSuccess

            '_authorizationForm.ShowDialog(Me)

            Dim authorizedUser As New Dictionary(Of String, String)

            authorizedUser.Add("Id", LoggedInEmployee.Id)
            authorizedUser.Add("Name", LoggedInEmployee.Name)
            authorizedUser.Add("Position", LoggedInEmployee.Position)

            AuthorizationSuccess(Me, New AuthorizationSuccessEventArgs(authorizedUser))
        End If
    End Sub

    Private Sub AuthorizationSuccess(ByVal sender As Object, ByVal e As AuthorizationSuccessEventArgs)
        If MessageBox.Show("Cancelling transaction. Are you sure?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim journalDocId = _headerBindingSource.DataSource.Select("trsid = '" & TransactionIdTxt.Text & "'")(0)("docid").ToString()

                If (String.IsNullOrEmpty(journalDocId) OrElse (Not String.IsNullOrEmpty(journalDocId) And MessageBox.Show("This transaction is already journaled. Cancelling will result to a reversal of that journal. Are you sure?", "COnfirmation", MessageBoxButtons.YesNo) = DialogResult.Yes)) Then
                    DoInTransaction(
                    Function() As Boolean
                        ExecQuery("UPDATE htransaction SET trstat = 'CANCELLED', updatedBy = '" & e.AuthorizedUser.Item("Id") & "', remrk = '" & RemarkTxt.Text & "' WHERE trsid = '" & TransactionIdTxt.Text & "'")

                        If (Not String.IsNullOrEmpty(journalDocId)) Then
                            Dim adapter As New MySqlCommand("SELECT * FROM jourdt WHERE docid = '" & journalDocId & "'", GetConnection())
                            Dim reader As MySqlDataReader = adapter.ExecuteReader(CommandBehavior.CloseConnection)
                            Dim table As New DataTable()

                            table.Load(reader)
                            reader.Close()

                            ExecQueryNonReader("INSERT INTO jourhd (SELECT (docid + 1) AS newId, NOW(), NOW(), '" & TransactionIdTxt.Text & "', 'REVERSAL', '', '', NOW(), 'AD', 'X' FROM jourhd ORDER BY docid DESC LIMIT 1)")

                            Dim jourReader As MySqlDataReader = ExecQueryReader("SELECT docid FROM jourhd ORDER BY docid DESC LIMIT 1")

                            If (jourReader.Read()) Then
                                Dim newJournalId As String = jourReader(0)

                                For Each row As DataRow In table.Rows
                                    ExecQueryNonReader("INSERT INTO jourdt VALUES('" & newJournalId & "', '" & row("glnum") & "', '" & If(row("pstky") = "10", "20", "10") & "', '" & row("psamt") & "', '')")
                                Next
                            End If

                            jourReader.Close()
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
End Class