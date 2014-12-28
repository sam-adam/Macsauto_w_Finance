Imports System.Text
Imports System.IO
Imports System.Drawing.Printing

Public Module PrintModule
    Const PrinterName As String = "KX-MB772CX"

    Dim _printDocument As PrintDocument
    Dim _printFont As Font
    Dim _streamToPrint As StreamReader

    Public Sub Print(ByVal code As String, ByVal text As String)
        Try
            _streamToPrint = New StreamReader(WriteToFile(code, text))

            Try
                _printDocument = New PrintDocument()
                _printFont = New Font("Arial", 10)

                AddHandler _printDocument.PrintPage, AddressOf printDocument_PrintPage

                _printDocument.PrinterSettings.PrinterName = PrinterName
                _printDocument.Print()
            Finally
                _streamToPrint.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub printDocument_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim count As Integer = 0
        Dim yPos As Single = 0
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim line As String = Nothing

        linesPerPage = e.MarginBounds.Height / _printFont.GetHeight(e.Graphics)

        While count < linesPerPage
            line = _streamToPrint.ReadLine()

            If line Is Nothing Then
                Exit While
            End If

            yPos = topMargin + count * _printFont.GetHeight(e.Graphics)

            e.Graphics.DrawString(line, _printFont, Brushes.Black, leftMargin, yPos, New StringFormat())

            count += 1
        End While

        e.HasMorePages = line IsNot Nothing
    End Sub

    Public Function WriteToFile(ByVal filename As String, ByVal content As String) As String
        Dim streamWriter As StreamWriter
        Dim fullpath As String

        fullpath = Application.StartupPath & "\" & filename.Replace("/", "") & ".txt"
        streamWriter = New StreamWriter(fullpath, False, Encoding.UTF8)

        streamWriter.WriteLine(content)
        streamWriter.Close()
        streamWriter.Dispose()

        Return fullpath
    End Function

    Public Function GetPrintHeader() As String
        Dim stringBuilder As StringBuilder

        stringBuilder = New StringBuilder()

        stringBuilder.AppendLine("              MACSAUTO INDONESIA                ")
        stringBuilder.AppendLine("================================================")

        Return stringBuilder.ToString()
    End Function
End Module