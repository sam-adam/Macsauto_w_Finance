Imports System.IO
Imports Microsoft.Office.Interop.Excel

Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class GLAccountImporter
    Inherits CommandLine

    Private _fileName As String = ""
    Private _sheetName As String = ""
    Private _glNumColIdx As String = ""
    Private _glDesColIdx As String = ""
    Private _actIdColIdx As String = ""
    Private _isPnLColIdx As String = ""
    Private _glStaColIdx As String = ""

    Public Overrides Sub Run()
        Dim temp As String

        Console.Clear()
        Console.WriteLine("MACSAUTO GL ACCOUNT IMPORTER CLI")
        Console.WriteLine("================================")

        _fileName = AskInput(_fileName, "Excel filepath")
        _sheetName = AskInput(_sheetName, "Sheet name")
        _glNumColIdx = AskInput(_glNumColIdx, "GLNum Column", "[A-Z]").ToUpperInvariant()
        _glDesColIdx = AskInput(_glDesColIdx, "GLDes Column", "[A-Z]").ToUpperInvariant()
        _actIdColIdx = AskInput(_actIdColIdx, "ActId Column", "[A-Z]").ToUpperInvariant()
        _isPnLColIdx = AskInput(_isPnLColIdx, "IsPnL Column", "[A-Z]").ToUpperInvariant()
        _glStaColIdx = AskInput(_glStaColIdx, "GLSta Column", "[A-Z]").ToUpperInvariant()

        Try
            Console.WriteLine("Importing....")

            DoImport(True)

            Console.WriteLine("GLAccount imported!")
        Catch ex As Exception
            Console.WriteLine("Exception occured:")
            Console.WriteLine(ex.Message)
        Finally
            ExitCli()
        End Try
    End Sub

    Private Function AskInput(ByRef variable As String, ByVal message As String, Optional ByVal secondaryMessage As String = "") As String
        Dim temp As String

        Do While String.IsNullOrEmpty(variable)
            Console.Write("{0,-20}{1,-30}{2,-1}", message, secondaryMessage, ": ")

            temp = Console.ReadLine()

            If String.IsNullOrEmpty(temp) Then
                Console.WriteLine("Input needed!")

                Return ""
            Else
                Return temp
            End If
        Loop

        Return ""
    End Function

    Private Sub DoImport(ByVal skipHeader As Boolean)
        Dim query As String = "INSERT INTO `glaccountms` VALUES "
        Dim excel As Application = New Application()
        Dim wb As Workbook = excel.Workbooks.Open(_fileName)
        Dim ws As Worksheet = wb.Sheets.Item(_sheetName)
        Dim allValues As Object(,) = ws.UsedRange.Value2

        wb.Close(False)

        For rowIdx As Integer = IIf(skipHeader, 2, 1) To allValues.GetLength(0)
            Dim glNum As String = allValues(rowIdx, Asc(_glNumColIdx) - 64)
            Dim glDes As String = allValues(rowIdx, Asc(_glDesColIdx) - 64)
            Dim actId As String = allValues(rowIdx, Asc(_actIdColIdx) - 64)
            Dim isPnL As String = allValues(rowIdx, Asc(_isPnLColIdx) - 64)
            Dim glSta As String = allValues(rowIdx, Asc(_glStaColIdx) - 64)

            If Not rowIdx = IIf(skipHeader, 2, 1) Then
                query &= ", "
            End If

            If Not String.IsNullOrEmpty(glNum) And Not String.IsNullOrEmpty(glDes) And Not String.IsNullOrEmpty(actId) Then
                query &= "('" & glNum & "', '" & glDes & "', '" & actId & "', '" & isPnL & "', '" & glSta & "')"
            End If
        Next

        Dim connection As MySqlConnection = New MySqlConnection(String.Format(ConnectionStringFormat, My.Settings.DatabaseHost, My.Settings.DatabaseUser, My.Settings.DatabasePass, My.Settings.DatabaseName))

        connection.Open()

        Dim command As MySqlCommand = New MySqlCommand(query, connection)

        command.ExecuteReader()
        connection.Close()
    End Sub
End Class
