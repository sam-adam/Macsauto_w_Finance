Imports FluentMigrator

Namespace Migrations
    <Migration(201502131304)>
    Public Class _029_PettyCashTableAlterRefString
        Inherits Migration

        Private ReadOnly _tableName As String = "pettycash"

        Public Overrides Sub Up()
            Alter.Column("ref").OnTable(_tableName).AsString(255).Nullable().Indexed()
        End Sub

        Public Overrides Sub Down()
            Alter.Column("ref").OnTable(_tableName).AsString(255).Nullable().Indexed()
        End Sub
    End Class
End Namespace
