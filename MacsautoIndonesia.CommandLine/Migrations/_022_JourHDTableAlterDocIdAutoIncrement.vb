Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201501201235)>
    Public Class _022_JourHDTableAlterDocIdAutoIncrement
        Inherits Migration

        Private ReadOnly _tableName As String = "jourhd"

        Public Overrides Sub Up()
            Alter.Column("docid").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey().Identity(1, 1)
        End Sub

        Public Overrides Sub Down()
            Alter.Column("docid").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey()
        End Sub
    End Class
End Namespace

