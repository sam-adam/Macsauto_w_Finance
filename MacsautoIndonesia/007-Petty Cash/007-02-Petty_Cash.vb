Public Class _007_02_Petty_Cash
    Dim reader
    Dim word() As String
    Dim pcact, btrans, Jcode, code As String
    Private Function getCurrentPeriod()
        reader = ExecQueryReader("SELECT ACYER,ACMON FROM PRACT WHERE ACTIV ='1'")
        reader.read()
        Return reader(0).ToString & "-" & reader(1).ToString
    End Function
    Private Function getCurrentAmt()
        reader = ExecQueryReader("SELECT (SUM(CASE WHEN pstky = '10' THEN psamt ELSE '0' END)- SUM(CASE WHEN pstky = '20' THEN psamt ELSE '0' END))'amount' FROM JOURHD A, JOURDT B,GLACCOUNTMS C  WHERE A.docid = B.docid AND C.glnum = B.glnum  and DSTAT <> 'X' AND B.glnum = '" + pcact + "' and pstdt LIKE '" + getCurrentPeriod() + "%' GROUP BY  B.glnum")
        While reader.read
            Return reader(0)
        End While
    End Function
    Private Sub autoPostPettyCash()
        Jcode = NewJournalCode()
        ExecQueryNonReader("INSERT INTO JOURHD(docid,DOCDT,PSTDT,RFDOC,RMARK,DSTAT,UNAME,CGDAT,DTNUM) VALUES('" + Jcode + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + TransDate.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" + code + "','" + PettyCashRea.Text + "','','','0000-00-00','PC')")
        If PettyCashType.SelectedItem.ToString = "CASH IN" Then
            ExecQueryNonReader("INSERT INTO JOURDT(docid,glnum,pstky,psamt,notes) VALUES('" + Jcode + "','" + pcact + "','10','" + pettyCashAmt.Text + "','')")
            ExecQueryNonReader("INSERT INTO JOURDT(docid,glnum,pstky,psamt,notes) VALUES('" + Jcode + "','" + btrans + "','20','" + pettyCashAmt.Text + "','')")
        Else
            ExecQueryNonReader("INSERT INTO JOURDT(docid,glnum,pstky,psamt,notes) VALUES('" + Jcode + "','" + btrans + "','10','" + pettyCashAmt.Text + "','')")
            ExecQueryNonReader("INSERT INTO JOURDT(docid,glnum,pstky,psamt,notes) VALUES('" + Jcode + "','" + pcact + "','20','" + pettyCashAmt.Text + "','')")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dispose()
    End Sub

    Public Function CreateNewCode()
        Dim lastCode As Integer
        Dim newcode, prefix As String
        prefix = "PC" & getText("SELECT * FROM company", 0)
        reader = ExecQueryReader("SELECT * FROM pettycash ORDER BY date DESC")
        reader.read()
        If reader.HasRows Then
            If Date.Today.Year.ToString.Substring(2, 2) = reader(0).ToString().Substring(6, 2) Then
                lastCode = reader(0).ToString().Substring(9, 4)

                newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & String.Format("{0:0000}", Integer.Parse(lastCode) + 1)
            Else
                newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
            End If
        Else
            newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
        End If

        Return newcode
    End Function
    Private Sub loadCboUsage()
        ComboBox1.Items.Clear()
        reader = ExecQueryReader("SELECT btrdc,glnum FROM btrgl WHERE ctype LIKE '" + PettyCashType.SelectedItem.ToString + "'")
        While reader.read
            ComboBox1.Items.Add(reader(0).ToString + "-" + reader(1).ToString)
        End While
    End Sub
    Private Sub loadCboSource()
        MsgBox("test")
        reader = ExecQueryReader("SELECT SOiDC FROM SCASH")
        While reader.read
            PettyCashType.Items.Add(reader(0).ToString)
        End While
    End Sub
    Private Sub loadAllHistory()
        pettycashGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM pettycash where date between '" + DateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' and '" + DateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' ORDER BY id DESC")
        While reader.read
            pettycashGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3).ToString, reader(4).ToString, reader(5))
        End While
        Marking(pettycashGrid)

        'PettyCashType.SelectedIndex = 1
    End Sub
    Private Sub loadHistory(ByVal flag As String)
        pettycashGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM pettycash where date between '" + DateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' and '" + DateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' and dflag = '" + flag + "' ORDER BY id DESC")
        While reader.read
            pettycashGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3).ToString, reader(4).ToString, reader(5))
        End While
        Marking(pettycashGrid)

        'PettyCashType.SelectedIndex = 1
    End Sub
    Private Sub getPettyCashAct()
        reader = ExecQueryReader("SELECT glnum FROM SCASH")
        While reader.read
            pcact = reader(0).ToString
        End While
    End Sub
    Private Sub _007_02_Petty_Cash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Today.AddDays(-30)
        getPettyCashAct()
        loadHistory("")
        Label11.Text = FormatCurrency(getCurrentAmt(), 2, TriState.True, TriState.True)

    End Sub
    Private Function checkActPeriod()
        reader = ExecQueryReader("SELECT ACMON,ACYER FROM PRACT WHERE ACTIV = '1'")
        reader.read()
        Return reader(1).ToString & "-" & reader(0).ToString
    End Function
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If pettyCashAmt.Text = "0" Then
            MsgBox("Please enter petty cash amount")
        ElseIf (TransDate.Value.Year.ToString & "-" & TransDate.Value.Month.ToString("00")) <> checkActPeriod() Then
            MsgBox("Accounting Period '" & TransDate.Value.Year.ToString & "-" & TransDate.Value.Month.ToString("00") & "'is not activated (Current Active Accounting Period : '" + checkActPeriod() + "')")
        ElseIf PettyCashRef.Text = "" Then
            MsgBox("Please enter petty cash reference")
        ElseIf PettyCashRea.Text = "" Then
            MsgBox("Please enter petty cash remark")
        Else
            If MsgBox("Add new petty cash?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                code = CreateNewCode()

                ExecQueryNonReader("INSERT INTO pettycash VALUES('" + code + "','" + PettyCashType.SelectedItem.ToString + "','" + pettyCashAmt.Text + "','" + PettyCashRef.Text + "','" + PettyCashRea.Text + "','" + TransDate.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" + word(0) + "',' ','')")
                autoPostPettyCash()

                MsgBox("New petty cash added")

                Print(code, GetPrintHeader())

                Close()
            End If
        End If
    End Sub


    Private Sub pettyCashAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pettyCashAmt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PettyCashType_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles PettyCashType.SelectedIndexChanged
        ' If PettyCashType.SelectedItem.ToString() = "CASH IN" Then
        loadCboUsage()
        'Else
        'Label4.Text = "Petty Cash #"
        'End If
    End Sub

    Private Sub ExportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportBtn.Click
        If pettycashGrid.Rows.Count <> 0 Then
            If MsgBox("Export Transaction List?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                'exportToExcel(TrlistGrid, "List")
                excelExport(pettycashGrid)
            End If
        Else
            MsgBox("No Data to be exported")
        End If
    End Sub

    
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            MsgBox("Start date cannot be bigger than end date")
        Else
            loadHistory(" ")
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            MsgBox("Start date cannot be bigger than end date")
        Else
            loadHistory(" ")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        word = ComboBox1.SelectedItem.ToString.Split("-")
        btrans = (word(1))
    End Sub

    Private Sub pettycashGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pettycashGrid.DoubleClick

        _007_02_01_Pettycash_Detail.ID.Text = pettycashGrid.CurrentRow.Cells(0).Value.ToString
        _007_02_01_Pettycash_Detail.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        loadAllHistory()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        loadHistory("X")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        loadHistory(" ")
    End Sub

   
End Class