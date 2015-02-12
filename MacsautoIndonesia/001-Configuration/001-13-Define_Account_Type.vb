Imports MySql.Data.MySqlClient

Public Class _001_13_Define_Account_Type
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadAccountTypeTable()
        reader = ExecQueryReader("SELECT * FROM accounttype")
        ActGridView.Rows.Clear()

        While reader.Read()
            ActGridView.Rows.Add(reader("actid").ToString, reader("actds").ToString, False)
        End While

        Marking(ActGridView)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnSave.Click
        If MsgBox("Save Account Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In ActGridView.Rows
                If Not row.Cells(AccountTypeDescCol.Index).Value Is Nothing Then
                    If row.Cells(NewAccountTypeCol.Index).Value = True Then
                        Dim newId As Integer = 1
                        Dim newIdQuery As String = "SELECT actid FROM accounttype ORDER BY actid DESC LIMIT 1"
                        Dim newIdReader As MySqlDataReader = ExecQueryReader(newIdQuery)

                        While newIdReader.Read()
                            newId = (Integer.Parse(newIdReader("actid").ToString()) + 1)
                        End While

                        ExecQueryNonReader("INSERT INTO accounttype VALUES('" & newId & "', '" & row.Cells(AccountTypeDescCol.Index).Value.ToString().ToUpperInvariant() & "')")
                    Else
                        ExecQueryNonReader("UPDATE accounttype SET actds = '" & row.Cells(AccountTypeDescCol.Index).Value.ToString().ToUpperInvariant() & "' WHERE actid = '" & row.Cells(AccountTypeIdCol.Index).Value & "'")
                    End If
                End If
            Next

            MsgBox("Account Type successfully defined")
            LoadAccountTypeTable()
        End If
    End Sub

    Private Sub _001_13_Define_Account_Type_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadAccountTypeTable()
    End Sub

    Private Sub ActGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ActGridView.UserAddedRow
        ActGridView.Rows(ActGridView.NewRowIndex).Cells(NewAccountTypeCol.Index).Value = True
    End Sub
End Class