Imports FluentMigrator

Namespace Migrations
    <Migration(201501011220)>
    Public Class _009_PettyCashTableAlterAddColumns
        Inherits Migration

        Private ReadOnly _tableName As String = "pettycash"

        Public Overrides Sub Up()
            Alter.Table(_tableName) _
                .AlterColumn("id").AsString(15).PrimaryKey() _
                .AlterColumn("type").AsString(10).Indexed() _
                .AddColumn("btransa").AsString(100) _
                .AddColumn("dflag").AsString(1).Indexed() _
                .AddColumn("canre").AsString(100) _
                .AddColumn("crtdt").AsDate() _
                .AddColumn("uname").AsString(100)


        End Sub

        Public Overrides Sub Down()
            Alter.Table(_tableName) _
                .AlterColumn("id").AsString("15") _
                .AlterColumn("type").AsString(3)

            Delete.Column("btransa") _
                .Column("dflag") _
                .Column("canre") _
                .FromTable(_tableName)

            Delete.PrimaryKey("id").FromTable(_tableName)
            Delete.Index("type").OnTable(_tableName)
        End Sub
    End Class
End Namespace