Imports FluentMigrator

Namespace Migrations
    <Migration(201501062025)>
    Public Class _011_HProductTableAlterAddColumnGLNum
        Inherits Migration

        Private ReadOnly _tableName As String = "hproduct"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("glnum").AsString(10).Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("glnum").FromTable(_tableName)
        End Sub
    End Class
End Namespace