Imports MacsautoIndonesia.My
Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Services
Imports MacsautoIndonesia.SmartCard
Imports MacsautoIndonesia.SmartCard.Reader
Imports System.Text.RegularExpressions

Public Class _003_01_02_TransactionDetail
#Region "Constants"
    Const CustomerQuery As String =
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
    Const VehiclesQuery As String =
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
    Const NewTransactionQuery As String =
        "INSERT INTO htransaction" & _
        "   (trsid, trdat, idcus," & _
        "    vtype, vbrnd, vmodl," & _
        "    vcolr, vsize, vkmre," & _
        "    linum, liexp, svamt," & _
        "    pdamt, toamt, topay," & _
        "    pterm, trstat, svsts," & _
        "    tpoin, chnce, createdBy," & _
        "    remrk, cpoin)" & _
        " VALUES" & _
        "   (@transactionId, NOW(), @customerId," & _
        "    @vehicleType, @vehicleBrand, @vehicleModel," & _
        "    @vehicleColor, @vehicleSize, @vehicleMileage," & _
        "    @vehicleReg, @licenseExpired, @serviceSubtotal," & _
        "    @productSubtotal, @grandTotal, @paymentTotal," & _
        "    @paymentTerm, @transactionStatus, @serviceStatus," & _
        "    @pointsEarned, @paymentChange, @employee," & _
        "    @transactionRemark, @currentPoint)"
    Const TransactionHeaderQuery As String =
        "SELECT htransaction.trsid," & _
        "   htransaction.trdat," & _
        "   htransaction.idcus," & _
        "   htransaction.vtype," & _
        "   htransaction.vbrnd," & _
        "   htransaction.vmodl," & _
        "   htransaction.vcolr," & _
        "   htransaction.vsize," & _
        "   htransaction.vkmre," & _
        "   htransaction.linum," & _
        "   htransaction.liexp," & _
        "   htransaction.svamt," & _
        "   htransaction.pdamt," & _
        "   htransaction.toamt," & _
        "   htransaction.topay," & _
        "   htransaction.pterm," & _
        "   htransaction.trstat," & _
        "   htransaction.svsts," & _
        "   htransaction.tpoin," & _
        "   htransaction.chnce," & _
        "   htransaction.createdBy," & _
        "   htransaction.remrk," & _
        "   htransaction.cpoin," & _
        "   htransaction.updatedBy" & _
        " FROM htransaction" & _
        " WHERE htransaction.trsid = '{0}'"
    Const TransactionDetailQuery As String =
        "SELECT dtransaction.trsid," & _
        "   dtransaction.ttype," & _
        "   dtransaction.seqnr," & _
        "   dtransaction.idsvc," & _
        "   dtransaction.idpdt," & _
        "   dtransaction.trqty," & _
        "   dtransaction.uomdc," & _
        "   dtransaction.price," & _
        "   dtransaction.idisc," & _
        "   dtransaction.rmark," & _
        "   dtransaction.vpaym," & _
        "   dtransaction.vnumb," & _
        "   hproduct.idpdt," & _
        "   hproduct.pdqty," & _
        "   hproduct.pdtds," & _
        "   hproduct.ppamt," & _
        "   hproduct.psamt," & _
        "   hservice.idsvc," & _
        "   hservice.svcdc" & _
        " FROM dtransaction" & _
        " LEFT JOIN hproduct ON dtransaction.idpdt = hproduct.idpdt" & _
        " LEFT JOIN hservice ON dtransaction.idsvc = hservice.idsvc" & _
        " WHERE dtransaction.trsid = '{0}'"
    Const UpdateProductStockQuery As String =
        "UPDATE hproduct" & _
        " INNER JOIN (" & _
        "   SELECT dproduct.idpdt, SUM(dproduct.slqty) AS total_stock" & _
        "   FROM dproduct" & _
        "   GROUP BY dproduct.idpdt" & _
        " ) dproduct ON hproduct.idpdt = dproduct.idpdt" & _
        " SET pdqty = dproduct.total_stock WHERE hproduct.idpdt = @productId"
