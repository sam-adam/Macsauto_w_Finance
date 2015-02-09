Imports MySql.Data.MySqlClient

Public Class _001_08_Define_Vehicle_Color
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadColorTable()
        reader = ExecQueryReader("SELECT * FROM vehiclecolor")
        ColorGridView.Rows.Clear()
        While reader.Read()
            ColorGridView.Rows.Add(reader("idcol").ToString, reader("coldc").ToString, False)
        End While
        Marking(ColorGridView)
    End Sub

    Private Sub _001_08_Define_Vehicle_Color_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadColorTable()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MsgBox("Save Vehicle Color Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each row As DataGridViewRow In ColorGridView.Rows
                If Not row.Cells(ColorDescriptionCol.Index).Value Is Nothing Then
                    If row.Cells(NewColorCol.Index).Value = True Then
                        Dim newId As String = "L01"
                        Dim newIdQuery As String = "SELECT idcol FROM vehiclecolor ORDER BY idcol DESC LIMIT 1"
                        Dim newIdReader As MySqlDataReader = ExecQueryReader(newIdQuery)

                        While newIdReader.Read()
                            newId = String.Format("L{0:00}", Integer.Parse(newIdReader("idcol").ToString().Replace("L", "")) + 1)
                        End While

                        ExecQueryNonReader("INSERT INTO vehiclecolor VALUES('" & newId & "', '" & row.Cells(ColorDescriptionCol.Index).Value & "')")
                    Else
                        ExecQueryNonReader("UPDATE vehiclecolor SET coldc = '" & row.Cells(ColorDescriptionCol.Index).Value & "' WHERE idcol = '" & row.Cells(ColorIdCol.Index).Value & "'")
                    End If
                End If
            Next

            MsgBox("Vehicle Color successfully defined")
            LoadColorTable()
        End If
    End Sub

    Private Sub ColorGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ColorGridView.UserAddedRow
        ColorGridView.Rows(ColorGridView.NewRowIndex - 1).Cells(NewColorCol.Index).Value = True
    End Sub
End Class