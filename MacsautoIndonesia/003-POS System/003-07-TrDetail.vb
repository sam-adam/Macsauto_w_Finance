Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.SmartCard.Reader
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
Imports MacsautoIndonesia.Services

Public Class _003_07_TrDetail2
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

    Private ReadOnly _selectedMode As PointOfSalesMode
    Private ReadOnly _customerDataTable As DataTable
    Private ReadOnly _vehiclesDataTable As DataTable
    Private ReadOnly _selectedVehicleBinding As BindingSource
    Private _searchCustomerForm As _005_15_Search_Vehicle
    Private _searchServiceForm As _005_16_Search_Service
    Private _searchProductForm As _005_17_Search_Product
    Private _paymentForm As _003_08_Payment

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

        End Select

        SwitchMode()
    End Sub

    Private Sub SwitchMode()
        CustomerPanel.Enabled = (_selectedMode = PointOfSalesMode.NewTransaction)
        VehiclePanel.Enabled = (_selectedMode = PointOfSalesMode.NewTransaction)
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
        End If
    End Sub

    Private Sub _searchCustomer_CustomerVehicleSelected(ByVal sender As Object, ByVal e As CustomerVehicleSelectedEventArgs)
        DoInTransaction(
            Function(command As MySqlCommand)
                TransactionService.CheckPointExpiry(command, e.CustomerId)

                Return True
            End Function)

        _customerDataTable.Rows.Clear()
        _customerDataTable.Load(ExecQueryReader(String.Format(CustomerQuery, e.CustomerId)))

        _vehiclesDataTable.Rows.Clear()
        _vehiclesDataTable.Load(ExecQueryReader(String.Format(VehiclesQuery, e.CustomerId)))

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

    Private Sub _searchProduct_ProductSelected(ByVal sender As Object, ByVal e As ProductSelectedEventArgs)
        Dim selectedProductRow As DataRow = e.ProductRow
        Dim alreadyExisted As DataGridViewRow = TransactionProductDataGrid.Rows.OfType(Of DataGridViewRow).FirstOrDefault(
            Function(row As DataGridViewRow)
                Return row.Cells(ProductIdCol.Index).Value = selectedProductRow("idpdt")
            End Function)

        If Not alreadyExisted Is Nothing Then
            If (TransactionProductDataGrid(ProductQuantityCol.Index, alreadyExisted.Index).Value + 1) > TransactionProductDataGrid(ProductRemainingQtyCol.Index, alreadyExisted.Index).Value Then
                MsgBox("Remaining quantity is not enough", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
            Else
                TransactionProductDataGrid(ProductQuantityCol.Index, alreadyExisted.Index).Value += 1
            End If
        Else
            TransactionProductDataGrid.Rows.Add(selectedProductRow("idpdt"), selectedProductRow("pdtds"), 1, selectedProductRow("slqty"), selectedProductRow("uodsc"), selectedProductRow("psamt"), 0)
        End If

        _searchProductForm.Close()
    End Sub

    Private Sub ShowCustomerForm()
        If _searchCustomerForm Is Nothing Then
            _searchCustomerForm = New _005_15_Search_Vehicle()
            AddHandler _searchCustomerForm.CustomerVehicleSelected, AddressOf _searchCustomer_CustomerVehicleSelected
        End If

        If _selectedVehicleBinding.Count = 0 OrElse (TransactionServiceDataGrid.Rows.Count = 0 OrElse MsgBox("Changing customer will remove all existing services. Continue?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes) Then
            If _selectedVehicleBinding.Count > 0 Then
                TransactionServiceDataGrid.Rows.Clear()
            End If

            _searchCustomerForm.ShowDialog(Me)
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
                If MsgBox("The selected vehicle is different from previous, all existing services will be removed. Continue?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                    TransactionServiceDataGrid.Rows.Clear()
                Else
                    VehicleRegCbo.SelectedValue = CurrentVehicleRegistration
                End If
            End If

            CurrentVehicleSize = VehicleSizeTxt.Text
            CurrentVehicleRegistration = VehicleRegCbo.SelectedText
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
        If e.ColumnIndex = ProductQuantityCol.Index AndAlso (e.FormattedValue > TransactionProductDataGrid(ProductRemainingQtyCol.Index, e.RowIndex).Value) Then
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

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        If MsgBox("Cancelling transaction. Are you sure?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If _selectedVehicleBinding.Count = 0 Then
            ErrorInput(FindCustomerBtn, "Customer and vehicle is required")
        ElseIf (TransactionProductDataGrid.Rows.Count + TransactionServiceDataGrid.Rows.Count) = 0 Then
            ErrorInput(AddServiceBtn, "No service or product selected")
        ElseIf MsgBox("Make payment?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            If _paymentForm Is Nothing Then
                _paymentForm = New _003_08_Payment(GrandTotal)
                AddHandler _paymentForm.PaymentSubmitted, AddressOf _paymentForm_PaymentSubmitted
            Else
                _paymentForm.GrandTotal = GrandTotal
            End If

            _paymentForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub QueueBtn_Click(sender As Object, e As EventArgs) Handles QueueBtn.Click

    End Sub

    Private Sub VoidBtn_Click(sender As Object, e As EventArgs) Handles VoidBtn.Click

    End Sub

    Private Sub _paymentForm_PaymentSubmitted(ByVal sender As Object, ByVal e As PaymentSubmittedEventArgs)
        Dim memberCurrentPoint As Integer
        Dim memberEarnedPoint As Integer
        Dim newTransactionId As String

        DoInTransaction(
            Function(command As MySqlCommand)
                Dim newPaymentId As String = TransactionService.GetNewPaymentId(command)

                memberEarnedPoint = TransactionService.CalculatePointsEarned(GrandTotal, command)
                newTransactionId = NewTransactionInsert(command, e.PaymentForm, memberEarnedPoint)

                '===========================================================================================================================================
                ' Create New Payment
                '===========================================================================================================================================
                command.CommandText = "INSERT INTO payment(payid, trsid, pyamt, pydat) VALUES(@paymentId, @transactionId, @paymentAmount, NOW())"
                command.Parameters.Clear()

                command.Parameters.AddWithValue("paymentId", newPaymentId)
                command.Parameters.AddWithValue("transactionId", newTransactionId)
                command.Parameters.AddWithValue("paymentAmount", If(e.PaymentForm.SelectedPaymentType = "Cash", e.PaymentForm.CashPayment, GrandTotal))

                command.ExecuteNonQuery()
                '===========================================================================================================================================

                If IsMemberChk.Checked Then
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
            transactionPage.SetPayment(GrandTotal, e.PaymentForm.SelectedPaymentType, memberEarnedPoint, memberCurrentPoint, DateTime.Now.AddYears(1).ToString("dd-MM-yyyy"))
        Else
            transactionPage.SetPayment(GrandTotal, e.PaymentForm.SelectedPaymentType)
        End If

        transactionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
        transactionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
        transactionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
        transactionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
        transactionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
        transactionPage.AppendFooter("© MACSAUTO INDONESIA")

        PrintPage(Me, transactionPage)
        '===========================================================================================================================================

        MsgBox("Transaction saved", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success")

        _paymentForm.Close()

        Dispose()
    End Sub

    Private Function NewTransactionInsert(ByVal command As MySqlCommand, ByVal paymentForm As _003_08_Payment, ByVal pointsEarned As Integer) As String
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
        command.Parameters.AddWithValue("licenseExpired", VehicleExpiryDate.Value.ToMySQLDateTime())
        command.Parameters.AddWithValue("serviceSubtotal", ServiceSubtotal)
        command.Parameters.AddWithValue("productSubtotal", ProductSubtotal)
        command.Parameters.AddWithValue("grandTotal", GrandTotal)
        command.Parameters.AddWithValue("paymentTotal", If(paymentForm.SelectedPaymentType = "Cash", paymentForm.CashPayment, paymentForm.GrandTotal))
        command.Parameters.AddWithValue("paymentTerm", paymentForm.SelectedPaymentType)
        command.Parameters.AddWithValue("transactionStatus", "PAID")
        command.Parameters.AddWithValue("serviceStatus", "")
        command.Parameters.AddWithValue("pointsEarned", If(IsMemberChk.Checked, pointsEarned, 0))
        command.Parameters.AddWithValue("paymentChange", If(paymentForm.SelectedPaymentType = "Cash", paymentForm.CashChange, 0))
        command.Parameters.AddWithValue("employee", LoggedInEmployee.Id)
        command.Parameters.AddWithValue("transactionRemark", "")
        command.Parameters.AddWithValue("currentPoint", customer("cpoin"))

        command.ExecuteNonQuery()

        For Each serviceItem As DataGridViewRow In TransactionServiceDataGrid.Rows
            command.CommandText =
                "INSERT INTO dtransaction(trsid, ttype, seqnr, idsvc, trqty, uomdc, price, idisc, rmark, vpaym)" & _
                " VALUES(@transactionId, 'S', @rowIndex, @serviceId, 1, 'UNIT', @servicePrice, @serviceDiscount, @serviceRemark, 'False')"
            command.Parameters.Clear()

            command.Parameters.AddWithValue("transactionId", newTransactionId)
            command.Parameters.AddWithValue("rowIndex", (serviceItem.Index + 1))
            command.Parameters.AddWithValue("serviceId", serviceItem.Cells(ServiceIdCol.Index).Value)
            command.Parameters.AddWithValue("servicePrice", serviceItem.Cells(ServicePriceCol.Index).Value)
            command.Parameters.AddWithValue("serviceDiscount", serviceItem.Cells(ServiceDiscountCol.Index).Value)
            command.Parameters.AddWithValue("serviceRemark", serviceItem.Cells(ServiceRemarksCol.Index).Value)

            command.ExecuteNonQuery()
        Next

        For Each productItem As DataGridViewRow In TransactionProductDataGrid.Rows
            command.CommandText =
                "INSERT INTO dtransaction(trsid, ttype, seqnr, idpdt, trqty, uomdc, price, idisc)" & _
                " VALUES(@transactionId, 'P', @rowIndex, @productId, @productQty, @productUoM, @productPrice, @productDiscount)"
            command.Parameters.Clear()

            command.Parameters.AddWithValue("transactionId", newTransactionId)
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

            command.CommandText =
                "UPDATE hproduct" & _
                " INNER JOIN (" & _
                "   SELECT dproduct.idpdt, SUM(dproduct.slqty) AS total_stock" & _
                "   FROM dproduct" & _
                "   GROUP BY dproduct.idpdt" & _
                " ) dproduct ON hproduct.idpdt = dproduct.idpdt" & _
                " SET pdqty = dproduct.total_stock WHERE hproduct.idpdt = @productId"

            command.ExecuteNonQuery()
        Next

        Return newTransactionId
    End Function
End Class

Public Enum PointOfSalesMode
    NewTransaction
    ExistingTransaction
End Enum