Imports MacsautoIndonesia.Services

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
        Dim employeeDataTable As DataTable = New DataTable()
        Dim query As String = "SELECT employee.id," & _
                    "   employee.name," & _
                    "   employee.post," & _
                    "   company.idcmp," & _
                    "   company.cmnam," & _
                    "   company.cmadd," & _
                    "   company.ccity," & _
                    "   company.strta," & _
                    "   company.phon1," & _
                    "   company.phon2," & _
                    "   company.webst" & _
                    " FROM user" & _
                    " LEFT JOIN employee ON employee.id = user.employee_id" & _
                    " LEFT JOIN company ON employee.idcmp = company.idcmp" & _
                    " WHERE user.username = '" & UsernameTextBox.Text & "'" & _
                    " AND user.password = '" & HashModule.GetMD5(PasswordTextBox.Text) & "'"
        employeeDataTable.Load(ExecQueryReader(query))

        If employeeDataTable.Rows.Count > 0 Then
            Dim company As Company = CompanyService.GetCurrentCompany()

            LoggedInEmployee = New Employee(employeeDataTable.Rows(0)("id").ToString(), _
                                            employeeDataTable.Rows(0)("name").ToString(), _
                                            [Enum].Parse(GetType(Position), employeeDataTable.Rows(0)("post").ToString()), company)
            OnLoginSucceded(New EventArgs())
        Else
            MsgBox("Login failed")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        OnLoginCanceled(New EventArgs())
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
    Property Street() As String
    Property Phone1() As String
    Property Phone2() As String
    Property Website() As String
End Class

Public Enum Position
    Staff
    Manager
End Enum

Public Class DummyEmployee
    Inherits Employee

    Public Sub New()
        MyBase.New("001", "Test", Position.Manager, New Company("002", "Test Company", "Jalan jalan", "Jakarta"))
    End Sub
End Class