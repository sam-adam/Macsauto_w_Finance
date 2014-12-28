Imports System.Text

Namespace SmartCard.Reader
    Public Module APDUCommands
        Public Function GetControl() As Byte()
            Return New Byte() {&HFF, &H0, &H0, &H0, &HA, &HD4, &H56, &H1, &H2, &H1, &H0, &HFF, &H0, &H0}
        End Function

        Public Function GetFirmware() As Byte()
            Return New Byte() {&HFF, &H0, &H48, &H0, &H0}
        End Function

        Public Function GetPICCParams() As Byte()
            Return New Byte() {&HFF, &H0, &H50, &H0, &H0}
        End Function

        Public Function GetBlockValue(ByVal block As Integer) As Byte()
            Return New Byte() {&HFF, &HB0, &H0, CByte(block), &H10}
        End Function

        Public Function SetBlockValue(ByVal text As String, ByVal block As Integer) As Byte()
            Dim bytes = New Byte() {&HFF, &HD6, &H0, CByte(block), &H10}
            Dim stringBytes = Encoding.ASCII.GetBytes(text)

            Dim bytesOriginalLen = bytes.Length

            Array.Resize(bytes, bytes.Length + stringBytes.Length)
            Array.Copy(stringBytes, 0, bytes, bytesOriginalLen, stringBytes.Length)

            Return bytes
        End Function

        Public Function GetIntValue(ByVal block As Integer) As Byte()
            Return New Byte() {&HFF, &HB0, &H0, CByte(block), &H0}
        End Function

        Public Function AuthenticateBlock(ByVal block As Integer) As Byte()
            Return New Byte() {&HFF, &H86, &H0, &H0, &H5, &H1, &H0, CByte(block), &H60, &H1}
        End Function

        Public Function SetPICCParams(ByVal piccParams As PICCParams)
            Return piccParams.GetParams()
        End Function
    End Module

    Public Class PICCParams
        Private _params As Byte() = New Byte() {&HFF, &H0, &H51, &H0, &H0}

        Public Function GetParams() As Byte()
            Return _params
        End Function

        Public Function DetectISO14443TypeACard() As PICCParams
            _params(3) = CByte((_params(3) Or &H1))

            Return Me
        End Function

        Public Function DetectISO14443TypeBCard() As PICCParams
            _params(3) = CByte((_params(3) Or &H2))

            Return Me
        End Function

        Public Function DetectTopazCard() As PICCParams
            _params(3) = CByte((_params(3) Or &H4))

            Return Me
        End Function

        Public Function DetectFeliCa212KCard() As PICCParams
            _params(3) = CByte((_params(3) Or &H8))

            Return Me
        End Function

        Public Function DetectFeliCa424KCard() As PICCParams
            _params(3) = CByte((_params(3) Or &H10))

            Return Me
        End Function

        Public Function SetPollInterval250() As PICCParams
            _params(3) = CByte((_params(3) Or &H20))

            Return Me
        End Function

        Public Function EnableAutomaticATSGeneration() As PICCParams
            _params(3) = CByte((_params(3) Or &H40))

            Return Me
        End Function

        Public Function EnableAutomaticPICCPolling() As PICCParams
            _params(3) = CByte((_params(3) Or &H80))

            Return Me
        End Function
    End Class
End Namespace