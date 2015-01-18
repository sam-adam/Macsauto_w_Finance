Namespace EventsModule.Events.Accounting.Period
    Public Class NewPeriodDefinedEvent
        Inherits BaseEvent(Of NewPeriodDefinedEventArgs)

        Public Sub New(ByRef sender As Object, ByVal eventArgs As NewPeriodDefinedEventArgs)
            MyBase.New(sender, eventArgs)
        End Sub
    End Class
End Namespace