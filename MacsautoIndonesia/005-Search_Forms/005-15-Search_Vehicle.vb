Public Class _005_15_Search_Vehicle
    Public Event CustomerVehicleSelected As EventHandler(Of CustomerVehicleSelectedEventArgs)

    Private ReadOnly _customersDataTable As DataTable
    Private ReadOnly _vehicleDataTable As DataTable
    Private ReadOnly _customerVehiclesDataTable As DataTable
    Private _customersDataView As DataView

    Public Sub New()
        My.Settings.Database = "macsauto_clean"

        InitializeComponent()

        _customersDataTable = New DataTable()
        _customersDataView = New DataView()
        _vehicleDataTable = New DataTable()
        _customerVehiclesDataTable = New DataTable()

        ReloadData()

        With CustomerDataGrid
            .AutoGenerateColumns = False
            .DataSource = _customersDataView

            .Columns(CustomerIdCol.Index).DataPropertyName = "idcus"
            .Columns(CustomerNameCol.Index).DataPropertyName = "cname"
            .Columns(CustomerGenderCol.Index).DataPropertyName = "cgndr"
            .Columns(CustomerDoBCol.Index).DataPropertyName = "cudob"
            .Columns(CustomerPhoneCol.Index).DataPropertyName = "cphon"
            .Columns(CustomerCellphoneCol.Index).DataPropertyName = "ccpon"
            .Columns(CustomerMailCol.Index).DataPropertyName = "cmail"
            .Columns(CustomerAddressCol.Index).DataPropertyName = "cadd1"
            .Columns(CustomerPointCol.Index).DataPropertyName = "cpoin"
            .Columns(CustomerIsMember.Index).DataPropertyName = "is_member"
        End With
    End Sub

    Private Sub ReloadData()
        Const allCustomerQuery As String =
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
            "   (hcustomer.cstat = 'Member') AS is_member" & _
            " FROM hcustomer"
        Const allVehicleQuery As String =
            "SELECT dcustomer.idcus," & _
            "   dcustomer.idbrn," & _
            "   dcustomer.idvmd," & _
            "   dcustomer.idcol," & _
            "   dcustomer.linum," & _
            "   dcustomer.vexpd," & _
            "   dcustomer.vyear," & _
            "   dcustomer.vkilo," & _
            "   dcustomer.vtype," & _
            "   vehiclebrand.brdsc," & _
            "   vehiclemodel.modsc," & _
            "   vehiclemodel.idsiz," & _
            "   vehiclesize.sizdc," & _
            "   vehiclecolor.coldc" & _
            " FROM dcustomer" & _
            " LEFT JOIN vehiclebrand ON dcustomer.idbrn = vehiclebrand.idbrn" & _
            " LEFT JOIN vehiclemodel ON dcustomer.idvmd = vehiclemodel.idvmd" & _
            " LEFT JOIN vehiclecolor ON dcustomer.idcol = vehiclecolor.idcol" & _
            " LEFT JOIN vehiclesize ON vehiclemodel.idsiz = vehiclesize.idsiz"

        _customersDataTable.Rows.Clear()
        _customersDataTable.Load(ExecQueryReader(allCustomerQuery))
        _customersDataView = _customersDataTable.AsDataView()

        _vehicleDataTable.Rows.Clear()
        _vehicleDataTable.Load(ExecQueryReader(allVehicleQuery))

        With CustomerDataGrid
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            .AllowUserToResizeColumns = True
            .AllowUserToOrderColumns = True
        End With

        SearchTxt.Focus()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        ReloadData()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        SelectCustomerVehicle()
    End Sub

    Private Sub SelectCustomerVehicle()
        If VehicleDataGrid.SelectedCells.Count = 0 Then
            MsgBox("No vehicle selected", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        Else
            Dim selectedCustomerId As String = CustomerDataGrid.CurrentRow.Cells(CustomerIdCol.Index).Value
            Dim selectedVehicleReg As String = VehicleDataGrid.CurrentRow.Cells(0).Value

            RaiseEvent CustomerVehicleSelected(Me, New CustomerVehicleSelectedEventArgs(selectedCustomerId, selectedVehicleReg))
        End If
    End Sub

    Private Sub CustomerDataGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGrid.CellEnter
        Dim selectedCustomerId As String = CustomerDataGrid.CurrentRow.Cells(CustomerIdCol.Index).Value

        _customerVehiclesDataTable.Rows.Clear()
        _customerVehiclesDataTable.Load(_vehicleDataTable.Select("idcus = '" & selectedCustomerId & "'").CopyToDataTable().CreateDataReader())
    End Sub

    Private Sub _005_15_Search_Vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With VehicleDataGrid
            .AutoGenerateColumns = False
            .DataSource = _customerVehiclesDataTable

            .Columns(VehicleRegColumn.Index).DataPropertyName = "linum"
            .Columns(VehicleModelCol.Index).DataPropertyName = "modsc"
            .Columns(VehicleBrandCol.Index).DataPropertyName = "brdsc"
            .Columns(VehicleColorCol.Index).DataPropertyName = "coldc"
            .Columns(VehicleTypeCol.Index).DataPropertyName = "vtype"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AllowUserToResizeColumns = True
            .AllowUserToOrderColumns = True
        End With

        SearchTxt.Focus()
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        Dim customerIds As String = String.Join(",", _vehicleDataTable.Select("linum LIKE '%" & SearchTxt.Text & "%'").Select(Of String)(
            Function(row As DataRow)
                Return ("'" & row("idcus") & "'")
            End Function))
        
        _customersDataView.RowFilter = "cname LIKE '%" & SearchTxt.Text & "%'"

        If Not String.IsNullOrEmpty(customerIds) Then
            _customersDataView.RowFilter &= " OR idcus IN (" & customerIds & ")"
        End If

        CustomerDataGrid.DataSource = _customersDataView

        If CustomerDataGrid.Rows.Count > 0 Then
            CustomerDataGrid.Rows(0).Cells(0).Selected = True
        End If
    End Sub

    Private Sub _005_15_Search_Vehicle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SearchTxt.Text = ""
    End Sub

    Private Sub CustomerDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGrid.CellDoubleClick
        SelectCustomerVehicle()
    End Sub

    Private Sub VehicleDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VehicleDataGrid.CellDoubleClick
        SelectCustomerVehicle()
    End Sub

    Private Sub CustomerDataGrid_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles CustomerDataGrid.RowsRemoved
        If CustomerDataGrid.Rows.Count = 0 Then
            _customerVehiclesDataTable.Rows.Clear()
        End If
    End Sub

    Private Sub CustomerDataGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustomerDataGrid.KeyPress
        If e.KeyChar.SameAsKey(Keys.Enter) Then
            SelectCustomerVehicle()
        End If
    End Sub

    Private Sub VehicleDataGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VehicleDataGrid.KeyPress
        If e.KeyChar.SameAsKey(Keys.Enter) Then
            SelectCustomerVehicle()
        End If
    End Sub

    Private Sub _005_15_Search_Vehicle_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SearchTxt.Focus()
    End Sub
End Class

Public Class CustomerVehicleSelectedEventArgs
    Inherits EventArgs

    Private ReadOnly _customerId As String
    Private ReadOnly _vehicleReg As String

    ReadOnly Property CustomerId() As String
        Get
            Return _customerId
        End Get
    End Property

    ReadOnly Property VehicleRegistration() As String
        Get
            Return _vehicleReg
        End Get
    End Property

    Public Sub New(ByVal customerId As String, ByVal vehicleReg As String)
        _customerId = customerId
        _vehicleReg = vehicleReg
    End Sub
End Class