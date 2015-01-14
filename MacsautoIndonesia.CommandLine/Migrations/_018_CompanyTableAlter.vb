Imports FluentMigrator

Namespace Migrations
    <Migration(201501142042)>
    Public Class _018_CompanyTableAlter
        Inherits Migration

        Private ReadOnly _tableName As String = "company"

        Public Overrides Sub Up()
            Alter.Table(_tableName).AddColumn("strta").AsString(255)
            Alter.Table(_tableName).AddColumn("phon1").AsString(50)
            Alter.Table(_tableName).AddColumn("phon2").AsString(50)
            Alter.Table(_tableName).AddColumn("webst").AsString(50)
        End Sub

        Public Overrides Sub Down()
            Delete.Column("webst").FromTable(_tableName)
            Delete.Column("phon2").FromTable(_tableName)
            Delete.Column("phon1").FromTable(_tableName)
            Delete.Column("strta").FromTable(_tableName)
        End Sub
    End Class
End Namespace

