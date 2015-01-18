Imports MySql.Data.MySqlClient

Public Class _001_05_Define_Product_type
    Private Sub LoadProductTypeTable()
        reader = ExecQueryReader("SELECT * FROM productType")
        PTypeGridView.Rows.Clear()
        While reader.Read()
            PTypeGridView.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), False)
        End While
        Marking(PTypeGridView)
    End Sub
    Private Sub _001_05_Define_Product_type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadProductTypeTable()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Product Type Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In PTypeGridView.Rows
                If Not row.Cells(1).Value Is Nothing Then
                    If row.Cells(NewProductTypeCol.Index).Value = True Then
                        Dim newId As String = "PT01"
                        Dim newIdQuery As String = "SELECT idptp FROM producttype ORDER BY idptp DESC LIMIT 1"
                        Dim newIdReader As MySqlDataReader = ExecQueryReader(newIdQuery)

                        While newIdReader.Read()
                            newId = String.Format("PT{0:00}", Integer.Parse(newIdReader(0).ToString().Replace("PT", "")) + 1)
                        End While

                        ExecQueryNonReader("INSERT INTO producttype VALUES('" & newId & "','" + row.Cells(1).Value.ToString + "', " & If(row.Cells(2).Value = True, 1, 0) & ", 0)")
                    Else
                        ExecQueryNonReader("UPDATE producttype SET ptpdc = '" & row.Cells(1).Value.ToString() & "', ismrch = " & If(row.Cells(2).Value = True, 1, 0) & " WHERE idptp = '" & row.Cells(0).Value.ToString() & "'")
                    End If
                End If
            Next

            MsgBox("Product Type successfully defined")
            LoadProductTypeTable()
        End If
    End Sub

    Private Sub PTypeGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles PTypeGridView.UserAddedRow
        PTypeGridView.Rows(PTypeGridView.NewRowIndex - 1).Cells(NewProductTypeCol.Index).Value = True
    End Sub
End Class