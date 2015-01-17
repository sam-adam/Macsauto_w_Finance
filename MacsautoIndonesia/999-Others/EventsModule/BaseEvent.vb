Namespace EventsModule
    Public Class BaseEvent(Of TEventArg As EventArgs)
        Private ReadOnly _sender As Object
        Private ReadOnly _eventArgs As TEventArg

        ReadOnly Property Sender() As Object
            Get
                Return _sender
            End Get
        End Property

        ReadOnly Property EventArgs() As TEventArg
            Get
                Return _eventArgs
            End Get
        End Property

        Public Sub New(ByRef sender As Object, ByVal eventArgs As TEventArg)
            _sender = sender
            _eventArgs = eventArgs
        End Sub
    End Class
End Namespace