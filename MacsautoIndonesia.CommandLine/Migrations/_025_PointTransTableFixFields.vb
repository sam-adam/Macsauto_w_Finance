Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator
Imports MySql.Data.MySqlClient

Namespace Migrations
    <Migration(201501311042)>
    Public Class _025_PointTransTableFixFields
        Inherits Migration

        Private ReadOnly _tableName As String = "pointtrans"

        Public Overrides Sub Up()
            Dim connection As MySqlConnection = New MySqlConnection(ConnectionString)
            Dim command As MySqlCommand = New MySqlCommand()
            Dim pointTransactionDataTable As DataTable = New DataTable()

            connection.Open()

            command.Connection = connection

            ' Delete all pointtransaction with 0 value
            command.CommandText = "DELETE FROM pointtrans WHERE TRPON = 0"
            command.ExecuteNonQuery()

            ' Find and summarize duplicate exact match
            command.CommandText = "SELECT *, SUM(TRPON) AS totalPoint FROM pointtrans GROUP BY IDPOR, IDCUS, PTDAT, TRPON, TRTYPE HAVING COUNT(IDPOR) > 1"
            pointTransactionDataTable.Rows.Clear()
            pointTransactionDataTable.Load(command.ExecuteReader())

            For Each pointTransaction As DataRow In pointTransactionDataTable.Rows
                command.CommandText = "DELETE FROM pointtrans WHERE IDPOR = @pointTransId AND IDCUS = @customerId AND PTDAT = @pointTransDate AND TRPON = @pointTransPoint AND TRTYPE = @pointTransType"
                command.CreateParameter()

                command.Parameters.AddWithValue("pointTransId", pointTransaction("IDPOR"))
                command.Parameters.AddWithValue("customerId", pointTransaction("IDCUS"))
                command.Parameters.AddWithValue("pointTransDate", pointTransaction("PTDAT"))
                command.Parameters.AddWithValue("pointTransPoint", pointTransaction("TRPON"))
                command.Parameters.AddWithValue("pointTransType", pointTransaction("TRTYPE"))

                command.ExecuteNonQuery()

                command.CommandText = "INSERT INTO pointtrans(IDPOR, IDCUS, PTDAT, TRPON, TRTYPE) VALUES(@pointTransId, @customerId, @pointTransDate, @accumulatedPoint, @pointTransType)"
                command.Parameters.AddWithValue("accumulatedPoint", pointTransaction("totalPoint"))

                command.ExecuteNonQuery()
            Next

            command.Parameters.Clear()

            command.CommandText = "SELECT * FROM pointtrans ORDER BY IDPOR ASC, PTDAT ASC"
            pointTransactionDataTable.Rows.Clear()
            pointTransactionDataTable.Load(command.ExecuteReader())

            Dim idx As Integer = 1

            ' Reorder the ids
            For Each pointTransaction As DataRow In pointTransactionDataTable.Rows
                command.CommandText = "UPDATE pointtrans SET IDPOR = @newPointTransId WHERE IDPOR = @oldPointTransId AND PTDAT = @pointTransDate AND IDCUS = @customerId AND TRTYPE = @pointTransType AND TRPON = @pointTransPoint"
                command.CreateParameter()

                command.Parameters.Clear()
                command.Parameters.AddWithValue("newPointTransId", idx)
                command.Parameters.AddWithValue("oldPointTransId", pointTransaction("IDPOR"))
                command.Parameters.AddWithValue("pointTransDate", pointTransaction("PTDAT"))
                command.Parameters.AddWithValue("pointTransType", pointTransaction("TRTYPE"))
                command.Parameters.AddWithValue("pointTransPoint", pointTransaction("TRPON"))
                command.Parameters.AddWithValue("customerId", pointTransaction("IDCUS"))

                command.ExecuteNonQuery()

                idx += 1
            Next

            Create.PrimaryKey("PK_pointtrans").OnTable(_tableName).Column("IDPOR")

            Alter.Column("IDPOR").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey("PK_pointtrans").Identity(1, 1)
            Alter.Column("IDCUS").OnTable(_tableName).AsString(25).Indexed()
            Alter.Column("TRPON").OnTable(_tableName).AsInt32().NotNullable().WithDefaultValue(0)
            Alter.Column("TRTYPE").OnTable(_tableName).AsString(5).NotNullable().Indexed()

            command.CommandText = "ALTER TABLE `pointtrans` CHANGE COLUMN `PTDAT` `ptdat` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP;"
            command.ExecuteNonQuery()
        End Sub

        Public Overrides Sub Down()
            Alter.Column("IDPOR").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey()
            Alter.Column("PTDAT").OnTable(_tableName).AsDate().Nullable()
            Alter.Column("TRPON").OnTable(_tableName).AsString(12).Nullable()
            Alter.Column("TRTYPE").OnTable(_tableName).AsString(5).Nullable()

            Delete.Index().OnTable(_tableName).OnColumn("idcus")
            Delete.Index().OnTable(_tableName).OnColumn("trtype")
        End Sub
    End Class
End Namespace

