Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201502011641)>
    Public Class _027_HTransactionTableAlterAddTrTim
        Inherits Migration

        Private ReadOnly _tableName As String = "htransaction"

        Public Overrides Sub Up()
            If Not Schema.Table(_tableName).Column("trtim").Exists() Then
                Alter.Table(_tableName).AddColumn("trtim").AsTime().Nullable()
            End If
        End Sub

        Public Overrides Sub Down()
            If Schema.Table(_tableName).Column("trtim").Exists() Then
                Delete.Column("trtim").FromTable(_tableName)
            End If
        End Sub
    End Class
End Namespace
