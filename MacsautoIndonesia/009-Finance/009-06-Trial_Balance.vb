Public Class _009_06_Trial_Balance
    Public Sub getAllTB()
        Dim query As String
        If zero.Checked = True Then
            query = "SELECT b.GLNUM,GLDES,SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)-SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)AS 'CREDIT' FROM JOURHD A, JOURDT B,GLACCOUNTMS C  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM  and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' GROUP BY  B.GLNUM"
        Else
            query = "SELECT b.GLNUM,GLDES,SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END) AS'Amount' FROM JOURHD A, JOURDT B,GLACCOUNTMS C  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM  and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' GROUP BY  B.GLNUM HAVING (SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END) - SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)) <> 0"
        End If
        reader = ExecQueryReader(query)
        While reader.read
            If reader(2) < 0 Then
                TBReport.Rows.Add(reader(0).ToString, reader(1).ToString, Nothing, reader(2))
            Else
                TBReport.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), Nothing)
            End If
        End While
        Marking(TBReport)
    End Sub
    Public Sub sumTotal()
        Dim cr, db As Double
        Dim i As Integer
        cr = 0
        db = 0
        For i = 0 To TBReport.Rows.Count - 1
            cr = cr + TBReport.Rows(i).Cells(3).Value
            db = db + TBReport.Rows(i).Cells(2).Value
        Next i
        TBReport.Rows.Add("", "", db, cr)
        TBReport.Rows(TBReport.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow
    End Sub
  
    Private Sub _009_06_Trial_Balance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMonth()
    End Sub
    Public Sub loadMonth()
        reader = ExecQueryReader("SELECT ACYER, ACMON FROM PRACT ORDER BY ACPID DESC")
        While reader.read()
            ComboBox1.Items.Add(reader(0).ToString & "-" & reader(1).ToString)
        End While

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select Accounting period")

        Else
            TBReport.Rows.Clear()
            getAllTB()
            sumTotal()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TBReport.Rows.Count <> 0 Then
            If MsgBox("Export Trial Balanced?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                'exportToExcel(TrlistGrid, "List")
                excelExport(TBReport)
            End If
        Else
            MsgBox("No Data to be exported")
        End If
    End Sub
End Class