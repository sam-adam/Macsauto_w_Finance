Imports MacsautoIndonesia.My
Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.SmartCard
Imports MacsautoIndonesia.SmartCard.Reader
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
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

    Private ReadOnly _customerDataTable As DataTable
    Private _searchCustomerForm As _005_15_Search_Vehicle
    Private _searchMerchandiseForm As _005_18_SearchMerchandise
    Private _acrReader As AcrReader

    Public Sub New()
        InitializeComponent()
        TryInitializeAcr()

        _customerDataTable = New DataTable()
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
            ErrorInput(FindCustomerBtn, "Customer and vehicle is required")
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
                selectedMerchandiseRow("pdtdc"),
                0,
                selectedMerchandiseRow("slqty"),
                selectedMerchandiseRow("uodsc"),
                selectedMerchandiseRow("mpoin"),
                selectedMerchandiseRow("ppamt"))
        End If

        _searchMerchandiseForm.Close()
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

            If CustomerIdTxt.DataBindings.Count = 0 Then
                CustomerIdTxt.DataBindings.Add("Text", _customerDataTable, "idcus", False, DataSourceUpdateMode.Never)
                CustomerNameTxt.DataBindings.Add("Text", _customerDataTable, "cname", False, DataSourceUpdateMode.Never)
                CustomerAddressTxt.DataBindings.Add("Text", _customerDataTable, "cadd1", False, DataSourceUpdateMode.Never)
                CustomerPhoneTxt.DataBindings.Add("Text", _customerDataTable, "cphon", False, DataSourceUpdateMode.Never)
                CustomerCellphoneTxt.DataBindings.Add("Text", _customerDataTable, "ccpon", False, DataSourceUpdateMode.Never)
                CustomerPointTxt.DataBindings.Add("Text", _customerDataTable, "cpoin", False, DataSourceUpdateMode.Never)
                IsMemberChk.DataBindings.Add("Checked", _customerDataTable, "is_member", False, DataSourceUpdateMode.Never)
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

    End Sub
End Class