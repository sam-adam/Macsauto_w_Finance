Imports FluentMigrator

Namespace Migrations
    <Migration(201412282359)>
    Public Class _001_AccountTypeTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "accounttype"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("actid").AsString(2).PrimaryKey() _
                .WithColumn("actds").AsString(30).NotNullable()

            Insert.IntoTable(_tableName) _
                .Row(New With {Key .actid = "1", Key .actds = "ASSET"}) _
                .Row(New With {Key .actid = "2", Key .actds = "LIABILITIES"}) _
                .Row(New With {Key .actid = "3", Key .actds = "EQUITY"}) _
                .Row(New With {Key .actid = "4", Key .actds = "REVENUE"}) _
                .Row(New With {Key .actid = "5", Key .actds = "COGS"}) _
                .Row(New With {Key .actid = "6", Key .actds = "EXPENSE"})
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace