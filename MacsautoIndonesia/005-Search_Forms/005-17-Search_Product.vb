Public Class _005_17_Search_Product
    Public Event ProductSelected As EventHandler(Of ProductSelectedEventArgs)

    Private ReadOnly _productsDataTable As DataTable
    Private _productsDataView As DataView

    Public Sub New()
        InitializeComponent()

        _productsDataTable = New DataTable()

        With ProductDataGrid
            .AutoGenerateColumns = False
            .DataSource = _productsDataView
        End With

        ReloadData()

        With ProductDataGrid
            .Columns(ProductIdCol.Index).DataPropertyName = "idpdt"
            .Columns(ProductDescriptionCol.Index).DataPropertyName = "pdtds"
            .Columns(ProductTypeIdCol.Index).DataPropertyName = "idptp"
            .Columns(ProductTypeDescriptionCol.Index).DataPropertyName = "ptpdc"
            .Columns(ProductStockCol.Index).DataPropertyName = "slqty"
            .Columns(ProductUoMCol.Index).DataPropertyName = "uodsc"
            .Columns(ProductPurchasePriceCol.Index).DataPropertyName = "ppamt"
            .Columns(ProductSellPriceCol.Index).DataPropertyName = "psamt"
        End With
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        SelectProduct()
    End Sub

    Private Sub ReloadData()
        Const allProductsQuery As String =
            "SELECT hproduct.idpdt," & _
            "   hproduct.idptp," & _
            "   hproduct.iduom," & _
            "   hproduct.pdtds," & _
            "   hproduct.glnum," & _
            "   hproduct.psamt," & _
            "   hproduct.ppamt," & _
            "   hproduct.pdqty," & _
            "   dproduct.slqty," & _
            "   producttype.ptpdc," & _
            "   uom.uodsc" & _
            " FROM hproduct" & _
            " RIGHT JOIN dproduct ON (hproduct.idpdt = dproduct.idpdt AND dproduct.defsl = 'True')" & _
            " LEFT JOIN producttype ON hproduct.idptp = producttype.idptp" & _
            " LEFT JOIN uom ON hproduct.iduom = uom.iduom" & _
            " WHERE hproduct.is_active = 1" & _
            " GROUP BY idpdt" & _
            " HAVING SUM(dproduct.slqty) > 0"

        _productsDataTable.Rows.Clear()
        _productsDataTable.Load(ExecQueryReader(allProductsQuery))

        _productsDataView = _productsDataTable.AsDataView()
        ProductDataGrid.DataSource = _productsDataView
    End Sub

    Private Sub _005_16_Search_Service_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F5 Then
            SearchTxt.Text = ""

            ReloadData()
        End If
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        _productsDataView.RowFilter = "pdtds LIKE '%" & SearchTxt.Text & "%'"
    End Sub

    Private Sub _005_16_Search_Service_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SearchTxt.Focus()
    End Sub

    Private Sub _005_16_Search_Service_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SearchTxt.Text = ""
    End Sub

    Private Sub SelectProduct()
        If ProductDataGrid.SelectedCells.Count = 0 Then
            MsgBox("No product selected", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        Else
            Dim selectedProductId As String = ProductDataGrid.CurrentRow.Cells(ProductIdCol.Index).Value
            Dim selectedProductRow As DataRow = _productsDataTable.Select("idpdt = '" & selectedProductId & "'").FirstOrDefault()

            RaiseEvent ProductSelected(Me, New ProductSelectedEventArgs(selectedProductRow))
        End If
    End Sub

    Private Sub ServiceDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGrid.CellDoubleClick
        SelectProduct()
    End Sub

    Private Sub ServiceDataGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductDataGrid.KeyPress
        If e.KeyChar.SameAsKey(Keys.Enter) Then
            SelectProduct()
        End If
    End Sub
End Class

Public Class ProductSelectedEventArgs
    Inherits EventArgs

    Private ReadOnly _productRow As DataRow

    ReadOnly Property ProductRow() As DataRow
        Get
            Return _productRow
        End Get
    End Property

    Public Sub New(ByVal productRow As DataRow)
        _productRow = productRow
    End Sub
End Class