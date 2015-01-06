Imports FluentMigrator

Namespace Migrations
    <Migration(201501062031)>
    Public Class _012_ProductTypeTableAlterAddColumnIsCnsm
        Inherits Migration

        Private ReadOnly _tableName As String = "producttype"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("glnum").AsBoolean().Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("glnum").FromTable(_tableName)
        End Sub
    End Class
End Namespace