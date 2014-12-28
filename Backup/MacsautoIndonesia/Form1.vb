Imports MacsautoIndonesia.Printing.Renderer

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.WindowState = FormWindowState.Normal
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.ClientSize = New Size(350, 500)
        'PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim bm As New Bitmap(Panel1.Width, Panel1.Height)
        'Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
        'e.Graphics.DrawImage(bm, 0, 0)

        Dim renderer As GraphicRenderer = New GraphicRenderer(e.Graphics, New PanelRenderer)

        renderer.Render(Panel1)
    End Sub
End Class
