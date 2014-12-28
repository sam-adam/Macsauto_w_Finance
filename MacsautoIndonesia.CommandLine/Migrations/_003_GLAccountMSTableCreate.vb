Imports FluentMigrator

Namespace Migrations
    <Migration(201412290158)>
    Public Class _003_GLAccountMSTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "glaccountms"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("glnum").AsString(10).NotNullable().PrimaryKey() _
                .WithColumn("gldes").AsString(50) _
                .WithColumn("actid").AsString(10).Indexed() _
                .WithColumn("ispnl").AsString(1).Indexed() _
                .WithColumn("glsta").AsString(10).Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace