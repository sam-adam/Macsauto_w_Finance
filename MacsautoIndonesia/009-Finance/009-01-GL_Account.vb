Imports System.Text.RegularExpressions
Public Class _009_01_GL_Account
    Dim flag As Integer
    Dim comp As String


    Public Sub editMODE()
        BtnSave.Visible = True
        btnEdit.Visible = False
        btnDel.Visible = False
        btnCancel.Visible = True
        btnAdd.Visible = False
        GLNum.Enabled = True
        GLDesc.Enabled = True
        actTypeCbo.Enabled = True
        PLSelect.Enabled = True
        BSSelect.Enabled = True
        GLActGrid.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
    End Sub
    Public Sub viewMode()
        BtnSave.Visible = False
        btnEdit.Visible = True
        btnDel.Visible = True
        btnCancel.Visible = False
        btnAdd.Visible = True
        GLNum.Enabled = False
        GLDesc.Enabled = False
        actTypeCbo.Enabled = False
        PLSelect.Enabled = False
        BSSelect.Enabled = False
        GLNum.Clear()
        GLDesc.Clear()
        GLActGrid.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
    End Sub
    Public Function getReportType()
        If PLSelect.Checked = True Then
            Return "X"
        Else
            Return " "
        End If
    End Function
    Private Function setReportType()
        If GLActGrid.CurrentRow.Cells(3).Value = "X" Then
            PLSelect.Checked = True
        Else
            BSSelect.Checked = True
        End If
    End Function
    Private Function checkTransaction(ByVal query As String)
        reader = ExecQueryReader(query)
        reader.read()
        Return reader(0).ToString
    End Function
    Private Sub loadGLTable()
        GLActGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT glnum, gldes,a.actid, b.actds, ispnl, glsta FROM GLAccountMS a, AccountType b WHERE a.actid = b.actid")
        While reader.read
            Dim flag As String
            flag = reader(2).ToString & "-" & reader(3).ToString
            GLActGrid.Rows.Add(reader(0).ToString, reader(1).ToString, flag, reader(4).ToString, reader(5).ToString)
        End While
        Marking(GLActGrid)
    End Sub
    Private Sub loadGLTable1(ByVal status As String)
        GLActGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT glnum, gldes,a.actid, b.actds, ispnl, glsta FROM GLAccountMS a, AccountType b WHERE a.actid = b.actid and a.glsta like '" + status + "'")
        While reader.read
            Dim flag As String
            flag = reader(2).ToString & "-" & reader(3).ToString
            GLActGrid.Rows.Add(reader(0).ToString, reader(1).ToString, flag, reader(4).ToString, reader(5).ToString)
        End While
        Marking(GLActGrid)
    End Sub
    Private Sub saveGLAccount()

        ExecQueryNonReader("INSERT INTO GLAccountMS VALUES('" + Regex.Replace(Prefix.Text, "-", "") & GLNum.Text + "','" + GLDesc.Text + "','" + actTypeCbo.SelectedItem.ToString.Substring(0, 1) + "','" + getReportType() + "','Active')")
    End Sub
    Private Sub modifyGLAccount()
        ExecQueryNonReader("UPDATE GLAccountMS SET gldes = '" + GLDesc.Text + "',ispnl = '" + getReportType() + "' WHERE GLNUM = '" + Regex.Replace(Prefix.Text, "-", "") & GLNum.Text + "'")
    End Sub
    Private Sub removeGLAccount()
        ExecQueryNonReader("DELETE FROM GlAccountMS WHERE glnum ='" + Regex.Replace(Prefix.Text, "-", "") & GLNum.Text + "'")
    End Sub
    Private Sub activateGL()
        ExecQueryNonReader("UPDATE GLACCOUNTMS SET GLSTA = 'Active' WHERE GLNUM = '" + Regex.Replace(Prefix.Text, "-", "") & GLNum.Text + "'")
    End Sub
    Private Sub deactivateGL()
        ExecQueryNonReader("UPDATE GLACCOUNTMS SET GLSTA = 'Deactive' WHERE GLNUM = '" + Regex.Replace(Prefix.Text, "-", "") & GLNum.Text + "'")
    End Sub
    Private Sub LoadAccountType()
        reader = ExecQueryReader("SELECT * FROM accountType")
        While reader.read
            actTypeCbo.Items.Add(reader(0).ToString & "-" & reader(1).ToString())
        End While
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If flag = 1 Then
            If actTypeCbo.SelectedIndex = -1 And GLDesc.Text = "" Then
                MsgBox("Please Complete the GL Account data")
            ElseIf GLNum.Text = "" Or GLNum.Text.Length <> 4 Then
                MsgBox("GL Account Number should be entered with the format 0-00-000-0000")
            Else
                If MsgBox("Add new GL Account?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    Try
                        saveGLAccount()
                        MsgBox("GL Account Added")
                        viewMode()
                        loadGLTable()
                    Catch ex As Exception
                        MsgBox("GL Account with this number is already exist")
                    End Try
                End If

            End If
        Else
            If actTypeCbo.SelectedIndex = -1 And GLDesc.Text = "" And GLNum.Text = "" Then
                MsgBox("Please Complete the GL Account data")
            Else
                If MsgBox("Modify the GL Account?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    modifyGLAccount()
                    MsgBox("GL Accound Modified")
                    viewMode()
                    loadGLTable()
                End If
            End If
        End If
       
    End Sub

    Private Sub _009_01_GL_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAccountType()
        loadGLTable()
        comp = getText("SELECT idcmp FROM company", 0)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        flag = 1
        editMODE()
        GLNum.Clear()
        GLDesc.Clear()
        actTypeCbo.SelectedIndex = -1
        ' GLNum.Enabled = False
        'GLDesc.Enabled = False
        Prefix.Text = "0-00-000-"
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If checkTransaction("SELECT count(*) from jourdt where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from mtrac where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from btrgl where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from scash where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from hproduct where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from hservice where glnum like '" + GLNum.Text + "'") = 0 Then
            flag = 2
            editMODE()
            GLNum.Enabled = False
            actTypeCbo.Enabled = False
        ElseIf GLNum.Text = "" Then
            MsgBox("Please select GL Account to be edited")
        Else
            MsgBox("GL Account cannot be edited, because it has been used in transaction or configuration")


        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        viewMode()
        Prefix.Text = "0-00-000-"
    End Sub

    Private Sub GLActGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GLActGrid.CellClick
        GLNum.Text = GLActGrid.CurrentRow.Cells(0).Value.ToString.Substring(6, 4)
        GLDesc.Text = GLActGrid.CurrentRow.Cells(1).Value.ToString
        actTypeCbo.SelectedItem = GLActGrid.CurrentRow.Cells(2).Value.ToString
        setReportType()
    End Sub

    Private Sub btnActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActive.Click
        If GLNum.Text = "" Then
            MsgBox("Please Select GL Account that need to be activated")
        Else
            If MsgBox("Activate GL Account ?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                activateGL()
                MsgBox("GL Account Activated")
                loadGLTable()
            End If
        End If

    End Sub

    Private Sub btnDeac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeac.Click
        If GLNum.Text = "" Then
            MsgBox("Please Select GL Account that need to be deactivated")
        Else
            If MsgBox("Deactivate GL Account ?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                deactivateGL()
                MsgBox("GL Account Deactivated")
                loadGLTable()
            End If
        End If

    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If GLNum.Text = "" Then
            MsgBox("Please Select GL Account that need to be deactivated")
        Else

            If checkTransaction("SELECT count(*) from jourdt where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from mtrac where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from btrgl where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from scash where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from hproduct where glnum like '" + GLNum.Text + "'") = 0 And checkTransaction("SELECT count(*) from hservice where glnum like '" + GLNum.Text + "'") = 0 Then
                If MsgBox("Delete GL Account ?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    removeGLAccount()
                    MsgBox("GL Account Deleted")
                    loadGLTable()
                End If
            Else
                MsgBox("GL Account cannot be delete, because it has been used in transaction or configuration")
            End If

        End If
    End Sub

    Private Sub actTypeCbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actTypeCbo.SelectedIndexChanged
        If actTypeCbo.SelectedIndex <> -1 Then
            Prefix.Text = actTypeCbo.SelectedItem.ToString.Substring(0, 1) & "-" & "00" & "-" & comp

        End If
       
    End Sub


    Private Sub GLNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GLNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        loadGLTable()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        loadGLTable1("Active")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        loadGLTable1("Deactive")
    End Sub
End Class