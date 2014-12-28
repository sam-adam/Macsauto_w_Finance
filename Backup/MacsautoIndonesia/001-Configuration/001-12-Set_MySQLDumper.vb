Public Class _001_12_MySQLDumper
    Private Sub _001_12_MySQLDumper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySQLDumperTxt.Text = My.MySettings.Default.MySQLDumpPath
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        My.Settings.MySQLDumpPath = MySQLDumperTxt.Text

        MessageBox.Show(Me, "MySQL Dumper path saved", "Success")

        Close()
    End Sub

    Private Sub Folder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folder.Click
        Dim dialog As OpenFileDialog = New OpenFileDialog()

        dialog.Title = "Find MySQL executable"
        dialog.InitialDirectory = "C:\"
        dialog.Filter = "Executable files (*.exe)|*.exe"

        If dialog.ShowDialog() = DialogResult.OK Then
            MySQLDumperTxt.Text = dialog.FileName
        End If
    End Sub
End Class