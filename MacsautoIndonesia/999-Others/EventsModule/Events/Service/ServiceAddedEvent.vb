Namespace EventsModule.Events.Service
    Public Class ServiceAddedEvent
        Inherits BaseEvent(Of ServiceAddedEventArgs)

        Public Sub New(ByRef sender As Object, ByVal eventArgs As ServiceAddedEventArgs)
            MyBase.New(sender, eventArgs)
        End Sub
    End Class
End Namespace