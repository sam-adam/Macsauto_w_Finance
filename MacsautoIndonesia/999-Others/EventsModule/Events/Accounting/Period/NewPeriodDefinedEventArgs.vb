Namespace EventsModule.Events.Accounting.Period
    Public Class NewPeriodDefinedEventArgs
        Inherits EventArgs

        Private ReadOnly _accountingPeriodId As String

        Public Sub New(ByVal accountingPeriodId As String)
            _accountingPeriodId = accountingPeriodId
        End Sub

        ReadOnly Property AccountingPeriodId() As String
            Get
                Return _accountingPeriodId
            End Get
        End Property
    End Class
End Namespace