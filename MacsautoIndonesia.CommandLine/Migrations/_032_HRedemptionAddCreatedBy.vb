Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201504142336)>
    Public Class _032_HRedemptionAddCreatedBy
        Inherits Migration

        Private ReadOnly _tableName As String = "hredemption"

        Public Overrides Sub Up()
            If Not Schema.Table(_tableName).Column("createdBy").Exists() Then
                Alter.Table(_tableName).AddColumn("createdBy").AsCustom("INT(11)").NotNullable()
            End If
        End Sub

        Public Overrides Sub Down()
            If Schema.Table(_tableName).Column("trtim").Exists() Then
                Delete.Column("trtim").FromTable(_tableName)
            End If
        End Sub
    End Class
End Namespace
