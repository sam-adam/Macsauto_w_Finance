Imports FluentMigrator

Namespace Migrations
    <Migration(201412290208)>
    Public Class _005_HTransactionTableAlterAddRemrk
        Inherits Migration

        Private ReadOnly _tableName As String = "htransaction"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("remrk").AsString(225).Nullable()
        End Sub

        Public Overrides Sub Down()
            Delete.Column("remrk").FromTable(_tableName)
        End Sub
    End Class
End Namespace