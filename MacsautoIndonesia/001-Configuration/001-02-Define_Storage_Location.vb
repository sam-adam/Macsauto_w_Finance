Imports MySql.Data.MySqlClient

Public Class _001_02_Define_Storage_Location
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadslocTable()
        reader = ExecQueryReader("SELECT * FROM sloc WHERE idslc LIKE '" & String.Format("{0:000}", LoggedInEmployee.Company.Id) & "%'")
        SlocGridView.Rows.Clear()
        While reader.Read()
            SlocGridView.Rows.Add(reader("idslc").ToString, reader("slocd").ToString, False)
        End While
        Marking(SlocGridView)
    End Sub
    
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Storage Location Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In SlocGridView.Rows
                If Not row.Cells(StorageDescriptionCol.Index).Value Is Nothing Then
                    If row.Cells(NewStorageCol.Index).Value = True Then
                        Dim newId As String = String.Format("{0:000}{1:000}", LoggedInEmployee.Company.Id, 1)
                        Dim newIdQuery As String = "SELECT idslc FROM sloc WHERE idslc LIKE '" & String.Format("{0:000}", LoggedInEmployee.Company.Id) & "%' ORDER BY idslc DESC LIMIT 1"
                        Dim newIdReader As MySqlDataReader = ExecQueryReader(newIdQuery)

                        While newIdReader.Read()
                            newId = String.Format("{0:000}{1:000}", LoggedInEmployee.Company.Id, Integer.Parse(newIdReader("idslc").ToString().Substring(3)) + 1)
                        End While

                        ExecQueryNonReader("INSERT INTO sloc VALUES ('" & newId & "', '" & row.Cells(StorageDescriptionCol.Index).Value.ToString().ToUpperInvariant() & "')")
                    Else
                        ExecQueryNonReader("UPDATE sloc SET slocd = '" & row.Cells(StorageDescriptionCol.Index).Value.ToString().ToUpperInvariant() & "' WHERE idslc = '" & row.Cells(StorageIdCol.Index).Value & "'")
                    End If
                End If
            Next

            MsgBox("Storage Location successfully defined")
            Close()
        End If
    End Sub

    Private Sub _001_02_Define_Storage_Location_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadslocTable()
    End Sub

    Private Sub SlocGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles SlocGridView.UserAddedRow
        SlocGridView.Rows(SlocGridView.NewRowIndex - 1).Cells(NewStorageCol.Index).Value = True
    End Sub
End Class