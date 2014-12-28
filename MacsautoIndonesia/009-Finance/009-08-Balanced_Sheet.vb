Public Class _009_08_Balanced_Sheet
    Dim nor As Integer
    Private Sub getPNL()
        Dim result As String

        reader = ExecQueryReader("SELECT (SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END))'AMOUNT' FROM JOURHD A, JOURDT B,GLACCOUNTMS C, ACCOUNTTYPE D  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM AND C.ACTID = D.ACTID and isPnl = 'X' and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' AND DTNUM <>'CL'")
        While reader.READ
            If reader(0) < 0 Then
                result = "LOSS AS OF PERIOD " + ComboBox1.SelectedItem.ToString
            Else
                result = "PROFIT AS OF PERIOD " + ComboBox1.SelectedItem.ToString
            End If
            BSGrid.Rows.Add("", "", "", "", "")
            BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.AliceBlue
            BSGrid.Rows.Add(result, "", "", "", "")
            BSGrid.Rows.Add("", "", "", "TOTAL", reader(0))
            BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow

        End While
    End Sub
    
    Public Sub getData1()
        Dim Actyp, flag, query As String
        Dim total As Double
        Dim i As Integer
        If zero.Checked = True Then
            query = "SELECT b.GLNUM,D.ACTDS,GLDES,(SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END))'AMOUNT' FROM JOURHD A, JOURDT B,GLACCOUNTMS C, ACCOUNTTYPE D  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM AND C.ACTID = D.ACTID and isPnl = ' ' and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' AND DTNUM <>'CL' GROUP BY  B.GLNUM"
        Else
            query = "SELECT b.GLNUM,D.ACTDS,GLDES,(SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END))'AMOUNT' FROM JOURHD A, JOURDT B,GLACCOUNTMS C, ACCOUNTTYPE D  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM AND C.ACTID = D.ACTID and isPnl = ' ' and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' AND DTNUM<>'CL' GROUP BY  B.GLNUM HAVING (SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END))<>0"
        End If
        i = 0
        total = 0
        reader = ExecQueryReader(query)
        BSGrid.Rows.Clear()
        While reader.read
            Actyp = reader(1).ToString
            If i > 0 Then
                If flag = Actyp Then

                    BSGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                    total = total + reader(3)

                Else
                    BSGrid.Rows.Add("", "", "", "TOTAL", total)
                    BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow
                    total = 0
                    BSGrid.Rows.Add(Actyp)
                    BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.AliceBlue
                    total = total + reader(3)
                    BSGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                    flag = Actyp
                End If

            Else

                BSGrid.Rows.Add(Actyp)
                BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.AliceBlue
                BSGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                total = total + reader(3)
                flag = Actyp
            End If
            i = i + 1
        End While
        BSGrid.Rows.Add("", "", "", "TOTAL", total)
        BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow
    End Sub
    Public Sub getData()
        Dim Actyp, flag As String
        Dim total As Double
        Dim i As Integer
        i = 0
        total = 0
        reader = ExecQueryReader("SELECT b.GLNUM,D.ACTDS,GLDES,(SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END))'AMOUNT' FROM JOURHD A, JOURDT B,GLACCOUNTMS C, ACCOUNTTYPE D  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM AND C.ACTID = D.ACTID and c.actid = '1' and isPnl = '' and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' GROUP BY  B.GLNUM")

        While reader.read
            Actyp = reader(1).ToString
            If i > 0 Then
                If flag = Actyp Then

                    BSGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                    total = total + reader(3)

                Else
                    BSGrid.Rows.Add("", "", "", "", "", "", "", "TOTAL", total)
                    ' BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow
                    total = 0
                    BSGrid.Rows.Add(Actyp)
                    'BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.AliceBlue
                    total = total + reader(3)
                    BSGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                    flag = Actyp
                End If

            Else
                BSGrid.Rows.Add(Actyp)
                'BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.AliceBlue
                BSGrid.Rows.Add("", reader(0).ToString, reader(2).ToString, reader(3))
                total = total + reader(3)
                flag = Actyp
            End If

            i = i + 1
        End While
        BSGrid.Rows.Add("", "", "", "TOTAL", total)
        '   BSGrid.Rows(BSGrid.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow
    End Sub
    Public Sub getLEData()
        Dim Actyp, flag As String
        Dim total As Double
        Dim i, j As Integer
        reader = ExecQueryReader("SELECT b.GLNUM,D.ACTDS,GLDES,(SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)- SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END))'AMOUNT' FROM JOURHD A, JOURDT B,GLACCOUNTMS C, ACCOUNTTYPE D  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM AND C.ACTID = D.ACTID and c.actid <> '1' and isPnl = '' and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' GROUP BY  B.GLNUM")
        i = 0
        j = 0
        total = 0
        While reader.read
            Actyp = reader(1).ToString
            If j = 0 Then
                MsgBox("1")
                BSGrid.Rows(i).Cells(6).Value = Actyp
                i = i + 1
                BSGrid.Rows(i).Cells(7).Value = reader(0).ToString
                BSGrid.Rows(i).Cells(8).Value = reader(2).ToString
                BSGrid.Rows(i).Cells(9).Value = reader(3)
                total = total + reader(3)
                i = i + 1
                j = j + 1
                flag = Actyp
            Else
                MsgBox("2")
                If flag <> Actyp Then
                    If nor < i Then
                        MsgBox("3")
                        BSGrid.Rows.Add("", "", "", "", "", "", "", "", "", "", total)
                        total = 0
                        BSGrid.Rows.Add("", "", "", "", "", "", Actyp)
                        BSGrid.Rows.Add("", "", "", "", "", "", "", reader(0).ToString, reader(2).ToString, reader(3))
                        total = total + reader(3)
                    Else
                        MsgBox("4")

                        BSGrid.Rows(i).Cells(10).Value = total
                        total = 0
                        i = i + 1
                        If nor < i Then
                            MsgBox("5")
                            BSGrid.Rows(i).Cells(6).Value = Actyp
                            i = i + 1
                            If nor < i Then
                                MsgBox("6")
                                BSGrid.Rows(i).Cells(7).Value = reader(0).ToString
                                BSGrid.Rows(i).Cells(8).Value = reader(2).ToString
                                BSGrid.Rows(i).Cells(9).Value = reader(3)
                                total = total + reader(3)
                            Else
                                MsgBox("7")
                                BSGrid.Rows.Add("", "", "", "", "", "", "", reader(0).ToString, reader(2).ToString, reader(3))
                            End If
                        Else
                            MsgBox("8")
                            BSGrid.Rows.Add("", "", "", "", "", "", Actyp)
                            BSGrid.Rows.Add("", "", "", "", "", "", "", reader(0).ToString, reader(2).ToString, reader(3))
                            total = total + reader(3)
                            BSGrid.Rows.Add("", "", "", "", "", "", "", "", "", "", total)

                        End If
                        flag = Actyp
                    End If
                Else
                    If nor < i Then
                        BSGrid.Rows.Add("", "", "", "", "", "", "", reader(0).ToString, reader(2).ToString, reader(3))
                    Else
                        BSGrid.Rows(i).Cells(7).Value = reader(0).ToString
                        BSGrid.Rows(i).Cells(8).Value = reader(2).ToString
                        BSGrid.Rows(i).Cells(9).Value = reader(3)
                    End If
                    total = total + reader(3)
                    i = i + 1
                    flag = Actyp
                End If
            End If
        End While
    End Sub
    Public Sub loadMonth()
        reader = ExecQueryReader("SELECT ACYER, ACMON FROM PRACT ORDER BY ACPID DESC")
        While reader.read()
            ComboBox1.Items.Add(reader(0).ToString & "-" & reader(1).ToString)
        End While

    End Sub
    Private Sub _009_08_Balanced_Sheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMonth()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select Accounting period")

        Else
            Try
                BSGrid.CellBorderStyle = DataGridViewCellBorderStyle.None
                BSGrid.Rows.Clear()
                getData1()
                ' nor = BSGrid.Rows.Count
                'getLEData()
                getPNL()
                'CountTotal()
            Catch ex As Exception

            End Try
           


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If BSGrid.Rows.Count <> 0 Then
            If MsgBox("Export General Ledger?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                excelExport(BSGrid)
            End If
        Else
            MsgBox("No Data to be exported")
        End If
    End Sub
End Class