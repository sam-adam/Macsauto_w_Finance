Imports MySql.Data.MySqlClient

Public Class _001_14_Acct_Doc_Type
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadactTable()
        reader = ExecQueryReader("SELECT * FROM actdoctype")
        ActGridView.Rows.Clear()

        While reader.Read()
            Dim newRowIndex As Integer = ActGridView.Rows.Add(reader("dtnum").ToString, reader("dtdes").ToString, False)

            ActGridView.Rows(newRowIndex).Cells(AccountDocTypeCol.Index).ReadOnly = True
        End While

        Marking(ActGridView)
    End Sub

    Private Sub _001_12_Acct_Doc_Type_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadactTable()
    End Sub
<<<<<<< HEAD
    Private Sub saveact()
        Dim i As Integer
        ExecQueryNonReader("TRUNCATE TABLE Actdoctype")
        For i = 0 To ActGridView.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO Actdoctype VALUES('" + ActGridView.Rows(i).Cells(0).Value.ToString + "','" + ActGridView.Rows(i).Cells(1).Value.ToString + "')")
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
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        ' MsgBox(ActGridView.CurrentRow.Cells(2).Value.ToString)
        If checkTable(0) <> 0 Or checkTable(1) <> 0 Then
            MsgBox("Please complete the accounting document type data")
        Else
            If MsgBox("Save Account Document Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                Try
                    saveact()
                    MsgBox("Account Document Type successfully defined")
                    LoadactTable()
                Catch ex As Exception
                    MsgBox("Accounting document type cannot be duplicate")
                End Try

            End If
=======

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnSave.Click
        If MsgBox("Save Account Document Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In ActGridView.Rows
                If Not row.Cells(AccountDocTypeDescCol.Index).Value Is Nothing Then
                    If row.Cells(NewAccountDocumentCol.Index).Value = True Then
                        Dim checkIdReader As MySqlDataReader = ExecQueryReader("SELECT dtnum FROM actdoctype WHERE dtnum = '" & row.Cells(AccountDocTypeCol.Index).Value.ToString().ToUpperInvariant() & "'")

                        If checkIdReader.HasRows Then
                            MsgBox("Account document with ID '" & row.Cells(AccountDocTypeCol.Index).Value & "' is already defined. Duplicate is ignored.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Warning")
                        Else
                            ExecQueryNonReader("INSERT INTO actdoctype VALUES('" & row.Cells(AccountDocTypeCol.Index).Value.ToString().ToUpperInvariant() & "', '" & row.Cells(AccountDocTypeDescCol.Index).Value.ToString().ToUpperInvariant() & "')")
                        End If
                    Else
                        ExecQueryNonReader("UPDATE actdoctype SET dtdes = '" & row.Cells(AccountDocTypeDescCol.Index).Value.ToString().ToUpperInvariant() & "' WHERE dtnum = '" & row.Cells(AccountDocTypeCol.Index).Value.ToString().ToUpperInvariant() & "'")
                    End If
                End If
            Next

            MsgBox("Account Document Type successfully defined")
            LoadactTable()
>>>>>>> origin/master
        End If
       
    End Sub

    Private Sub ActGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ActGridView.UserAddedRow
        ActGridView.Rows(ActGridView.NewRowIndex - 1).Cells(NewAccountDocumentCol.Index).Value = True
    End Sub
End Class