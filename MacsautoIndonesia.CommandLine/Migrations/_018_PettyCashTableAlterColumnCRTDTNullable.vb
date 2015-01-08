Imports FluentMigrator

Namespace Migrations
    <Migration(201501091532)>
    Public Class _018_PettyCashTableAlterColumnCRTDTNullable
        Inherits Migration

        Private ReadOnly _tableName As String = "pettycash"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("crtdt").AsDate.NotNullable().WithDefaultValue(False)
        End Sub

        Public Overrides Sub Down()
            Delete.Column("crtdt").FromTable(_tableName)
        End Sub
    End Class
End Namespace
