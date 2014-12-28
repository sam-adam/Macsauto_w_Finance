Public Class _009_07_Profit_and_Lost
   
    Public Sub getData()
        Dim Actyp, flag As String
        Dim total As Double
        Dim i As Integer
        i = 0
        total = 0
        reader = ExecQueryReader("SELECT b.GLNUM,D.ACTDS,GLDES,(SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END))'AMOUNT' FROM JOURHD A, JOURDT B,GLACCOUNTMS C, ACCOUNTTYPE D  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM AND C.ACTID = D.ACTID and isPnl = 'X' and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' GROUP BY  B.GLNUM")
        PNLGrid.Rows.Clear()
        While reader.read
            Actyp = reader(1).ToString
            If i > 0 Then
                If flag = Actyp Then

                    PNLGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                    total = total + reader(3)

                Else
                    PNLGrid.Rows.Add("", "", "", "TOTAL", total)
                    PNLGrid.Rows(PNLGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow
                    total = 0
                    PNLGrid.Rows.Add(Actyp)
                    PNLGrid.Rows(PNLGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.AliceBlue
                    total = total + reader(3)
                    PNLGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                    flag = Actyp
                End If

            Else

                PNLGrid.Rows.Add(Actyp)
                PNLGrid.Rows(PNLGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.AliceBlue
                PNLGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                total = total + reader(3)
                flag = Actyp
            End If
            i = i + 1
        End While
        PNLGrid.Rows.Add("", "", "", "TOTAL", total)
        PNLGrid.Rows(PNLGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow
    End Sub

    Private Sub countProfit()
        Dim i As Integer
        Dim total As Long
        Dim remark As String
        total = 0

        For i = 0 To PNLGrid.Rows.Count - 1

            '            If total = 0 Then
            total = total + PNLGrid.Rows(i).Cells(4).Value
            'Else
            ' total = total - PNLGrid.Rows(i).Cells(4).Value
            'End If
        Next
        If total < 0 Then
            remark = "LOSS AS OF PERIOD " + ComboBox1.SelectedItem.ToString
        Else
            remark = "PROFIT AS OF PERIOD " + ComboBox1.SelectedItem.ToString

        End If
        PNLGrid.Rows.Add("", "", "", remark, total)
        PNLGrid.Rows(PNLGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Orange
    End Sub
    Public Sub loadMonth()
        reader = ExecQueryReader("SELECT ACYER, ACMON FROM PRACT ORDER BY ACPID DESC")
        While reader.read()
            ComboBox1.Items.Add(reader(0).ToString & "-" & reader(1).ToString)
        End While

    End Sub
    Private Sub _009_07_Profit_and_Lost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMonth()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select Accounting period")

        Else
            getData()
            countProfit()
            PNLGrid.CellBorderStyle = DataGridViewCellBorderStyle.None

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If PNLGrid.Rows.Count <> 0 Then
            If MsgBox("Export Profit & Loss Report?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                'exportToExcel(TrlistGrid, "List")
                excelExport(PNLGrid)
            End If
        Else
            MsgBox("No Data to be exported")
        End If
    End Sub
End Class