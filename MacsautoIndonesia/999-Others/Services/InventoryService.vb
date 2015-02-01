Imports MySql.Data.MySqlClient

Namespace Services
    Public Class InventoryService
        Public Shared Sub UseItemInDefaultStorage(ByRef command As MySqlCommand, ByVal productId As String, ByVal quantity As Integer)
            command.CommandText = "SELECT slqty FROM dproduct WHERE idpdt = @productId"
            command.CreateParameter()

            command.Parameters.Clear()
            command.Parameters.AddWithValue("productId", productId)

            Dim result As Object = command.ExecuteScalar()

            If result Is Nothing Then
                Throw New DataException("Product with id '" & productId & "' does not exist")
            ElseIf Integer.Parse(result) < quantity Then
                Throw New DataException("Stock is insufficient")
            End If

            command.CommandText = "UPDATE dproduct SET slqty = (slqty - @usage) WHERE idpdt = @productId AND defsl = 'True'"
            command.Parameters.AddWithValue("usage", quantity)
            command.ExecuteNonQuery()

            command.CommandText =
                "UPDATE hproduct" & _
                " LEFT JOIN dproduct ON hproduct.idpdt = dproduct.idpdt" & _
                " SET pdqty = SUM(dproduct.slqty)" & _
                " WHERE hproduct.idpdt = @productId"
            command.ExecuteNonQuery()
        End Sub
    End Class
End Namespace