Public Class _005_16_Search_Service
    Public Event ServiceSelected As EventHandler(Of ServiceSelectedEventArgs)

    Private ReadOnly _servicesDataTable As DataTable
    Private _servicesDataView As DataView
    Private _vehicleSize As String

    Property VehicleSize() As String
        Set(ByVal value As String)
            _vehicleSize = value
        End Set
        Get
            Return _vehicleSize
        End Get
    End Property

    Public Sub New(ByVal vehicleSize As String)
        InitializeComponent()

        _vehicleSize = vehicleSize
        _servicesDataTable = New DataTable()

        ReloadData()

        With ServiceDataGrid
            .AutoGenerateColumns = False
            .DataSource = _servicesDataView

            .Columns(ServiceIdCol.Index).DataPropertyName = "idsvc"
            .Columns(ServiceDescriptionCol.Index).DataPropertyName = "svcdc"
            .Columns(ServiceTypeIdCol.Index).DataPropertyName = "idsvt"
            .Columns(ServiceTypeDescriptionCol.Index).DataPropertyName = "svtdc"
            .Columns(ServicePriceCol.Index).DataPropertyName = "svprc"
        End With
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        SelectService()
    End Sub

    Private Sub ReloadData()
        Const allServicesQuery As String =
            "SELECT hservice.idsvc," & _
            "   hservice.idsvt," & _
            "   hservice.svcdc," & _
            "   hservice.vcpmt," & _
            "   hservice.glnum," & _
            "   servicetype.svtdc," & _
            "   dservice.idsiz," & _
            "   dservice.svprc," & _
            "   vehiclesize.sizdc" & _
            " FROM hservice" & _
            " RIGHT JOIN dservice ON (hservice.idsvc = dservice.idsvc AND dservice.idsiz = '{0}')" & _
            " LEFT JOIN servicetype ON hservice.idsvt = servicetype.idsvt" & _
            " LEFT JOIN vehiclesize ON dservice.idsiz = vehiclesize.idsiz" & _
            " WHERE hservice.is_active = 1" & _
            " GROUP BY idsvc"

        _servicesDataTable.Rows.Clear()
        _servicesDataTable.Load(ExecQueryReader(String.Format(allServicesQuery, _vehicleSize)))

        _servicesDataView = _servicesDataTable.AsDataView()
        ServiceDataGrid.DataSource = _servicesDataView
    End Sub

    Private Sub _005_16_Search_Service_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F5 Then
            SearchTxt.Text = ""

            ReloadData()
        End If
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        _servicesDataView.RowFilter = "svcdc LIKE '%" & SearchTxt.Text & "%'"
    End Sub

    Private Sub _005_16_Search_Service_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SearchTxt.Focus()
    End Sub

    Private Sub _005_16_Search_Service_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SearchTxt.Text = ""
    End Sub

    Private Sub SelectService()
        If ServiceDataGrid.SelectedCells.Count = 0 Then
            MsgBox("No service selected", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        Else
            Dim selectedServiceId As String = ServiceDataGrid.CurrentRow.Cells(ServiceIdCol.Index).Value
            Dim selectedServiceRow As DataRow = _servicesDataTable.Select("idsvc = '" & selectedServiceId & "'").FirstOrDefault()

            RaiseEvent ServiceSelected(Me, New ServiceSelectedEventArgs(selectedServiceRow))
        End If
    End Sub

    Private Sub ServiceDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServiceDataGrid.CellDoubleClick
        SelectService()
    End Sub

    Private Sub ServiceDataGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ServiceDataGrid.KeyPress
        If e.KeyChar.SameAsKey(Keys.Enter) Then
            SelectService()
        End If
    End Sub
End Class

Public Class ServiceSelectedEventArgs
    Inherits EventArgs

    Private ReadOnly _serviceRow As DataRow

    ReadOnly Property ServiceRow() As DataRow
        Get
            Return _serviceRow
        End Get
    End Property

    Public Sub New(ByVal serviceRow As DataRow)
        _serviceRow = serviceRow
    End Sub
End Class