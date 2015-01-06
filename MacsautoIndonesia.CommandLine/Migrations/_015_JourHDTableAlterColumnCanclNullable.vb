Imports FluentMigrator

Namespace Migrations
    <Migration(201501062134)>
    Public Class _015_JourHDTableAlterColumnCanclNullable
        Inherits Migration

        Private ReadOnly _tableName As String = "jourhd"

        Public Overrides Sub Up()
            Alter.Column("cancl").OnTable(_tableName).AsString(1).Nullable()
        End Sub

        Public Overrides Sub Down()
            Alter.Column("cancl").OnTable(_tableName).AsString(1).NotNullable()
        End Sub
    End Class
End Namespace