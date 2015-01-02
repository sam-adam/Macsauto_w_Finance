Imports FluentMigrator

Namespace Migrations
    Public Class _008_MTracTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "mtrac"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("mtrid").AsCustom("INT(11)").PrimaryKey() _
                .WithColumn("glnum").AsString(10).NotNullable().Indexed() _
                .WithColumn("gldes").AsString(255).Nullable()
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace