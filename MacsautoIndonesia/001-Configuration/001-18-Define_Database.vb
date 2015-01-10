Imports MySql.Data.MySqlClient

Public Class _001_18_Define_Database
    Public Sub New()
        InitializeComponent()

        If String.IsNullOrEmpty(My.Settings.Database) Then
            DbNameTxt.Text = "macsauto"
        Else
            DbNameTxt.Text = My.Settings.Database
        End If

        If String.IsNullOrEmpty(My.Settings.Username) Then
            DbUsernameTxt.Text = "root"
        Else
            DbUsernameTxt.Text = My.Settings.Username
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim connection As MySqlConnection = New MySqlConnection()
        Dim mysqlPath As String = "C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe"

        connection.ConnectionString = "Server=" & My.Settings.Host & ";Uid=" & DbUsernameTxt.Text & ";Pwd=" & DbPasswordTxt.Text & ";Database=" & DbNameTxt.Text & ";Convert Zero Datetime=True"

        Try
            CreateDatabase(mysqlPath, DbNameTxt.Text, DbUsernameTxt.Text, DbPasswordTxt.Text)
            ImportDatabase(mysqlPath, DbNameTxt.Text, DbUsernameTxt.Text, DbPasswordTxt.Text)

            connection.Open()

            My.Settings.Database = DbNameTxt.Text
            My.Settings.Username = DbUsernameTxt.Text
            My.Settings.Password = DbPasswordTxt.Text

            My.Settings.Save()

            MessageBox.Show(Me, "Settings saved", "Success", MessageBoxButtons.OK)

            Dispose()
        Catch ex As Exception
            MessageBox.Show(Me, "Failed to connect with this settings", "Connection failed", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub _001_18_Define_Database_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If String.IsNullOrEmpty(My.Settings.Password) AndAlso MessageBox.Show(Me, "This application will not start if the database configuration is incomplete! Quit anyway?", "Warning", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class