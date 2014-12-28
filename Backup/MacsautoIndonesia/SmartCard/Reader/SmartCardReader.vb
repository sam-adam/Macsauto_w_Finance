Imports System.Text

Namespace SmartCard.Reader
    Public Class SmartCardReader
        Implements IDisposable

        Private ReadOnly _pollingTimer As Timer
        Private ReadOnly _name As String
        Private ReadOnly _hContext As Integer
        Private ReadOnly _dwControlCode As Integer
        Private _piccParams As PICCParams
        Private _readerCardState As ReaderCardState = ReaderCardState.NO_CARD_DETECTED
        Private _smartCard As Card.SmartCard
        Private _isConnected As Boolean
        Private _isControlled As Boolean
        Private _sentBuffer As Byte()
        Private _receivedBuffer As Byte()
        Private _hCard As Integer
        Private _protocol As Integer
        Private _returnCode As Integer

        Public Event ReaderCardStateChanged As EventHandler(Of ReaderCardStateChangedEventArgs)

        Public Sub New(ByVal name As String, ByVal hContext As Integer)
            _name = name
            _hContext = hContext
            _dwControlCode = CInt(ModWinsCard.IOCTL_CCID_ESCAPE_SCARD_CTL_CODE)

            _isConnected = False
            _isControlled = False

            _pollingTimer = New Timer()

            AddHandler _pollingTimer.Tick, AddressOf _pollingTimer_Tick

            _piccParams = New PICCParams().DetectFeliCa212KCard().DetectFeliCa424KCard().DetectISO14443TypeACard().DetectISO14443TypeBCard().DetectTopazCard().EnableAutomaticATSGeneration().EnableAutomaticPICCPolling().SetPollInterval250()
        End Sub

        Public ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property Firmware() As String
            Get
                _sentBuffer = APDUCommands.GetFirmware()
                _receivedBuffer = New Byte(10) {}
                _receivedBuffer(0) = 0

                Return If(CanControl, Encoding.ASCII.GetString(_receivedBuffer, 0, _receivedBuffer.Length), "")
            End Get
        End Property

        Public ReadOnly Property IsConnected() As Boolean
            Get
                Return _isConnected
            End Get
        End Property

        Public ReadOnly Property IsControlled() As Boolean
            Get
                Return _isControlled
            End Get
        End Property

        Public ReadOnly Property ReaderCardState() As ReaderCardState
            Get
                Return _readerCardState
            End Get
        End Property

        Public ReadOnly Property SmartCard() As Card.SmartCard
            Get
                Return _smartCard
            End Get
        End Property

        Public Property PiccParams() As PICCParams
            Set(ByVal value As PICCParams)
                _piccParams = value
            End Set
            Get
                Return _piccParams
            End Get
        End Property

        Public Sub StartPolling(ByVal interval As Integer)
            _pollingTimer.Interval = interval
            _pollingTimer.Start()
        End Sub

        Public Sub StopPolling()
            _pollingTimer.Stop()
        End Sub

        Public Function GetCardBlockValue(ByVal block As Integer) As String
            Connect()

            If (_smartCard Is Nothing) Then Throw New ApplicationException("No card detected")

            Return _smartCard.GetBlockValue(block, _hCard)
        End Function

        Public Sub UpdateCardBlockValue(ByVal block As Integer, ByVal value As String)
            Connect()

            If (_smartCard Is Nothing) Then Throw New ApplicationException("No card detected")

            _smartCard.UpdateBlockValue(block, value, _hCard)
        End Sub

        Private Function CanControl() As Boolean
            Dim bytesReturned = 0

            If Not IsConnected Then Connect()

            _sentBuffer = APDUCommands.GetControl()
            _receivedBuffer = New Byte(21) {}
            _receivedBuffer(0) = 0

            _isControlled = (ModWinsCard.SCardControl(_hCard, _dwControlCode, _sentBuffer(0), _sentBuffer.Length, _receivedBuffer(0), _receivedBuffer.Length, bytesReturned) = ModWinsCard.SCARD_S_SUCCESS)

            Return _isControlled
        End Function

        Private Sub Connect()
            If (_isConnected) Then
                _returnCode = ModWinsCard.SCardDisconnect(_hCard, ModWinsCard.SCARD_EJECT_CARD)
                _isConnected = False
            End If

            _returnCode = ModWinsCard.SCardConnect(_hContext, _name, ModWinsCard.SCARD_SHARE_SHARED, ModWinsCard.SCARD_PROTOCOL_T0 Or ModWinsCard.SCARD_PROTOCOL_T1, _hCard, _protocol)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then
                _returnCode = ModWinsCard.SCardConnect(_hContext, _name, ModWinsCard.SCARD_SHARE_DIRECT, ModWinsCard.SCARD_PROTOCOL_UNDEFINED, _hCard, _protocol)

                If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS) Then
                    Throw New ApplicationException("Failed to connect to reader" & _name, New ApplicationException(ModWinsCard.GetScardErrMsg(_returnCode)))
                End If
            End If

            _isConnected = True
        End Sub

        Private Sub _pollingTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim readerLen As Integer = 0
            Dim dwState As Integer = 0
            Dim dwProtocol As Integer = 0

            _receivedBuffer = New Byte(32) {}

            Dim atrLen = _receivedBuffer.Length

            Connect()

            _returnCode = ModWinsCard.SCardStatus(_hCard, _name, readerLen, dwState, dwProtocol, _receivedBuffer(0), atrLen)

            If (_returnCode <> ModWinsCard.SCARD_S_SUCCESS And ShouldChangeState(ReaderCardState.NO_CARD_DETECTED)) Then
                _smartCard = Nothing

                OnReaderCardStateChanged(New ReaderCardStateChangedEventArgs(ReaderCardState.NO_CARD_DETECTED))
            Else
                Try
                    Dim card As Card.SmartCard = New Card.SmartCard(atrLen, _receivedBuffer)

                    If (ShouldChangeState(ReaderCardState.CARD_PRESENT)) Then
                        If (_smartCard Is Nothing) Then
                            _smartCard = card
                        Else
                            _smartCard = If(_smartCard.Type = card.Type, _smartCard, card)
                        End If

                        OnReaderCardStateChanged(New ReaderCardStateChangedEventArgs(ReaderCardState.CARD_PRESENT))
                    End If
                Catch ex As Exception
                    _smartCard = Nothing

                    OnReaderCardStateChanged(New ReaderCardStateChangedEventArgs(ReaderCardState.NO_CARD_DETECTED))
                End Try
            End If
        End Sub

        Private Function ShouldChangeState(ByVal currentReaderCardState As ReaderCardState) As Boolean
            Return _readerCardState <> currentReaderCardState
        End Function

        Protected Sub OnReaderCardStateChanged(ByVal e As ReaderCardStateChangedEventArgs)
            _readerCardState = e.ReaderCardState

            RaiseEvent ReaderCardStateChanged(Me, e)
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ModWinsCard.SCardEndTransaction(_hCard, ModWinsCard.SCARD_EJECT_CARD)
            ModWinsCard.SCardReleaseContext(_hContext)
            ModWinsCard.SCardDisconnect(_hCard, ModWinsCard.SCARD_EJECT_CARD)
        End Sub
    End Class
End Namespace