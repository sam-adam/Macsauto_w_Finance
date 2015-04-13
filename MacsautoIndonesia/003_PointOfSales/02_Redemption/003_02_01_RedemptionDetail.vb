Imports MacsautoIndonesia.My
Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.SmartCard
Imports MacsautoIndonesia.SmartCard.Reader
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Services
Imports System.Text.RegularExpressions

Public Class _003_04_TrMerchandiseRedemption
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

    Public Event RedemptionCreated As EventHandler(Of RedemptionCreatedEventArgs)

    Private ReadOnly _customerDataTable As DataTable
    Private _searchCustomerForm As _005_15_Search_Vehicle
    Private _searchMerchandiseForm As _005_18_SearchMerchandise
    Private _acrReader As AcrReader

    Property PointRequired() As Integer
        Set(ByVal value As Integer)
            PointRequiredLbl.Text = value.ToString("N0")
        End Set
        Get
            Return Integer.Parse(PointRequiredLbl.Text)
        End Get
    End Property

    Property PointLeft() As Integer
        Set(ByVal value As Integer)
            PointLeftLbl.Text = value.ToString("N0")
        End Set
        Get
            Return Integer.Parse(PointLeftLbl.Text)
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        TryInitializeAcr()

        _customerDataTable = New DataTable()

        MerchandiseDataGrid.ValidateIntegerInput(ProductQuantityCol.Index)
    End Sub

    Private Sub _003_04_TrMerchandiseRedemption_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F1 Then
            ShowCustomerForm()
        ElseIf e.KeyData = Keys.F2 Then
            ShowMerchandiseForm()
        ElseIf e.KeyData = Keys.F4 Then
            While _acrReader Is Nothing And MsgBox("No card reader found. Try again?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Warning") = MsgBoxResult.Yes
                TryInitializeAcr()
            End While

            If Not _acrReader Is Nothing Then
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
        End If
    End Sub

    Private Function TryInitializeAcr() As Boolean
        Try
            InitializeAcr()

            _acrReader = AcrReaders.FirstOrDefault()

            Return Not _acrReader Is Nothing
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub ShowCustomerForm()
        If _searchCustomerForm Is Nothing Then
            _searchCustomerForm = New _005_15_Search_Vehicle(_005_15_Search_Vehicle.CustomerMode, True)

            AddHandler _searchCustomerForm.CustomerSelected, AddressOf _searchCustomer_CustomerSelected
        End If

        _searchCustomerForm.ShowDialog(Me)
    End Sub

    Private Sub ShowMerchandiseForm()
        If String.IsNullOrEmpty(CustomerIdTxt.Text) Then
            ErrorInput(FindCustomerBtn, "Customer is required")
        Else
            If _searchMerchandiseForm Is Nothing Then
                _searchMerchandiseForm = New _005_18_SearchMerchandise()

                AddHandler _searchMerchandiseForm.MerchandiseSelected, AddressOf _searchMerchandise_MerchandiseSelected
            End If

            _searchMerchandiseForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub _searchCustomer_CustomerSelected(ByVal sender As Object, ByVal e As CustomerSelectedEventArgs)
        SelectCustomer(e.CustomerId)

        _searchCustomerForm.Close()
    End Sub

    Private Sub _searchMerchandise_MerchandiseSelected(ByVal sender As Object, ByVal e As MerchandiseSelectedEventArgs)
        Dim selectedMerchandiseRow As DataRow = e.MerchandiseDataRow

        If PointLeft - Integer.Parse(selectedMerchandiseRow("mpoin")) < 0 Then
            MsgBox("Not enough point", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
        Else
            Dim alreadyExisted As DataGridViewRow = MerchandiseDataGrid.Rows.OfType(Of DataGridViewRow).FirstOrDefault(
                Function(row As DataGridViewRow)
                    Return row.Cells(ProductIdCol.Index).Value = selectedMerchandiseRow("idpdt")
                End Function)

            If Not alreadyExisted Is Nothing Then
                If (MerchandiseDataGrid(ProductQuantityCol.Index, alreadyExisted.Index).Value + 1) > MerchandiseDataGrid(ProductRemainingQtyCol.Index, alreadyExisted.Index).Value Then
                    MsgBox("Remaining quantity is not enough", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
                Else
                    MerchandiseDataGrid(ProductQuantityCol.Index, alreadyExisted.Index).Value += 1
                End If
            Else
                MerchandiseDataGrid.Rows.Add(
                    selectedMerchandiseRow("idpdt"),
                    selectedMerchandiseRow("idmrch"),
                    selectedMerchandiseRow("pdtds"),
                    1,
                    selectedMerchandiseRow("slqty"),
                    selectedMerchandiseRow("uodsc"),
                    selectedMerchandiseRow("mpoin"),
                    selectedMerchandiseRow("ppamt"))
            End If

            _searchMerchandiseForm.Close()
        End If
    End Sub

    Private Sub SelectCustomer(ByVal customerId As String)
        customerId = Regex.Replace(customerId, "/\s/g", "")

        If customerId <> CustomerIdTxt.Text Then
            _customerDataTable.Rows.Clear()
            _customerDataTable.Load(ExecQueryReader(String.Format(CustomerQuery, customerId)))

            If _customerDataTable.Rows.Count = 0 Then
                _customerDataTable.Rows.Clear()

                MsgBox("Customer not found", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning")
            Else
                MerchandiseDataGrid.Rows.Clear()

                DoInTransaction(
                    Function(command As MySqlCommand)
                        TransactionService.CheckPointExpiry(command, customerId)

                        Return True
                    End Function)

                If CustomerIdTxt.DataBindings.Count = 0 Then
                    CustomerIdTxt.DataBindings.Add("Text", _customerDataTable, "idcus", False, DataSourceUpdateMode.Never)
                    CustomerNameTxt.DataBindings.Add("Text", _customerDataTable, "cname", False, DataSourceUpdateMode.Never)
                    CustomerAddressTxt.DataBindings.Add("Text", _customerDataTable, "cadd1", False, DataSourceUpdateMode.Never)
                    CustomerPhoneTxt.DataBindings.Add("Text", _customerDataTable, "cphon", False, DataSourceUpdateMode.Never)
                    CustomerCellphoneTxt.DataBindings.Add("Text", _customerDataTable, "ccpon", False, DataSourceUpdateMode.Never)
                    CustomerPointTxt.DataBindings.Add("Text", _customerDataTable, "cpoin", False, DataSourceUpdateMode.Never)
                    IsMemberChk.DataBindings.Add("Checked", _customerDataTable, "is_member", False, DataSourceUpdateMode.Never)

                    DataBindings.Add("PointLeft", _customerDataTable, "cpoin", False, DataSourceUpdateMode.Never)
                End If
            End If
        End If
    End Sub

    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click
        ShowMerchandiseForm()
    End Sub

    Private Sub RemoveProductBtn_Click(sender As Object, e As EventArgs) Handles RemoveProductBtn.Click
        If MerchandiseDataGrid.SelectedCells.Count = 0 Then
            MsgBox("Nothing to remove", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")
        Else
            MerchandiseDataGrid.Rows.RemoveAt(MerchandiseDataGrid.CurrentRow.Index)
        End If
    End Sub

    Private Sub MerchandiseDataGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles MerchandiseDataGrid.RowsAdded
        RemoveProductBtn.Enabled = (MerchandiseDataGrid.Rows.Count > 0)

        Recalculate()
    End Sub

    Private Sub MerchandiseDataGrid_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles MerchandiseDataGrid.RowsRemoved
        RemoveProductBtn.Enabled = (MerchandiseDataGrid.Rows.Count > 0)

        Recalculate()
    End Sub

    Private Sub Recalculate()
        PointRequired = MerchandiseDataGrid.Rows.OfType(Of DataGridViewRow).Sum(
            Function(row As DataGridViewRow)
                Return Integer.Parse(row.Cells(MerchandisePointCol.Index).Value) * Integer.Parse(If(row.Cells(ProductQuantityCol.Index).Value Is Nothing, 0, row.Cells(ProductQuantityCol.Index).Value))
            End Function)
        PointLeft = If(String.IsNullOrEmpty(CustomerPointTxt.Text), 0, Integer.Parse(CustomerPointTxt.Text) - PointRequired)
    End Sub

    Private Function ConfirmExit() As Boolean
        Return MsgBox("Cancelling transaction. Are you sure?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes
    End Function

    Private Sub _003_04_TrMerchandiseRedemption_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmExit() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        ConfirmExit()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If String.IsNullOrEmpty(CustomerIdTxt.Text) Then
            ErrorInput(CustomerIdTxt, "Customer is required")
        ElseIf MerchandiseDataGrid.Rows.Count = 0 Then
            ErrorInput(AddProductBtn, "No service or product selected")
        ElseIf MsgBox("Redeem point with merchandise?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
            Dim newRedemptionId As String = ""
            DoInTransaction(
                Function(command As MySqlCommand)
                    newRedemptionId = TransactionService.GetNewRedemptionId(command)

                    '===========================================================================================================================================
                    ' Create New Redemption
                    '===========================================================================================================================================
                    command.CommandText = "INSERT INTO hredemption(rdmpid, rdmpdat, idcus, tpoin, cpoin) VALUES(@redemptionId, NOW(), @customerId, @totalPoint, @currentPoint)"

                    command.CreateParameter()
                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("redemptionId", newRedemptionId)
                    command.Parameters.AddWithValue("customerId", CustomerIdTxt.Text)
                    command.Parameters.AddWithValue("totalPoint", PointRequired)
                    command.Parameters.AddWithValue("currentPoint", Integer.Parse(CustomerPointTxt.Text))

                    command.ExecuteNonQuery()

                    For Each row As DataGridViewRow In MerchandiseDataGrid.Rows
                        command.Parameters.Clear()

                        command.CommandText = "INSERT INTO dredemption(rdmpid, idmrch, point, qty) VALUES(@redemptionId, @merchandiseId, @merchandisePoint, @quantity)"

                        command.Parameters.AddWithValue("redemptionId", newRedemptionId)
                        command.Parameters.AddWithValue("merchandiseId", row.Cells(MerchandiseIdCol.Index).Value)
                        command.Parameters.AddWithValue("merchandisePoint", Integer.Parse(row.Cells(MerchandisePointCol.Index).Value))
                        command.Parameters.AddWithValue("quantity", Integer.Parse(row.Cells(ProductQuantityCol.Index).Value))

                        command.ExecuteNonQuery()

                        command.CommandText = "UPDATE dproduct SET slqty = slqty - @quantity WHERE idpdt = @productId AND defsl = 'True'"

                        command.Parameters.AddWithValue("productId", row.Cells(ProductIdCol.Index).Value)

                        command.ExecuteNonQuery()

                        command.CommandText = "UPDATE hproduct SET pdqty = pdqty - @quantity WHERE idpdt = @productId"

                        command.ExecuteNonQuery()
                    Next
                    '===========================================================================================================================================

                    '===========================================================================================================================================
                    ' Update customer point
                    '===========================================================================================================================================
                    command.Parameters.Clear()

                    command.CommandText = "UPDATE hcustomer SET cpoin = (cpoin - @totalPoint) WHERE idcus = @customerId"

                    command.Parameters.AddWithValue("totalPoint", PointRequired)
                    command.Parameters.AddWithValue("customerId", CustomerIdTxt.Text)

                    command.ExecuteNonQuery()

                    command.CommandText = "INSERT INTO pointtrans(idcus, ptdat, trpon, trtype) VALUES(@customerId, NOW(), @totalPoint, 'SUB')"
                    command.ExecuteNonQuery()
                    '===========================================================================================================================================

                    Return True
                End Function)

            Dim redemptionPage As RedemptionPage = New RedemptionPage(RollPageWidth, New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular))

            redemptionPage.Logo = Resources.Logo_MACSAUTO_only__background_putih__1_
            redemptionPage.SetTransactionInformation(newRedemptionId, RedemptionDate.Value.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString())

            redemptionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
            redemptionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
            redemptionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
            redemptionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
            redemptionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
            redemptionPage.AppendFooter("© MACSAUTO INDONESIA")

            PrintPage(Me, redemptionPage)

            MsgBox("Transaction saved", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success")

            RaiseEvent RedemptionCreated(Me, New RedemptionCreatedEventArgs(newRedemptionId))

            Close()
        End If
    End Sub

    Private Sub MerchandiseDataGrid_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles MerchandiseDataGrid.CellValidating
        If e.ColumnIndex = ProductQuantityCol.Index Then
            If MerchandiseDataGrid(ProductQuantityCol.Index, e.RowIndex).IsInEditMode AndAlso (e.FormattedValue > MerchandiseDataGrid(ProductRemainingQtyCol.Index, e.RowIndex).Value) Then
                MsgBox("Remaining quantity is not enough", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Warning")

                e.Cancel = True
            Else
                Dim totalPoint As Integer = 0

                For Each row As DataGridViewRow In MerchandiseDataGrid.Rows
                    If row.Index = e.RowIndex Then
                        totalPoint += (Integer.Parse(e.FormattedValue) * Integer.Parse(row.Cells(MerchandisePointCol.Index).Value))
                    Else
                        totalPoint += (Integer.Parse(row.Cells(ProductQuantityCol.Index).Value) * Integer.Parse(row.Cells(MerchandisePointCol.Index).Value))
                    End If
                Next

                If totalPoint > Integer.Parse(CustomerPointTxt.Text) Then
                    MsgBox("Not enough point", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")

                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub MerchandiseDataGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles MerchandiseDataGrid.CellValueChanged
        If e.ColumnIndex = ProductQuantityCol.Index Then
            Recalculate()
        End If
    End Sub

    Private Sub MerchandiseDataGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles MerchandiseDataGrid.CellEnter
        RemoveProductBtn.Enabled = (MerchandiseDataGrid.Rows.Count > 0)
    End Sub

    Private Sub FindCustomerBtn_Click(sender As Object, e As EventArgs) Handles FindCustomerBtn.Click
        ShowCustomerForm()
    End Sub
End Class

Public Class RedemptionCreatedEventArgs
    Inherits EventArgs

    Private ReadOnly _redemptionId As String

    ReadOnly Property RedemptionId As String
        Get
            Return _redemptionId
        End Get
    End Property

    Public Sub New(ByVal redemptionId As String)
        _redemptionId = redemptionId
    End Sub
End Class