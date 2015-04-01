Imports MacsautoIndonesia.SmartCard.Card

Namespace SmartCard.Reader
    Public Class AcrReader
        Implements IDisposable

        Private ReadOnly _pollingTimer As Timer
        Private ReadOnly _name As String
        Private ReadOnly _hContext As Integer
        Private _readerCardState As ReaderCardState = ReaderCardState.NO_CARD_DETECTED
        Private _firmware As String
        Private _dllVersion As String
        Private _lastSector As Integer = -1

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

        Public Function ReadBlock(ByVal block As ACR120_Block)
            If Not [Enum].IsDefined(GetType(ACR120_Block), block) Then
                Throw New ApplicationException("Please use ACR120_Block enum")
            End If

            If _hContext = 0 Then
                If _lastSector = -1 AndAlso Not Login(_lastSector) Then
                    Throw New ApplicationException("Please login to a sector first")
                End If

                Dim result As Integer
                Dim tempBlockData(16) As Byte

                block = block + (_lastSector * 4)

                result = ACR120U.ACR120_Read(_hContext, block, tempBlockData(0))

                If result = 0 Then
                    Return System.Text.Encoding.UTF8.GetString(tempBlockData).Trim()
                Else
                    Throw New ApplicationException(ACR120U.GetErrMsg(result))
                End If
            Else
                Return Nothing
            End If
        End Function

        Public Function WriteBlock(ByVal block As ACR120_Block, ByVal value As String) As Boolean
            If Not [Enum].IsDefined(GetType(ACR120_Block), block) Then
                Throw New ApplicationException("Please use ACR120_Block enum")
            End If

            If _hContext = 0 Then
                If _lastSector = -1 AndAlso Not Login(_lastSector) Then
                    Throw New ApplicationException("Please login to a sector first")
                End If

                block = block + (_lastSector * 4)

                Dim result As Integer
                Dim valueBytes(16) As Byte

                For i = 0 To 15
                    valueBytes(i) = &H0
                Next

                valueBytes = System.Text.Encoding.UTF8.GetBytes(value)

                result = ACR120U.ACR120_Write(_hContext, block, valueBytes(0))

                If result = 0 Then
                    Return True
                Else
                    Throw New ApplicationException(ACR120U.GetErrMsg(result))
                End If
            Else
                Return False
            End If
        End Function

        Public Function Login(ByVal sector As Integer) As Boolean
            GetTag()

            Dim result As Integer
            Dim keys() As Byte = {255, 255, 255, 255, 255, 255}

            result = ACR120U.ACR120_Login(_hContext, sector, ACR120_LoginKeyTypes.ACR120_LOGIN_KEYTYPE_A, 0, keys(0))

            If result = 0 Then
                _lastSector = sector

                Return True
            Else
                Throw New ApplicationException(ACR120U.GetErrMsg(result))
            End If
        End Function

        Public ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property DllVersion()
            Get
                If String.IsNullOrEmpty(_dllVersion) Then
                    Dim tempBytes(40) As Byte
                    Dim tempInfoLen As Byte
                    Dim returnCode As Integer

                    returnCode = ACR120U.ACR120_RequestDLLVersion(tempInfoLen, tempBytes(0))

                    If returnCode = 0 Then
                        _dllVersion = System.Text.Encoding.UTF8.GetString(tempBytes)
                        _dllVersion = _dllVersion.TrimEnd()
                    Else
                        Throw New ApplicationException(ACR120U.GetErrMsg(returnCode))
                    End If
                End If

                Return _dllVersion
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

        Public Sub Dispose() Implements IDisposable.Dispose
            ACR120U.ACR120_Close(_hContext)
        End Sub
    End Class
End Namespace