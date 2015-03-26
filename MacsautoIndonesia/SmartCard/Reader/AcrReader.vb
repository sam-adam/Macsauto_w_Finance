Imports MacsautoIndonesia.SmartCard.Card

Namespace SmartCard.Reader
    Public Class AcrReader
        Implements IDisposable

        Private ReadOnly _pollingTimer As Timer
        Private ReadOnly _name As String
        Private ReadOnly _hContext As Integer
        Private _readerCardState As ReaderCardState = ReaderCardState.NO_CARD_DETECTED
        Private _firmware As String

        Public Sub New(ByVal hContext As Integer)
            If hContext < 0 Then
                Throw New ApplicationException("Invalid handle")
            End If

            _hContext = hContext
            _name = "ACR120"

            ACR120U.ACR120_Reset(_hContext)

            _pollingTimer = New Timer()

            AddHandler _pollingTimer.Tick, AddressOf _pollingTimer_Tick
        End Sub

        Private Sub _pollingTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Throw New NotImplementedException()
        End Sub

        Public Sub StartPolling(ByVal interval As Integer)
            _pollingTimer.Interval = interval
            _pollingTimer.Start()
        End Sub

        Public Sub StopPolling()
            _pollingTimer.Stop()
        End Sub

        Public Function GetTag() As AcrSmartCard?
            If _hContext = 0 Then
                Return New AcrSmartCard(_hContext)
            Else
                Return Nothing
            End If
        End Function

        Public Function ReadBlock()
            If _hContext = 0 Then
                If GetTag() Is Nothing Then
                    Throw New ApplicationException("No card detected")
                End If


            Else
                Return Nothing
            End If
        End Function

        Public ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property Firmware() As String
            Get
                If String.IsNullOrEmpty(_firmware) Then
                    Dim tempBytes(20) As Byte
                    Dim tempStatus As New ACR120U.tReaderStatus
                    Dim returnCode As Integer

                    returnCode = ACR120U.ACR120_Status(_hContext, tempBytes(0), tempStatus)

                    If returnCode = 0 Then
                        _firmware = System.Text.Encoding.UTF8.GetString(tempBytes)
                        _firmware = _firmware.TrimEnd()
                    Else
                        Throw New ApplicationException(ACR120U.GetErrMsg(returnCode))
                    End If
                End If

                Return _firmware
            End Get
        End Property

        Public ReadOnly Property IsConnected() As Boolean
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property IsControlled() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Sub Dispose() Implements IDisposable.Dispose
            ACR120U.ACR120_Close(_hContext)
        End Sub
    End Class
End Namespace