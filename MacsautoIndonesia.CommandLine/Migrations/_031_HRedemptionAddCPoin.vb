Imports FluentMigrator

Namespace Migrations
    <Migration(201503262315)>
    Public Class _031_HRedemptionAddCPoin
        Inherits Migration

        Private ReadOnly _tableName As String = "hredemption"

        Public Overrides Sub Up()
            Alter.Column("cpoin").OnTable(_tableName).AsCustom("INT(11)").NotNullable()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("cpoin").FromTable(_tableName)
        End Sub
    End Class
End Namespace
