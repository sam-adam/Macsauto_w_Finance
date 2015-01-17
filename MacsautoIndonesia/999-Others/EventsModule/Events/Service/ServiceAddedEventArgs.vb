Namespace EventsModule.Events.Service
    Public Class ServiceAddedEventArgs
        Inherits EventArgs

        Private ReadOnly _serviceId As String

        Public Sub New(ByVal serviceId As String)
            _serviceId = serviceId
        End Sub

        ReadOnly Property ServiceId() As String
            Get
                Return _serviceId
            End Get
        End Property
    End Class
End Namespace