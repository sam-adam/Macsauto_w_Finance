Public Class _009_04_Display_Journal_Tr
    Dim flag As Integer
    Public Sub getheaderData()
        reader = ExecQueryReader("select * from Jourhd where docid = '" + ID.Text + "'")
        While reader.read
            docdate.Text = reader(1).ToString
            pstdt.Text = reader(2).ToString
            refdoc.Text = reader(3).ToString
            remark.Text = reader(4).ToString
            If reader(5).ToString = "X" Then
                Reversal.Checked = True
                CANREA.Enabled = False
                CANREA.Text = reader(9).ToString

            Else
                Reversal.Checked = False
            End If
        End While
    End Sub
    Public Sub getDetail()
        reader = ExecQueryReader("select  b.glnum, gldes, pstky,psamt, notes from jourhd a, jourdt b, glaccountms c where a.docid = b.docid and b.glnum = c.glnum and b.docid = '" + ID.Text + "'")
        While reader.read
            If reader(2).ToString = "10" Then
                detJour.Rows.Add(reader(0).ToString, reader(1).ToString, reader(3).ToString, "", reader(4).ToString)
            Else
                detJour.Rows.Add(reader(0).ToString, reader(1).ToString, "", reader(3).ToString, reader(4).ToString)
            End If

        End While
        Marking(detJour)
    End Sub
    Public Sub updateStatus()

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.TextChanged
        getheaderData()
        getDetail()
        flag = 0
        If Reversal.Checked = True Then
            Button1.Text = "Cancel Reversal"
            flag = 1
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CANREA.Text = "" Then
            MsgBox("Please enter the cancellation reason for journal posting")
        Else
            If flag = 0 Then
                If MsgBox("Are you sure to reverse the document?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("UPDATE Jourhd SET DSTAT = 'X' , CANCL = '" + CANREA.Text + "', CGDAT = NOW() WHERE DOCID = '" + ID.Text + "'")
                    MsgBox("Journal Posting reversed")
                    Me.Close()
                End If
            Else
                If MsgBox("Are you sure to cancel reversal the document?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("UPDATE Jourhd SET DSTAT = ' ' , CANCL = '', CGDAT = NOW() WHERE DOCID = '" + ID.Text + "'")
                    MsgBox("Journal Posting reversal cancelled")
                    Me.Close()
                End If
            End If
          
        End If

    End Sub

    Private Sub _009_04_Display_Journal_Tr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class