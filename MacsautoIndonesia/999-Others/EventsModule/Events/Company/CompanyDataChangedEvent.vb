Namespace EventsModule.Events.Company
    Public Class CompanyDataChangedEvent
        Inherits BaseEvent(Of CompanyDataChangedEventArgs)

        Public Sub New(ByRef sender As Object, ByVal eventArgs As CompanyDataChangedEventArgs)
            MyBase.New(sender, eventArgs)
        End Sub
    End Class
End Namespace