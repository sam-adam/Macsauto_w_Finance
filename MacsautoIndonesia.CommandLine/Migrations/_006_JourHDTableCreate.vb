Imports FluentMigrator

Namespace Migrations
    <Migration(201412290211)>
    Public Class _006_JourHDTableCreate
        Inherits Migration

        Private ReadOnly _tableName As String = "jourhd"

        Public Overrides Sub Up()
            Create.Table(_tableName) _
                .WithColumn("docid").AsCustom("INT(11)").NotNullable().PrimaryKey() _
                .WithColumn("docdt").AsDateTime() _
                .WithColumn("pstdt").AsDateTime() _
                .WithColumn("rfdoc").AsString(20) _
                .WithColumn("rmark").AsString(225) _
                .WithColumn("dstat").AsString(1).Indexed() _
                .WithColumn("uname").AsString(10).Indexed() _
                .WithColumn("cgdat").AsDateTime() _
                .WithColumn("dtnum").AsString(10).Indexed() _
                .WithColumn("cancl").AsString(1).Indexed()
        End Sub

        Public Overrides Sub Down()
            Delete.Table(_tableName)
        End Sub
    End Class
End Namespace