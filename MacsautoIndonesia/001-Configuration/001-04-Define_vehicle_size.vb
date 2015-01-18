Imports MySql.Data.MySqlClient

Public Class _001_04_Define_vehicle_size
    Private Sub loadSizeTable()
        SizeView.Rows.Clear()
        reader = ExecQueryReader("select * from vehicleSize")
        While reader.Read()
            SizeView.Rows.Add(reader(0).ToString, reader(1).ToString, False)
        End While
        Marking(SizeView)
    End Sub
    Private Sub _001_04_Define_vehicle_size_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSizeTable()
    End Sub

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        If MsgBox("Save Vehicle Size Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In SizeView.Rows
                If Not row.Cells(1).Value Is Nothing Then
                    If row.Cells(NewSizeCol.Index).Value = True Then
                        Dim newId As String = "S01"
                        Dim newIdQuery As String = "SELECT idsiz FROM vehiclesize ORDER BY idsiz DESC LIMIT 1"
                        Dim newIdReader As MySqlDataReader = ExecQueryReader(newIdQuery)

                        While newIdReader.Read()
                            newId = String.Format("S{0:00}", Integer.Parse(newIdReader(0).ToString().Replace("S", "")) + 1)
                        End While

                        ExecQueryNonReader("INSERT INTO vehiclesize VALUES('" & newId & "','" + row.Cells(1).Value.ToString + "')")
                    Else
                        ExecQueryNonReader("UPDATE vehiclesize SET sizdc = '" & row.Cells(1).Value.ToString() & "' WHERE idsiz = '" & row.Cells(0).Value.ToString() & "'")
                    End If
                End If
            Next

            MsgBox("Vehicle Size successfully defined")
            loadSizeTable()
        End If
    End Sub

    Private Sub SizeView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles SizeView.UserAddedRow
        SizeView.Rows(SizeView.NewRowIndex - 1).Cells(NewSizeCol.Index).Value = True
    End Sub
End Class