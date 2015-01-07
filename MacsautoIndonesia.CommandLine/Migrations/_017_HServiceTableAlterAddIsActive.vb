Imports FluentMigrator

Namespace Migrations
    <Migration(201501072020)>
    Public Class _017_HServiceTableAlterAddIsActive
        Inherits Migration

        Private ReadOnly _tableName As String = "hservice"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("is_active").AsBoolean().NotNullable().WithDefaultValue(1)
        End Sub

        Public Overrides Sub Down()
            Delete.Column("is_active").FromTable(_tableName)
        End Sub
    End Class
End Namespace