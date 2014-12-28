Public Class _005_01_Storage_Location
    Public index, product
    Private Sub _005_01_Storage_Location_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable("SELECT idslc as'Storage #',slocd as 'Storage Location' FROM sloc", SearchSloc)
        Marking(SearchSloc)
        'MsgBox(index)
    End Sub

    Private Sub SearchSloc_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSloc.DoubleClick
        '   If index = 1 Then 'For Product Movement
        'Dim Move As _004_01_Product_Movement = CType(Application.OpenForms("_004_01_Product_Movement"), _004_01_Product_Movement)
        'Move.ProdMoveGrid.CurrentRow.Cells(5).Value = Me.SearchSloc.CurrentRow.Cells(0).Value.ToString
        'Move.ProdMoveGrid.CurrentRow.Cells(6).Value = Me.SearchSloc.CurrentRow.Cells(1).Value.ToString
        '  Move.ProdMoveGrid.CurrentRow.Cells(7).Value = getText("SELECT slqty FROM DPRODUCT where idslc = '" + Me.SearchSloc.CurrentRow.Cells(0).Value.ToString + "' and idpdt = '" + product + "'", 0)
        'Else 'for Master Product
        Dim MsProduct As _002_01_Product = CType(Application.OpenForms("_002_01_Product"), _002_01_Product)
        Dim NewRowIdx = MsProduct.ProdSLoc.Rows.Add()
        MsProduct.ProdSLoc(0, NewRowIdx).Value = Me.SearchSloc.CurrentRow.Cells(0).Value.ToString
        MsProduct.ProdSLoc(1, NewRowIdx).Value = Me.SearchSloc.CurrentRow.Cells(1).Value.ToString
        MsProduct.ProdSLoc(2, NewRowIdx).Value = "0"
        MsProduct.ProdSLoc(3, NewRowIdx).Value = False
        Me.Close()
        'End If

    End Sub
End Class