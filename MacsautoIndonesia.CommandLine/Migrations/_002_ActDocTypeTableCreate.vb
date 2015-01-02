Imports FluentMigrator

Namespace Migrations
    <Migration(201412290152)>
    Public Class _002_ActDocTypeTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "actdoctype"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("dtnum").AsString(10).PrimaryKey() _
                .WithColumn("dtdes").AsString(50).Indexed()

            Insert.IntoTable(_tableName) _
                .Row(New With {Key .dtnum = "AD", Key .dtdes = "ACCOUNTING DOCUMENT"}) _
                .Row(New With {Key .dtnum = "GI", Key .dtdes = "GOODS ISSUE"}) _
                .Row(New With {Key .dtnum = "GR", Key .dtdes = "GOODS RECEIPT"}) _
                .Row(New With {Key .dtnum = "PC", Key .dtdes = "PETTY CASH"}) _
                .Row(New With {Key .dtnum = "TR", Key .dtdes = "TRANSACTION"})
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace