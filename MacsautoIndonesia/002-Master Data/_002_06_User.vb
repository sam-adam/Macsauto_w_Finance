Public Class _002_06_User
    Public Sub New()
        InitializeComponent()

        LoadEmployee()

        For Each pos As Position In [Enum].GetValues(GetType(Position))
            CboEmployeePosition.Items.Add(pos)
        Next
    End Sub

    Private Sub LoadEmployee()
        Dim query As String = "SELECT emp.id, emp.name, emp.post, user.username" & _
                              " FROM employee emp" & _
                              " JOIN user user ON emp.id = user.employee_id"
        Dim reader = ExecQueryReader(query)

        GridView.Rows.Clear()

        While reader.Read()
            GridView.Rows.Add(reader(0).ToString(), reader(1).ToString(), [Enum].Parse(GetType(Position), reader(2).ToString()), reader(3).ToString())
        End While
    End Sub

    Private Sub GridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellEnter
        LoadData()
    End Sub

    Private Sub LoadData()
        If GridView.Rows.Count > 0 Then
            Dim rowIdx As Integer = GridView.CurrentRow.Index

            EmployeeIdLabel.Text = GridView(0, rowIdx).Value.ToString()
            TxtEmployeeName.Text = GridView(1, rowIdx).Value.ToString()
            CboEmployeePosition.SelectedItem = [Enum].Parse(GetType(Position), GridView(2, rowIdx).Value.ToString())
            TxtUsername.Text = GridView(3, rowIdx).Value.ToString()
            TxtPassword.Text = ""
        Else
            EmployeeIdLabel.Text = ""
            TxtEmployeeName.Text = ""
            CboEmployeePosition.SelectedIndex = -1
            TxtUsername.Text = ""
            TxtPassword.Text = ""
        End If
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        Panel2.Enabled = True

        AddBtn.Visible = False
        Edit.Visible = False
    End Sub

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        EmployeeIdLabel.Text = "Auto Generated"
        TxtEmployeeName.Text = ""
        CboEmployeePosition.SelectedIndex = 0
        TxtUsername.Text = ""
        TxtPassword.Text = ""

        Panel2.Enabled = True

        AddBtn.Visible = False
        Edit.Visible = False
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Panel2.Enabled = False

        AddBtn.Visible = True
        Edit.Visible = True

        LoadData()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Dim query As String
        Dim reader

        If TxtEmployeeName.Text = "" Then
            ShowError("Name cannot be empty")
        ElseIf TxtUsername.Text = "" Then
            ShowError("Username cannot be empty")
        Else
            If EmployeeIdLabel.Text = "Auto Generated" Then
                If TxtPassword.Text = "" Then
                    ShowError("Password cannot be empty")
                Else
                    Dim companyId As String
                    Dim employee As String

                    query = "SELECT idcmp FROM company LIMIT 0, 1"
                    reader = ExecQueryReader(query)

                    While reader.Read
                        companyId = reader(0).ToString
                    End While

                    query = "INSERT INTO employee(name, post, idcmp)" & _
                            " VALUES('" & TxtEmployeeName.Text & "', '" & [Enum].Parse(GetType(Position), CboEmployeePosition.SelectedItem.ToString) & "', '" & companyId & "')"
                    ExecQueryNonReader(query)

                    query = "SELECT id FROM employee ORDER BY id DESC LIMIT 0, 1"
                    reader = ExecQueryReader(query)

                    While reader.Read
                        employee = reader(0).ToString
                    End While

                    query = "INSERT INTO user(username, password, employee_id)" & _
                            " VALUES('" & TxtUsername.Text & "', MD5('" & TxtPassword.Text & "'), '" & employee & "')"
                    ExecQueryNonReader(query)

                    MessageBox.Show(Me, "New employee created", "Success")

                    Panel2.Enabled = False

                    LoadEmployee()
                End If
            Else
                Dim canContinue As Boolean = True

                If TxtPassword.Text <> "" And MessageBox.Show(Me, "Change password?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.No Then
                    canContinue = False
                End If

                If canContinue Then
                    query = "UPDATE employee SET" & _
                            " name = '" & TxtEmployeeName.Text & "'" & _
                            ", post = '" & [Enum].Parse(GetType(Position), CboEmployeePosition.SelectedItem.ToString) & "'" & _
                            " WHERE id = '" & EmployeeIdLabel.Text & "'"
                    ExecQueryNonReader(query)

                    query = "UPDATE user SET" & _
                            " username = '" & TxtUsername.Text & "'"

                    If TxtPassword.Text <> "" Then
                        query &= " ,password = MD5('" & TxtPassword.Text & "')"
                    End If

                    query &= " WHERE employee_id = '" & EmployeeIdLabel.Text & "'"

                    ExecQueryNonReader(query)

                    MessageBox.Show(Me, "Employee updated", "Success")

                    Panel2.Enabled = False

                    LoadEmployee()
                End If
            End If
        End If
    End Sub

    Private Sub ShowError(ByVal content As String)
        MessageBox.Show(Me, content, "Error", MessageBoxButtons.OK)
    End Sub

    Private Sub _002_06_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class