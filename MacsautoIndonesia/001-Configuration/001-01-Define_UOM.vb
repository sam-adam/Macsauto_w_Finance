Imports MySql.Data.MySqlClient

Public Class _001_01_Define_UOM
    Private Sub LoaduomTable()
        reader = ExecQueryReader("SELECT * FROM uom")
        UOMGridView.Rows.Clear()
        While reader.Read()
            UOMGridView.Rows.Add(reader(0).ToString, reader(1).ToString, False)
        End While
        Marking(UOMGridView)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save UOM Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In UOMGridView.Rows
                If Not row.Cells(1).Value Is Nothing Then
                    If row.Cells(NewUoMCol.Index).Value = True Then
                        Dim newId As String = "UOM001"
                        Dim newIdQuery As String = "SELECT iduom FROM uom ORDER BY iduom DESC LIMIT 1"
                        Dim newIdReader As MySqlDataReader = ExecQueryReader(newIdQuery)

                        While newIdReader.Read()
                            newId = String.Format("UOM{0:000}", Integer.Parse(newIdReader(0).ToString().Replace("UOM", "")) + 1)
                        End While

                        ExecQueryNonReader("INSERT INTO uom VALUES('" & newId & "','" + row.Cells(1).Value.ToString + "')")
                    Else
                        ExecQueryNonReader("UPDATE uom SET uodsc = '" & row.Cells(1).Value.ToString() & "' WHERE iduom = '" & row.Cells(0).Value.ToString() & "'")
                    End If
                End If
            Next

            MsgBox("Unit of Measure successfully defined")
            LoaduomTable()
        End If
    End Sub

    Private Sub _001_01_Define_UOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoaduomTable()
    End Sub

    Private Sub UOMGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles UOMGridView.UserAddedRow
        UOMGridView.Rows(UOMGridView.NewRowIndex - 1).Cells(NewUoMCol.Index).Value = True
    End Sub
End Class