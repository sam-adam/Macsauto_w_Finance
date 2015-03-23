Imports FluentMigrator

Namespace Migrations
    <Migration(201503231230)>
    Public Class _030_JourHDTableAlterCancl
        Inherits Migration

        Private ReadOnly _tableName As String = "jourhd"

        Public Overrides Sub Up()
            Alter.Column("cancl").OnTable(_tableName).AsString(255).Nullable()
        End Sub

        Public Overrides Sub Down()
            Alter.Column("cancl").OnTable(_tableName).AsString(1).Nullable()
        End Sub
    End Class
End Namespace
