Public Class _005_03_Product
    Public indexType

    Private Sub _005_03_Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable("SELECT idpdt as 'PRODUCT #',pdtds AS 'PRODUCT DESCRIPTION',uodsc AS 'UOM',glnum as 'GL. Act.',c.iscnsm as 'Consumable'  from hproduct a, uom b, productType c where a.iduom = b.iduom and a.idptp = c.idptp WHERE a.is_active = 1", productGrid)
        Marking(productGrid)
        '   MsgBox(_004_01_Product_Movement.MoveType.SelectedIndex.ToString())
        'MsgBox(indexType)
    End Sub

    Private Sub productGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles productGrid.DoubleClick
        Dim detail As _004_01_Product_Movement = CType(Application.OpenForms("_004_01_Product_Movement"), _004_01_Product_Movement)
        detail.ProdMoveGrid.CurrentRow.Cells(0).Value = Me.productGrid.CurrentRow.Cells(0).Value.ToString
        detail.ProdMoveGrid.CurrentRow.Cells(1).Value = Me.productGrid.CurrentRow.Cells(1).Value.ToString
        detail.ProdMoveGrid.CurrentRow.Cells(2).Value = "0"
        detail.ProdMoveGrid.CurrentRow.Cells(4).Value = Me.productGrid.CurrentRow.Cells(2).Value.ToString
        detail.ProdMoveGrid.CurrentRow.Cells(5).Value = getText("select A.idslc,slocD,slqty from dproduct A, sloc B where a.idslc = b.idslc and defsl like 'true' and idpdt='" + Me.productGrid.CurrentRow.Cells(0).Value.ToString + "'", 0)
        detail.ProdMoveGrid.CurrentRow.Cells(6).Value = getText("select A.idslc,slocD,slqty from dproduct A, sloc B where a.idslc = b.idslc and defsl like 'true' and idpdt='" + Me.productGrid.CurrentRow.Cells(0).Value.ToString + "'", 1)
        detail.ProdMoveGrid.CurrentRow.Cells(7).Value = getText("select A.idslc,slocD,slqty from dproduct A, sloc B where a.idslc = b.idslc and defsl like 'true' and idpdt='" + Me.productGrid.CurrentRow.Cells(0).Value.ToString + "'", 2)
        If indexType = 2 Or indexType = 3 Then
            detail.ProdMoveGrid.CurrentRow.Cells(3).Value = getText("select ppamt,psamt from dproduct A, sloc B,hproduct c where a.idslc = b.idslc  and a.idpdt = c.idpdt and defsl like 'true' and c.idpdt = '" + Me.productGrid.CurrentRow.Cells(0).Value.ToString + "'", 0)
        Else
            detail.ProdMoveGrid.CurrentRow.Cells(3).Value = getText("select ppamt,psamt from dproduct A, sloc B,hproduct c where a.idslc = b.idslc  and a.idpdt = c.idpdt and defsl like 'true' and c.idpdt = '" + Me.productGrid.CurrentRow.Cells(0).Value.ToString + "'", 1)

        End If
        detail.ProdMoveGrid.CurrentRow.Cells(8).Value = Me.productGrid.CurrentRow.Cells(3).Value.ToString
        detail.ProdMoveGrid.CurrentRow.Cells(9).Value = Me.productGrid.CurrentRow.Cells(4).Value
        Me.Close()
    End Sub
End Class