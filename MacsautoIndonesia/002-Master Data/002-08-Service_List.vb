Public Class _002_08_Service_List
    Private ReadOnly _serviceDataTable As DataTable
    Private ReadOnly _serviceTypeDataTable As DataTable
    Private ReadOnly _servicePriceDataTable As DataTable
    Private ReadOnly _serviceBinding As BindingSource

    Public Sub New()
        InitializeComponent()

        _serviceDataTable = New DataTable()
        _serviceTypeDataTable = New DataTable()
        _servicePriceDataTable = New DataTable()
        _serviceBinding = New BindingSource()

        FillService()
        FillServicePrice()

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
    End Sub

    Private Sub _002_08_Service_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer.Panel2MinSize = ServicePricesDataGrid.Size.Width + 15
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
End Class