Imports FluentMigrator

Namespace Migrations
    <Migration(201501181239)>
    Public Class _021_PettyCashTableAlterAddNullables
        Inherits Migration

        Private ReadOnly _tableName As String = "pettycash"

        Public Overrides Sub Up()
            Alter.Column("ref").OnTable(_tableName).AsString(255).Nullable()
            Alter.Column("rmrk").OnTable(_tableName).AsString(255).Nullable()
            Alter.Column("dflag").OnTable(_tableName).AsString(1).Nullable()
            Alter.Column("canre").OnTable(_tableName).AsString(100).Nullable()
            Alter.Column("ref").OnTable(_tableName).AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
        End Sub

        Public Overrides Sub Down()
            Alter.Column("ref").OnTable(_tableName).AsString(255).NotNullable()
            Alter.Column("rmrk").OnTable(_tableName).AsString(255).NotNullable()
            Alter.Column("dflag").OnTable(_tableName).AsString(1).NotNullable()
            Alter.Column("canre").OnTable(_tableName).AsString(100).NotNullable()
            Alter.Column("ref").OnTable(_tableName).AsDateTime().Nullable()
        End Sub
    End Class
End Namespace

