Public Class _007_02_01_Pettycash_Detail
    Dim flag As Integer
    Private Sub getDetail()
        reader = ExecQueryReader("SELECT * FROM PETTYCASH WHERE ID LIKE '" + ID.Text + "'")
        While reader.READ
            TrType.Text = reader(1).ToString
            TrDt.Text = reader(5)
            TrAmt.Text = reader(2)
            TrRefDoc.Text = reader(3).ToString
            TrRem.Text = reader(4).ToString
            TrBustr.Text = reader(6).ToString
            If reader(7).ToString = "X" Then
                Trrever.Checked = True
            Else
                Trrever.Checked = False
            End If
            CancelRea.Text = reader(8).ToString
        End While
    End Sub
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CancelRea.Text = "" Then
            MsgBox("Please fill cancellation Reason")
        Else
            If flag = 0 Then
                If MsgBox("Are you sure to reverse the document?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("UPDATE pettycash SET DFLAG = 'X', CANRE = '" + CancelRea.Text + "' WHERE id = '" + ID.Text + "'")
                    ExecQueryNonReader("UPDATE JOURHD set cgdat = now(), cancl = '" + CancelRea.Text + "',dstat = 'X' WHERE RFDOC = '" + ID.Text + "' ")
                    MsgBox("Petty Cash transacstion Reversed")
                    Me.Close()
                End If
            Else
                If MsgBox("Are you sure to cancel reversal the document?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("UPDATE pettycash SET DFLAG = '', CANRE = '' WHERE id = '" + ID.Text + "'")
                    ExecQueryNonReader("UPDATE JOURHD set cgdat = now(), cancl = '',dstat = '' WHERE RFDOC = '" + ID.Text + "' ")

                    MsgBox("Petty Cash reversal cancelled")
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.TextChanged
        getDetail()
        If Trrever.Checked = True Then
            Button1.Text = "CANCEL REVERSAL"
        End If
        If Trrever.Checked = True Then
            flag = 1
        Else
            flag = 0
        End If
    End Sub

    
End Class