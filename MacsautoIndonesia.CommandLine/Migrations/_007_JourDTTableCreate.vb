Imports FluentMigrator

Namespace Migrations
    <Migration(201501011210)>
    Public Class _007_JourDTTableCreate
        Inherits Migration

        Private ReadOnly _tableName = "jourdt"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("docid").AsCustom("INT(11)").NotNullable().Indexed() _
                .WithColumn("glnum").AsString(10).NotNullable() _
                .WithColumn("pstky").AsString(10).NotNullable().Indexed() _
                .WithColumn("pstamt").AsDouble().WithDefaultValue(0).NotNullable() _
                .WithColumn("notes").AsString(255).Nullable()
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace