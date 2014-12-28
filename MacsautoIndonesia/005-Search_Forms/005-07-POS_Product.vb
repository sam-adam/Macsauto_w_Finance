Public Class _005_07_POS_Product

    Private Sub _005_07_POS_Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loadTable("select A.idpdt as 'PRODUCT #',pdtds AS 'PRODUCT DESCRIPTION',b.slqty AS 'QTY',uodsc AS 'UNIT',psamt as 'PRICE' from HProduct a, DProduct b, uom c where a.idpdt = b.idpdt AND a.iduom = c.iduom AND defsl = 'True'", SProductGrid)
        loadTable("SELECT B.idpdt as 'PRODUCT#', pdtds AS 'DESCRIPTION', slqty AS 'QUANTITY', uodsc AS 'UNIT', psamt AS 'PRICE' ,pmdcp AS 'PROMOTION',pdamt AS 'Disc. Amount', pdpct as 'Disc. %' FROM HProduct A join DProduct B ON A.idpdt = B.idpdt  join UOM C ON A.iduom = C.iduom and B.defsl = 'True' join ProductType F ON F.idptp = A.idptp and F.ismrch = '0' left join promoAssignment as D on A.idpdt = D.iditm and D.atype = 'P' and D.begda <= curdate() and D.endda >= curdate() and D.astat = 'True'left join promotion as E on D.idpmt = E.idpmt order by a.idpdt asc", SProductGrid)
        Me.SProductGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Marking(SProductGrid)
    End Sub

    Private Sub SProductGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SProductGrid.DoubleClick
        If SProductGrid.CurrentRow.Cells(2).Value.ToString = "0" Then
            MsgBox("No quantity available for this item")
        Else
            Dim POS As _003_02_TrDetail2 = CType(Application.OpenForms("_003_02_TrDetail2"), _003_02_TrDetail2)
            POS.ProductGrid.Rows.Add()
            POS.ProductGrid.CurrentCell = POS.ProductGrid.Item(1, POS.ProductGrid.Rows.Count - 1)
            POS.addSeqNumber(POS.ProductGrid)
            POS.ProductGrid.CurrentRow.Cells(1).Value = Me.SProductGrid.CurrentRow.Cells(0).Value.ToString
            POS.ProductGrid.CurrentRow.Cells(2).Value = Me.SProductGrid.CurrentRow.Cells(1).Value.ToString
            POS.ProductGrid.CurrentRow.Cells(3).Value = "1"
            POS.ProductGrid.CurrentRow.Cells(4).Value = Me.SProductGrid.CurrentRow.Cells(3).Value.ToString
            If Me.SProductGrid.CurrentRow.Cells(5).Value.ToString.Length = 0 Then
                POS.ProductGrid.CurrentRow.Cells(5).Value = Me.SProductGrid.CurrentRow.Cells(4).Value.ToString
            Else
                If Me.SProductGrid.CurrentRow.Cells(7).Value = "0" Then
                    POS.ProductGrid.CurrentRow.Cells(5).Value = Integer.Parse(Me.SProductGrid.CurrentRow.Cells(4).Value.ToString) - Integer.Parse(Me.SProductGrid.CurrentRow.Cells(6).Value.ToString)
                Else
                    POS.ProductGrid.CurrentRow.Cells(5).Value = Integer.Parse(Me.SProductGrid.CurrentRow.Cells(4).Value.ToString) - ((Integer.Parse(Me.SProductGrid.CurrentRow.Cells(7).Value.ToString) / 100) * Integer.Parse(Me.SProductGrid.CurrentRow.Cells(4).Value.ToString))
                End If
            End If
            POS.ProductGrid.CurrentRow.Cells(6).Value = "0"
            POS.ProductGrid.CurrentRow.Cells(7).Value = Me.SProductGrid.CurrentRow.Cells(2).Value.ToString
            POS.ProductGrid.CurrentRow.Cells(8).Value = Me.SProductGrid.CurrentRow.Cells(3).Value.ToString
            POS.totalService.Text = POS.countSubtotal(POS.ServiceGrid)
            POS.totalProduct.Text = POS.countSubtotal(POS.ProductGrid)
            POS.GrandTotal.Text = POS.countGrandTotal()
            POS.DEBT.Text = POS.countGrandTotal()
            POS.remainAR = POS.countGrandTotal()

            Me.Close()
        End If

    End Sub

End Class