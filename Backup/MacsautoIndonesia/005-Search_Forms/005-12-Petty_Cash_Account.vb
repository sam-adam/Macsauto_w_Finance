Public Class _005_12_Petty_Cash_Account
    Dim length As Integer
    Private Sub loadGLAccount()
        reader = ExecQueryReader("SELECT * FROM AccountType")
        TreeView1.Nodes.Clear()
        While reader.read

            TreeView1.Nodes.Add(reader(0).ToString & "-" & reader(1).ToString.ToUpper)

        End While
    End Sub
    Private Sub loadGLDetail()

        Dim i As Integer

        For i = 0 To TreeView1.Nodes.Count - 1
            ' MsgBox(TreeView1.Nodes(i).Text.ToString)
            reader = ExecQueryReader("SELECT * FROM GLAccountMS where Actid like '" + TreeView1.Nodes(i).Text.ToString.Substring(0, 1) + "'")
            While reader.read
                length = reader(0).ToString.Length
                TreeView1.Nodes(i).Nodes.Add(reader(0) & "-" & reader(1).ToString)
            End While
        Next i

    End Sub
    Private Sub _005_12_Petty_Cash_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGLAccount()
        loadGLDetail()
    End Sub

    Private Sub TreeView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        If TreeView1.SelectedNode.Level.ToString = "0" Then
            MsgBox("You cannot select Account Type, please select GL Account")
        Else

            Dim gl As _001_15_Petty_Cash_Config = CType(Application.OpenForms("_001_15_Petty_Cash_Config"), _001_15_Petty_Cash_Config)

            If gl.flag = 0 Then
                '    gl.SourceTable.CurrentRow.Cells(2).Value = TreeView1.SelectedNode.Text.ToString.Substring(0, 3)
                '   gl.SourceTable.CurrentRow.Cells(3).Value = TreeView1.SelectedNode.Text.ToString.Substring(4, TreeView1.SelectedNode.Text.ToString.Length - 4)
                gl.Account.Text = TreeView1.SelectedNode.Text.ToString.Substring(0, length)
                gl.Description.Text = TreeView1.SelectedNode.Text.ToString.Substring(length + 1, TreeView1.SelectedNode.Text.ToString.Length - (length + 1))
            Else
                gl.usageTable.CurrentRow.Cells(2).Value = TreeView1.SelectedNode.Text.ToString.Substring(0, length)
                gl.usageTable.CurrentRow.Cells(3).Value = TreeView1.SelectedNode.Text.ToString.Substring(length + 1, TreeView1.SelectedNode.Text.ToString.Length - (length + 1))
            End If


            Me.Close()
        End If
    End Sub
End Class