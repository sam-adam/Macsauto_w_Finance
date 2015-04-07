Imports System.Runtime.InteropServices

Namespace SmartCard.Card
    <StructLayout(LayoutKind.Sequential)>
    Public Structure AcrSmartCard
        Public Connected As Boolean
        Public Type As String
        Public SerialNumber As String

        Public Sub New(ByVal hContext As Integer)
            Dim tagType(1) As Byte
            Dim tagLength As Byte
            Dim tagSerialNumber(20) As Byte

            Connected = False

            Dim result As Integer = ACR120U.ACR120_Select(hContext, tagType(0), tagLength, tagSerialNumber(0))

            If result = 0 Then
                Connected = True

                Select Case (tagType(0))
                    Case 1 : Type = "Mifare Light"
                    Case 2 : Type = "Mifare 1K"
                    Case 3 : Type = "Mifare 4K"
                    Case 4 : Type = "Mifare DESFire"
                    Case 5 : Type = "Mifare Ultralight"
                    Case 6 : Type = "JCOP30"
                    Case 7 : Type = "Shanghai Transport"
                    Case 8 : Type = "MPCOS Combi"
                    Case &H80 : Type = "ISO Type B, Calypso"
                End Select

                For i = 0 To tagLength
                    SerialNumber &= tagSerialNumber(i).FormatHexToString()
                Next
            End If
        End Sub
    End Structure
End Namespace