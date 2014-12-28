Imports System.ComponentModel

Public Class _009_09_Set_Service_Account
    Private ReadOnly _allServiceQuery As Func(Of Boolean, String) =
        Function(notAssignedOnly As Boolean)
            Dim query As String = "SELECT hservice.idsvc, hservice.idsvt, hservice.svcdc, servicetype.svtdc, hservice.glnum, glaccountms.gldes, accounttype.actds" & _
                " FROM hservice" & _
                " LEFT JOIN servicetype ON hservice.idsvt = servicetype.idsvt" & _
                " LEFT JOIN glaccountms ON hservice.glnum = glaccountms.glnum" & _
                " LEFT JOIN accounttype ON glaccountms.actid = accounttype.actid" & _
                " WHERE idsvc LIKE '%{0}%'" & _
                " OR svcdc LIKE '%{0}%'"

            If notAssignedOnly Then
                query &= " AND hservice.glnum IS NULL"
            End If

            Return query
        End Function
    Private ReadOnly _allAccountQuery As String = "SELECT glaccountms.glnum, glaccountms.gldes, glaccountms.actid, glaccountms.ispnl, accounttype.actds" & _
        " FROM glaccountms" & _
        " LEFT JOIN accounttype ON glaccountms.actid = accounttype.actid" & _
        " WHERE glsta = 'Active'"
    Private ReadOnly _allServiceTypeQuery As String = "SELECT idsvt,svtdc" & _
        " FROM servicetype"
    Private ReadOnly _dataTable As DataTable
    Private ReadOnly _accountDataTable As DataTable
    Private ReadOnly _searchAccountForm As _005_11_GLAccount
    Private ReadOnly _serviceTypeDataTable As DataTable
    Private ReadOnly _saveBackgroundWorker As BackgroundWorker

    Public Sub New()
        InitializeComponent()

        _dataTable = New DataTable()
        _accountDataTable = New DataTable()
        _searchAccountForm = New _005_11_GLAccount()
        _serviceTypeDataTable = New DataTable()
        _saveBackgroundWorker = New BackgroundWorker()

        _dataTable.Load(ExecQueryReader(String.Format(_allServiceQuery(AccountTypeChk.Checked), "")))
        _serviceTypeDataTable.Load(ExecQueryReader(_allServiceTypeQuery))
        _accountDataTable.Load(ExecQueryReader(_allAccountQuery))

        With ServiceItemsDataGridView
            .AutoGenerateColumns = False
            .DataSource = _dataTable
            .Columns("ServiceId").DataPropertyName = "idsvc"
            .Columns("ServiceType").DataPropertyName = "svtdc"
            .Columns("ServiceDesc").DataPropertyName = "svcdc"
            .Columns("ServiceGLAccount").DataPropertyName = "glnum"
            .Columns("ServiceGLAccountDesc").DataPropertyName = "gldes"
        End With

        ServiceIdTxt.DataBindings.Add("Text", _dataTable, "idsvc", False, DataSourceUpdateMode.OnPropertyChanged, "")
        ServiceTypeTxt.DataBindings.Add("Text", _dataTable, "svtdc", False, DataSourceUpdateMode.OnPropertyChanged, "")
        ServiceDescTxt.DataBindings.Add("Text", _dataTable, "svcdc", False, DataSourceUpdateMode.OnPropertyChanged, "")
        AccountNoTxt.DataBindings.Add("Text", _dataTable, "glnum", False, DataSourceUpdateMode.Never, "")
        AccountDescTxt.DataBindings.Add("Text", _dataTable, "gldes", False, DataSourceUpdateMode.Never, "")
        AccountTypeTxt.DataBindings.Add("Text", _dataTable, "actds", False, DataSourceUpdateMode.Never, "")

        For Each row As DataRow In _serviceTypeDataTable.Rows
            ServiceTypeCbo.Items.Add(New KeyValuePair(Of String, String)(row("idsvt"), row("svtdc")))
        Next
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Dispose()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        _dataTable.Rows.Clear()
        _dataTable.Load(ExecQueryReader(String.Format(_allServiceQuery(AccountTypeChk.Checked), SearchTxt.Text)))
    End Sub

    Private Sub SearchAccountBtn_Click(sender As Object, e As EventArgs) Handles SearchAccountBtn.Click
        AddHandler _searchAccountForm.AccountSelected,
            Sub(s As Object, arg As SelectedAccountEventArgs)
                If Not String.IsNullOrEmpty(arg.AccountNumber) Then
                    Dim selectedAccount As DataRow = _accountDataTable.Select("glnum = " & arg.AccountNumber).First()

                    If Not selectedAccount Is Nothing Then
                        AccountNoTxt.Text = selectedAccount("glnum").ToString()
                        AccountDescTxt.Text = selectedAccount("gldes").ToString()
                        AccountTypeTxt.Text = selectedAccount("actds").ToString()
                        AccountPnLChk.Checked = (selectedAccount("ispnl").ToString() = "X")
                    End If
                End If

                _searchAccountForm.Close()
            End Sub

        _searchAccountForm.ShowDialog()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If SetByAccountTab.SelectedTab.Equals(SetByServiceItemTabPage) Then
            If MsgBox("Save service account setting?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                SaveByServiceItem()
            End If
        Else
            If MsgBox("Save service type account setting?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                SaveByServiceType()
            End If
        End If
    End Sub

    Private Sub SaveByServiceItem()
        If String.IsNullOrEmpty(AccountNoTxt.Text) Then
            MsgBox("Please choose the associated GLAccount for this service", MsgBoxStyle.OkOnly, "Error")
        Else
            If _dataTable.Select("idsvc = '" & ServiceIdTxt.Text & "'").First()("glnum").Equals(AccountNoTxt.Text) Then
                MsgBox("Nothing to save", MsgBoxStyle.OkOnly, "Notice")
            Else
                Dim saveQuery As String = "UPDATE hservice SET glnum = '" & AccountNoTxt.Text & "' WHERE idsvc = '" & ServiceIdTxt.Text & "'"
                Dim saveMessage As String = "Updating '" & AccountDescTxt.Text & "' GL Account to '" & AccountNoTxt.Text & " - " & AccountDescTxt.Text & "'"

                DoSaveInBackground(saveQuery, saveMessage,
                    Sub()
                        _dataTable.Rows.Clear()
                        _dataTable.Load(ExecQueryReader(String.Format(_allServiceQuery(AccountTypeChk.Checked), "")))
                    End Sub)
            End If
        End If
    End Sub

    Private Sub SaveByServiceType()
        If ServiceTypeCbo.SelectedIndex = -1 Then
            MsgBox("Please choose the service type to assign account to", MsgBoxStyle.OkOnly, "Error")
        ElseIf String.IsNullOrEmpty(ServiceTypeAccountNoTxt.Text) Then
            MsgBox("Please choose the associated GLAccount for this service type", MsgBoxStyle.OkOnly, "Error")
        Else
            Dim saveQuery As String = "UPDATE hservice SET glnum = '" & ServiceTypeAccountNoTxt.Text & "' WHERE idsvt = '" & CType(ServiceTypeCbo.SelectedItem, KeyValuePair(Of String, String)).Key & "'"
            Dim saveMessage As String = "Batch updating service with type of '" & CType(ServiceTypeCbo.SelectedItem, KeyValuePair(Of String, String)).Value & "' GL Account to '" & ServiceTypeAccountNoTxt.Text & "'"

            DoSaveInBackground(saveQuery, saveMessage,
                Sub()
                    _serviceTypeDataTable.Clear()
                    _serviceTypeDataTable.Load(ExecQueryReader(_allServiceTypeQuery))
                    _dataTable.Rows.Clear()
                    _dataTable.Load(ExecQueryReader(String.Format(_allServiceQuery(AccountTypeChk.Checked), "")))

                    ServiceTypeItemsGridView.DataSource = _dataTable.Select("idsvt = '" & CType(ServiceTypeCbo.SelectedItem, KeyValuePair(Of String, String)).Key & "'").CopyToDataTable()
                End Sub)
        End If
    End Sub

    Private Sub DoSaveInBackground(ByVal query As String, ByVal message As String, Optional ByVal callback As Action = Nothing)
        Dim timer As New Windows.Forms.Timer

        AddHandler timer.Tick,
            Sub(sender As Object, e As EventArgs)
                MessageLabel.Text &= "."
            End Sub

        MessageLabel.Text = message

        timer.Interval = 100
        timer.Start()

        AddHandler _saveBackgroundWorker.DoWork,
            Sub(sender As Object, e As DoWorkEventArgs)
                DoInTransaction(
                    Function()
                        ExecQueryNonReader(query)

                        Return True
                    End Function)
            End Sub
        AddHandler _saveBackgroundWorker.RunWorkerCompleted,
            Sub(sender As Object, e As RunWorkerCompletedEventArgs)
                timer.Stop()

                MessageLabel.Text = "Success - " & message

                If Not callback Is Nothing Then
                    callback.Invoke()
                End If
            End Sub

        _saveBackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub ServiceTypeCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ServiceTypeCbo.SelectedIndexChanged
        Dim services As DataTable = _dataTable.Select("idsvt = '" & CType(ServiceTypeCbo.SelectedItem, KeyValuePair(Of String, String)).Key & "'").CopyToDataTable()

        TotalServicesTxt.Text = services.Rows.Count()

        With ServiceTypeItemsGridView
            .AutoGenerateColumns = False
            .DataSource = services
            .Columns("ServiceTypeServiceId").DataPropertyName = "idsvc"
            .Columns("ServiceTypeServiceType").DataPropertyName = "svtdc"
            .Columns("ServiceTypeServiceDesc").DataPropertyName = "svcdc"
            .Columns("ServiceTypeServiceGLAccount").DataPropertyName = "glnum"
            .Columns("ServiceTypeServiceGLAccountDesc").DataPropertyName = "gldes"
        End With
    End Sub

    Private Sub ServiceTypeSearchAccountBtn_Click(sender As Object, e As EventArgs) Handles ServiceTypeSearchAccountBtn.Click
        AddHandler _searchAccountForm.AccountSelected,
            Sub(s As Object, arg As SelectedAccountEventArgs)
                If Not String.IsNullOrEmpty(arg.AccountNumber) Then
                    Dim selectedAccount As DataRow = _accountDataTable.Select("glnum = " & arg.AccountNumber).First()

                    If Not selectedAccount Is Nothing Then
                        ServiceTypeAccountNoTxt.Text = selectedAccount("glnum").ToString()
                        ServiceTypeAccountDescTxt.Text = selectedAccount("gldes").ToString()
                        ServiceTypeAccountTypeTxt.Text = selectedAccount("actds").ToString()
                        ServiceTypeAccountPnLChk.Checked = (selectedAccount("ispnl").ToString() = "X")
                    End If
                End If

                _searchAccountForm.Close()
            End Sub

        _searchAccountForm.ShowDialog()
    End Sub

    Private Sub _009_09_Set_Service_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class