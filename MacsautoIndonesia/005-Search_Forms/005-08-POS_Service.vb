Public Class _005_08_POS_Service

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles servSearchGrid.DoubleClick
        Dim POS As _003_01_02_TransactionDetail_Old = CType(Application.OpenForms("_003_01_02_TransactionDetail_Old"), _003_01_02_TransactionDetail_Old)


        POS.ServiceGrid.CurrentRow.Cells(1).Value = Me.servSearchGrid.CurrentRow.Cells(0).Value.ToString
        POS.ServiceGrid.CurrentRow.Cells(2).Value = Me.servSearchGrid.CurrentRow.Cells(1).Value.ToString
        POS.ServiceGrid.CurrentRow.Cells(3).Value = "1"
        POS.ServiceGrid.CurrentRow.Cells(4).Value = "UNIT"
        'MsgBox(Me.servSearchGrid.CurrentRow.Cells(3).Value.ToString.Length)
        If Me.servSearchGrid.CurrentRow.Cells(3).Value.ToString.Length = 0 Then
            POS.ServiceGrid.CurrentRow.Cells(5).Value = Me.servSearchGrid.CurrentRow.Cells(2).Value.ToString
        Else
            If Me.servSearchGrid.CurrentRow.Cells(4).Value = "0" Then
                'percentage discount
                POS.ServiceGrid.CurrentRow.Cells(5).Value = Integer.Parse(Me.servSearchGrid.CurrentRow.Cells(2).Value.ToString) - ((Integer.Parse(Me.servSearchGrid.CurrentRow.Cells(5).Value.ToString) / 100) * Integer.Parse(Me.servSearchGrid.CurrentRow.Cells(2).Value.ToString))
            Else
                'amount discount
                POS.ServiceGrid.CurrentRow.Cells(5).Value = Integer.Parse(Me.servSearchGrid.CurrentRow.Cells(2).Value.ToString) - Integer.Parse(Me.servSearchGrid.CurrentRow.Cells(4).Value.ToString)
            End If

        End If
        POS.ServiceGrid.CurrentRow.Cells(6).Value = "0"
        If Me.servSearchGrid.CurrentRow.Cells(3).Value.ToString.Length = 0 Then
            POS.ServiceGrid.CurrentRow.Cells(7).Value = "-"
        Else
            POS.ServiceGrid.CurrentRow.Cells(7).Value = Me.servSearchGrid.CurrentRow.Cells(3).Value.ToString
        End If
        POS.ServiceGrid.CurrentRow.Cells(8).Value = False
        POS.ServiceGrid.CurrentRow.Cells(9).Value = ""

        POS.totalService.Text = POS.countSubtotal(POS.ServiceGrid)
        POS.GrandTotal.Text = POS.countGrandTotal()
        POS.DEBT.Text = POS.countGrandTotal()
        POS.remainAR = POS.countGrandTotal()
        Me.Close()
    End Sub

    Private Sub _005_08_POS_Service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Marking(servSearchGrid)
    End Sub
End Class