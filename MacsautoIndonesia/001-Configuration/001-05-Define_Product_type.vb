Public Class _001_05_Define_Product_type
    Private Sub savePtype()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE productType")
        For i = 0 To PTypeGridView.Rows.Count - 2
            'MsgBox(PTypeGridView.Rows(i).Cells(2).Value.ToString)
            ExecQueryNonReader("INSERT INTO ProductType VALUES('" + PTypeGridView.Rows(i).Cells(0).Value.ToString + "','" + PTypeGridView.Rows(i).Cells(1).Value.ToString + "', " + PTypeGridView.Rows(i).Cells(2).Value.ToString() + "," + PTypeGridView.Rows(i).Cells(3).Value.ToString + ")")
        Next i
    End Sub
    Private Sub getProductTypeNumbers()
        Dim i As Integer
        For i = 0 To PTypeGridView.Rows.Count - 2

            If PTypeGridView.Rows.Count <= 9 Then
                PTypeGridView.Rows(i).Cells(0).Value = "PT0" & i + 1
            Else
                PTypeGridView.Rows(i).Cells(0).Value = "PT00" & i + 1
            End If
        Next i
    End Sub
    Private Sub LoadProductTypeTable()
        reader = ExecQueryReader("SELECT * FROM productType")
        PTypeGridView.Rows.Clear()
        While reader.Read()
            PTypeGridView.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3))
        End While
        Marking(PTypeGridView)
    End Sub
    Private Sub _001_05_Define_Product_type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadProductTypeTable()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Product Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            savePtype()
            MsgBox("Product Type successfully defined")
            LoadProductTypeTable()
        End If
    End Sub

    Private Sub PTypeGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PTypeGridView.CellEndEdit
        If e.ColumnIndex = 1 Then
            getProductTypeNumbers()
            PTypeGridView.CurrentRow.Cells(2).Value = False
            PTypeGridView.CurrentRow.Cells(3).Value = False
        End If
       
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(PTypeGridView.Rows(0).Cells(2).Value.ToString())

    End Sub
End Class