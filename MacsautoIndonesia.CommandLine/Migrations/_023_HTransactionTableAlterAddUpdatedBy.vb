Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201501201342)>
    Public Class _023_HTransactionTableAlterAddUpdatedBy
        Inherits Migration

        Private ReadOnly _tableName As String = "htransaction"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("updatedBy").AsCustom("INT(11)").Nullable().Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("updatedBy").FromTable(_tableName)
        End Sub
    End Class
End Namespace
