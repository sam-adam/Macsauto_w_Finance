Public Class _002_09_Customer
    Private ReadOnly _customersDataTable As DataTable
    Private _customersDataView As DataView
    Private _customersBindingSource As BindingSource

    Private Const DateTimeFormat As String = "dd MMMM yyyy"

    Public Sub New()
        InitializeComponent()

        _customersDataTable = New DataTable()
        _customersDataView = New DataView()
        _customersBindingSource = New BindingSource()

        RefreshCustomerTable()
    End Sub

    Private Sub RefreshCustomerTable()
        Const customersQuery As String =
            "SELECT hcustomer.idcus," & _
            "   hcustomer.cname," & _
            "   hcustomer.cgndr," & _
            "   hcustomer.cudob," & _
            "   hcustomer.cphon," & _
            "   hcustomer.ccpon," & _
            "   hcustomer.cmail," & _
            "   hcustomer.cadd1," & _
            "   hcustomer.cpoin," & _
            "   hcustomer.cstat," & _
            "   IF(hcustomer.cstat = 'Member', 1, 0) AS is_member" & _
            " FROM hcustomer"

        _customersDataTable.Rows.Clear()
        _customersDataTable.Load(ExecQueryReader(customersQuery))

        _customersDataView = _customersDataTable.AsDataView()
        _customersBindingSource.DataSource = _customersDataView

        If CustomerDataGrid.DataBindings.Count = 0 Then
            With CustomerDataGrid
                .AutoGenerateColumns = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AllowUserToResizeColumns = True
                .AllowUserToResizeRows = False
                .DataSource = _customersBindingSource

                .Columns(CustomerIdCol.Index).DataPropertyName = "idcus"
                .Columns(CustomerNameCol.Index).DataPropertyName = "cname"
                .Columns(CustomerCellphoneCol.Index).DataPropertyName = "ccpon"
                .Columns(CustomerIsMemberCol.Index).DataPropertyName = "is_member"
                .Columns(CustomerDoBCol.Index).DataPropertyName = "cudob"
                .Columns(CustomerDoBCol.Index).DefaultCellStyle.Format = DateTimeFormat
                .Columns(CustomerAddressCol.Index).DataPropertyName = "cadd1"
            End With
        End If

        CustomerNameLbl.DataBindings.Add("Text", _customersBindingSource, "cname", False, DataSourceUpdateMode.Never)

        UpdateSearch()
    End Sub

    Private Sub UpdateSearch()
        Dim filter As String = "cname LIKE '%" & CustomerNameTxt.Text & "%'"

        If MemberOnlyChk.Checked Then
            filter &= " AND is_member = " & MemberOnlyChk.Checked
        End If

        _customersDataView.RowFilter = filter

        CustomerDataGrid.DataSource = _customersDataView

        If CustomerDataGrid.Rows.Count > 0 Then
            CustomerDataGrid.Rows(0).Cells(0).Selected = True
        End If
    End Sub

    Private Sub CustomerNameTxt_TextChanged(sender As Object, e As EventArgs) Handles CustomerNameTxt.TextChanged
        UpdateSearch()
    End Sub

    Private Sub MemberOnlyChk_CheckedChanged(sender As Object, e As EventArgs) Handles MemberOnlyChk.CheckedChanged
        UpdateSearch()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Refresh()
    End Sub
End Class