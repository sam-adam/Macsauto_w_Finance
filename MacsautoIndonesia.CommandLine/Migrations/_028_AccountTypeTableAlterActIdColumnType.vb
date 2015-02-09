Imports FluentMigrator

Namespace Migrations
    <Migration(201502092219)>
    Public Class _028_AccountTypeTableAlterActIdColumnType
        Inherits Migration

        Private ReadOnly _tableName As String = "accounttype"

        Public Overrides Sub Up()
            Alter.Column("actid").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey()
        End Sub

        Public Overrides Sub Down()
            Alter.Column("actid").OnTable(_tableName).AsString(2).NotNullable().PrimaryKey()
        End Sub
    End Class
End Namespace
