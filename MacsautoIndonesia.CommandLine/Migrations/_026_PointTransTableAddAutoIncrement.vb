Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator
Imports MySql.Data.MySqlClient

Namespace Migrations
    <Migration(201501311243)>
    Public Class _026_PointTransTableAddAutoIncrement
        Inherits Migration

        Private ReadOnly _tableName As String = "pointtrans"

        Public Overrides Sub Up()
            Rename.Column("IDPOR").OnTable(_tableName).To("idpor")
            Rename.Column("IDCUS").OnTable(_tableName).To("idcus")
            Rename.Column("TRPON").OnTable(_tableName).To("trpon")
            Rename.Column("TRTYPE").OnTable(_tableName).To("trtype")
        End Sub

        Public Overrides Sub Down()
            Rename.Column("idcus").OnTable(_tableName).To("IDCUS")
            Rename.Column("ptdat").OnTable(_tableName).To("PTDAT")
            Rename.Column("trpon").OnTable(_tableName).To("TRPON")
            Rename.Column("trtype").OnTable(_tableName).To("TRTYPE")
        End Sub
    End Class
End Namespace