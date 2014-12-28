Public Class _001_08_Define_Vehicle_Color
    Private Sub saveColor()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE vehicleColor")
        For i = 0 To ColorGridView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO vehicleColor VALUES('" + ColorGridView.Rows(i).Cells(0).Value.ToString + "','" + ColorGridView.Rows(i).Cells(1).Value.ToString + "')")
        Next i
    End Sub
    Private Sub getColorNumbers()
        Dim i As Integer
        For i = 0 To ColorGridView.Rows.Count - 2
            ColorGridView.Rows(i).Cells(0).Value = String.Format("L{0:00}", i + 1)
        Next i
    End Sub
    Private Sub LoadColorTable()
        reader = ExecQueryReader("SELECT * FROM vehiclecOLOR")
        ColorGridView.Rows.Clear()
        While reader.Read()
            ColorGridView.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
        Marking(ColorGridView)
    End Sub
    Private Sub _001_08_Define_Vehicle_Color_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadColorTable()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Vehicle Color Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveColor()
            MsgBox("Vehicle Color successfully defined")
            LoadColorTable()
        End If
    End Sub

    Private Sub ColorGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ColorGridView.CellEndEdit
        getColorNumbers()
    End Sub
End Class