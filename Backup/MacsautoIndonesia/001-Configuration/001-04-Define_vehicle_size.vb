Public Class _001_04_Define_vehicle_size
    Private Sub loadSizeTable()
        SizeView.Rows.Clear()
        reader = ExecQueryReader("select * from vehicleSize")
        While reader.Read()
            SizeView.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
        Marking(SizeView)
    End Sub
    Private Sub getNumbers()
        Dim i As Integer
        For i = 0 To SizeView.Rows.Count - 2
            If SizeView.Rows.Count <= 9 Then
                SizeView.Rows(i).Cells(0).Value = "S0" & i + 1
            Else
                SizeView.Rows(i).Cells(0).Value = "S" & i + 1
            End If
        Next i
    End Sub
    Private Sub saveSizeModel()
        Dim i As Integer
        ExecQueryNonReader("Truncate table vehicleSize")
        For i = 0 To SizeView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO vehicleSize VALUES('" + SizeView.Rows(i).Cells(0).Value.ToString + "','" + SizeView.Rows(i).Cells(1).Value.ToString + "')")
        Next i
    End Sub
    Private Sub _001_04_Define_vehicle_size_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSizeTable()
    End Sub

    Private Sub SizeView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SizeView.CellEndEdit
        getNumbers()
    End Sub

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click
        If MsgBox("Save Vehicle Size Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveSizeModel()
            MsgBox("Vehicle Size successfully defined")
            loadSizeTable()
        End If
    End Sub
End Class