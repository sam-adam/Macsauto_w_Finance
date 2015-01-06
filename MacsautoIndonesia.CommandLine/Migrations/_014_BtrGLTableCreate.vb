Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201501062059)>
    Public Class _014_BtrGLTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "btrgl"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("btrid").AsCustom("INT(11)").NotNullable().PrimaryKey().Identity(1, 1) _
                .WithColumn("btrdc").AsString(200) _
                .WithColumn("glnum").AsString(10).Indexed() _
                .WithColumn("ctype").AsString(20).Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace