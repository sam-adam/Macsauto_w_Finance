Namespace SmartCard.Reader
    Public Class ReaderCardStateChangedEventArgs
        Inherits EventArgs
        Private ReadOnly _readerCardState As ReaderCardState

        Public Sub New(ByVal readerCardState As ReaderCardState)
            _readerCardState = readerCardState
        End Sub

        Public ReadOnly Property ReaderCardState() As ReaderCardState
            Get
                Return _readerCardState
            End Get
        End Property
    End Class
End Namespace