#End Region

    Public Event TransactionUpdated As EventHandler

    Private ReadOnly _selectedMode As PointOfSalesMode
    Private ReadOnly _transactionHeaderDataTable As DataTable
    Private ReadOnly _transactionDetailDataTable As DataTable
    Private ReadOnly _selectedTransactionDataRow As DataRow
    Private ReadOnly _customerDataTable As DataTable
    Private ReadOnly _vehiclesDataTable As DataTable
    Private ReadOnly _selectedVehicleBinding As BindingSource
    Private _searchCustomerForm As _005_15_Search_Vehicle
    Private _searchServiceForm As _005_16_Search_Service
    Private _searchProductForm As _005_17_Search_Product
    Private _createPaymentForm As _003_01_04_CreatePayment
    Private _authorizationForm As _006_04_Authorization_Form
    Private _voidReasonForm As _003_01_07_TransactionVoidRemark
    Private _transactionCompleted As Boolean = False
    Private _acrReader As AcrReader

    Property ProductSubtotal As Double
        Set(ByVal value As Double)
            ProductSubtotalLbl.Text = value.ToString("N0")
        End Set
        Get
            Return Double.Parse(ProductSubtotalLbl.Text)
        End Get
    End Property

    Property ServiceSubtotal As Double
        Set(ByVal value As Double)
            ServiceSubtotalLbl.Text = value.ToString("N0")
        End Set
        Get
            Return Double.Parse(ServiceSubtotalLbl.Text)
        End Get
    End Property

    Property GrandTotal As Double
        Set(ByVal value As Double)
            GrandTotalLbl.Text = value.ToString("N0")
        End Set
        Get
            Return ProductSubtotal + ServiceSubtotal
        End Get
    End Property

    Property SelectedVehicleType As String
        Set(ByVal value As String)
            CarRadio.Checked = (value = "Car")
            MotorcycleRadio.Checked = (value = "Motorcycle")
        End Set
        Get
            Return If(CarRadio.Checked, "Car", "Motorcycle")
        End Get
    End Property

    Property CurrentVehicleSize As String

    Property CurrentVehicleRegistration As String

    Property SelectedVehicleSize As String

    Public Sub New(ByVal mode As PointOfSalesMode, Optional ByVal transactionId As String = "")
        InitializeComponent()

        _selectedMode = mode
        _customerDataTable = New DataTable()
        _vehiclesDataTable = New DataTable()
        _selectedVehicleBinding = New BindingSource()

        _selectedVehicleBinding.DataSource = _vehiclesDataTable

        TransactionServiceDataGrid.ValidateIntegerInput(ServiceDiscountCol.Index, 100)
        TransactionProductDataGrid.ValidateIntegerInput(ProductDiscountCol.Index, 100)
        TransactionProductDataGrid.ValidateIntegerInput(ProductQuantityCol.Index)

        Select Case _selectedMode
            Case PointOfSalesMode.NewTransaction

            Case PointOfSalesMode.ExistingTransaction
                _transactionHeaderDataTable = New DataTable()
                _transactionDetailDataTable = New DataTable()

                If String.IsNullOrEmpty(transactionId) Then
                    Throw New ArgumentException("Transaction id is required in editing queue mode", transactionId)
                End If

                _transactionHeaderDataTable.Load(ExecQueryReader(String.Format(TransactionHeaderQuery, transactionId)))
                _transactionDetailDataTable.Load(ExecQueryReader(String.Format(TransactionDetailQuery, transactionId)))

                _selectedTransactionDataRow = _transactionHeaderDataTable.Rows(0)

                TransactionIdLbl.DataBindings.Add("Text", _transactionHeaderDataTable, "trsid", False, DataSourceUpdateMode.Never)

                SelectCustomer(_selectedTransactionDataRow("idcus"))

                VehicleRegCbo.SelectedItem = VehicleRegCbo.Items.OfType(Of DataRowView).FirstOrDefault(
                    Function(row As DataRowView)
                        Return row("linum") = _selectedTransactionDataRow("linum")
                    End Function)

                For Each transactionItem As DataRow In _transactionDetailDataTable.Rows
                    If transactionItem("ttype") = "P" Then
                        Dim newRowIndex As Integer = TransactionProductDataGrid.Rows.Add(
                            transactionItem("idpdt"),
                            transactionItem("pdtds"),
                            transactionItem("trqty"),
                            transactionItem("pdqty"),
                            transactionItem("uomdc"),
                            transactionItem("price"),
                            transactionItem("ppamt"),
                            transactionItem("idisc"),
                            transactionItem("trqty"),
                            True,
                            transactionItem("trqty"))
                        TransactionProductDataGrid(ProductQuantityCol.Index, newRowIndex).ReadOnly = True
                        TransactionProductDataGrid(ProductQuantityCol.Index, newRowIndex).Style.BackColor = ProductIdCol.DefaultCellStyle.BackColor
                        TransactionProductDataGrid(ProductDiscountCol.Index, newRowIndex).ReadOnly = True
                        TransactionProductDataGrid(ProductDiscountCol.Index, newRowIndex).Style.BackColor = ProductIdCol.DefaultCellStyle.BackColor
                    Else
                        Dim newRowIndex As Integer = TransactionServiceDataGrid.Rows.Add(
                            transactionItem("idsvc"),
                            transactionItem("svcdc"),
                            transactionItem("price"),
                            transactionItem("idisc"),
                            transactionItem("rmark"),
                            True)
                        TransactionServiceDataGrid(ServiceDiscountCol.Index, newRowIndex).ReadOnly = True
                        TransactionServiceDataGrid(ServiceDiscountCol.Index, newRowIndex).Style.BackColor = ProductIdCol.DefaultCellStyle.BackColor
                    End If
                Next
        End Select

        SwitchMode()
    End Sub

    Private Sub SwitchMode()
        FindCustomerBtn.Visible = (_selectedMode = PointOfSalesMode.NewTransaction)
        VehicleRegCbo.Enabled = (_selectedMode = PointOfSalesMode.NewTransaction)
        VoidBtn.Enabled = (_selectedMode = PointOfSalesMode.ExistingTransaction)
        QueueBtn.Enabled = (_selectedMode = PointOfSalesMode.NewTransaction)
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

            Try
                VehicleExpiryDate.DataBindings.Add("Text", _selectedVehicleBinding, "vexpd")
            Catch ex As Exception

            End Try

            VehicleMileageTxt.DataBindings.Add("Text", _selectedVehicleBinding, "vkilo")
            DataBindings.Add("SelectedVehicleType", _selectedVehicleBinding, "vtype")
            DataBindings.Add("SelectedVehicleSize", _selectedVehicleBinding, "idsiz")
        End If
    End Sub

    Private Sub _003_07_TrDetail2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F1 Then
            ShowCustomerForm()
        ElseIf e.KeyData = Keys.F2 Then
            ShowServiceForm()
        ElseIf e.KeyData = Keys.F3 Then
            ShowProductForm()
        ElseIf e.KeyData = Keys.F4 AndAlso Not _acrReader Is Nothing Then
            If Not _acrReader.GetTag().Connected Then
                MsgBox("No card detected", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning")
            Else
                Try
                    _acrReader.Login(MySettings.Default.RFIDSector)

                    SelectCustomer(_acrReader.ReadBlock(MySettings.Default.RFIDDataBlock).ToString())
                Catch ex As Exception
                    MsgBox("Read failed. Message: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub SelectCustomer(ByVal customerId As String)
        customerId = Regex.Replace(customerId, "/\s/g", "")

        _customerDataTable.Rows.Clear()
        _customerDataTable.Load(ExecQueryReader(String.Format(CustomerQuery, customerId)))

        If _customerDataTable.Rows.Count = 0 Then
            _customerDataTable.Rows.Clear()

            MsgBox("Customer not found", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning")
        Else
            DoInTransaction(
                Function(command As MySqlCommand)
                    TransactionService.CheckPointExpiry(command, customerId)

                    Return True
                End Function)

            _vehiclesDataTable.Rows.Clear()
            _vehiclesDataTable.Load(ExecQueryReader(String.Format(VehiclesQuery, customerId)))

            _selectedVehicleBinding.ResetBindings(False)

            PerformBindings()
        End If
    End Sub

    Private Sub _searchCustomer_CustomerVehicleSelected(ByVal sender As Object, ByVal e As CustomerVehicleSelectedEventArgs)
        SelectCustomer(e.CustomerId)

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
            Dim bestPromotion As DataRow = TransactionService.FindBestPromotion(Not IsMemberChk.Checked, selectedServiceRow("idsvc"), "S", selectedServiceRow("svprc"))
            Dim newRowIndex As Integer = TransactionServiceDataGrid.Rows.Add(
                selectedServiceRow("idsvc"),
                selectedServiceRow("svcdc"),
                If(bestPromotion Is Nothing, selectedServiceRow("svprc"), TransactionService.CalculatePromotion(selectedServiceRow("svprc"), bestPromotion)),
                If(bestPromotion Is Nothing, 0, bestPromotion("pdpct")),
                If(bestPromotion Is Nothing, "-", bestPromotion("pmdcp")),
                False)

            If Not bestPromotion Is Nothing Then
                TransactionServiceDataGrid(ServiceDiscountCol.Index, newRowIndex).ReadOnly = True
                TransactionServiceDataGrid(ServiceDiscountCol.Index, newRowIndex).Style.BackColor = ProductIdCol.DefaultCellStyle.BackColor
            End If

            _searchServiceForm.Close()
        End If
    End Sub

    Private Sub _searchProduct_ProductSelected(ByVal sender As Object, ByVal e As ProductSelectedEventArgs)
        Dim selectedProductRow As DataRow = e.ProductRow
        Dim alreadyExisted As DataGridViewRow = TransactionProductDataGrid.Rows.OfType(Of DataGridViewRow).FirstOrDefault(
            Function(row As DataGridViewRow)
                Return row.Cells(ProductIdCol.Index).Value = selectedProductRow("idpdt")
            End Function)

        If Not alreadyExisted Is Nothing Then
            If (TransactionProductDataGrid(ProductQuantityCol.Index, alreadyExisted.Index).Value + 1) > TransactionProductDataGrid(ProductRemainingQtyCol.Index, alreadyExisted.Index).Value Then
                MsgBox("Remaining quantity is not enough", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
            ElseIf alreadyExisted.Cells(ProductPreAddedCol.Index).Value = True Then
                MsgBox("Cannot add same product as queued", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
            Else
                TransactionProductDataGrid(ProductQuantityCol.Index, alreadyExisted.Index).Value += 1
            End If
        Else
            Dim bestPromotion As DataRow = TransactionService.FindBestPromotion(Not IsMemberChk.Checked, selectedProductRow("idpdt"), "P", selectedProductRow("psamt"))
            Dim newRowIndex As Integer = TransactionProductDataGrid.Rows.Add(
                selectedProductRow("idpdt"),
                selectedProductRow("pdtds"),
                1,
                selectedProductRow("slqty"),
                selectedProductRow("uodsc"),
                If(bestPromotion Is Nothing, selectedProductRow("psamt"), TransactionService.CalculatePromotion(selectedProductRow("psamt"), bestPromotion)),
                selectedProductRow("ppamt"),
                If(bestPromotion Is Nothing, 0, bestPromotion("pdpct")),
                If(bestPromotion Is Nothing, "-", bestPromotion("pmdcp")),
                False,
                True)

            If Not bestPromotion Is Nothing Then
                TransactionServiceDataGrid(ServiceDiscountCol.Index, newRowIndex).ReadOnly = True
                TransactionServiceDataGrid(ServiceDiscountCol.Index, newRowIndex).Style.BackColor = ProductIdCol.DefaultCellStyle.BackColor
            End If
        End If

        _searchProductForm.Close()
    End Sub

    Private Sub ShowCustomerForm()
        If _selectedMode = PointOfSalesMode.NewTransaction Then
            If _searchCustomerForm Is Nothing Then
                _searchCustomerForm = New _005_15_Search_Vehicle(_005_15_Search_Vehicle.CustomerVehicleMode)

                AddHandler _searchCustomerForm.CustomerVehicleSelected, AddressOf _searchCustomer_CustomerVehicleSelected
            End If

            If _selectedVehicleBinding.Count = 0 OrElse (TransactionServiceDataGrid.Rows.Count = 0 OrElse MsgBox("Changing customer will remove all existing services. Continue?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes) Then
                If _selectedVehicleBinding.Count > 0 Then
                    TransactionServiceDataGrid.Rows.Clear()
                End If

                _searchCustomerForm.ShowDialog(Me)
            End If
        Else
            MsgBox("Cannot choose customer in queued transaction", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub

    Private Sub ShowServiceForm()
        If _selectedVehicleBinding.Count = 0 Then
            ErrorInput(FindCustomerBtn, "Customer and vehicle is required")
        Else
            If _searchServiceForm Is Nothing Then
                _searchServiceForm = New _005_16_Search_Service(SelectedVehicleSize)
                AddHandler _searchServiceForm.ServiceSelected, AddressOf _searchService_ServiceSelected
            Else
                _searchServiceForm.VehicleSize = SelectedVehicleSize
            End If

            _searchServiceForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub ShowProductForm()
        If _selectedVehicleBinding.Count = 0 Then
            ErrorInput(FindCustomerBtn, "Customer and vehicle is required")
        Else
            If _searchProductForm Is Nothing Then
                _searchProductForm = New _005_17_Search_Product()
                AddHandler _searchProductForm.ProductSelected, AddressOf _searchProduct_ProductSelected
            End If

            _searchProductForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub Recalculate()
        ProductSubtotal = TransactionProductDataGrid.Rows.OfType(Of DataGridViewRow).Sum(
            Function(row As DataGridViewRow)
                Return Double.Parse((row.Cells(ProductQuantityCol.Index).Value * row.Cells(ProductPriceCol.Index).Value) * ((100 - row.Cells(ProductDiscountCol.Index).Value) / 100))
            End Function)
        ServiceSubtotal = TransactionServiceDataGrid.Rows.OfType(Of DataGridViewRow).Sum(
            Function(row As DataGridViewRow)
                Return Double.Parse(row.Cells(ServicePriceCol.Index).Value * ((100 - row.Cells(ServiceDiscountCol.Index).Value) / 100))
            End Function)
        GrandTotal = ProductSubtotal + ServiceSubtotal
    End Sub

    Private Sub FindCustomerBtn_Click(sender As Object, e As EventArgs) Handles FindCustomerBtn.Click
        ShowCustomerForm()
    End Sub

    Private Sub AddServiceBtn_Click(sender As Object, e As EventArgs) Handles AddServiceBtn.Click
        ShowServiceForm()
    End Sub

    Private Sub VehicleMileageTxt_TextChanged(sender As Object, e As EventArgs) Handles VehicleMileageTxt.TextChanged
        VehicleMileageTxt.Text = String.Format("{0:n0}", VehicleMileageTxt.Text)
    End Sub

    Private Sub VehicleRegCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VehicleRegCbo.SelectedIndexChanged
        If VehicleRegCbo.SelectedIndex > -1 Then
            If VehicleSizeTxt.Text <> CurrentVehicleSize AndAlso TransactionServiceDataGrid.Rows.Count > 0 Then
                MsgBox("The selected vehicle is different from previous, all existing services will be removed", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
                TransactionServiceDataGrid.Rows.Clear()
            End If

            CurrentVehicleSize = VehicleSizeTxt.Text

            If VehicleRegCbo.SelectedValue.GetType() Is GetType(DataRowView) Then
                CurrentVehicleRegistration = CType(VehicleRegCbo.SelectedValue, DataRowView)("linum")
            Else
                CurrentVehicleRegistration = VehicleRegCbo.SelectedText
            End If
        End If
    End Sub

    Private Sub TransactionServiceDataGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TransactionServiceDataGrid.RowsAdded
        RemoveServiceBtn.Enabled = (TransactionServiceDataGrid.Rows.Count > 0)

        Recalculate()
    End Sub

    Private Sub TransactionServiceDataGrid_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TransactionServiceDataGrid.RowsRemoved
        RemoveServiceBtn.Enabled = (TransactionServiceDataGrid.Rows.Count > 0)

        Recalculate()
    End Sub

    Private Sub RemoveServiceBtn_Click(sender As Object, e As EventArgs) Handles RemoveServiceBtn.Click
        If TransactionServiceDataGrid.SelectedCells.Count = 0 Then
            MsgBox("Nothing to remove", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
        ElseIf TransactionServiceDataGrid.CurrentRow.Cells(ServicePreAddedCol.Index).Value = True Then
            MsgBox("Cannot remove service pre-added before queue", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
        Else
            TransactionServiceDataGrid.Rows.RemoveAt(TransactionServiceDataGrid.CurrentRow.Index)
        End If
    End Sub

    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        ShowProductForm()
    End Sub

    Private Sub RemoveProductBtn_Click(sender As Object, e As EventArgs) Handles RemoveProductBtn.Click
        If TransactionProductDataGrid.SelectedCells.Count = 0 Then
            MsgBox("Nothing to remove", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
        ElseIf TransactionProductDataGrid.CurrentRow.Cells(ProductPreAddedCol.Index).Value = True Then
            MsgBox("Cannot remove product pre-added before queue", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
        Else
            TransactionProductDataGrid.Rows.RemoveAt(TransactionProductDataGrid.CurrentRow.Index)
        End If
    End Sub

    Private Sub TransactionProductDataGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TransactionProductDataGrid.RowsAdded
        RemoveProductBtn.Enabled = (TransactionProductDataGrid.Rows.Count > 0)

        Recalculate()
    End Sub

    Private Sub TransactionProductDataGrid_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TransactionProductDataGrid.RowsRemoved
        RemoveProductBtn.Enabled = (TransactionProductDataGrid.Rows.Count > 0)

        Recalculate()
    End Sub

    Private Sub TransactionProductDataGrid_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles TransactionProductDataGrid.CellValidating
        If e.ColumnIndex = ProductQuantityCol.Index AndAlso TransactionProductDataGrid(ProductRemainingQtyCol.Index, e.RowIndex).IsInEditMode AndAlso (e.FormattedValue > TransactionProductDataGrid(ProductRemainingQtyCol.Index, e.RowIndex).Value) Then
            MsgBox("Remaining quantity is not enough", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")

            e.Cancel = True
        End If
    End Sub

    Private Sub TransactionProductDataGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionProductDataGrid.CellValueChanged
        If e.ColumnIndex = ProductQuantityCol.Index Or e.ColumnIndex = ProductDiscountCol.Index Then
            Recalculate()
        End If
    End Sub

    Private Sub TransactionServiceDataGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionServiceDataGrid.CellValueChanged
        If e.ColumnIndex = ServiceDiscountCol.Index Then
            Recalculate()
        End If
    End Sub

    Private Function ConfirmExit()
        If _transactionCompleted Then
            Return True
        End If

        Dim message As String = ""

        If _selectedMode = PointOfSalesMode.NewTransaction Then
            message = "Cancelling transaction. Are you sure?"
        ElseIf _selectedMode = PointOfSalesMode.ExistingTransaction Then
            message = "Close transaction? All changes will be unsaved. Are you sure?"
        End If

        Return MsgBox(message, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes
    End Function

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If _selectedVehicleBinding.Count = 0 Then
            ErrorInput(FindCustomerBtn, "Customer and vehicle is required")
        ElseIf (TransactionProductDataGrid.Rows.Count + TransactionServiceDataGrid.Rows.Count) = 0 Then
            ErrorInput(AddServiceBtn, "No service or product selected")
        ElseIf MsgBox("Make payment?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            If _createPaymentForm Is Nothing Then
                _createPaymentForm = New _003_01_04_CreatePayment(GrandTotal)
                AddHandler _createPaymentForm.PaymentSubmitted, AddressOf _paymentForm_PaymentSubmitted
            Else
                _createPaymentForm.GrandTotal = GrandTotal
            End If

            _createPaymentForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub QueueBtn_Click(sender As Object, e As EventArgs) Handles QueueBtn.Click
        If _selectedVehicleBinding.Count = 0 Then
            ErrorInput(FindCustomerBtn, "Customer and vehicle is required")
        ElseIf (TransactionProductDataGrid.Rows.Count + TransactionServiceDataGrid.Rows.Count) = 0 Then
            ErrorInput(AddServiceBtn, "No service or product selected")
        ElseIf MsgBox("Queue transaction?" & If(TransactionProductDataGrid.Rows.Count > 0, " Selected products cannot be removed after queue. Are you sure?", ""), MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            DoInTransaction(
                Function(command As MySqlCommand)
                    Dim customer As DataRow = _customerDataTable.Select("idcus = '" & CustomerIdTxt.Text & "'").FirstOrDefault()
                    Dim newTransactionId As String = TransactionService.GetNewTransactionId(command)

                    command.CommandText = NewTransactionQuery
                    command.CreateParameter()

                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("transactionId", newTransactionId)
                    command.Parameters.AddWithValue("customerId", CustomerIdTxt.Text)
                    command.Parameters.AddWithValue("vehicleType", SelectedVehicleType)
                    command.Parameters.AddWithValue("vehicleBrand", VehicleBrandTxt.Text)
                    command.Parameters.AddWithValue("vehicleModel", VehicleModelTxt.Text)
                    command.Parameters.AddWithValue("vehicleColor", VehicleColorTxt.Text)
                    command.Parameters.AddWithValue("vehicleSize", VehicleSizeTxt.Text)
                    command.Parameters.AddWithValue("vehicleMileage", VehicleMileageTxt.Text)
                    command.Parameters.AddWithValue("vehicleReg", VehicleRegCbo.SelectedValue)
                    command.Parameters.AddWithValue("licenseExpired", VehicleExpiryDate.Value.ToMySqlDateTime())
                    command.Parameters.AddWithValue("serviceSubtotal", ServiceSubtotal)
                    command.Parameters.AddWithValue("productSubtotal", ProductSubtotal)
                    command.Parameters.AddWithValue("grandTotal", GrandTotal)
                    command.Parameters.AddWithValue("paymentTotal", 0)
                    command.Parameters.AddWithValue("paymentTerm", "")
                    command.Parameters.AddWithValue("transactionStatus", "OPEN")
                    command.Parameters.AddWithValue("serviceStatus", "")
                    command.Parameters.AddWithValue("pointsEarned", 0)
                    command.Parameters.AddWithValue("paymentChange", 0)
                    command.Parameters.AddWithValue("employee", LoggedInEmployee.Id)
                    command.Parameters.AddWithValue("transactionRemark", "")
                    command.Parameters.AddWithValue("currentPoint", customer("cpoin"))

                    command.ExecuteNonQuery()

                    TransactionItemsInsert(command, newTransactionId, TransactionServiceDataGrid.Rows.OfType(Of DataGridViewRow).ToArray(), TransactionProductDataGrid.Rows.OfType(Of DataGridViewRow).ToArray())

                    Return True
                End Function)

            MsgBox("Transaction queued", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success")

            _transactionCompleted = True

            RaiseEvent TransactionUpdated(Me, New EventArgs())

            Close()
        End If
    End Sub

    Private Sub VoidBtn_Click(sender As Object, e As EventArgs) Handles VoidBtn.Click
        If _authorizationForm Is Nothing OrElse _authorizationForm.IsDisposed Then
            _authorizationForm = New _006_04_Authorization_Form(AuthorizationLevel.Supervisor)

            AddHandler _authorizationForm.AuthorizationSuccess,
                Sub(s As Object, evt As AuthorizationSuccessEventArgs)
                    If _voidReasonForm Is Nothing OrElse _voidReasonForm.IsDisposed Then
                        _voidReasonForm = New _003_01_07_TransactionVoidRemark()

                        AddHandler _voidReasonForm.ReasonSubmitted,
                            Sub(sV As Object, eV As EventArgs)
                                Dim form As _003_01_07_TransactionVoidRemark = CType(sV, _003_01_07_TransactionVoidRemark)

                                If MsgBox("Used product quantity will be added back to inventory. Continue void?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                                    DoInTransaction(
                                        Function(command As MySqlCommand)
                                            command.CommandText = "UPDATE htransaction SET trstat = 'VOID', updatedBy = @managerId, remrk = @voidReason WHERE trsid = @transactionId"
                                            command.CreateParameter()

                                            command.Parameters.Clear()
                                            command.Parameters.AddWithValue("managerId", evt.AuthorizedUser("Id"))
                                            command.Parameters.AddWithValue("transactionId", TransactionIdLbl.Text)
                                            command.Parameters.AddWithValue("voidReason", form.VoidReason)

                                            command.ExecuteNonQuery()

                                            For Each row As DataRow In _transactionDetailDataTable.Rows
                                                If row("ttype") = "P" Then
                                                    command.CommandText = "UPDATE dproduct SET slqty = (slqty + @usedQuantity) WHERE defsl = 'True' AND idpdt = @productId"
                                                    command.Parameters.Clear()

                                                    command.Parameters.AddWithValue("usedQuantity", row("trqty"))
                                                    command.Parameters.AddWithValue("productId", row("idpdt"))
                                                    command.ExecuteNonQuery()

                                                    command.CommandText = UpdateProductStockQuery
                                                    command.ExecuteNonQuery()
                                                End If
                                            Next

                                            Return True
                                        End Function)

                                    MsgBox("Transaction voided", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success")

                                    _transactionCompleted = True

                                    RaiseEvent TransactionUpdated(Me, New EventArgs())

                                    Close()
                                End If
                            End Sub
                        _voidReasonForm.ShowDialog(Me)
                    End If
                End Sub
            AddHandler _authorizationForm.AuthorizationFailed,
                Sub(s As Object, evt As EventArgs)
                    MsgBox("Authorization failed", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")

                    _authorizationForm.Close()
                End Sub
        End If

        _authorizationForm.ShowDialog(Me)
    End Sub

    Private Sub _paymentForm_PaymentSubmitted(ByVal sender As Object, ByVal e As PaymentSubmittedEventArgs)
        Dim memberCurrentPoint As Integer = 0
        Dim memberEarnedPoint As Integer = 0
        Dim newTransactionId As String = ""

        DoInTransaction(
            Function(command As MySqlCommand)
                Dim newPaymentId As String = TransactionService.GetNewPaymentId(command)

                memberEarnedPoint = TransactionService.CalculatePointsEarned(GrandTotal, command)

                If (_selectedMode = PointOfSalesMode.NewTransaction) Then
                    newTransactionId = NewTransactionInsert(command, e.CreatePaymentForm, memberEarnedPoint)
                Else
                    newTransactionId = QueuedTransactionUpdate(command, e.CreatePaymentForm, memberEarnedPoint)
                End If

                '===========================================================================================================================================
                ' Create New Payment
                '===========================================================================================================================================
                command.CommandText = "INSERT INTO payment(payid, trsid, pyamt, pydat) VALUES(@paymentId, @transactionId, @paymentAmount, NOW())"
                command.Parameters.Clear()

                command.Parameters.AddWithValue("paymentId", newPaymentId)
                command.Parameters.AddWithValue("transactionId", newTransactionId)
                command.Parameters.AddWithValue("paymentAmount", If(e.CreatePaymentForm.SelectedPaymentType = "Cash", e.CreatePaymentForm.CashPayment, GrandTotal))

                command.ExecuteNonQuery()
                '===========================================================================================================================================

                If IsNumeric(VehicleMileageTxt.Text) Then
                    command.CommandText = "UPDATE dcustomer SET vkilo = @vehicleMileage WHERE idcus = @customerId AND linum = @vehicleRegistration"
                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("vehicleMileage", Double.Parse(VehicleMileageTxt.Text))
                    command.Parameters.AddWithValue("customerId", CustomerIdTxt.Text)
                    command.Parameters.AddWithValue("vehicleRegistration", VehicleRegCbo.SelectedValue)

                    command.ExecuteNonQuery()
                End If

                If IsMemberChk.Checked And memberEarnedPoint > 0 Then
                    '===========================================================================================================================================
                    ' Member Point Related Transactions
                    '===========================================================================================================================================
                    command.CommandText = "UPDATE hcustomer SET cpoin = (cpoin + @pointsEarned) WHERE idcus = @customerId"
                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("pointsEarned", memberEarnedPoint)
                    command.Parameters.AddWithValue("customerId", CustomerIdTxt.Text)

                    command.ExecuteNonQuery()

                    command.CommandText = "INSERT INTO pointtrans(idcus, ptdat, trpon, trtype) VALUES(@customerId, NOW(), @pointsEarned, 'ADD')"
                    command.ExecuteNonQuery()

                    command.CommandText = "SELECT cpoin FROM hcustomer WHERE idcus = @customerId"

                    memberCurrentPoint = Integer.Parse(command.ExecuteScalar())
                    '===========================================================================================================================================
                End If

                Return True
            End Function)

        '===========================================================================================================================================
        ' Print Transaction
        '===========================================================================================================================================
        Dim transactionPage As TransactionPage = New TransactionPage(RollPageWidth, New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular))

        transactionPage.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_
        transactionPage.SetTransactionInformation(newTransactionId, VehicleRegCbo.SelectedValue, VehicleBrandTxt.Text, VehicleModelTxt.Text, TransactionDate.Value.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString())

        For Each serviceItem As DataGridViewRow In TransactionServiceDataGrid.Rows
            transactionPage.AppendItem(serviceItem.Cells(ServiceDescriptionCol.Index).Value, serviceItem.Cells(ServicePriceCol.Index).Value, 1, serviceItem.Cells(ServiceDiscountCol.Index).Value)
        Next

        For Each productItem As DataGridViewRow In TransactionProductDataGrid.Rows
            transactionPage.AppendItem(productItem.Cells(ProductDescCol.Index).Value, productItem.Cells(ProductPriceCol.Index).Value, productItem.Cells(ProductQuantityCol.Index).Value, productItem.Cells(ProductDiscountCol.Index).Value)
        Next

        If IsMemberChk.Checked Then
            transactionPage.SetPayment(GrandTotal, e.CreatePaymentForm.SelectedPaymentType, memberEarnedPoint, memberCurrentPoint, DateTime.Now.AddYears(1).ToString("dd-MM-yyyy"))
        Else
            transactionPage.SetPayment(GrandTotal, e.CreatePaymentForm.SelectedPaymentType)
        End If

        transactionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
        transactionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
        transactionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
        transactionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
        transactionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
        transactionPage.AppendFooter("© MACSAUTO INDONESIA")

        PrintPage(Me, transactionPage)
        '===========================================================================================================================================

        TryPostJournal(newTransactionId, e.CreatePaymentForm.SelectedPaymentType)

        MsgBox("Transaction saved", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success")

        _createPaymentForm.Close()

        _transactionCompleted = True

        RaiseEvent TransactionUpdated(Me, New EventArgs())

        Close()
    End Sub

    Private Function NewTransactionInsert(ByVal command As MySqlCommand, ByVal createPaymentForm As _003_01_04_CreatePayment, ByVal pointsEarned As Integer) As String
        Dim customer As DataRow = _customerDataTable.Select("idcus = '" & CustomerIdTxt.Text & "'").FirstOrDefault()
        Dim newTransactionId As String = TransactionService.GetNewTransactionId(command)

        command.CommandText = NewTransactionQuery
        command.CreateParameter()

        command.Parameters.Clear()
        command.Parameters.AddWithValue("transactionId", newTransactionId)
        command.Parameters.AddWithValue("customerId", CustomerIdTxt.Text)
        command.Parameters.AddWithValue("vehicleType", SelectedVehicleType)
        command.Parameters.AddWithValue("vehicleBrand", VehicleBrandTxt.Text)
        command.Parameters.AddWithValue("vehicleModel", VehicleModelTxt.Text)
        command.Parameters.AddWithValue("vehicleColor", VehicleColorTxt.Text)
        command.Parameters.AddWithValue("vehicleSize", VehicleSizeTxt.Text)
        command.Parameters.AddWithValue("vehicleMileage", VehicleMileageTxt.Text)
        command.Parameters.AddWithValue("vehicleReg", VehicleRegCbo.SelectedValue)
        command.Parameters.AddWithValue("licenseExpired", VehicleExpiryDate.Value.ToMySqlDateTime())
        command.Parameters.AddWithValue("serviceSubtotal", ServiceSubtotal)
        command.Parameters.AddWithValue("productSubtotal", ProductSubtotal)
        command.Parameters.AddWithValue("grandTotal", GrandTotal)
        command.Parameters.AddWithValue("paymentTotal", If(createPaymentForm.SelectedPaymentType = "Cash", createPaymentForm.CashPayment, createPaymentForm.GrandTotal))
        command.Parameters.AddWithValue("paymentTerm", createPaymentForm.SelectedPaymentType)
        command.Parameters.AddWithValue("transactionStatus", "PAID")
        command.Parameters.AddWithValue("serviceStatus", "")
        command.Parameters.AddWithValue("pointsEarned", If(IsMemberChk.Checked, pointsEarned, 0))
        command.Parameters.AddWithValue("paymentChange", If(createPaymentForm.SelectedPaymentType = "Cash", createPaymentForm.CashChange, 0))
        command.Parameters.AddWithValue("employee", LoggedInEmployee.Id)
        command.Parameters.AddWithValue("transactionRemark", "")
        command.Parameters.AddWithValue("currentPoint", customer("cpoin"))

        command.ExecuteNonQuery()

        TransactionItemsInsert(command, newTransactionId, TransactionServiceDataGrid.Rows.OfType(Of DataGridViewRow).ToArray(), TransactionProductDataGrid.Rows.OfType(Of DataGridViewRow).ToArray())

        Return newTransactionId
    End Function

    Private Sub TransactionItemsInsert(ByVal command As MySqlCommand, ByVal transactionId As String, ByVal serviceRows As DataGridViewRow(), ByVal productRows As DataGridViewRow())
        For Each serviceItem As DataGridViewRow In serviceRows
            command.CommandText =
                "INSERT INTO dtransaction(trsid, ttype, seqnr, idsvc, trqty, uomdc, price, idisc, rmark, vpaym)" & _
                " VALUES(@transactionId, 'S', @rowIndex, @serviceId, 1, 'UNIT', @servicePrice, @serviceDiscount, @serviceRemark, 'False')"
            command.Parameters.Clear()

            command.Parameters.AddWithValue("transactionId", transactionId)
            command.Parameters.AddWithValue("rowIndex", (serviceItem.Index + 1))
            command.Parameters.AddWithValue("serviceId", serviceItem.Cells(ServiceIdCol.Index).Value)
            command.Parameters.AddWithValue("servicePrice", serviceItem.Cells(ServicePriceCol.Index).Value)
            command.Parameters.AddWithValue("serviceDiscount", serviceItem.Cells(ServiceDiscountCol.Index).Value)
            command.Parameters.AddWithValue("serviceRemark", serviceItem.Cells(ServiceRemarksCol.Index).Value)

            command.ExecuteNonQuery()
        Next

        For Each productItem As DataGridViewRow In productRows
            command.CommandText =
                "INSERT INTO dtransaction(trsid, ttype, seqnr, idpdt, trqty, uomdc, price, idisc)" & _
                " VALUES(@transactionId, 'P', @rowIndex, @productId, @productQty, @productUoM, @productPrice, @productDiscount)"
            command.Parameters.Clear()

            command.Parameters.AddWithValue("transactionId", transactionId)
            command.Parameters.AddWithValue("rowIndex", (productItem.Index + 1))
            command.Parameters.AddWithValue("productId", productItem.Cells(ProductIdCol.Index).Value)
            command.Parameters.AddWithValue("productQty", productItem.Cells(ProductQuantityCol.Index).Value)
            command.Parameters.AddWithValue("productUoM", productItem.Cells(ProductMeasurementCol.Index).Value)
            command.Parameters.AddWithValue("productPrice", productItem.Cells(ProductPriceCol.Index).Value)
            command.Parameters.AddWithValue("productDiscount", productItem.Cells(ProductDiscountCol.Index).Value)

            command.ExecuteNonQuery()

            command.CommandText = "UPDATE dproduct SET slqty = (slqty - @usage) WHERE idpdt = @productId AND defsl = 'True'"
            command.Parameters.AddWithValue("usage", productItem.Cells(ProductQuantityCol.Index).Value)

            command.ExecuteNonQuery()

            command.CommandText = UpdateProductStockQuery

            command.ExecuteNonQuery()
        Next
    End Sub

    Private Function QueuedTransactionUpdate(ByVal command As MySqlCommand, ByVal createPaymentForm As _003_01_04_CreatePayment, ByVal pointsEarned As Integer)
        _customerDataTable.Load(ExecQueryReader(String.Format(CustomerQuery, CustomerIdTxt.Text)))

        Dim customer As DataRow = _customerDataTable.Select("idcus = '" & CustomerIdTxt.Text & "'").FirstOrDefault()

        command.CommandText =
            "UPDATE htransaction" & _
            " SET toamt = @grandTotal, topay = @paymentTotal," & _
            "   pterm = @paymentTerm, trstat = @transactionStatus," & _
            "   tpoin = @pointsEarned, chnce = @paymentChange," & _
            "   updatedBy = @employee, cpoin = @currentPoint," & _
            "   svamt = @serviceSubtotal, pdamt = @productSubtotal" & _
            " WHERE htransaction.trsid = @transactionId"
        command.Parameters.Clear()

        command.Parameters.AddWithValue("transactionId", TransactionIdLbl.Text)
        command.Parameters.AddWithValue("grandTotal", createPaymentForm.GrandTotal)
        command.Parameters.AddWithValue("paymentTotal", If(createPaymentForm.SelectedPaymentType = "Cash", createPaymentForm.CashPayment, createPaymentForm.GrandTotal))
        command.Parameters.AddWithValue("paymentTerm", createPaymentForm.SelectedPaymentType)
        command.Parameters.AddWithValue("transactionStatus", "PAID")
        command.Parameters.AddWithValue("pointsEarned", If(IsMemberChk.Checked, pointsEarned, 0))
        command.Parameters.AddWithValue("paymentChange", If(createPaymentForm.SelectedPaymentType = "Cash", createPaymentForm.CashChange, 0))
        command.Parameters.AddWithValue("employee", LoggedInEmployee.Id)
        command.Parameters.AddWithValue("serviceSubtotal", ServiceSubtotal)
        command.Parameters.AddWithValue("productSubtotal", ProductSubtotal)
        command.Parameters.AddWithValue("currentPoint", customer("cpoin"))

        command.ExecuteNonQuery()

        TransactionItemsInsert(command, TransactionIdLbl.Text, TransactionServiceDataGrid.Rows.OfType(Of DataGridViewRow).Where(
            Function(row As DataGridViewRow)
                Return row.Cells(ServicePreAddedCol.Index).Value = False
            End Function).ToArray(), TransactionProductDataGrid.Rows.OfType(Of DataGridViewRow).Where(
            Function(row As DataGridViewRow)
                Return row.Cells(ProductPreAddedCol.Index).Value = False
            End Function).ToArray())

        Return TransactionIdLbl.Text
    End Function

    Private Sub TryPostJournal(ByVal transactionId As String, ByVal paymentMethod As String)
        Dim serviceAccountsDataTable As DataTable = New DataTable()
        Dim productAccountsDataTable As DataTable = New DataTable()

        Dim serviceAccounts As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
        Dim serviceQuery As String =
            "SELECT hservice.idsvc, hservice.glnum" & _
            " FROM hservice" & _
            " RIGHT JOIN glaccountms ON hservice.glnum = glaccountms.glnum AND glaccountms.glsta = 'Active'" & _
            " WHERE hservice.idsvc IN (" & String.Join(", ", TransactionServiceDataGrid.Rows.OfType(Of DataGridViewRow).Select(Function(row) "'" & row.Cells(ServiceIdCol.Index).Value.ToString() & "'")) & ")"
        Dim productAccounts As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
        Dim productQuery As String =
            "SELECT hproduct.idpdt, hproduct.glnum" & _
            " FROM hproduct" & _
            " RIGHT JOIN glaccountms ON hproduct.glnum = glaccountms.glnum AND glaccountms.glsta = 'Active'" & _
            " WHERE hproduct.idpdt IN (" & String.Join(", ", TransactionProductDataGrid.Rows.OfType(Of DataGridViewRow).Select(Function(row) "'" & row.Cells(ProductIdCol.Index).Value.ToString() & "'")) & ")"

        If TransactionServiceDataGrid.Rows.Count > 0 Then
            serviceAccountsDataTable.Load(ExecQueryReader(serviceQuery))

            For Each serviceAccount As DataRow In serviceAccountsDataTable.Rows
                Dim row As DataGridViewRow = TransactionServiceDataGrid.Rows.OfType(Of DataGridViewRow).First(Function(rowItem) rowItem.Cells(ServiceIdCol.Index).Value.ToString() = serviceAccount("idsvc"))
                Dim subTotal As Double = 0

                If row.Cells(ServiceRemarksCol.Index).Value <> "-" Or row.Cells(ServiceDiscountCol.Index).Value <> 0 Then
                    If row.Cells(ServiceDiscountCol.Index).Value = 0 Then
                        subTotal = Double.Parse(row.Cells(ServicePriceCol.Index).Value)
                    Else
                        subTotal = Double.Parse(row.Cells(ServicePriceCol.Index).Value) * (100 - Double.Parse(row.Cells(ServiceDiscountCol.Index).Value)) / 100
                    End If
                Else
                    subTotal = Double.Parse(row.Cells(ServicePriceCol.Index).Value)
                End If

                If serviceAccounts.ContainsKey(serviceAccount("glnum")) Then
                    serviceAccounts(serviceAccount("glnum")) += subTotal
                Else
                    serviceAccounts(serviceAccount("glnum")) = subTotal
                End If
            Next
        End If

        If TransactionProductDataGrid.Rows.Count > 0 Then
            productAccountsDataTable.Load(ExecQueryReader(productQuery))
        End If

        If serviceAccountsDataTable.Rows.Count = TransactionServiceDataGrid.Rows.Count And productAccountsDataTable.Rows.Count = TransactionProductDataGrid.Rows.Count Then
            DoInTransaction(
                Function(command As MySqlCommand)
                    command.CommandText = "INSERT INTO jourhd(docdt, pstdt, rfdoc, rmark, dstat, uname, cgdat, dtnum, cancl) VALUES(NOW(), NOW(), @referenceId, @remark, '', @employeeId, '0000-00-00', 'TR', '')"
                    command.CreateParameter()

                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("referenceId", transactionId)
                    command.Parameters.AddWithValue("remark", "AUTOPOST TRANSAKSI")
                    command.Parameters.AddWithValue("employeeId", LoggedInEmployee.Id)

                    command.ExecuteNonQuery()

                    command.CommandText = "SELECT docid FROM jourhd ORDER BY docid DESC LIMIT 1"
                    Dim newJournalId As String = command.ExecuteScalar()

                    command.CommandText = "INSERT INTO jourdt(docid, glnum, pstky, psamt, notes) VALUES(@journalId, @accountId, @postingKey, @postingAmount, @notes)"

                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("journalId", newJournalId)
                    command.Parameters.AddWithValue("accountId", If(paymentMethod = "Cash", My.Settings.AutomaticPostingConfiguration.Find("transaction_cash"), My.Settings.AutomaticPostingConfiguration.Find("transaction_card")))
                    command.Parameters.AddWithValue("postingKey", 10)
                    command.Parameters.AddWithValue("postingAmount", GrandTotal)
                    command.Parameters.AddWithValue("notes", "")

                    command.ExecuteNonQuery()

                    If TransactionProductDataGrid.Rows.Count > 0 Then
                        Dim totalCogs As Double = 0

                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("journalId", newJournalId)
                        command.Parameters.AddWithValue("accountId", My.Settings.AutomaticPostingConfiguration.Find("transaction_product_revenue"))
                        command.Parameters.AddWithValue("postingKey", 20)
                        command.Parameters.AddWithValue("postingAmount", ProductSubtotal)
                        command.Parameters.AddWithValue("notes", "")

                        command.ExecuteNonQuery()

                        '=====================================================================================================================================================
                        ' Product CoGS Posting
                        '=====================================================================================================================================================
                        For Each row As DataGridViewRow In TransactionProductDataGrid.Rows
                            Dim account As String = productAccountsDataTable.Select("idpdt = '" & row.Cells(ProductIdCol.Index).Value & "'").FirstOrDefault()("glnum")

                            totalCogs += Double.Parse(row.Cells(ProductPurchasePriceCol.Index).Value)

                            command.Parameters.Clear()
                            command.Parameters.AddWithValue("journalId", newJournalId)
                            command.Parameters.AddWithValue("accountId", account)
                            command.Parameters.AddWithValue("postingKey", 20)
                            command.Parameters.AddWithValue("postingAmount", Double.Parse(row.Cells(ProductPurchasePriceCol.Index).Value))
                            command.Parameters.AddWithValue("notes", "")

                            command.ExecuteNonQuery()
                        Next

                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("journalId", newJournalId)
                        command.Parameters.AddWithValue("accountId", My.Settings.AutomaticPostingConfiguration.Find("transaction_cogs"))
                        command.Parameters.AddWithValue("postingKey", 10)
                        command.Parameters.AddWithValue("postingAmount", totalCogs)
                        command.Parameters.AddWithValue("notes", "")

                        command.ExecuteNonQuery()
                        '=====================================================================================================================================================
                    End If

                    If TransactionServiceDataGrid.Rows.Count > 0 Then
                        For Each account As KeyValuePair(Of String, Double) In serviceAccounts
                            command.Parameters.Clear()
                            command.Parameters.AddWithValue("journalId", newJournalId)
                            command.Parameters.AddWithValue("accountId", account.Key)
                            command.Parameters.AddWithValue("postingKey", 20)
                            command.Parameters.AddWithValue("postingAmount", account.Value)
                            command.Parameters.AddWithValue("notes", "")

                            command.ExecuteNonQuery()
                        Next
                    End If

                    Return True
                End Function)
        End If
    End Sub

    Private Sub _003_07_TrDetail2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmExit() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TransactionServiceDataGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionServiceDataGrid.CellEnter
        RemoveServiceBtn.Enabled = (TransactionServiceDataGrid(ServicePreAddedCol.Index, e.RowIndex).Value = False)
    End Sub

    Private Sub TransactionProductDataGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionProductDataGrid.CellEnter
        RemoveProductBtn.Enabled = (TransactionProductDataGrid(ProductPreAddedCol.Index, e.RowIndex).Value = False)
    End Sub

    Private Sub _003_07_TrDetail2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshReader()
    End Sub

    Private Sub RefreshReader()
        Try
            InitializeAcr()

            If AcrReaders.Count > 0 Then
                _acrReader = AcrReaders.FirstOrDefault()
            Else
                _acrReader = Nothing
            End If

            HelpF4Lbl.Visible = Not _acrReader Is Nothing
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Enum PointOfSalesMode
    NewTransaction
    ExistingTransaction
End Enum