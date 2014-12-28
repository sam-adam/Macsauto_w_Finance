Public Class _001_06_Define_Service_Type
    Private Sub saveStype()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE serviceType")
        For i = 0 To STypeGridView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO serviceType VALUES('" + STypeGridView.Rows(i).Cells(0).Value.ToString + "','" + STypeGridView.Rows(i).Cells(1).Value.ToString + "')")
        Next i
    End Sub
    Private Sub getServiceTypeNumbers()
        Dim i As Integer
        For i = 0 To STypeGridView.Rows.Count - 2

            If STypeGridView.Rows.Count <= 9 Then
                STypeGridView.Rows(i).Cells(0).Value = "ST0" & i + 1
            Else
                STypeGridView.Rows(i).Cells(0).Value = "ST00" & i + 1
            End If
        Next i
    End Sub
    Private Sub LoadServiceTypeTable()
        reader = ExecQueryReader("SELECT * FROM serviceType")
        STypeGridView.Rows.Clear()
        While reader.Read()
            STypeGridView.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
        Marking(STypeGridView)
    End Sub
    Private Sub _001_06_Define_Service_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadServiceTypeTable()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Service Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveStype()
            MsgBox("Service Type successfully defined")
            LoadServiceTypeTable()
        End If
    End Sub

    Private Sub STypeGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles STypeGridView.CellEndEdit
        getServiceTypeNumbers()
    End Sub
End Class