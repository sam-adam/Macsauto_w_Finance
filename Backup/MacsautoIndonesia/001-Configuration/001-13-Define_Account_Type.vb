Public Class _001_13_Define_Account_Type
    Private Sub LoadactTable()

        reader = ExecQueryReader("SELECT * FROM AccountType")
        ActGridView.Rows.Clear()
        While reader.Read()
         
            ActGridView.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
        Marking(ActGridView)
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        ' MsgBox(ActGridView.CurrentRow.Cells(2).Value.ToString)
        If MsgBox("Save Account Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveact()
            MsgBox("Account Type successfully defined")
            LoadactTable()
        End If
    End Sub
   
    Private Sub saveact()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE AccountType")
        For i = 0 To ActGridView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO AccountType VALUES('" + ActGridView.Rows(i).Cells(0).Value.ToString + "','" + ActGridView.Rows(i).Cells(1).Value.ToString + "')")
        Next i
    End Sub
    Private Sub _001_13_Define_Account_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadactTable()

    End Sub


   
End Class