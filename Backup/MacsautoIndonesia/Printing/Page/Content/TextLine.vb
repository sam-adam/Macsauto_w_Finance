'Namespace Printing.Page.Content
'    Public Class TextLine
'        Inherits Line

'        Private _text As String

'        Public Sub New(ByVal text As String, ByVal font As Font)
'            MyBase.New(font, DockStyle.Top)

'            _text = text
'        End Sub

'        Public Sub New(ByVal text As String, ByVal contentAlignment As ContentAlignment, ByVal font As Font)
'            MyBase.New(font, DockStyle.Top)

'            _text = text
'        End Sub

'        Public Sub New(ByVal text As String, ByVal contentAlignment As ContentAlignment, ByVal indent As Integer, ByVal font As Font)
'            MyBase.New(font, DockStyle.Top)

'            _text = IndentText(text, indent)
'        End Sub

'        ReadOnly Property Text() As String
'            Get
'                Return _text
'            End Get
'        End Property

'        Private Function AddText(ByVal textToAdd As String, ByVal contentAlignment As ContentAlignment, Optional ByVal indent As Integer = 0) As Line
'            If _subLines.Count = 0 And _text <> "" Then
'                _subLines.Add(New Line(_font).AddText(_text, _alignment))
'            End If

'            _alignment = contentAlignment

'            textToAdd = IndentText(textToAdd, indent)

'            If _text = Nothing Then
'                _text = textToAdd
'            Else
'                _subLines.Add(New Line(_font).AddText(textToAdd, _alignment))
'            End If

'            Return Me
'        End Function

'        Private Function IndentText(ByVal textToIndent As String, ByVal count As Integer) As String
'            Dim indentation As String = ""

'            For i = 0 To count - 1
'                indentation &= "    "
'            Next

'            Return indentation & textToIndent
'        End Function
'    End Class
'End Namespace