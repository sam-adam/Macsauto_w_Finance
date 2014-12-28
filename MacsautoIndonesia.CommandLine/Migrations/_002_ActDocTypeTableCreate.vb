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
                .Row(New With {Key .actid = "GI", Key .actds = "GOODS ISSUE"}) _
                .Row(New With {Key .actid = "GR", Key .actds = "GOODS RECEIPT"}) _
                .Row(New With {Key .actid = "PC", Key .actds = "PETTY CASH"}) _
                .Row(New With {Key .actid = "TR", Key .actds = "TRANSACTION"})
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace