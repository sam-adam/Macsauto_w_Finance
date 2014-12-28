Imports FluentMigrator

Namespace Migrations
    <Migration(201412290203)>
    Public Class _004_HServiceTableAlterAddGLNum
        Inherits Migration

        Private ReadOnly _tableName As String = "hservice"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("glnum").AsString(10).Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("glnum").FromTable(_tableName)
        End Sub
    End Class
End Namespace