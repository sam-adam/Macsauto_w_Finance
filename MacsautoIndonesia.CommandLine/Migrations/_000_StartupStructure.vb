Imports FluentMigrator.Runner.Extensions
Imports FluentMigrator
Imports FluentMigrator.Builders.Create.Table

Namespace Migrations
    <Migration(0)>
    Public Class _000_StartupStructure
        Inherits Migration

        Private ReadOnly _map As Dictionary(Of String, Action(Of ICreateTableWithColumnOrSchemaOrDescriptionSyntax))

        Public Sub New()
            _map = New Dictionary(Of String, Action(Of ICreateTableWithColumnOrSchemaOrDescriptionSyntax))()

            _map.Add("basepoint",
                    Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                        builder.WithColumn("idcmp").AsString(3).NotNullable() _
                            .WithColumn("pbase").AsCustom("INT(11)").Nullable()
                    End Sub)
            _map.Add("company",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idcmp").AsString(3).NotNullable().PrimaryKey() _
                             .WithColumn("cmnam").AsString(50).Nullable() _
                             .WithColumn("cmadd").AsString(200).Nullable() _
                             .WithColumn("ccity").AsString(50).Nullable() _
                             .WithColumn("ccode").AsString(45).Nullable()
                     End Sub)
            _map.Add("dcustomer",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idcus").AsString(11).Nullable() _
                             .WithColumn("idbrn").AsString(3).Nullable() _
                             .WithColumn("idvmd").AsString(6).Nullable() _
                             .WithColumn("idcol").AsString(3).Nullable() _
                             .WithColumn("linum").AsString(15).Nullable() _
                             .WithColumn("vexpd").AsDate().Nullable() _
                             .WithColumn("vyear").AsString(4).Nullable() _
                             .WithColumn("vkilo").AsCustom("INT(11)").Nullable() _
                             .WithColumn("vtype").AsString(20).Nullable()
                     End Sub)
            _map.Add("dpmovement",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("pmvid").AsString(12).Nullable() _
                             .WithColumn("idpdt").AsString(8).Nullable() _
                             .WithColumn("mpdsc").AsString(50).Nullable() _
                             .WithColumn("mvqty").AsCustom("INT(11)").Nullable() _
                             .WithColumn("mpric").AsDouble().Nullable() _
                             .WithColumn("mvuom").AsString(10).Nullable() _
                             .WithColumn("idslc").AsString(6).Nullable() _
                             .WithColumn("ppdtqty").AsCustom("INT(11)").NotNullable()
                     End Sub)
            _map.Add("dproduct",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idpdt").AsString(8).Nullable() _
                             .WithColumn("idslc").AsString(6).Nullable() _
                             .WithColumn("slqty").AsCustom("INT(11)").Nullable() _
                             .WithColumn("defsl").AsString(10).Nullable()
                     End Sub)
            _map.Add("dredemption",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("rdmpid").AsString(50).NotNullable() _
                             .WithColumn("idmrch").AsString(50).NotNullable() _
                             .WithColumn("point").AsCustom("INT(11)").NotNullable() _
                             .WithColumn("qty").AsCustom("INT(11)").NotNullable()
                     End Sub)
            _map.Add("dservice",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idsvc").AsString(8).Nullable() _
                             .WithColumn("idsiz").AsString(3).Nullable() _
                             .WithColumn("svprc").AsDouble().Nullable()
                     End Sub)
            _map.Add("dtransaction",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("trsid").AsString(20).Nullable() _
                             .WithColumn("ttype").AsString(10).Nullable() _
                             .WithColumn("seqnr").AsCustom("INT(11)").Nullable() _
                             .WithColumn("idsvc").AsString(8).Nullable() _
                             .WithColumn("idpdt").AsString(8).Nullable() _
                             .WithColumn("trqty").AsCustom("INT(11)").Nullable() _
                             .WithColumn("uomdc").AsString(8).Nullable() _
                             .WithColumn("price").AsDouble().Nullable() _
                             .WithColumn("idisc").AsCustom("INT(11)").Nullable() _
                             .WithColumn("rmark").AsString(200).Nullable() _
                             .WithColumn("vpaym").AsString(200).Nullable() _
                             .WithColumn("vnumb").AsString(200).Nullable()
                     End Sub)
            _map.Add("employee",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("id").AsCustom("INT(11)").NotNullable().PrimaryKey().Identity(1, 1) _
                             .WithColumn("name").AsString(255).NotNullable() _
                             .WithColumn("post").AsCustom("INT(11)").NotNullable().WithDefaultValue("1") _
                             .WithColumn("idcmp").AsString(3).NotNullable()
                     End Sub)
            _map.Add("hcustomer",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idcus").AsString(11).NotNullable().PrimaryKey() _
                             .WithColumn("cname").AsString(50).Nullable() _
                             .WithColumn("cgndr").AsString(10).Nullable() _
                             .WithColumn("cudob").AsDate().Nullable() _
                             .WithColumn("cphon").AsString(20).Nullable() _
                             .WithColumn("ccpon").AsString(20).Nullable() _
                             .WithColumn("cmail").AsString(100).Nullable() _
                             .WithColumn("cadd1").AsString(200).Nullable() _
                             .WithColumn("cpoin").AsCustom("INT(11)").Nullable() _
                             .WithColumn("cstat").AsString(10).Nullable()
                     End Sub)
            _map.Add("hmerchandise",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idmrch").AsString(16).NotNullable().PrimaryKey() _
                             .WithColumn("idpdt").AsString(16).NotNullable() _
                             .WithColumn("mpoin").AsCustom("INT(11)").NotNullable()
                     End Sub)
            _map.Add("hpmovement",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("pmvid").AsString(12).NotNullable().PrimaryKey() _
                             .WithColumn("mtype").AsString(50).Nullable() _
                             .WithColumn("mdate").AsDateTime().Nullable() _
                             .WithColumn("redoc").AsString(50).Nullable() _
                             .WithColumn("reamv").AsString(200).Nullable() _
                             .WithColumn("updtm").AsDateTime().Nullable()
                     End Sub)
            _map.Add("hproduct",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idpdt").AsString(8).NotNullable().PrimaryKey() _
                             .WithColumn("idptp").AsString(4).Nullable() _
                             .WithColumn("pdtds").AsString(50).Nullable() _
                             .WithColumn("pdqty").AsCustom("INT(11)").Nullable() _
                             .WithColumn("iduom").AsString(6).NotNullable() _
                             .WithColumn("ppamt").AsDouble().Nullable() _
                             .WithColumn("psamt").AsDouble().Nullable()
                     End Sub)
            _map.Add("hredemption",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("rdmpid").AsString(50).NotNullable().PrimaryKey() _
                             .WithColumn("rdmpdat").AsDateTime().NotNullable() _
                             .WithColumn("idcus").AsString(50).NotNullable() _
                             .WithColumn("tpoin").AsCustom("INT(11)").NotNullable()
                     End Sub)
            _map.Add("hservice",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idsvc").AsString(8).NotNullable().PrimaryKey() _
                             .WithColumn("idsvt").AsString(4).Nullable() _
                             .WithColumn("svcdc").AsString(50).Nullable() _
                             .WithColumn("vcpmt").AsString(1).Nullable()
                     End Sub)
            _map.Add("htransaction",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("trsid").AsString(20).NotNullable().PrimaryKey() _
                             .WithColumn("trdat").AsDateTime().Nullable() _
                             .WithColumn("idcus").AsString(11).Nullable() _
                             .WithColumn("vtype").AsString(50).Nullable() _
                             .WithColumn("vbrnd").AsString(50).Nullable() _
                             .WithColumn("vmodl").AsString(50).Nullable() _
                             .WithColumn("vcolr").AsString(50).Nullable() _
                             .WithColumn("vsize").AsString(50).Nullable() _
                             .WithColumn("vkmre").AsCustom("INT(11)").Nullable() _
                             .WithColumn("linum").AsString(20).Nullable() _
                             .WithColumn("liexp").AsDate().Nullable() _
                             .WithColumn("svamt").AsDouble().Nullable() _
                             .WithColumn("pdamt").AsDouble().Nullable() _
                             .WithColumn("toAmt").AsDouble().Nullable() _
                             .WithColumn("topay").AsDouble().Nullable() _
                             .WithColumn("Pterm").AsString(20).Nullable() _
                             .WithColumn("trstat").AsString(20).Nullable() _
                             .WithColumn("svsts").AsString(20).Nullable() _
                             .WithColumn("tpoin").AsCustom("INT(11)").Nullable() _
                             .WithColumn("chnce").AsCustom("INT(11)").Nullable() _
                             .WithColumn("createdBy").AsCustom("INT(11)").Nullable()
                     End Sub)
            _map.Add("payment",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("payid").AsString(12).Nullable() _
                             .WithColumn("trsid").AsString(20).Nullable() _
                             .WithColumn("pyamt").AsCustom("INT(11)").Nullable() _
                             .WithColumn("pydat").AsDateTime().Nullable()
                     End Sub)
            _map.Add("pettycash",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("id").AsString(15).NotNullable() _
                             .WithColumn("type").AsString(3).NotNullable() _
                             .WithColumn("amt").AsDouble().NotNullable() _
                             .WithColumn("ref").AsString(255).NotNullable() _
                             .WithColumn("rmrk").AsString(255).NotNullable() _
                             .WithColumn("date").AsDateTime().NotNullable()
                     End Sub)
            _map.Add("pointtrans",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("IDPOR").AsString(10).Nullable() _
                             .WithColumn("idcus").AsString(25).Nullable() _
                             .WithColumn("PTDAT").AsDate().Nullable() _
                             .WithColumn("TRPON").AsString(12).Nullable() _
                             .WithColumn("TRTYPE").AsString(5).Nullable()
                     End Sub)
            _map.Add("producttype",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idptp").AsString(4).NotNullable().PrimaryKey() _
                             .WithColumn("ptpdc").AsString(50).Nullable() _
                             .WithColumn("ismrch").AsCustom("TINYINT(1)").NotNullable()
                     End Sub)
            _map.Add("promoassignment",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("atype").AsString(1).Nullable() _
                             .WithColumn("iditm").AsString(8).NotNullable() _
                             .WithColumn("idpmt").AsString(8).Nullable() _
                             .WithColumn("begda").AsDate().Nullable() _
                             .WithColumn("endda").AsDate().Nullable() _
                             .WithColumn("astat").AsString(5).Nullable() _
                             .WithColumn("ismem").AsString(5).Nullable()
                     End Sub)
            _map.Add("promotion",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idpmt").AsString(8).NotNullable().PrimaryKey() _
                             .WithColumn("pmdcp").AsString(50).Nullable() _
                             .WithColumn("ptype").AsString(4).Nullable() _
                             .WithColumn("pdamt").AsDouble().Nullable() _
                             .WithColumn("pdpct").AsCustom("INT(11)").Nullable()
                     End Sub)
            _map.Add("servicetype",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idsvt").AsString(4).NotNullable().PrimaryKey() _
                             .WithColumn("svtdc").AsString(50).Nullable()
                     End Sub)
            _map.Add("sloc",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idslc").AsString(6).NotNullable().PrimaryKey() _
                             .WithColumn("slocd").AsString(50).Nullable()
                     End Sub)
            _map.Add("stocktransfer",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("stfid").AsString(12).NotNullable().PrimaryKey() _
                             .WithColumn("idpdt").AsString(8).Nullable() _
                             .WithColumn("frslc").AsString(6).Nullable() _
                             .WithColumn("frsld").AsString(50).Nullable() _
                             .WithColumn("frqty").AsCustom("INT(11)").Nullable() _
                             .WithColumn("toslc").AsString(6).Nullable() _
                             .WithColumn("tosld").AsString(50).Nullable() _
                             .WithColumn("toqty").AsCustom("INT(11)").Nullable() _
                             .WithColumn("trqty").AsCustom("INT(11)").Nullable() _
                             .WithColumn("tfdat").AsDateTime().Nullable() _
                             .WithColumn("tfref").AsString(50).Nullable() _
                             .WithColumn("tfrea").AsString(200).Nullable()
                     End Sub)
            _map.Add("uom",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("iduom").AsString(6).NotNullable().PrimaryKey() _
                             .WithColumn("uodsc").AsString(10).Nullable()
                     End Sub)
            _map.Add("user",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("id").AsCustom("INT(11)").NotNullable().PrimaryKey().Identity(1, 1) _
                             .WithColumn("username").AsString(255).NotNullable() _
                             .WithColumn("password").AsString(255).NotNullable() _
                             .WithColumn("employee_id").AsCustom("INT(11)").NotNullable()
                     End Sub)
            _map.Add("vehiclebrand",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idbrn").AsString(3).NotNullable().PrimaryKey() _
                             .WithColumn("vtype").AsString(20).Nullable() _
                             .WithColumn("brdsc").AsString(50).Nullable()
                     End Sub)
            _map.Add("vehiclecolor",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idcol").AsString(3).NotNullable().PrimaryKey() _
                             .WithColumn("coldc").AsString(50).Nullable()
                     End Sub)
            _map.Add("vehiclemodel",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idvmd").AsString(6).NotNullable().PrimaryKey() _
                             .WithColumn("idbrn").AsString(3).Nullable() _
                             .WithColumn("modsc").AsString(50).Nullable() _
                             .WithColumn("idsiz").AsString(3).NotNullable()
                     End Sub)
            _map.Add("vehiclesize",
                     Sub(builder As ICreateTableWithColumnOrSchemaOrDescriptionSyntax)
                         builder.WithColumn("idsiz").AsString(3).NotNullable().PrimaryKey() _
                             .WithColumn("sizdc").AsString(50).Nullable()
                     End Sub)
        End Sub

        Public Overrides Sub Up()
            For Each table As KeyValuePair(Of String, Action(Of ICreateTableWithColumnOrSchemaOrDescriptionSyntax)) In _map
                If Not Schema.Table(table.Key).Exists() Then
                    table.Value.Invoke(Create.Table(table.Key))
                End If
            Next
        End Sub

        Public Overrides Sub Down()
            For Each table As KeyValuePair(Of String, Action(Of ICreateTableWithColumnOrSchemaOrDescriptionSyntax)) In _map
                If Schema.Table(table.Key).Exists() Then
                    Delete.Table(table.Key)
                End If
            Next
        End Sub
    End Class
End Namespace