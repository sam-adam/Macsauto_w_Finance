Imports MacsautoIndonesia.Services
Imports System.Collections.Specialized

Public Class _001_19_Accounting_Configuration
    Const AllAccountsQuery As String =
        "SELECT glaccountms.glnum," & _
        "   glaccountms.gldes," & _
        "   glaccountms.actid," & _
        "   glaccountms.ispnl," & _
        "   glaccountms.glsta," & _
        "   accounttype.actds" & _
        " FROM glaccountms" & _
        " LEFT JOIN accounttype ON glaccountms.actid = accounttype.actid" & _
        " WHERE glaccountms.glsta = 'Active'"

    Private ReadOnly _allAccountsDataTable As DataTable

    Public Sub New()
        InitializeComponent()

        _allAccountsDataTable = New DataTable()
        _allAccountsDataTable.Load(ExecQueryReader(AllAccountsQuery))

        For Each account As DataRow In _allAccountsDataTable.Select("actid = 4")
            CashPaymentCbo.Items.Add(New KeyValuePair(Of String, String)(account("glnum"), account("gldes")))
            CardPaymentCbo.Items.Add(New KeyValuePair(Of String, String)(account("glnum"), account("gldes")))
        Next

        If AccountingService.IsConfigurationValid("transaction_cash") Then
            CashPaymentCbo.SelectedItem = CashPaymentCbo.Items.OfType(Of KeyValuePair(Of String, String)).FirstOrDefault(
                Function(item As KeyValuePair(Of String, String))
                    Return item.Key = My.Settings.AutomaticPostingConfiguration.Find("transaction_cash")
                End Function)
        End If

        If AccountingService.IsConfigurationValid("transaction_card") Then
            CardPaymentCbo.SelectedItem = CardPaymentCbo.Items.OfType(Of KeyValuePair(Of String, String)).FirstOrDefault(
                Function(item As KeyValuePair(Of String, String))
                    Return item.Key = My.Settings.AutomaticPostingConfiguration.Find("transaction_card")
                End Function)
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If CashPaymentCbo.SelectedItem Is Nothing Then
            ErrorInput(CashPaymentCbo, "Cash payment account is required")
        ElseIf CardPaymentCbo.SelectedItem Is Nothing Then
            ErrorInput(CardPaymentCbo, "Card payment account is required")
        Else
            If My.Settings.AutomaticPostingConfiguration Is Nothing Then
                My.Settings.AutomaticPostingConfiguration = New ArrayList()
            End If

            My.Settings.AutomaticPostingConfiguration.SafeAdd("transaction_cash", CType(CashPaymentCbo.SelectedItem, KeyValuePair(Of String, String)).Key)
            My.Settings.AutomaticPostingConfiguration.SafeAdd("transaction_card", CType(CardPaymentCbo.SelectedItem, KeyValuePair(Of String, String)).Key)
            My.Settings.Save()

            MsgBox("Configuration is saved", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success")

            Dispose()
        End If
    End Sub
End Class