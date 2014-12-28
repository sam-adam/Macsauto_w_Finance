Public Class _001_01_Define_UOM

    Private Sub UOMGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UOMGridView.CellEndEdit
        ' If UOMGridView.Rows.Count < 9 Then
        ' UOMGridView.CurrentRow.Cells(0).Value = "UOM00" & UOMGridView.Rows.Count - 1
        '    ElseIf UOMGridView.Rows.Count >= 9 And UOMGridView.Rows.Count < 100 Then
        'UOMGridView.CurrentRow.Cells(0).Value = "UOM0" & UOMGridView.Rows.Count - 1
        '   End If
        getUomNumbers()
    End Sub
    Private Sub saveUOM()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE UOM")
        For i = 0 To UOMGridView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO UOM VALUES('" + UOMGridView.Rows(i).Cells(0).Value.ToString + "','" + UOMGridView.Rows(i).Cells(1).Value.ToString + "')")
        Next i
    End Sub
    Private Sub getUomNumbers()
        Dim i As Integer
        For i = 0 To UOMGridView.Rows.Count - 2

            If UOMGridView.Rows.Count <= 9 Then
                UOMGridView.Rows(i).Cells(0).Value = "UOM0" & i + 1
            Else
                UOMGridView.Rows(i).Cells(0).Value = "UOM00" & i + 1
            End If
        Next i
    End Sub
    Private Sub LoaduomTable()
        reader = ExecQueryReader("SELECT * FROM uom")
        UOMGridView.Rows.Clear()
        While reader.Read()
            UOMGridView.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
        Marking(UOMGridView)
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save UOM Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveUOM()
            MsgBox("Unit of Measure successfully defined")
            LoaduomTable()
        End If
    End Sub

    Private Sub _001_01_Define_UOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoaduomTable()
    End Sub
End Class