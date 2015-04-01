'=======================================================================================
'   Class Form:  ACR120U.vb
'   Company   : Advanced Card System LTD.
'   Author    : Aileen Grace Sarte
'   Date      : July 31, 2006
'   Description : ACR120USB API Class 
'   Revision    :
'                Name                   Date                    Brief Description
'=======================================================================================
Imports System.Runtime.InteropServices

Namespace SmartCard
    Public Class ACR120U
        Public Const ERR_READER_NO_RESPONSE = -5000
        Public Const ERR_ACR120_INTERNAL_UNEXPECTED = -1000
        Public Const ERR_ACR120_PORT_INVALID = -2000
        Public Const ERR_ACR120_PORT_OCCUPIED = -2010
        Public Const ERR_ACR120_HANDLE_INVALID = -2020
        Public Const ERR_ACR120_INCORRECT_PARAM = -2030
        Public Const ERR_ACR120_READER_NO_TAG = -3000
        Public Const ERR_ACR120_READER_READ_FAIL_AFTER_OP = -3010
        Public Const ERR_ACR120_READER_NO_VALUE_BLOCK = -3020
        Public Const ERR_ACR120_READER_OP_FAILURE = -3030
        Public Const ERR_ACR120_READER_UNKNOWN = -3040
        Public Const ERR_ACR120_READER_LOGIN_INVALID_STORED_KEY_FORMAT = -4010
        Public Const ERR_ACR120_READER_WRITE_READ_AFTER_WRITE_ERROR = -4020
        Public Const ERR_ACR120_READER_DEC_FAILURE_EMPTY = -4030
        Public Const ERR_READER_VALUE_INC_OVERFLOW = -4031
        Public Const ERR_READER_VALUE_OP_FAILURE = -4032
        Public Const ERR_READER_VALUE_INVALID_BLOCK = -4033
        Public Const ERR_READER_VALUE_ACCESS_FAILURE = -4034

        Public Shared Function GetErrMsg(ByVal ErrCode As Integer) As String
            Select Case (ErrCode)
                Case -1000 : GetErrMsg = "Unexpected Internal Library Error : -1000"
                Case -2000 : GetErrMsg = "Invalid Port : -2000"
                Case -2010 : GetErrMsg = "Port Occupied by Another Application : -2010"
                Case -2020 : GetErrMsg = "Invalid Handle : -2020"
                Case -2030 : GetErrMsg = "Incorrect Parameter : -2030"
                Case -3000 : GetErrMsg = "No TAG Selected or in Reachable Range : -3000"
                Case -3010 : GetErrMsg = "Read Failed after Operation : -3010"
                Case -3020 : GetErrMsg = "Block doesn't contain value : -3020"
                Case -3030 : GetErrMsg = "Operation Failed : -3030"
                Case -3040 : GetErrMsg = "Unknown Reader Error : -3040"
                Case -4010 : GetErrMsg = "Invalid stored key format in login process : -4010"
                Case -4020 : GetErrMsg = "Reader can't read after write operation : -4020"
                Case -4030 : GetErrMsg = "Decrement Failure (Empty) : -4030"
                Case -4031 : GetErrMsg = "Increment Overflow : -4031"
                Case -4032 : GetErrMsg = "Value Operations failure : -4032"
                Case -4033 : GetErrMsg = "Block doesn't contain value : -4033"
                Case -4034 : GetErrMsg = "Value Access failure : -4034"
                Case Else
                    GetErrMsg = "Error : " & ErrCode
            End Select
        End Function

        <StructLayout(LayoutKind.Sequential)>
        Public Structure tReaderStatus
            '// 0x01 = Type A; 0x02 = Type B; 0x03 = Type A + Type B
            Dim MifareInterfaceType As Byte

            '// Bit 0 = Mifare Light; Bit 1 = Mifare1K; Bit 2 = Mifare 4K; Bit 3 = Mifare DESFire
            '// Bit 4 = Mifare UltraLight; Bit 5 = JCOP30; Bit 6 = Shanghai Transport
            '// Bit 7 = MPCOS Combi; Bit 8 = ISO type B, Calypso
            '// Bit 9 - Bit 31 = To be defined
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
            Dim CardsSupported() As Byte

            ' CardOpMode As Byte '// 0x00 = Type A; 0x01 = Type B TAG is being processed
            '// 0xFF = No TAG is being processed.
            Dim FWI As Byte '// the current FWI value (time out value)
            Dim RFU As Byte ' // To be defined
            Dim RFU2 As Short  '// to be defined
        End Structure

        '------------------------------------------------------------------------------------------
        'Prototype section
        '------------------------------------------------------------------------------------------
        '======================================================================================
        ' READER COMMANDS
        '======================================================================================
        Declare Function ACR120_Open Lib "ACR120U.DLL" (ByVal ReaderPort As ACR120_UsbPorts) As Short
        Declare Function ACR120_Close Lib "ACR120U.DLL" (ByVal hReader As Short) As Short
        Declare Function ACR120_Reset Lib "ACR120U.DLL" (ByVal hReader As Short) As Short
        Declare Function ACR120_Status Lib "ACR120U.DLL" (ByVal hReader As Short, ByRef pFirmwareVersion As Byte, _
                                                          ByRef pReaderStatus As tReaderStatus) As Short
        Declare Function ACR120_ReadRC531Reg Lib "ACR120U.DLL" Alias "ACR120_ReadRC500Reg" (ByVal hReader As Short, _
                                                                                            ByVal RegNo As Byte, _
                                                                                            ByRef pRegData As Byte) As Short
        Declare Function ACR120_WriteRC531Reg Lib "ACR120U.DLL" Alias "ACR120_WriteRC500Reg" (ByVal hReader As Short, _
                                                                                              ByVal RegNo As Byte, _
                                                                                              ByVal RegData As Byte) As Short
        Declare Function ACR120_DirectSend Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                              ByVal DataLength As Byte, _
                                                              ByRef pData As Byte, _
                                                              ByRef pResponseDataLength As Byte, _
                                                              ByRef pResponseData As Byte, _
                                                              ByVal TimedOut As Short) As Short
        Declare Function ACR120_DirectReceive Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                                 ByVal RespectedDataLength As Byte, _
                                                                 ByRef pReceivedDataLength As Byte, _
                                                                 ByRef pReceivedData As Byte, _
                                                                 ByVal TimedOut As Short) As Short
        Declare Function ACR120_RequestDLLVersion Lib "ACR120U.DLL" (ByRef pVersionInfoLen As Byte, _
                                                                     ByRef pVersionInfo As Byte) As Short
        Declare Function ACR120_ReadEEPROM Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                              ByVal RegNo As Byte, _
                                                              ByRef pEEPROMData As Byte) As Short
        Declare Function ACR120_WriteEEPROM Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                               ByVal RegNo As Byte, _
                                                               ByVal eePROMData As Byte) As Short
        Declare Function ACR120_ReadUserPort Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                                ByRef pUserPortState As Byte) As Short
        Declare Function ACR120_WriteUserPort Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                                 ByVal userPortState As Byte) As Short

        '======================================================================================
        ' CARD COMMANDS
        '======================================================================================
        Declare Function ACR120_Select Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                          ByRef pResultTagType As Byte, _
                                                          ByRef pResultTagLength As Byte, _
                                                          ByRef pResultSN As Byte) As Short
        Declare Function ACR120_Login Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                         ByVal sector As Byte, ByVal keyType As ACR120_LoginKeyTypes, _
                                                         ByVal storedNo As Byte, ByRef pKey As Byte) As Short
        Declare Function ACR120_Read Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                        ByVal block As Byte, _
                                                        ByRef pBlockData As Byte) As Short
        Declare Function ACR120_ReadValue Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                             ByVal block As Byte, _
                                                             ByRef pValueData As Integer) As Short
        Declare Function ACR120_Write Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                         ByVal block As Byte, _
                                                         ByRef pBlockData As Byte) As Short
        Declare Function ACR120_WriteValue Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                              ByVal block As Byte, _
                                                              ByVal valueData As Integer) As Short
        Declare Function ACR120_WriteMasterKey Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                                  ByVal keyNo As Byte, _
                                                                  ByRef pKey As Byte) As Short
        Declare Function ACR120_Inc Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                       ByVal Block As Byte, _
                                                       ByVal value As Integer, _
                                                       ByRef pNewValue As Integer) As Short
        Declare Function ACR120_Dec Lib "ACR120U.DLL" (ByVal hReader As Short, ByVal block As Byte, _
                                                       ByVal value As Integer, _
                                                       ByRef pNewValue As Integer) As Short
        Declare Function ACR120_Copy Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                        ByVal srcBlock As Byte, _
                                                        ByVal desBlock As Byte, _
                                                        ByRef pNewValue As Integer) As Short
        Declare Function ACR120_Power Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                         ByVal State As Byte) As Short
        Declare Function ACR120_ListTags Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                            ByRef pNumTagFound As Byte, _
                                                            ByRef pTagType As Byte, _
                                                            ByRef pTagLength As Byte, _
                                                            ByRef pSN As Byte) As Short
        Declare Function ACR120_MultiTagSelect Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                                  ByVal TagLength As Byte, _
                                                                  ByRef SN As Byte, _
                                                                  ByRef pResultTagType As Byte, _
                                                                  ByRef pResultTagLength As Byte, _
                                                                  ByRef pResultSN As Byte) As Short
        Declare Function ACR120_TxDataTelegram Lib "ACR120U.DLL" (ByVal hReader As Short, _
                                                                  ByVal SendDataLength As Byte, _
                                                                  ByRef pSendData As Byte, _
                                                                  ByRef pReceivedDataLength As Byte, _
                                                                  ByRef pReceivedData As Byte) As Short
    End Class

    Public Enum ACR120_UsbPorts
        ACR120_USB1 = 0
        ACR120_USB2 = 1
        ACR120_USB3 = 2
        ACR120_USB4 = 3
        ACR120_USB5 = 4
        ACR120_USB6 = 5
        ACR120_USB7 = 6
        ACR120_USB8 = 7
    End Enum

    Public Enum ACR120_LoginKeyTypes
        ACR120_LOGIN_KEYTYPE_A = &HAA
        ACR120_LOGIN_KEYTYPE_B = &HBB
        ACR120_LOGIN_KEYTYPE_DEFAULT_A = &HAD
        ACR120_LOGIN_KEYTYPE_DEFAULT_B = &HBD
        ACR120_LOGIN_KEYTYPE_DEFAULT_F = &HFD
        ACR120_LOGIN_KEYTYPE_STORED_A = &HAF
        ACR120_LOGIN_KEYTYPE_STORED_B = &HBF
    End Enum

    Public Enum ACR120_Block
        ACR120_BLOCK_0 = 0
        ACR120_BLOCK_1 = 1
        ACR120_BLOCK_2 = 2
        ACR120_BLOCK_3 = 3
    End Enum
End Namespace