Imports FluentMigrator

Namespace Migrations
    <Migration(201501062051)>
    Public Class _013_JourDTTableAlterRenameColumnPstAmt
        Inherits Migration

        Private ReadOnly _tableName As String = "jourdt"

        Public Overrides Sub Up()
            Rename.Column("pstamt").OnTable(_tableName).To("psamt")
        End Sub

        Public Overrides Sub Down()
            Rename.Column("psamt").OnTable(_tableName).To("pstamt")
        End Sub
    End Class
End Namespace