Imports MacsautoIndonesia.SmartCard.Reader

Namespace SmartCard.Card
    Public Class SmartCard
        Private ReadOnly _type As String
        Private ReadOnly _rid As String
        Private _sentBuff() As Byte
        Private _recvBuff() As Byte
        Private _returnCode As Integer
        Private _recvBuffLen As Integer
        Private _ioSendRequest As SCARD_IO_REQUEST

        Public Sub New(ByVal atrLen As Integer, ByVal atr() As Byte)
            Dim ridBytes() As Byte = New Byte() {}

            Select Case (atrLen)
                Case 17
                    Array.Resize(ridBytes, 17)
                    Array.ConstrainedCopy(atr, 4, ridBytes, 0, 17)

                    _rid = GetRID(ridBytes)

                    If _rid = "50 12 23 45 56 12 53 54 4E 33 81 C3" Then
                        _type = "ST19XRC8E"
                    End If
                Case 11
                    Array.Resize(ridBytes, 6)
                    Array.ConstrainedCopy(atr, 4, ridBytes, 0, 6)

                    _rid = GetRID(ridBytes)

                    If _rid = "06 75 77 81 02 80" Then
                        _type = "Mifare DESFire"
                    End If
                Case Else
                    If (atrLen > 14 And atr(12) = &H3) Then
                        Array.Resize(ridBytes, 5)
                        Array.ConstrainedCopy(atr, 7, ridBytes, 0, 5)

                        _rid = GetRID(ridBytes)

                        Select Case atr(13)
                            Case &HF0
                                Select Case atr(14)
                                    Case &H11
                                        _type = "FeliCa 212K"
                                    Case &H12
                                        _type = "Felica 424K"
                                    Case &H4
                                        _type = "Topaz"
                                End Select
                            Case &H0
                                Select Case atr(14)
                                    Case &H1
                                        _type = "Mifare Standard 1K"
                                    Case &H2
                                        _type = "Mifare Standard 4K"
                                    Case &H3
                                        _type = "Mifare Ultra light"
                                    Case &H4
                                        _type = "SLE55R_XXXX"
                                    Case &H6
                                        _type = "SR176"
                                    Case &H7
                                        _type = "SRI X4K"
                                    Case &H8
                                        _type = "AT88RF020"
                                    Case &H9
                                        _type = "AT88SC0204CRF"
                                    Case &HA
                                        _type = "AT88SC0808CRF"
                                    Case &HB
                                        _type = "AT88SC1616CRF"
                                    Case &HC
                                        _type = "AT88SC3216CRF"
                                    Case &HD
                                        _type = "AT88SC6416CRF"
                                    Case &HE
                                        _type = "SRF55V10P"
                                    Case &HF
                                        _type = "SRF55V02P"
                                    Case &H10
                                        _type = "SRF55V10S"
                                    Case &H11
                                        _type = "SRF55V02S"
                                    Case &H12
                                        _type = "TAG IT"
                                    Case &H13
                                        _type = "LRI512"
                                    Case &H14
                                        _type = "ICODESLI"
                                    Case &H15
                                        _type = "TEMPSENS"
                                    Case &H16
                                        _type = "I.CODE1"
                                    Case &H17
                                        _type = "PicoPass 2K"
                                    Case &H18
                                        _type = "PicoPass 2KS"
                                    Case &H19
                                        _type = "PicoPass 16K"
                                    Case &H1A
                                        _type = "PicoPass 16KS"
                                    Case &H1B
                                        _type = "PicoPass 16K(8x2)"
                                    Case &H1C
                                        _type = "PicoPass 16KS(8x2)"
                                    Case &H1D
                                        _type = "PicoPass 32KS(16+16)"
                                    Case &H1E
                                        _type = "PicoPass 32KS(16+8x2)"
                                    Case &H1F
                                        _type = "PicoPass 32KS(8x2+16)"
                                    Case &H20
                                        _type = "PicoPass 32KS(8x2+8x2)"
                                    Case &H21
                                        _type = "LRI64"
                                    Case &H22
                                        _type = "I.CODE UID"
                                    Case &H23
                                        _type = "I.CODE EPC"
                                    Case &H24
                                        _type = "LRI12"
                                    Case &H25
                                        _type = "LRI128"
                                    Case &H26
                                        _type = "Mifare Mini"
                                End Select
                        End Select
                    End If
            End Select

            If String.IsNullOrEmpty(_type) Then
                Throw New ApplicationException("Cannot determine card type")
            End If
        End Sub

        ReadOnly Property Type() As String
            Get
                Return _type
            End Get
        End Property

        ReadOnly Property RID() As String
            Get
                Return _rid
            End Get
        End Property

        Public Function GetBlockValue(ByVal block As Integer, ByVal hCard As Integer) As String
            Dim value As String = ""

            _returnCode = AuthenticateBlock(block, hCard)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then Throw New ApplicationException("Fail to authenticate block")

            _sentBuff = New Byte(255) {}
            _recvBuff = New Byte(255) {}

            _sentBuff = APDUCommands.GetBlockValue(block)
            _recvBuffLen = _sentBuff(4) + 2
            _returnCode = ModWinsCard.SCardTransmit(hCard, _ioSendRequest, _sentBuff(0), _sentBuff.Length, _ioSendRequest, _recvBuff(0), _recvBuffLen)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then Throw New ApplicationException("Fail to fetch block value")

            For i = 0 To _recvBuffLen - 2
                value = value & Convert.ToChar(_recvBuff(i))
            Next

            Return value
        End Function

        Public Sub UpdateBlockValue(ByVal block As Integer, ByVal value As String, ByVal hCard As Integer)
            _returnCode = AuthenticateBlock(block, hCard)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then Throw New ApplicationException("Fail to authenticate block")

            _recvBuffLen = &H2

            _sentBuff = New Byte(255) {}
            _recvBuff = New Byte(255) {}

            _sentBuff = APDUCommands.SetBlockValue(value, block)

            _returnCode = ModWinsCard.SCardTransmit(hCard, _ioSendRequest, _sentBuff(0), _sentBuff.Length, _ioSendRequest, _recvBuff(0), _recvBuffLen)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS Or _recvBuff(0).ToString("X2") <> "90") Then Throw New ApplicationException("Fail to update block value", New ApplicationException(ModWinsCard.GetScardErrMsg(_returnCode)))
        End Sub

        Private Function AuthenticateBlock(ByVal block As Integer, ByVal hCard As Integer) As Integer
            _ioSendRequest = New SCARD_IO_REQUEST()
            _ioSendRequest.dwProtocol = ModWinsCard.SCARD_PROTOCOL_UNDEFINED
            _ioSendRequest.cbPciLength = 8

            _recvBuffLen = &H2

            _sentBuff = New Byte(255) {}
            _recvBuff = New Byte(255) {}

            _sentBuff = APDUCommands.AuthenticateBlock(block)

            Return ModWinsCard.SCardTransmit(hCard, _ioSendRequest, _sentBuff(0), _sentBuff.Length, _ioSendRequest, _recvBuff(0), _recvBuffLen)
        End Function

        Private Function GetRID(ByVal ridBytes As IEnumerable(Of Byte)) As String
            Return ridBytes.Aggregate("", Function(current, ridByte) current & String.Format("{0:X2}", ridByte))
        End Function
    End Class
End Namespace