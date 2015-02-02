Imports System.Drawing.Printing
Imports MacsautoIndonesia.Printing.Renderer
Imports MacsautoIndonesia.Printing.Renderer.Contract
Imports MacsautoIndonesia.Printing.Page

Namespace Printing
    Public Class Printer
        Private ReadOnly _printDocument As PrintDocument
        Private ReadOnly _printPreview As PrintPreviewDialog
        Private _renderer As IRenderer(Of Graphics)
        Private _page As RollPage
        Private _showPrintPreview As Boolean = False

        Property PrinterName() As String

        Public Sub New(ByVal currentPrinterName As String)
            _printDocument = New PrintDocument()
            _printPreview = New PrintPreviewDialog()

            PrinterName = currentPrinterName

            AddHandler _printDocument.PrintPage, AddressOf _printDocument_PrintPage
        End Sub

        Private Sub _printDocument_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
            _renderer = New GraphicRenderer(e.Graphics, New PanelRenderer())
            _renderer.Render(_page)
        End Sub

        Private Sub InitializePrintDocument()
            _printDocument.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)
            _printDocument.DefaultPageSettings.PaperSize = New PaperSize("Roll Page", _page.Width, _page.Height)
            _printDocument.DefaultPageSettings.Color = False
        End Sub

        Public Sub Print(ByVal page As RollPage)
            _page = page

            _printDocument.PrinterSettings.PrinterName = PrinterName
            _printPreview.Document = _printDocument

            InitializePrintDocument()

            _printDocument.Print()
        End Sub
    End Class
End Namespace