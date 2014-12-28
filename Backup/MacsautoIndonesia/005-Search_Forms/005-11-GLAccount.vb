Public Class _005_11_GLAccount
    Dim reader1
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

                TreeView1.Nodes(i).Nodes.Add(reader(0) & "-" & reader(1).ToString)
            End While
            length = reader(0).ToString.Length
        Next i

    End Sub
    Private Sub _005_11_GLAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGLAccount()
        loadGLDetail()
    End Sub

    Private Sub TreeView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDoubleClick
        If TreeView1.SelectedNode.Level.ToString = "0" Then
            MsgBox("You cannot select Account Type, please select GL Account")
        Else
            Dim gl As _009_02_Journal_Transaction = CType(Application.OpenForms("_009_02_Journal_Transaction"), _009_02_Journal_Transaction)

            gl.JournalGrid.CurrentRow.Cells(0).Value = TreeView1.SelectedNode.Text.ToString.Substring(0, length)
            gl.JournalGrid.CurrentRow.Cells(1).Value = TreeView1.SelectedNode.Text.ToString.Substring(length + 1, TreeView1.SelectedNode.Text.ToString.Length - (length + 1))
            Me.Close()
        End If
    End Sub
End Class