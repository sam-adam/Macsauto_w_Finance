Namespace EventsModule
    Public Class EventBus
        Private Shared ReadOnly Subscribers As Dictionary(Of Type, List(Of EventSubscriber)) = New Dictionary(Of Type, List(Of EventSubscriber))()

        Public Shared Sub Publish(Of TEvent As BaseEvent(Of TEventArg), TEventArg As EventArgs)(ByRef publisher As Object, ByVal e As TEvent)
            For Each eventSubscriber As KeyValuePair(Of Type, List(Of EventSubscriber)) In Subscribers
                If eventSubscriber.Key Is GetType(TEvent) Then
                    Dim listedSubscribers As List(Of EventSubscriber) = eventSubscriber.Value

                    For Each listedSubscriber As EventSubscriber In listedSubscribers
                        If Not listedSubscriber.IsDisposed Then
                            listedSubscriber.Callback.Invoke(CType(publisher, Form), e.EventArgs)
                        Else
                            listedSubscribers.Remove(listedSubscriber)
                        End If
                    Next
                End If
            Next
        End Sub

        Public Shared Sub Subscribe(Of TEvent As BaseEvent(Of TEventArg), TEventArg As EventArgs)(ByRef subscriber As Form, ByVal callback As Action(Of Object, EventArgs))
            If Subscribers.ContainsKey(GetType(TEvent)) Then
                Subscribers.Item(GetType(TEvent)).Add(New EventSubscriber(subscriber, callback))
            Else
                Dim subscribersList As List(Of EventSubscriber) = New List(Of EventSubscriber)()

                subscribersList.Add(New EventSubscriber(subscriber, callback))

                Subscribers.Add(GetType(TEvent), subscribersList)
            End If
        End Sub
    End Class
End Namespace