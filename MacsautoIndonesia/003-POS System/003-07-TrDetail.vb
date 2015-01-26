Imports MacsautoIndonesia.SmartCard.Reader
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
Imports MySql.Data.MySqlClient

Public Class _003_07_TrDetail2
    Private ReadOnly _selectedMode As PointOfSalesMode
    Private ReadOnly _customerDataTable As DataTable
    Private ReadOnly _vehiclesDataTable As DataTable
    Private ReadOnly _selectedVehicleBinding As BindingSource
    Private _searchCustomerForm As _005_15_Search_Vehicle
    Private _searchServiceForm As _005_16_Search_Service

    Property SelectedVehicleType As String
        Set(ByVal value As String)
            CarRadio.Checked = (value = "Car")
            MotorcycleRadio.Checked = (value = "Motorcycle")
        End Set
        Get
            Return If(CarRadio.Checked, "Car", "Motorcycle")
        End Get
    End Property

    Property SelectedVehicleSize As String

    Public Sub New(ByVal mode As PointOfSalesMode, Optional ByVal transactionId As String = "")
        InitializeComponent()

        _selectedMode = mode
        _customerDataTable = New DataTable()
        _vehiclesDataTable = New DataTable()
        _selectedVehicleBinding = New BindingSource()

        _selectedVehicleBinding.DataSource = _vehiclesDataTable

        Select Case _selectedMode
            Case PointOfSalesMode.NewTransaction
                
            Case PointOfSalesMode.ExistingTransaction

        End Select

        SwitchMode()
    End Sub

    Private Sub PerformBindings()
        If CustomerIdTxt.DataBindings.Count = 0 Then
            CustomerIdTxt.DataBindings.Add("Text", _customerDataTable, "idcus", False, DataSourceUpdateMode.OnPropertyChanged)
            CustomerNameTxt.DataBindings.Add("Text", _customerDataTable, "cname", False, DataSourceUpdateMode.OnPropertyChanged)
            CustomerAddressTxt.DataBindings.Add("Text", _customerDataTable, "cadd1", False, DataSourceUpdateMode.OnPropertyChanged)
            CustomerPhoneTxt.DataBindings.Add("Text", _customerDataTable, "cphon", False, DataSourceUpdateMode.OnPropertyChanged)
            CustomerCellphoneTxt.DataBindings.Add("Text", _customerDataTable, "ccpon", False, DataSourceUpdateMode.OnPropertyChanged)
            IsMemberChk.DataBindings.Add("Checked", _customerDataTable, "is_member", False, DataSourceUpdateMode.OnPropertyChanged)
        End If

        If VehicleBrandTxt.DataBindings.Count = 0 Then
            VehicleRegCbo.DataSource = _selectedVehicleBinding
            VehicleRegCbo.ValueMember = "linum"
            VehicleRegCbo.DisplayMember = "linum"

            VehicleBrandTxt.DataBindings.Add("Text", _selectedVehicleBinding, "brdsc")
            VehicleModelTxt.DataBindings.Add("Text", _selectedVehicleBinding, "modsc")
            VehicleColorTxt.DataBindings.Add("Text", _selectedVehicleBinding, "coldc")
            VehicleSizeTxt.DataBindings.Add("Text", _selectedVehicleBinding, "sizdc")
            VehicleExpiryDate.DataBindings.Add("Text", _selectedVehicleBinding, "vexpd")
            DataBindings.Add("SelectedVehicleType", _selectedVehicleBinding, "vtype")
            DataBindings.Add("SelectedVehicleSize", _selectedVehicleBinding, "idsiz")
        End If
    End Sub

    Private Sub _searchCustomer_CustomerVehicleSelected(ByVal sender As Object, ByVal e As CustomerVehicleSelectedEventArgs)
        Const customerQuery As String =
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
            " FROM hcustomer" & _
            " WHERE hcustomer.idcus = '{0}'"
        Const vehiclesQuery As String =
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
            " LEFT JOIN vehiclesize ON vehiclemodel.idsiz = vehiclesize.idsiz" & _
            " WHERE dcustomer.idcus = '{0}'"

        _customerDataTable.Rows.Clear()
        _customerDataTable.Load(ExecQueryReader(String.Format(customerQuery, e.CustomerId)))

        _vehiclesDataTable.Rows.Clear()
        _vehiclesDataTable.Load(ExecQueryReader(String.Format(vehiclesQuery, e.CustomerId)))
        
        _selectedVehicleBinding.ResetBindings(False)

        PerformBindings()
        
        _searchCustomerForm.Close()
    End Sub

    Private Sub _searchService_ServiceSelected(ByVal sender As Object, ByVal e As ServiceSelectedEventArgs)
        Dim selectedServiceRow As DataRow = e.ServiceRow
        Dim alreadyExisted As Boolean = TransactionServiceDataGrid.Rows.OfType(Of DataGridViewRow).Any(
            Function(row As DataGridViewRow)
                Return row.Cells(ServiceIdCol.Index).Value = selectedServiceRow("idsvc")
            End Function)

        If alreadyExisted Then
            MsgBox("This service is already added", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
        Else
            TransactionServiceDataGrid.Rows.Add(selectedServiceRow("idsvc"), selectedServiceRow("svcdc"), selectedServiceRow("svprc"), 0, "-")

            _searchServiceForm.Close()
        End If
    End Sub

    Private Sub SwitchMode()
        CustomerPanel.Enabled = (_selectedMode = PointOfSalesMode.NewTransaction)
        VehiclePanel.Enabled = (_selectedMode = PointOfSalesMode.NewTransaction)
    End Sub

    Private Sub ShowCustomerForm()
        If _searchCustomerForm Is Nothing Then
            _searchCustomerForm = New _005_15_Search_Vehicle()
            AddHandler _searchCustomerForm.CustomerVehicleSelected, AddressOf _searchCustomer_CustomerVehicleSelected
        End If

        _searchCustomerForm.ShowDialog(Me)
    End Sub

    Private Sub ShowServiceForm()
        If _searchServiceForm Is Nothing Then
            _searchServiceForm = New _005_16_Search_Service(SelectedVehicleSize)
            AddHandler _searchServiceForm.ServiceSelected, AddressOf _searchService_ServiceSelected
        Else
            _searchServiceForm.VehicleSize = SelectedVehicleSize
        End If

        _searchServiceForm.ShowDialog(Me)
    End Sub

    Private Sub FindCustomerBtn_Click(sender As Object, e As EventArgs) Handles FindCustomerBtn.Click
        ShowCustomerForm()
    End Sub

    Private Sub _003_07_TrDetail2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F1 Then
            ShowCustomerForm()
        ElseIf e.KeyData = Keys.F2 Then
            ShowServiceForm()
        End If
    End Sub

    Private Sub AddServiceBtn_Click(sender As Object, e As EventArgs) Handles AddServiceBtn.Click
        If _selectedVehicleBinding.Count = 0 Then
            ErrorInput(FindCustomerBtn, "Customer and vehicle is required")
        Else
            ShowServiceForm()
        End If
    End Sub

    Private Sub VehicleRegCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VehicleRegCbo.SelectedIndexChanged

    End Sub

    Private Sub TransactionServiceDataGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TransactionServiceDataGrid.RowsAdded
        RemoveServiceBtn.Enabled = (TransactionServiceDataGrid.Rows.Count > 0)
    End Sub

    Private Sub TransactionServiceDataGrid_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TransactionServiceDataGrid.RowsRemoved
        RemoveServiceBtn.Enabled = (TransactionServiceDataGrid.Rows.Count > 0)
    End Sub

    Private Sub RemoveServiceBtn_Click(sender As Object, e As EventArgs) Handles RemoveServiceBtn.Click
        If TransactionServiceDataGrid.SelectedCells.Count = 0 Then
            MsgBox("Nothing to remove", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
        Else
            TransactionServiceDataGrid.Rows.RemoveAt(TransactionServiceDataGrid.CurrentRow.Index)
        End If
    End Sub
End Class

Public Enum PointOfSalesMode
    NewTransaction
    ExistingTransaction
End Enum