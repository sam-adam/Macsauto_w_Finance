Imports MacsautoIndonesia.SmartCard.Reader

Namespace SmartCard
    Public Module SmartCardManager
        Private _returnCode As Integer
        Private _hContext As Integer
        Private _cardReaders As IList(Of SmartCardReader)

        Public Sub Initialize()
            If (_cardReaders Is Nothing) Then
                _cardReaders = New List(Of SmartCardReader)()
                _returnCode = ModWinsCard.SCardEstablishContext(ModWinsCard.SCARD_SCOPE_USER, 0, 0, _hContext)

                If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then
                    Throw New ApplicationException(GetMessage())
                End If

                FetchReaders()
            End If
        End Sub

        Public ReadOnly Property CardReaders() As IList(Of SmartCardReader)
            Get
                Return _cardReaders
            End Get
        End Property

        Private Sub FetchReaders()
            Dim pcchReader = 0

            _returnCode = ModWinsCard.SCardListReaders(_hContext, Nothing, Nothing, pcchReader)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then
                Throw New ApplicationException(GetMessage())
            End If

            Dim readerName As String

            For i = 0 To 255
                readerName = readerName & vbNullChar
            Next

            _returnCode = ModWinsCard.SCardListReaders(_hContext, Nothing, readerName, pcchReader)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then
                Throw New ApplicationException(GetMessage())
            End If

            _cardReaders.Add(New SmartCardReader(readerName, _hContext))
        End Sub

        Private Function GetMessage() As String
            Dim message = ModWinsCard.GetScardErrMsg(_returnCode)

            Return If(message = "?", ("An error occured : " & _returnCode), message)
        End Function
    End Module
End Namespace