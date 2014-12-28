Public Class _001_17_Define_Accounting_Period
    Private Function checkActPeriod()
        reader = ExecQueryReader("SELECT COUNT(*)from pract")
        reader.read()
        If reader(0).ToString = "0" Then
            Return "0"
        Else
            Return "1"
        End If
    End Function
    Public Function getLastCode()
        reader = ExecQueryReader("SELECT *  FROM pract order by acpid desc")
        reader.read()
        Return reader(0).ToString
    End Function
    Public Function CreateNewCode()

        reader = ExecQueryReader("SELECT *  FROM pract order by acpid desc")
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        '  MsgBox(reader(0).ToString.Substring(4, 2))
        If reader.HasRows Then
            lastCode = reader(0).ToString
            newcode = lastCode + 1
        Else
            newcode = "1"
        End If
        Return newcode
    End Function
    Private Sub getAccountingPeriod()
        reader = ExecQueryReader("SELECT * FROM PRACT WHERE ACTIV = '1'")
        reader.read()
        Month.Text = reader(1).ToString
        Year.Text = reader(2).ToString
    End Sub

    Private Sub _001_17_Define_Accounting_Period_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If checkActPeriod() <> 0 Then
            getAccountingPeriod()
            Month.Enabled = False
            Year.Enabled = False
        End If
    End Sub
    Private Sub transferActPrd(ByVal vmonth As String, ByVal vyear As String)
        fetchData
        Dim i As Integer
        Dim code As String
        code = NewJournalCode()
        ExecQueryNonReader("INSERT INTO JOURHD VALUES('" + code + "',NOW(),'" & vyear & "-" & vmonth & "-01','','TRANFER POSTING FROM PERIOD " & Year.Text & "-" & Month.Text & "','','TRANSFER','0000-00-00 00:00:00','AD','')")
        For i = 0 To DataFlag.Rows.Count - 1
            If DataFlag.Rows(i).Cells(2).Value < 0 Then
                ExecQueryNonReader("INSERT INTO JOURDT VALUES('" + code + "','" + DataFlag.Rows(i).Cells(0).Value.ToString + "','20','" + Math.Abs(DataFlag.Rows(i).Cells(2).Value).ToString + "','')")
            Else
                ExecQueryNonReader("INSERT INTO JOURDT VALUES('" + code + "','" + DataFlag.Rows(i).Cells(0).Value.ToString + "','10','" + DataFlag.Rows(i).Cells(2).Value.ToString + "','')")
            End If
        Next i
    End Sub
    Private Sub fetchData()
        reader = ExecQueryReader("SELECT b.GLNUM,GLDES,(SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)-SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END))'Amount' FROM JOURHD A, JOURDT B,GLACCOUNTMS C  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM  and DSTAT <> 'X' AND PSTDT LIKE '" + Year.Text + "-" + Month.Text + "%' GROUP BY  B.GLNUM having (SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)-SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)) <> 0 ")
        While reader.read
            DataFlag.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2))
        End While
    End Sub
  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim code As String
        Dim nmonth, nyear As String
        code = CreateNewCode()
        If checkActPeriod() = 0 Then
            If MsgBox("Enter Initial accounting period?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("INSERT INTO pract VALUES('" + code + "','" + Month.SelectedItem.ToString + "','" + Year.Text + "','1')")
                MsgBox("Accounting Period Defined")
            End If
        Else
            If MsgBox("Are you sure to close this accounting Period?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                If MsgBox("Current Account balance will be carry over to the next period (Check Trial Balance)", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("UPDATE pract SET activ = 0 WHERE acpid = '" + getLastCode() + "'")
                    If (Integer.Parse(Month.SelectedItem.ToString) + 1) > 12 Then
                        nmonth = "01"
                        nyear = (Integer.Parse(Year.Text) + 1).ToString
                    Else
                        nmonth = (Integer.Parse(Month.SelectedItem.ToString) + 1).ToString("00")
                        nyear = Year.Text
                    End If
                    transferActPrd(nmonth, nyear)
                    ExecQueryNonReader("INSERT INTO pract VALUES('" + code + "','" + nmonth + "','" + nyear + "','1')")
                    MsgBox("Accounting Period Closed")
                End If
                
            End If
        End If
        getAccountingPeriod()
        Me.Close()

    End Sub
End Class