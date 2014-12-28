Public Class _005_04_Storage_Location__Movement_


    Private Sub SearchSloc_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSloc.DoubleClick
        Dim Move As _004_01_Product_Movement = CType(Application.OpenForms("_004_01_Product_Movement"), _004_01_Product_Movement)
        Move.ProdMoveGrid.CurrentRow.Cells(5).Value = Me.SearchSloc.CurrentRow.Cells(0).Value.ToString
        Move.ProdMoveGrid.CurrentRow.Cells(6).Value = Me.SearchSloc.CurrentRow.Cells(1).Value.ToString
        Move.ProdMoveGrid.CurrentRow.Cells(7).Value = Me.SearchSloc.CurrentRow.Cells(2).Value.ToString
        Me.Close()
    End Sub

   
End Class