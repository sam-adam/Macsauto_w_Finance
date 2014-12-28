Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports MacsautoIndonesia.Printing.Page.Content

Namespace Printing.Page
    Public Class Page
        Private _content As Line
        Private _font As Font
        Private _height As Integer
        Private _margin As Padding
        Private _orientation As Orientation
        Private _width As Integer

        ''' <summary>
        ''' Create a basic page
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            _font = SystemFonts.DialogFont
            _content = New Line(_font)
            _height = 400
            _margin = New Padding(0, 0, 0, 0)
            _orientation = Orientation.Portrait
            _width = 400
        End Sub

        Public Sub New(ByVal paperSize As PaperSize)
            _font = SystemFonts.DialogFont
            _content = New Line(_font)
            _height = paperSize.Height
            _margin = New Padding(0, 0, 0, 0)
            _orientation = Orientation.Portrait
            _width = paperSize.Width
        End Sub

        Public Sub New(ByVal width As Integer, ByVal height As Integer)
            _font = SystemFonts.DialogFont
            _content = New Line(_font)
            _height = height
            _margin = New Padding(0, 0, 0, 0)
            _orientation = Orientation.Portrait
            _width = width
        End Sub

        Public Property Content() As Line
            Get
                Return _content
            End Get
            Set(ByVal value As Line)
                _content = value
            End Set
        End Property

        Public Property Font() As Font
            Get
                Return _font
            End Get
            Set(ByVal value As Font)
                _font = value
            End Set
        End Property

        Public Overridable Property Height() As Integer
            Get
                Return IIf(_orientation = Orientation.Portrait, _height, _width)
            End Get
            Set(ByVal value As Integer)
                _height = value
            End Set
        End Property

        Property Margin() As Padding
            Get
                Return _margin
            End Get
            Set(ByVal value As Padding)
                _margin = value
            End Set
        End Property

        Property Orientation() As Orientation
            Get
                Return _orientation
            End Get
            Set(ByVal value As Orientation)
                _orientation = value
            End Set
        End Property

        Public Property Width() As Integer
            Get
                Return IIf(_orientation = Orientation.Portrait, _width, _height)
            End Get
            Set(ByVal value As Integer)
                _width = value
            End Set
        End Property

        Public Property Logo() As Bitmap
    End Class

    Public Enum Orientation
        Landscape
        Portrait
    End Enum
End Namespace