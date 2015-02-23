Namespace Printing.Page.Content
    Public Class Line
        Private _text As String
        Private _alignment As ContentAlignment
        Private _name As String
        Private _margin As Padding
        Private ReadOnly _dock As DockStyle
        Private ReadOnly _font As Font
        Private ReadOnly _subLines As IList(Of Line)

        Public Sub New(ByVal font As Font, Optional ByVal dock As DockStyle = DockStyle.Top)
            _font = font
            _dock = dock
            _subLines = New List(Of Line)()
        End Sub

        Public Sub New(ByVal name As String, ByVal font As Font, Optional ByVal dock As DockStyle = DockStyle.Top)
            _name = name
            _font = font
            _dock = dock
            _subLines = New List(Of Line)()
        End Sub

        ReadOnly Property Text() As String
            Get
                Return _text
            End Get
        End Property

        ReadOnly Property Dock() As DockStyle
            Get
                Return _dock
            End Get
        End Property

        ReadOnly Property Font() As Font
            Get
                Return _font
            End Get
        End Property

        ReadOnly Property Sublines() As List(Of Line)
            Get
                Return _subLines
            End Get
        End Property

        ReadOnly Property Alignment() As ContentAlignment
            Get
                Return _alignment
            End Get
        End Property

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Public Property Margin() As Padding
            Get
                Return _margin
            End Get
            Set(ByVal value As Padding)
                _margin = value
            End Set
        End Property

        Public Property Group() As String

        Public Function AddText(ByVal textToAdd As String, ByVal contentAlignment As ContentAlignment, Optional ByVal indent As Integer = 0) As Line
            If _subLines.Count = 0 And _text <> "" Then
                _subLines.Add(New Line(_font).AddText(_text, _alignment))
            End If

            _alignment = contentAlignment

            textToAdd = IndentText(textToAdd, indent)

            If _text = Nothing Then
                _text = textToAdd
            Else
                _subLines.Add(New Line(_font).AddText(textToAdd, _alignment))
            End If

            Return Me
        End Function

        Private Function IndentText(ByVal textToIndent As String, ByVal count As Integer) As String
            Dim indentation As String = ""

            For i = 0 To count - 1
                indentation &= "    "
            Next

            Return indentation & textToIndent
        End Function

        Public Function AddSubLine(ByVal subLine As Line) As Line
            _subLines.Add(subLine)

            Return Me
        End Function

        Public Overrides Function ToString() As String
            Return "[" & _name & " - " & _dock & "]"
        End Function
    End Class
End Namespace