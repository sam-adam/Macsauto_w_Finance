Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201501311243)>
    Public Class _026_PointTransTableAddAutoIncrement
        Inherits Migration

        Private ReadOnly _tableName As String = "pointtrans"

        Public Overrides Sub Up()
            Create.PrimaryKey("PK_pointtrans").OnTable(_tableName).Column("idpor")
            Alter.Column("idpor").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey("PK_pointtrans").Identity(1, 1)
        End Sub

        Public Overrides Sub Down()
            Alter.Column("idpor").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey()
        End Sub
    End Class
End Namespace

