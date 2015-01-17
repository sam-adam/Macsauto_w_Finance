Imports FluentMigrator

Namespace Migrations
    <Migration(201501171412)>
    Public Class _019_HTransactionTableAlterAddCPoin
        Inherits Migration

        Private ReadOnly _tableName As String = "htransaction"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("cpoin").AsCustom("INT(11)")
            Update.Table(_tableName).Set(New With {.cpoin = 0}).AllRows()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("cpoin").FromTable(_tableName)
        End Sub
    End Class
End Namespace

