Imports MySql.Data.MySqlClient

Public Class _006_04_Authorization_Form
    Private ReadOnly _authorizationLevel As String

    Public Event AuthorizationSuccess As EventHandler(Of AuthorizationSuccessEventArgs)
    Public Event AuthorizationFailed As EventHandler

    Public Sub New(ByVal authorizationLevel As AuthorizationLevel)
        InitializeComponent()

        _authorizationLevel = authorizationLevel

        Select Case _authorizationLevel
            Case authorizationLevel.Admin
                AuthorizationLevelLabel.Text = "Admin"
            Case authorizationLevel.User
                AuthorizationLevelLabel.Text = "User"
        End Select
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        RaiseEvent AuthorizationFailed(Me, New EventArgs())

        Dispose()
    End Sub

    Private Sub AuthorizeBtn_Click(sender As Object, e As EventArgs) Handles AuthorizeBtn.Click
        Dim query As String = "SELECT employee.id AS employer_id" & _
            " , employee.name AS employer_name" & _
            " , employee.post AS employer_position" & _
            " , employee.name AS employer_name" & _
            " , user.id AS user_id" & _
            " FROM employee" & _
            " LEFT JOIN user ON employee.id = user.employee_id" & _
            " WHERE user.username = '" & UsernameTxt.Text & "'" & _
            " AND user.password = MD5('" & PasswordTxt.Text & "')" & _
            " AND employee.post = " & _authorizationLevel
        Dim reader As MySqlDataReader = ExecQueryReader(query)

        If reader.HasRows Then
            Dim authorizedUser As New Dictionary(Of String, String)

            While reader.Read()
                authorizedUser.Add("Id", reader("employer_id"))
                authorizedUser.Add("Name", reader("employer_name"))
                authorizedUser.Add("Position", reader("employer_position"))
            End While

            RaiseEvent AuthorizationSuccess(Me, New AuthorizationSuccessEventArgs(authorizedUser))
        Else
            RaiseEvent AuthorizationFailed(Me, New EventArgs())
        End If

        Dispose()
    End Sub
End Class

Public Enum AuthorizationLevel
    User = 0
    Admin = 1
End Enum

Public Class AuthorizationSuccessEventArgs
    Inherits EventArgs

    Private ReadOnly _authorizedUser As Dictionary(Of String, String)

    Public ReadOnly Property AuthorizedUser() As Dictionary(Of String, String)
        Get
            Return _authorizedUser
        End Get
    End Property


    Public Sub New(ByVal authorizedUser As Dictionary(Of String, String))
        _authorizedUser = authorizedUser
    End Sub
End Class