Public Class _001_02_Define_Storage_Location
    Private Sub saveSLOC()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE SLOC")
        For i = 0 To SlocGridView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO sloc VALUES('" + SlocGridView.Rows(i).Cells(0).Value.ToString + "','" + SlocGridView.Rows(i).Cells(1).Value.ToString + "')")
        Next i
    End Sub
    Private Sub getSlocNumbers()
        Dim i As Integer
        Dim prefix As String
        prefix = getText("SELECT * FROM COMPANY", 0)
        For i = 0 To SlocGridView.Rows.Count - 2

            If i >= 9 Then
                SlocGridView.Rows(i).Cells(0).Value = prefix & "0" & i + 1
            Else
                SlocGridView.Rows(i).Cells(0).Value = prefix & "00" & i + 1
            End If
        Next i
    End Sub
    Private Sub LoadslocTable()
        reader = ExecQueryReader("SELECT * FROM SLOC")
        SlocGridView.Rows.Clear()
        While reader.Read()
            SlocGridView.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
        Marking(SlocGridView)
    End Sub
    Private Sub SlocGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SlocGridView.CellEndEdit
        getSlocNumbers()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Storage Location Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveSLOC()
            MsgBox("Storage Location successfully defined")
            LoadslocTable()
        End If
    End Sub

    Private Sub _001_02_Define_Storage_Location_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadslocTable()
    End Sub
End Class