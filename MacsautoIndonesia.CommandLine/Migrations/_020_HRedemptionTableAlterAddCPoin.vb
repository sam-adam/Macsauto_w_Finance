Imports FluentMigrator

Namespace Migrations
    <Migration(201501171444)>
    Public Class _020_HRedemptionTableAlterAddCPoin
        Inherits Migration

        Private ReadOnly _tableName As String = "hredemption"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("cpoin").AsCustom("INT(11)")
            Update.Table(_tableName).Set(New With {.cpoin = 0}).AllRows()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("cpoin").FromTable(_tableName)
        End Sub
    End Class
End Namespace

