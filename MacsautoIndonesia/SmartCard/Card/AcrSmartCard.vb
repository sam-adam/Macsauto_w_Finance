Imports System.Runtime.InteropServices

Namespace SmartCard.Card
    <StructLayout(LayoutKind.Sequential)>
    Public Structure AcrSmartCard
        Public Shared connected As Boolean = False
        Public Shared type As String
        Public Shared serialNumber As String

        Public Sub New(ByVal hContext As Integer)
            Dim tagType(1) As Byte
            Dim tagLength As Byte
            Dim tagSerialNumber(20) As Byte

            Dim result As Integer = ACR120U.ACR120_Select(hContext, tagType(0), tagLength, tagSerialNumber(0))

            If result = 0 Then
                connected = True

                Select Case (tagType(0))
                    Case 1 : type = "Mifare Light"
                    Case 2 : type = "Mifare 1K"
                    Case 3 : type = "Mifare 4K"
                    Case 4 : type = "Mifare DESFire"
                    Case 5 : type = "Mifare Ultralight"
                    Case 6 : type = "JCOP30"
                    Case 7 : type = "Shanghai Transport"
                    Case 8 : type = "MPCOS Combi"
                    Case &H80 : type = "ISO Type B, Calypso"
                End Select

                For i = 0 To tagLength
                    serialNumber &= tagSerialNumber(i).FormatHexToString()
                Next
            End If
        End Sub
    End Structure
End Namespace