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
        
        If checkTable(0) <> 0 Or checkTable(1) <> 0 Then
            MsgBox("Please complete the accounting document type data")
        Else
            If MsgBox("Save Account Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                Try
                    saveact()
                    MsgBox("Account Type successfully defined")
                    LoadactTable()
                Catch ex As Exception
                    MsgBox("Account type data cannot be duplicated")
                End Try

            End If
        End If

        


    End Sub
   
    Private Sub saveact()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE AccountType")
        For i = 0 To ActGridView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO AccountType VALUES('" + ActGridView.Rows(i).Cells(0).Value.ToString + "','" + ActGridView.Rows(i).Cells(1).Value.ToString + "')")
        Next i
    End Sub
    Private Function checkTable(ByVal num As Integer)
        Dim i, j As Integer
        j = 0
        For i = 0 To ActGridView.Rows.Count - 2
            If ActGridView.Rows(i).Cells(num).Value = Nothing Then
                j = j + 1
            End If
        Next
        Return j
    End Function
    Private Sub _001_13_Define_Account_Type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadactTable()
    End Sub


   
End Class