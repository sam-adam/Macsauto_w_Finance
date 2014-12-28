Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class _006_02_LoginForm
    Public Event LoginSucceded As EventHandler
    Public Event LoginCanceled As EventHandler

    Private Sub OnLoginSucceded(ByVal e As EventArgs)
        RaiseEvent LoginSucceded(Me, e)
    End Sub

    Private Sub OnLoginCanceled(ByVal e As EventArgs)
        RaiseEvent LoginCanceled(Me, e)
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim query = "SELECT emp.id, emp.name, emp.post, comp.idcmp, comp.cmnam, comp.cmadd, comp.ccity" & _
                    " FROM user user" & _
                    " LEFT JOIN employee emp ON emp.id = user.employee_id" & _
                    " LEFT JOIN company comp ON emp.idcmp = comp.idcmp" & _
                    " WHERE user.username = '" & UsernameTextBox.Text & "'" & _
                    " AND user.password = '" & HashModule.GetMD5(PasswordTextBox.Text) & "'"
        Dim reader As MySqlDataReader = ExecQueryReader(query)

        reader.Read()

        If reader.HasRows Then
            LoggedInEmployee = New Employee(reader(0).ToString(), _
                                            reader(1).ToString(), _
                                            [Enum].Parse(GetType(Position), reader(2).ToString()), _
                                            New Company(reader(3).ToString(), _
                                                        reader(4).ToString(), _
                                                        reader(5).ToString(), _
                                                        reader(6).ToString()))
            OnLoginSucceded(Nothing)
        Else
            MsgBox("Login failed")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        OnLoginCanceled(Nothing)
    End Sub
End Class

Public Class Employee
    Public Sub New(ByVal id As String, ByVal name As String, ByVal position As Position, ByVal company As Company)
        Me.Id = id
        Me.Name = name
        Me.Position = position
        Me.Company = company
    End Sub

    Property Id() As String
    Property Name() As String
    Property Position() As Position
    Property Company() As Company
End Class

Public Class Company
    Public Sub New(ByVal id As String, ByVal name As String, ByVal address As String, ByVal city As String)
        Me.Id = id
        Me.Name = name
        Me.Address = address
        Me.City = city
    End Sub

    Property Id() As String
    Property Name() As String
    Property Address() As String
    Property City() As String
End Class

Public Enum Position
    Staff
    Manager
End Enum

Public Class DummyEmployee
    Inherits Employee

    Public Sub New()
        MyBase.New("001", "Test", Position.Manager, New Company("001", "Test Company", "Jalan jalan", "Jakarta"))
    End Sub
End Class