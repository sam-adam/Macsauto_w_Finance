Namespace EventsModule.Events.Company
    Public Class CompanyDataChangedEventArgs
        Inherits EventArgs

        Private ReadOnly _company As MacsautoIndonesia.Company

        ReadOnly Property Company() As MacsautoIndonesia.Company
            Get
                Return _company
            End Get
        End Property

        Public Sub New(ByVal company As MacsautoIndonesia.Company)
            _company = company
        End Sub
    End Class
End Namespace