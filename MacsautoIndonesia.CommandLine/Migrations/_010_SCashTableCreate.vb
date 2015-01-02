Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201501011222)>
    Public Class _010_SCashTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "scash"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("souid").AsCustom("INT(11)").NotNullable().PrimaryKey().Identity(1, 1) _
                .WithColumn("soudc").AsString(255) _
                .WithColumn("glnum").AsString(10).Indexed().NotNullable()
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace