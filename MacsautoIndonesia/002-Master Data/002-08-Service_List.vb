Imports MySql.Data.MySqlClient

Public Class _002_08_Service_List
    Private ReadOnly _serviceDataTable As DataTable
    Private ReadOnly _serviceTypeDataTable As DataTable
    Private ReadOnly _servicePriceDataTable As DataTable
    Private ReadOnly _serviceBinding As BindingSource
    Private _addNewForm As _002_07_Service_Add

    Public Sub New()
        InitializeComponent()

        _serviceDataTable = New DataTable()
        _serviceTypeDataTable = New DataTable()
        _servicePriceDataTable = New DataTable()
        _serviceBinding = New BindingSource()

        FillService()
        FillServicePrice()

        _serviceTypeDataTable.Load(ExecQueryReader("SELECT servicetype.idsvt, servicetype.svtdc FROM servicetype"))

        _serviceBinding.DataSource = _serviceDataTable

        ServiceIdLbl.DataBindings.Add("Text", _serviceBinding, "idsvc", False, DataSourceUpdateMode.Never)
        ServiceNameTxt.DataBindings.Add("Text", _serviceBinding, "svcdc", False, DataSourceUpdateMode.Never)

        With ServiceGridView
            .AutoGenerateColumns = False
            .DataSource = _serviceBinding

            .Columns(ServiceIdCol.Index).DataPropertyName = "idsvc"
            .Columns(ServiceDescCol.Index).DataPropertyName = "svcdc"
            .Columns(ServiceTypeCol.Index).DataPropertyName = "svtdc"
            .Columns(ServiceGLAccountIdCol.Index).DataPropertyName = "glnum"
            .Columns(ServiceGLAccountDescCol.Index).DataPropertyName = "gldes"
        End With

        For Each serviceType In _serviceTypeDataTable.Rows
            ServiceTypeCbo.Items.Add(New KeyValuePair(Of String, String)(serviceType("idsvt"), serviceType("svtdc")))
        Next
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
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        _addNewForm = New _002_07_Service_Add()

        AddHandler _addNewForm.ServiceAdded,
            Sub(s As Object, args As ServiceAddedEventArgs)
                FillService()
                FillServicePrice()

                _addNewForm.Dispose()
            End Sub

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

        If isEditMode Then
            ServiceNameTxt.Focus()
        End If

        AcceptButton = IIf(isEditMode, SaveBtn, Nothing)
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        FormMode(True)
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
End Class