Public Class _001_03_02
    Public code, type As String
    Private Sub saveVehicleModel()
        Dim i As Integer
        For i = 0 To ModelView.Rows.Count - 2
            If ModelView(3, i).Value = True Then
                ExecQueryNonReader("INSERT INTO vehiclemodel VALUES('" + ModelView.Rows(i).Cells(0).Value.ToString + "','" + code + "','" + ModelView.Rows(i).Cells(1).Value.ToString + "','" + ModelView.Rows(i).Cells(2).Value.ToString().Substring(0, 3) + "')")
            ElseIf ModelView(4, i).Value = True Then
                Dim query As String = "UPDATE vehiclemodel " &
                                      "SET modsc = '" & ModelView.Rows(i).Cells(1).Value.ToString & "', " &
                                      "idsiz = '" & ModelView.Rows(i).Cells(2).Value.ToString().Substring(0, 3) & "' " &
                                      "WHERE idvmd = '" & ModelView.Rows(i).Cells(0).Value.ToString & "'"
                ExecQueryNonReader(query)
            End If
        Next i
    End Sub
    Private Function checkDataCompleteness()
        Dim i, y As Integer
        For i = 0 To ModelView.Rows.Count - 2
            If ModelView.Rows(i).Cells(2).Value = "" Or ModelView.Rows(i).Cells(1).Value = "" Then
                y = 1
                Exit For
            Else
                y = 2
            End If
        Next i
        Return y
    End Function

    Private Sub getNumbers()
        Dim i As Integer
        For i = 0 To ModelView.Rows.Count - 2
            If ModelView.Rows.Count <= 9 Then
                ModelView.Rows(i).Cells(0).Value = code & "M0" & i + 1
            Else
                ModelView.Rows(i).Cells(0).Value = code & "M" & i + 1
            End If
        Next i
    End Sub

    Private Sub Savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Savebtn.Click

        If checkDataCompleteness() = 1 Then
            MsgBox("Please Complete the vehicle data")
        Else
            If MsgBox("Save Vehicle model Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                saveVehicleModel()
                MsgBox("Vehicle model successfully defined")
                Me.Close()
            End If
        End If
    End Sub
    Private Sub loadModelTable()
        ModelView.Rows.Clear()
        reader = ExecQueryReader("select idvmd,idbrn,modsc,a.idsiz, b.sizdc from vehicleModel a, vehicleSize b where a.idsiz = b.idsiz and idbrn = '" + code + "'")
        While reader.Read()
            ModelView.Rows.Add(reader(0).ToString, reader(2).ToString, reader(3).ToString & " - " & reader(4).ToString, False, False)
        End While
        Marking(ModelView)
    End Sub
    Private Sub ModelView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ModelView.CellEndEdit
        getNumbers()

        ModelView(4, e.RowIndex).Value = True
    End Sub

    Private Sub _001_03_02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadModelTable()
    End Sub

    Private Sub ModelView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ModelView.KeyDown
        If e.KeyCode = Keys.F4 Then
            _005_02_Vehicle_Size.ShowDialog()
        End If
    End Sub

    Private Sub ModelView_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles ModelView.RowsAdded
        ModelView(3, ModelView.NewRowIndex).Value = True
        ModelView(4, ModelView.NewRowIndex).Value = True
    End Sub

    Private Sub ModelView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ModelView.CellValueChanged
        If e.ColumnIndex = VehicleSizeCol.Index AndAlso e.RowIndex <> -1 AndAlso ModelView.Rows.Count > 0 AndAlso ModelView.Columns.Count > 0 Then
            ModelView(4, e.RowIndex).Value = True
        End If
    End Sub
End Class