Namespace EventsModule
    Public Class EventSubscriber
        Private ReadOnly _subscribedOn As DateTime
        Private ReadOnly _subscriber As Form
        Private ReadOnly _callback As Action(Of Object, EventArgs)

        ReadOnly Property SubscribedOn() As DateTime
            Get
                Return _subscribedOn
            End Get
        End Property

        ReadOnly Property Subscriber() As Form
            Get
                Return _subscriber
            End Get
        End Property

        ReadOnly Property Callback() As Action(Of Object, EventArgs)
            Get
                Return _callback
            End Get
        End Property

        ReadOnly Property IsDisposed() As Boolean
            Get
                Return _subscriber.IsDisposed
            End Get
        End Property

        Public Sub New(ByRef form As Form, ByVal callback As Action(Of Object, EventArgs))
            _subscriber = form
            _subscribedOn = DateTime.Now
            _callback = callback
        End Sub
    End Class
End Namespace