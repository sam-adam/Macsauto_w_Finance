Public Class _001_15_Petty_Cash_Config
    Public flag
    Private Sub getNumbers(ByVal datagridview)
        Dim i As Integer
        For i = 0 To datagridview.Rows.Count - 2
            If datagridview.Rows.Count > 9 Then
                datagridview.Rows(i).Cells(0).Value = i + 1
            Else
                datagridview.Rows(i).Cells(0).Value = i + 1
            End If
        Next i
    End Sub
    Private Sub saveSource1()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE scash")

        ExecQueryNonReader("INSERT INTO scash VALUES('1','Petty Cash Account', " + Account.Text + ")")

    End Sub
    Private Sub saveSource()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE scash")
        For i = 0 To SourceTable.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO scash VALUES('" + SourceTable.Rows(i).Cells(0).Value.ToString + "','" + SourceTable.Rows(i).Cells(1).Value.ToString + "', " + SourceTable.Rows(i).Cells(2).Value.ToString() + ")")
        Next i
    End Sub
    Private Sub loadSourceTable()
        reader = ExecQueryReader("SELECT SOUID,SOIDC, A.GLNUM, GLDES FROM SCASH A, GLACCOUNTMS B WHERE A.GLNUM = B.GLNUM")
        SourceTable.Rows.Clear()
        While reader.Read()
            SourceTable.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3))
        End While

    End Sub
    Private Sub loadSourceTable1()
        reader = ExecQueryReader("SELECT SOUID,SOIDC, A.GLNUM, GLDES FROM SCASH A, GLACCOUNTMS B WHERE A.GLNUM = B.GLNUM")
        SourceTable.Rows.Clear()
        While reader.Read()
            Account.Text = reader(2).ToString
            Description.Text = reader(3).ToString
        End While

    End Sub
    Private Sub saveUsage()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE btrgl")
        For i = 0 To usageTable.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO btrgl VALUES('" + usageTable.Rows(i).Cells(0).Value.ToString + "','" + usageTable.Rows(i).Cells(1).Value.ToString + "','" + usageTable.Rows(i).Cells(2).Value.ToString() + "','" + usageTable.Rows(i).Cells(4).Value.ToString + "')")
        Next i
    End Sub
    Private Sub loadUsageTable()
        reader = ExecQueryReader("SELECT BTRID, BTRDC, A.GLNUM, GLDES,CTYPE FROM BTRGL A, GLACCOUNTMS B WHERE A.GLNUM = B.GLNUM")
        usageTable.Rows.Clear()
        While reader.Read()
            usageTable.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3), reader(4))
        End While

    End Sub

    Private Sub SourceTable_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SourceTable.CellEndEdit
        getNumbers(SourceTable)
    End Sub

    Private Sub SourceTable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SourceTable.KeyDown
        If e.KeyCode = Keys.F4 Then
            flag = 0
            _005_12_Petty_Cash_Account.ShowDialog()

        End If
    End Sub

    Private Sub usageTable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles usageTable.KeyDown
        If e.KeyCode = Keys.F4 Then
            flag = 1
            _005_12_Petty_Cash_Account.ShowDialog()
        End If
    End Sub
   
    Private Sub sourceBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sourceBtn.Click
        If MsgBox("Save Source account for petty cash?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveSource1()
            MsgBox("Source account for petty cash saved")
            LoadSourceTable()
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save usage account for petty cash?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveUsage()
            MsgBox("usage account for petty cash saved")
            loadUsageTable()
        End If
    End Sub

    Private Sub usageTable_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles usageTable.CellEndEdit
        getNumbers(usageTable)
    End Sub

    Private Sub _001_15_Petty_Cash_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSourceTable1()
        loadUsageTable()

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Account.KeyDown
        If e.KeyCode = Keys.F4 Then
            flag = 0
            _005_12_Petty_Cash_Account.ShowDialog()
        End If
    End Sub
End Class