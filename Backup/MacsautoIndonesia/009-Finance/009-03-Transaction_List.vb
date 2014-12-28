Public Class _009_03_Transaction_List
    Public Sub getTransactionData()
        Dim pstky As String
        reader = ExecQueryReader("select a.docid, dtdes, pstdt,rfdoc,rmark, b.glnum, gldes,pstky,psamt, notes from jourhd a, jourdt b, glaccountms c, actdoctype d where a.docid = b.docid and b.glnum = c.glnum and a.dtnum = d.dtnum and pstdt like '" + ComboBox1.SelectedItem.ToString + "%' order by docid desc")
        While reader.read
            If reader(7).ToString = "10" Then
                pstky = "Debit"
            Else
                pstky = "Credit"
            End If
            TransJour.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, pstky, reader(8).ToString, reader(9).ToString)
        End While
        Marking(TransJour)
    End Sub
    Public Sub getTransactionData1(ByVal con As String)
        Dim pstky As String
        reader = ExecQueryReader("select a.docid, dtdes, pstdt,rfdoc,rmark, b.glnum, gldes,pstky,psamt, notes from jourhd a, jourdt b, glaccountms c, actdoctype d where a.docid = b.docid and b.glnum = c.glnum and a.dtnum = d.dtnum and dstat = '" + con + "' and pstdt like '" + ComboBox1.SelectedItem.ToString + "%' order by docid desc")
        While reader.read
            If reader(7).ToString = "10" Then
                pstky = "Debit"
            Else
                pstky = "Credit"
            End If
            TransJour.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, pstky, reader(8), reader(9).ToString)
        End While
        Marking(TransJour)
    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select Accounting period")
        Else
            TransJour.Rows.Clear()
            If RadioButton2.Checked = True Then

                getTransactionData1("")
            ElseIf RadioButton1.Checked = True Then
                getTransactionData()
            ElseIf RadioButton3.Checked = True Then
                getTransactionData1("X")
            End If
        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TransJour.Rows.Count <> 0 Then
            If MsgBox("Export Transaction List?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                'exportToExcel(TrlistGrid, "List")
                excelExport(TransJour)
            End If
        Else
            MsgBox("No Data to be exported")
        End If
    End Sub

    Private Sub TransJour_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TransJour.CellDoubleClick
        _009_04_Display_Journal_Tr.Show()
        _009_04_Display_Journal_Tr.ID.Text = TransJour.CurrentRow.Cells(0).Value
        _009_04_Display_Journal_Tr.Type.Text = TransJour.CurrentRow.Cells(1).Value

    End Sub
    Public Sub loadMonth()
        reader = ExecQueryReader("SELECT ACYER, ACMON FROM PRACT ORDER BY ACPID DESC")
        While reader.read()
            ComboBox1.Items.Add(reader(0).ToString & "-" & reader(1).ToString)
        End While

    End Sub
    Private Sub _009_03_Transaction_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMonth()
    End Sub
End Class