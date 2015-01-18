Imports MySql.Data.MySqlClient

Public Class _001_06_Define_Service_Type
    Private Sub LoadServiceTypeTable()
        reader = ExecQueryReader("SELECT * FROM serviceType")
        STypeGridView.Rows.Clear()
        While reader.Read()
            STypeGridView.Rows.Add(reader(0).ToString, reader(1).ToString, False)
        End While
        Marking(STypeGridView)
    End Sub
    Private Sub _001_06_Define_Service_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadServiceTypeTable()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Service Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In STypeGridView.Rows
                If Not row.Cells(1).Value Is Nothing Then
                    If row.Cells(NewServiceTypeCol.Index).Value = True Then
                        Dim newId As String = "ST01"
                        Dim newIdQuery As String = "SELECT idsvt FROM servicetype ORDER BY idsvt DESC LIMIT 1"
                        Dim newIdReader As MySqlDataReader = ExecQueryReader(newIdQuery)

                        While newIdReader.Read()
                            newId = String.Format("ST{0:00}", Integer.Parse(newIdReader(0).ToString().Replace("ST", "")) + 1)
                        End While

                        ExecQueryNonReader("INSERT INTO servicetype VALUES('" & newId & "','" + row.Cells(1).Value.ToString + "')")
                    Else
                        ExecQueryNonReader("UPDATE servicetype SET svtdc = '" & row.Cells(1).Value.ToString() & "' WHERE idsvt = '" & row.Cells(0).Value.ToString() & "'")
                    End If
                End If
            Next

            MsgBox("Service Type successfully defined")
            LoadServiceTypeTable()
        End If
    End Sub

    Private Sub STypeGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles STypeGridView.UserAddedRow
        STypeGridView.Rows(STypeGridView.NewRowIndex - 1).Cells(NewServiceTypeCol.Index).Value = True
    End Sub
End Class