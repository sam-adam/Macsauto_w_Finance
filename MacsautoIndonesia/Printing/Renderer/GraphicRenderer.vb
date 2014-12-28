Imports MacsautoIndonesia.Printing.Renderer.Contract
Imports System.Collections.ObjectModel

Namespace Printing.Renderer
    Public Class GraphicRenderer
        Implements IRenderer(Of Graphics)

        Private ReadOnly _renderer As IRenderer(Of Panel)
        Private ReadOnly _graphics As Graphics
        Private _font As Font
        Private _printLines As Collection(Of PrintLine)

        Public Sub New(ByRef graphics As Graphics, ByVal renderer As IRenderer(Of Panel))
            _graphics = graphics
            _renderer = renderer
        End Sub

        Public Function Render(ByVal page As Page.Page) As Graphics Implements IRenderer(Of Graphics).Render
            Dim panel As Panel = _renderer.Render(page)

            _font = page.Font
            _printLines = New Collection(Of PrintLine)()

            GetPrintLines(panel, panel.Location.X, panel.Location.Y)

            For Each line As PrintLine In _printLines
                Dim clientRectangle As RectangleF

                clientRectangle = New RectangleF(line.Location, line.Size)

                If Not line.Text Is Nothing Then
                    _graphics.DrawString(line.Text, line.Font, New SolidBrush(Color.Black), clientRectangle, line.Format)
                ElseIf Not line.Image Is Nothing Then
                    Dim x As Single
                    Dim imageWidth As Integer

                    imageWidth = New Size(page.Width / 2, (line.Image.Height / (line.Image.Width / page.Width)) / 2).Width

                    x = (page.Width - imageWidth) / 2

                    _graphics.DrawImage(line.Image, New RectangleF(x, line.Location.Y, line.Size.Width, line.Size.Height))
                End If
            Next

            Return _graphics
        End Function

        Public Function Render(ByVal panel As Panel) As Graphics
            _font = SystemFonts.DialogFont
            _printLines = New Collection(Of PrintLine)()

            GetPrintLines(panel, panel.Location.X, panel.Location.Y)

            For Each line As PrintLine In _printLines
                Dim clientRectangle As RectangleF

                clientRectangle = New RectangleF(line.Location, line.Size)

                _graphics.DrawString(line.Text, line.Font, New SolidBrush(Color.Black), clientRectangle, line.Format)
            Next

            Return _graphics
        End Function

        Private Sub GetPrintLines(ByVal panel As Panel, ByVal x As Integer, ByVal y As Integer)
            For idx As Integer = panel.Controls.Count - 1 To 0 Step -1
                Dim control As Control

                control = panel.Controls(idx)

                If control.GetType() Is GetType(Label) Then
                    Dim label As Label = CType(control, Label)
                    Dim stringFormat = New StringFormat()

                    If label.TextAlign = ContentAlignment.MiddleCenter Then
                        stringFormat.Alignment = StringAlignment.Center
                        stringFormat.LineAlignment = StringAlignment.Near
                    ElseIf label.TextAlign = ContentAlignment.MiddleRight Then
                        stringFormat.Alignment = StringAlignment.Far
                        stringFormat.LineAlignment = StringAlignment.Near
                    End If

                    _printLines.Add(New PrintLine(New PointF(x, y), label.Text, stringFormat, label.Font, panel.Size))
                ElseIf control.GetType() Is GetType(PictureBox) Then
                    Dim pictureBox As PictureBox = CType(control, PictureBox)
                    Dim size As Size

                    size = New Size(panel.Width / 2, (pictureBox.Image.Height / (pictureBox.Image.Width / panel.Width)) / 2)

                    _printLines.Add(New PrintLine(New PointF(x, y), pictureBox.Image, size))
                ElseIf control.GetType() Is GetType(Panel) Then
                    Dim container As Panel = CType(control, Panel)

                    GetPrintLines(container, x + container.Location.X, y + container.Location.Y)
                End If
            Next
        End Sub
    End Class

    Class PrintLine
        Private ReadOnly _location As PointF
        Private ReadOnly _text As String
        Private ReadOnly _image As Bitmap
        Private ReadOnly _format As StringFormat
        Private ReadOnly _font As Font
        Private ReadOnly _size As SizeF

        Sub New(ByVal location As PointF, ByVal text As String, ByVal format As StringFormat, ByVal font As Font, ByVal size As SizeF)
            _location = location
            _text = text
            _format = format
            _font = font
            _size = size
        End Sub

        Sub New(ByVal location As PointF, ByVal image As Bitmap, ByVal size As SizeF)
            _location = location
            _image = image
            _size = size
        End Sub

        ReadOnly Property Location() As PointF
            Get
                Return _location
            End Get
        End Property

        ReadOnly Property Text() As String
            Get
                Return _text
            End Get
        End Property

        ReadOnly Property Image() As Bitmap
            Get
                Return _image
            End Get
        End Property

        ReadOnly Property Format() As StringFormat
            Get
                Return _format
            End Get
        End Property

        ReadOnly Property Font() As Font
            Get
                Return _font
            End Get
        End Property

        ReadOnly Property Size() As SizeF
            Get
                Return _size
            End Get
        End Property
    End Class
End Namespace