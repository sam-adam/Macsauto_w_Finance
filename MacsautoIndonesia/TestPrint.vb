Imports MacsautoIndonesia.Printing.Page.Content
Imports MacsautoIndonesia.Printing
Imports MacsautoIndonesia.Printing.Renderer
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.SmartCard

Public Class TestPrint
    Public Sub New()
        InitializeComponent()

        InitializeAcr()

        Dim cardReader = SmartCardManager.AcrReaders.FirstOrDefault()

        cardReader.Login(1)
        cardReader.ReadBlock(ACR120_Block.ACR120_BLOCK_0)
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