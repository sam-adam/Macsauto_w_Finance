Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201501201542)>
    Public Class _024_JourDTTableAddCompositePrimaryKey
        Inherits Migration

        Private ReadOnly _tableName As String = "jourdt"

        Public Overrides Sub Up()
            Alter.Column("glnum").OnTable(_tableName).AsString(10).NotNullable()
            Create.PrimaryKey("PK_jourdt").OnTable(_tableName).Columns({"docid", "glnum", "pstky"})
        End Sub

        Public Overrides Sub Down()
            Delete.PrimaryKey("PK_jourdt").FromTable(_tableName)
        End Sub
    End Class
End Namespace

