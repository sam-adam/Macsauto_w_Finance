Public Class _005_10_POS_Merchandise
    Private Sub _005_10_POS_Merchandise_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
        loadTable("select A.idpdt as 'PRODUCT #',pdtds AS 'PRODUCT DESCRIPTION',b.slqty AS 'QTY',uodsc AS 'UNIT',mpoin as 'POINT' from HProduct a, DProduct b, uom c, hmerchandise d where a.idpdt = d.idpdt AND a.idpdt = b.idpdt AND a.iduom = c.iduom AND defsl = 'True' AND a.is_active = 1", SProductGrid)
        Marking(SProductGrid)
    End Sub

    Private Sub addSeqNumber(ByVal dg As DataGridView)
        Dim i As Integer
        If dg.Rows.Count > 0 Then
            For i = 0 To dg.Rows.Count - 1
                dg.Rows(i).Cells(0).Value = i + 1
            Next i
        End If
    End Sub
End Class