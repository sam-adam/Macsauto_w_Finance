Public Class _005_10_POS_Merchandise
    Private Sub _005_10_POS_Merchandise_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
        loadTable("select A.idpdt as 'PRODUCT #',pdtds AS 'PRODUCT DESCRIPTION',b.slqty AS 'QTY',uodsc AS 'UNIT',mpoin as 'POINT' from HProduct a, DProduct b, uom c, hmerchandise d where a.idpdt = d.idpdt AND a.idpdt = b.idpdt AND a.iduom = c.iduom AND defsl = 'True'", SProductGrid)
        Marking(SProductGrid)
    End Sub

    Private Sub SProductGrid_CellContentClick( sender As System.Object,  e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SProductGrid.CellContentClick
        Dim POS As _003_04_TrMerchandiseRedemption = CType(Application.OpenForms("_003_04_TrMerchandiseRedemption"), _003_04_TrMerchandiseRedemption)

        POS.MerchandiseGrid.Rows.Add()

        addSeqNumber(POS.MerchandiseGrid)

        POS.MerchandiseGrid(1, POS.MerchandiseGrid.Rows.Count - 1).Value = Me.SProductGrid.CurrentRow.Cells(0).Value.ToString
        POS.MerchandiseGrid(2, POS.MerchandiseGrid.Rows.Count - 1).Value = Me.SProductGrid.CurrentRow.Cells(1).Value.ToString
        POS.MerchandiseGrid(3, POS.MerchandiseGrid.Rows.Count - 1).Value = 1
        POS.MerchandiseGrid(4, POS.MerchandiseGrid.Rows.Count - 1).Value = Me.SProductGrid.CurrentRow.Cells(3).Value.ToString
        POS.MerchandiseGrid(5, POS.MerchandiseGrid.Rows.Count - 1).Value = Me.SProductGrid.CurrentRow.Cells(4).Value.ToString
        Me.Close()
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