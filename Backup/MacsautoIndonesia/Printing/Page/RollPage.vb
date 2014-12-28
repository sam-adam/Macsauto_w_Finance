Imports MacsautoIndonesia.Printing.Renderer.Contract

Namespace Printing.Page
    Public Class RollPage
        Inherits Page

        Private ReadOnly _renderer As IRenderer(Of Panel)

        Public Sub New(ByVal width As Integer, ByVal renderer As IRenderer(Of Panel))
            MyBase.New(width, 0)

            _renderer = renderer
        End Sub

        Public Overrides Property Height() As Integer
            Get
                Return _renderer.Render(Me).Height
            End Get
            Set(ByVal value As Integer)

            End Set
        End Property
    End Class
End Namespace