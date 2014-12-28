Imports MacsautoIndonesia.Printing.Page.Content
Imports MacsautoIndonesia.Printing
Imports MacsautoIndonesia.Printing.Renderer
Imports MacsautoIndonesia.Printing.Page

Public Class TestPrint
    Public Sub New()
        InitializeComponent()

        Dim panelRenderer = New PanelRenderer
        Dim lineFont = New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular)
        Dim line = New Line(lineFont)

        line.AddText("MACSAUTO INDONESIA", ContentAlignment.MiddleCenter)
        line.AddText("JALAN HOS COKROAMINOTO", ContentAlignment.MiddleCenter)
        line.AddText("CILEDUG", ContentAlignment.MiddleCenter)
        line.AddSubLine(
            New Line(lineFont, DockStyle.Fill).AddSubLine(
                New Line(lineFont, DockStyle.Left).AddText("adam", ContentAlignment.MiddleCenter)
            ).AddSubLine(
                New Line(lineFont, DockStyle.Right).AddText("suhendra", ContentAlignment.MiddleCenter)
            )
        )

        Dim page As TransactionPage = New TransactionPage(200, lineFont)

        page.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_

        page.SetTransactionInformation("001/03- 2014/0029/030", "B321DS", "TOYOTA", "AVANZA 1.3", "24/03/2014", "21:37", "Samuel Adam Suhendra")
        page.AppendTitle("HOS COKROAMINOTO (KOMP. SPBU PERTAMINA)")
        page.AppendTitle("SAMPING UBUD VILLAGE, CILEDUG RAYA")
        page.AppendTitle("WWW.MACSAUTO-INDONESIA.COM")
        page.AppendItem("rainbow express car wash (body, tyre, vaccum)", 69000, 7)
        page.AppendItem("anggur new autumn", 6900, 4, 10)
        page.SetPayment(100000, "CASH", "10", "100", "10/10/2014")
        page.AppendFooter("terimakasih sudah datang")
        page.AppendFooter("datang kembali ya")

        Dim redPage As RedemptionPage = New RedemptionPage(200, lineFont)

        redPage.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_
        redPage.AppendTitle("HOS COKROAMINOTO (KOMP. SPBU PERTAMINA)")
        redPage.SetTransactionInformation("001/03- 2014/0029/030", "24/03/2014", "21:37", "Samuel Adam Suhendra")
        redPage.AppendTitle("SAMPING UBUD VILLAGE, CILEDUG RAYA")
        redPage.AppendTitle("WWW.MACSAUTO-INDONESIA.COM")
        redPage.SetData("CUS001", "SAMUEL ADAM SUHENDRA", "10", "100", "01/21/2111")
        redPage.AppendFooter("terimakasih sudah datang")
        redPage.AppendFooter("datang kembali ya")

        Dim content As Panel = panelRenderer.Render(redPage)
        Dim content2 As Panel = panelRenderer.Render(page)

        Panel1.Height = content.Height
        Panel1.Controls.Add(content)

        Panel2.Height = content2.Height
        Panel2.Controls.Add(content2)

        Dim definePrinter = New _001_11_Set_Printer

        'definePrinter.ShowDialog()

        Dim printer = New Printer(My.Settings.DefaultPrinter)

        'printer.Print(page)
    End Sub
End Class

Public Class DummyRenderer
    Inherits PanelRenderer

    Public Function Render(ByVal page As Page) As Panel
        Dim panel As Panel = New Panel()
        Dim contentPanel As Panel = MyBase.Render(page.Content)

        panel.Width = 1000
        panel.Height = 1000

        panel.Controls.Add(MyBase.Render(page.Content))

        Return panel
    End Function
End Class