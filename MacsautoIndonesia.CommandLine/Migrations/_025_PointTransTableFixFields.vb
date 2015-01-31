Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator

Namespace Migrations
    <Migration(201501311042)>
    Public Class _025_PointTransTableFixFields
        Inherits Migration

        Private ReadOnly _tableName As String = "pointtrans"

        Public Overrides Sub Up()
            Rename.Column("IDPOR").OnTable(_tableName).To("idpor")
            Rename.Column("PTDAT").OnTable(_tableName).To("ptdat")
            Rename.Column("TRPON").OnTable(_tableName).To("trpon")
            Rename.Column("TRTYPE").OnTable(_tableName).To("trtype")

            Alter.Column("idpor").OnTable(_tableName).AsCustom("INT(11)").NotNullable().PrimaryKey("PK_pointtrans")
            Alter.Column("idcus").OnTable(_tableName).AsString(25).Indexed()
            Alter.Column("ptdat").OnTable(_tableName).AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
            Alter.Column("trpon").OnTable(_tableName).AsInt32().NotNullable().WithDefaultValue(0)
            Alter.Column("trtype").OnTable(_tableName).AsString(5).NotNullable().Indexed()
        End Sub

        Public Overrides Sub Down()
            Alter.Column("ptdat").OnTable(_tableName).AsDate().Nullable()
            Alter.Column("trpon").OnTable(_tableName).AsString(12).Nullable()
            Alter.Column("trtype").OnTable(_tableName).AsString(5).Nullable()

            Delete.PrimaryKey("PK_pointtrans").FromTable(_tableName)
            Delete.Index().OnTable(_tableName).OnColumn("idcus")
            Delete.Index().OnTable(_tableName).OnColumn("trtype")

            Rename.Column("idpor").OnTable(_tableName).To("IDPOR")
            Rename.Column("ptdat").OnTable(_tableName).To("PTDAT")
            Rename.Column("trpon").OnTable(_tableName).To("TRPON")
            Rename.Column("trtype").OnTable(_tableName).To("TRTYPE")
        End Sub
    End Class
End Namespace

