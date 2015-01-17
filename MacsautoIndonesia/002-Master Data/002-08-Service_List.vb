Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.EventsModule
Imports MacsautoIndonesia.EventsModule.Events.Service

Public Class _002_08_Service_List
    Private ReadOnly _serviceDataTable As DataTable
    Private ReadOnly _servicePriceDataTable As DataTable
    Private ReadOnly _vehicleSizeDataTable As DataTable
    Private ReadOnly _serviceBinding As BindingSource
    Private _addNewForm As _002_07_Service_Add

    Public Sub New()
        InitializeComponent()

        Dim serviceTypeDataTable As DataTable = New DataTable()
        Dim revenueAccountDataTable As DataTable = New DataTable()

        _serviceDataTable = New DataTable()
        _servicePriceDataTable = New DataTable()
        _vehicleSizeDataTable = New DataTable()
        _serviceBinding = New BindingSource()

        FillService()
        FillServicePrice()

        serviceTypeDataTable.Load(ExecQueryReader("SELECT servicetype.idsvt, servicetype.svtdc FROM servicetype"))
        revenueAccountDataTable.Load(ExecQueryReader("SELECT glaccountms.glnum, glaccountms.gldes" & _
            " FROM glaccountms" & _
            " LEFT JOIN accounttype ON glaccountms.actid = accounttype.actid" & _
            " WHERE glaccountms.glsta = 'Active'" & _
            " AND accounttype.actds = 'REVENUE'"))
        _vehicleSizeDataTable.Load(ExecQueryReader("SELECT vehiclesize.idsiz, vehiclesize.sizdc FROM vehiclesize"))

        For Each serviceType In serviceTypeDataTable.Rows
            ServiceTypeCbo.Items.Add(New KeyValuePair(Of String, String)(serviceType("idsvt"), serviceType("svtdc")))
        Next

        For Each glAccount In revenueAccountDataTable.Rows
            AccountCbo.Items.Add(New KeyValuePair(Of String, String)(glAccount("glnum"), glAccount("gldes")))
        Next

        _serviceBinding.DataSource = _serviceDataTable

        ServiceIdLbl.DataBindings.Add("Text", _serviceBinding, "idsvc", False, DataSourceUpdateMode.Never)
        ServiceNameTxt.DataBindings.Add("Text", _serviceBinding, "svcdc", False, DataSourceUpdateMode.Never)
        ServiceTypeCbo.DataBindings.Add("SelectedItem", _serviceBinding, "idsvt", False, DataSourceUpdateMode.Never)

        With ServiceGridView
            .AutoGenerateColumns = False
            .DataSource = _serviceBinding

            .Columns(ServiceIdCol.Index).DataPropertyName = "idsvc"
            .Columns(ServiceDescCol.Index).DataPropertyName = "svcdc"
            .Columns(ServiceTypeCol.Index).DataPropertyName = "svtdc"
            .Columns(ServiceTypeIdCol.Index).DataPropertyName = "idsvt"
            .Columns(ServiceGLAccountIdCol.Index).DataPropertyName = "glnum"
            .Columns(ServiceGLAccountDescCol.Index).DataPropertyName = "gldes"
        End With

        ServicePricesDataGrid.ValidateIntegerInput(ServicePriceCol.Index)

        EventBus.Subscribe(Of ServiceAddedEvent, ServiceAddedEventArgs)(Me,
            Sub(s As Object, e As ServiceAddedEventArgs)
                FillService()
                FillServicePrice()
            End Sub)
    End Sub

    Private Sub _002_08_Service_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer.Panel2MinSize = ServicePricesDataGrid.Size.Width + 15
        SplitContainer.SplitterDistance = (SplitContainer.Width - (ServicePricesDataGrid.Size.Width + 15))
    End Sub

    Private Sub FillService(Optional ByVal activeOnly As Boolean = True)
        Dim allServiceQuery As String =
            "SELECT hservice.idsvc," & _
            "   hservice.idsvt," & _
            "   hservice.svcdc," & _
            "   hservice.glnum," & _
            "   hservice.is_active," & _
            "   servicetype.svtdc," & _
            "   glaccountms.gldes" & _
            " FROM hservice" & _
            " LEFT JOIN servicetype ON hservice.idsvt = servicetype.idsvt" & _
            " LEFT JOIN glaccountms ON hservice.glnum = glaccountms.glnum"

        If activeOnly Then
            allServiceQuery &= " WHERE hservice.is_active = 1"
        End If

        allServiceQuery &= " ORDER BY hservice.idsvc DESC"

        _serviceDataTable.Rows.Clear()
        _serviceDataTable.Load(ExecQueryReader(allServiceQuery))
    End Sub

    Private Sub FillServicePrice()
        Const allServicePricesQuery As String =
            "SELECT dservice.idsvc," & _
            "   dservice.idsiz," & _
            "   dservice.svprc," & _
            "   vehiclesize.sizdc" & _
            " FROM dservice" & _
            " LEFT JOIN vehiclesize ON dservice.idsiz = vehiclesize.idsiz"

        _servicePriceDataTable.Rows.Clear()
        _servicePriceDataTable.Load(ExecQueryReader(allServicePricesQuery))
    End Sub

    Private Sub ServiceGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceGridView.CellEnter
        ServicePricesDataGrid.Rows.Clear()

        For Each price As DataRow In _servicePriceDataTable.Select("idsvc = '" & ServiceGridView(ServiceIdCol.Index, e.RowIndex).Value & "'")
            ServicePricesDataGrid.Rows.Add(price("idsiz").ToString(), price("sizdc").ToString(), FormatNumber(price("svprc").ToString(), 0))
        Next

        ServiceTypeCbo.SelectedIndex = -1
        AccountCbo.SelectedIndex = -1

        Dim selectedTypeId As String = ServiceGridView(ServiceTypeIdCol.Index, e.RowIndex).Value
        Dim selectedAccountId As String = ServiceGridView(ServiceGLAccountIdCol.Index, e.RowIndex).Value

        If Not String.IsNullOrEmpty(selectedTypeId) Then
            ServiceTypeCbo.SelectedItem = ServiceTypeCbo.Items.OfType(Of KeyValuePair(Of String, String)).ToList().FirstOrDefault(
                Function(item)
                    Return item.Key = selectedTypeId
                End Function)
        End If

        If Not String.IsNullOrEmpty(selectedAccountId) Then
            AccountCbo.SelectedItem = AccountCbo.Items.OfType(Of KeyValuePair(Of String, String)).ToList().First(
                Function(item)
                    Return item.Key = selectedAccountId
                End Function)
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        _addNewForm = New _002_07_Service_Add()

        _addNewForm.ShowDialog(Me)
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        If MsgBox("Once removed, you cannot use this service in any transaction. All existing transaction will not affected. Are you sure?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Try
                Dim selectedServiceId As String = ServiceGridView.CurrentRow.Cells(ServiceIdCol.Index).Value

                If String.IsNullOrEmpty(selectedServiceId) Then
                    Throw New Exception("No service selected")
                End If

                DoInTransaction(
                    Function(command As MySqlCommand)
                        command.CommandText = "UPDATE hservice SET is_active = 0 WHERE hservice.idsvc = @serviceId"
                        command.CreateParameter()

                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("serviceId", selectedServiceId)

                        command.ExecuteNonQuery()

                        Return True
                    End Function)

                MsgBox("Service removed", MsgBoxStyle.Exclamation, "Success")

                FillService()
                FillServicePrice()
            Catch ex As Exception
                Throw
            End Try
        End If
    End Sub

    Private Sub FormMode(ByVal isEditMode As Boolean)
        ServiceNameTxt.ReadOnly = (Not isEditMode)
        ServiceGridView.Enabled = (Not isEditMode)
        SaveBtn.Visible = (isEditMode)
        CancelBtn.Visible = (isEditMode)
        EditBtn.Visible = (Not isEditMode)
        AddBtn.Visible = (Not isEditMode)
        RemoveBtn.Visible = (Not isEditMode)
        ServiceTypeCbo.Enabled = (isEditMode)
        AccountCbo.Enabled = (isEditMode)
        ServicePricesDataGrid.Columns(ServicePriceCol.Index).ReadOnly = False

        If isEditMode Then
            ServiceNameTxt.Focus()
        End If

        AcceptButton = IIf(isEditMode, SaveBtn, Nothing)
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        FormMode(True)

        For Each vehicleSize As DataRow In From currentVehicleSize As DataRow In _vehicleSizeDataTable.Rows Where Not ServicePricesDataGrid.Rows.Cast(Of DataGridViewRow).Any(
            Function(row As DataGridViewRow)
                Return row.Cells(VehicleSizeIdCol.Index).Value = currentVehicleSize("idsiz")
            End Function)

            ServicePricesDataGrid.Rows.Add(vehicleSize("idsiz"), vehicleSize("sizdc"), 0, True)
        Next
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        If MsgBox("Cancel editing?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            FormMode(False)

            _serviceBinding.ResetBindings(False)
        End If
    End Sub

    Private Sub _002_08_Service_List_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        SplitContainer.SplitterDistance = (SplitContainer.Width - (ServicePricesDataGrid.Size.Width + 15))
    End Sub

    Private Sub _002_08_Service_List_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = (SaveBtn.Visible AndAlso MsgBox("You are in the middle of editing, any unsaved changes will be lost. Quit anyway?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No)
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If String.IsNullOrEmpty(ServiceNameTxt.Text) Then
                ErrorInput(ServiceNameTxt, "Service description is required")
            ElseIf ServiceTypeCbo.SelectedIndex = -1 Then
                ErrorInput(ServiceTypeCbo, "Service type is required")
            ElseIf AccountCbo.SelectedIndex = -1 Then
                ErrorInput(AccountCbo, "GL Account is required")
            ElseIf MsgBox("Update service data?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                DoInTransaction(
                    Function(command As MySqlCommand)
                        command.CommandText =
                            "UPDATE hservice" & _
                            "   SET hservice.svcdc = @serviceDesc," & _
                            "       hservice.idsvt = @serviceTypeId," & _
                            "       hservice.glnum = @glaccount" & _
                            "   WHERE hservice.idsvc = @serviceId"
                        command.CreateParameter()

                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("serviceId", ServiceIdLbl.Text)
                        command.Parameters.AddWithValue("serviceDesc", ServiceNameTxt.Text)
                        command.Parameters.AddWithValue("serviceTypeId", CType(ServiceTypeCbo.SelectedItem, KeyValuePair(Of String, String)).Key)
                        command.Parameters.AddWithValue("glaccount", CType(AccountCbo.SelectedItem, KeyValuePair(Of String, String)).Key)

                        command.ExecuteNonQuery()

                        For Each row As DataGridViewRow In ServicePricesDataGrid.Rows
                            If Boolean.Parse(CType(row.Cells(NewPriceCol.Index), DataGridViewCheckBoxCell).EditedFormattedValue) Then
                                command.CommandText = "INSERT INTO dservice VALUES (@serviceId, @vehicleSizeId, @servicePrice)"
                            Else
                                command.CommandText =
                                    "UPDATE dservice" & _
                                    "   SET dservice.svprc = @servicePrice" & _
                                    "   WHERE dservice.idsvc = @serviceId" & _
                                    "   AND dservice.idsiz = @vehicleSizeId"
                            End If

                            command.Parameters.Clear()
                            command.Parameters.AddWithValue("serviceId", ServiceIdLbl.Text)
                            command.Parameters.AddWithValue("vehicleSizeId", row.Cells(VehicleSizeIdCol.Index).Value)
                            command.Parameters.AddWithValue("servicePrice", Double.Parse(row.Cells(ServicePriceCol.Index).Value))

                            command.ExecuteNonQuery()
                        Next

                        Return True
                    End Function)

                MsgBox("Service updated", MsgBoxStyle.Exclamation, "Success")

                FormMode(False)
                FillService()
                FillServicePrice()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub ServicePricesDataGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ServicePricesDataGrid.CellEndEdit
        If e.ColumnIndex = ServicePriceCol.Index And Not String.IsNullOrEmpty(ServicePricesDataGrid(e.ColumnIndex, e.RowIndex).Value) Then
            ServicePricesDataGrid(e.ColumnIndex, e.RowIndex).Value = String.Format("{0:n0}", Double.Parse(ServicePricesDataGrid(e.ColumnIndex, e.RowIndex).Value))
        End If
    End Sub
End Class