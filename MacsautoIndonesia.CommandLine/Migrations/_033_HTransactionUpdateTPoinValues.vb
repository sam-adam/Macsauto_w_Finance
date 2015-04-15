Imports FluentMigrator
Imports MySql.Data.MySqlClient

Namespace Migrations
    <Migration(201504152316)>
    Public Class _033_HTransactionUpdateTPoinValues
        Inherits Migration

        Public Overrides Sub Up()
            Dim connection As MySqlConnection = New MySqlConnection(ConnectionString)
            Dim command As MySqlCommand = New MySqlCommand()

            connection.Open()

            command.Connection = connection

            command.CommandText = "UPDATE htransaction JOIN pointtrans ON htransaction.idcus = pointtrans.idcus AND DATE(htransaction.trdat) = DATE(pointtrans.ptdat) AND pointtrans.trtype = 'ADD' SET htransaction.tpoin = pointtrans.trpon;"
            command.ExecuteNonQuery()

            connection.Close()
        End Sub

        Public Overrides Sub Down()
            ' Nothing to do..
        End Sub
    End Class
End Namespace
