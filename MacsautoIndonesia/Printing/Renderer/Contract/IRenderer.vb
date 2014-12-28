Namespace Printing.Renderer.Contract
    Public Interface IRenderer(Of T)
        Function Render(ByVal page As Page.Page) As T
    End Interface
End Namespace