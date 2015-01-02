Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    Public Class _010_PrActTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "pract"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("acpid").AsCustom("INT(11)").NotNullable().PrimaryKey().Identity(1, 1) _
                .WithColumn("acmon").AsString(2).NotNullable().Indexed() _
                .WithColumn("acyer").AsString(4).NotNullable().Indexed() _
                .WithColumn("activ").AsCustom("TINYINT(1)").NotNullable().Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace