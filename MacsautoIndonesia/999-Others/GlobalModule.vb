Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.ComponentModel
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
Imports System.Drawing.Printing
Imports System.Net.Mail
Imports System.Net

Module GlobalModule
    Public LoggedInEmployee As Employee
    Public MySqlDateFormat As String = "yyyy-MM-dd"
    Public MySqlDateTimeFormat As String = "yyyy-MM-dd HH:ii:ss"
    Public LongFriendlyDateTimeFormat As String = "dd MMMM yyyy HH:mm tt"
    Public CurrentDateTimeFormat As String = (DateTimeFormatInfo.CurrentInfo.ShortDatePattern & " " & DateTimeFormatInfo.CurrentInfo.LongTimePattern)
    Public RollPageWidth As Integer = 250

    
    Public Sub SendMail(ByVal subject As String, ByVal body As String, Optional mailAttachments As Attachment() = Nothing)
        Dim smtp As SmtpClient = New SmtpClient()
        Dim mail As MailMessage = New MailMessage()

        smtp.UseDefaultCredentials = False
        smtp.Credentials = New NetworkCredential("sam.testing.purpose.only@gmail.com", "strongpass")
        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587
        smtp.EnableSsl = True

        mail.From = New MailAddress("sam.testing.purpose.only@gmail.com")
        mail.To.Add("samuel.suhendra@gmail.com,surya.wijaya12@gmail.com")
        mail.Subject = subject
        mail.Body = body
        mail.BodyEncoding = Encoding.UTF8

        If Not mailAttachments Is Nothing Then
            For Each mailAttachment As Attachment In mailAttachments
                mail.Attachments.Add(mailAttachment)
            Next
        End If

        Try
            smtp.Send(mail)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub BackupDatabase(ByVal mysqlDumper As String, ByVal database As String, ByVal outputPath As String, ByVal user As String, ByVal password As String)
        Dim ignoredWarnings As String() = {
            "Warning: Using a password on the command line interface can be insecure."
        }
        Dim process As Process = New Process()
        Dim processInfo As ProcessStartInfo = New ProcessStartInfo()
        Dim outputFileName As String = String.Format("{0}_{1:ddMMyyyyHHmmss}.sql", database, DateTime.Now)

        With processInfo
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .CreateNoWindow = True
            .FileName = mysqlDumper
            .Arguments = String.Format("--host=127.0.0.1 --user={0} --password={1} --databases {2}", user, password, database)
        End With

        process.StartInfo = processInfo
        process.Start()

        Dim stringBuilder As StringBuilder = New StringBuilder()

        While Not process.HasExited
            stringBuilder.Append(process.StandardOutput.ReadToEnd())
        End While

        WriteToFile(outputPath & "\" & outputFileName, stringBuilder.ToString())

        Dim errorMessage As String = ignoredWarnings.Aggregate(process.StandardError.ReadToEnd(), Function(current, ignoredWarning) current.Replace(ignoredWarning, ""))

        process.WaitForExit()
        process.Close()

        If Not String.IsNullOrEmpty(errorMessage.Trim()) Then
            Throw New Exception(errorMessage)
        End If
    End Sub

    Public Sub CreateDatabase(ByVal mysql As String, ByVal database As String, ByVal user As String, ByVal password As String)
        Dim ignoredWarnings As String() = {
            "Warning: Using a password on the command line interface can be insecure."
        }
        Dim process As Process = New Process()
        Dim processInfo As ProcessStartInfo = New ProcessStartInfo()

        With processInfo
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .CreateNoWindow = False
            .FileName = mysql
            .Arguments = String.Format("--host=127.0.0.1 --user={0} --password={1} -e 'CREATE DATABASE {2}'", user, password, database)
        End With

        process.StartInfo = processInfo
        process.Start()

        Dim errorMessage As String = ignoredWarnings.Aggregate(process.StandardError.ReadToEnd(), Function(current, ignoredWarning) current.Replace(ignoredWarning, ""))

        process.WaitForExit()
        process.Close()

        If Not String.IsNullOrEmpty(errorMessage.Trim()) Then
            Throw New Exception(errorMessage)
        End If
    End Sub

    Public Sub ImportDatabase(ByVal mysql As String, ByVal database As String, ByVal user As String, ByVal password As String)
        Dim ignoredWarnings As String() = {
            "Warning: Using a password on the command line interface can be insecure."
        }
        Dim process As Process = New Process()
        Dim processInfo As ProcessStartInfo = New ProcessStartInfo()

        With processInfo
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .CreateNoWindow = True
            .FileName = mysql
            .Arguments = String.Format("--host=127.0.0.1 --user={0} --password={1} {2} < '{3}'", user, password, database, Directory.GetCurrentDirectory() & "/macsauto_structure.sql")
        End With

        process.StartInfo = processInfo
        process.Start()

        Dim errorMessage As String = process.StandardError.ReadToEnd()

        process.WaitForExit()
        process.Close()

        If Not String.IsNullOrEmpty(errorMessage.Trim()) Then
            Throw New Exception(errorMessage)
        End If
    End Sub

    Public Sub WriteToFile(ByVal filename As String, ByVal buffer As String)
        Dim fileStream As FileStream = New FileStream(filename, FileMode.Create, FileAccess.Write)

        Using streamWriter As New StreamWriter(fileStream)
            streamWriter.Write(buffer)
            streamWriter.Close()
        End Using

        fileStream.Close()
    End Sub

    Public Sub ErrorInput(ByRef input As Control, ByVal errorMessage As String)
        MsgBox(errorMessage, MsgBoxStyle.Critical, "Error")

        input.Focus()
    End Sub

    Public Function GetMoneyBinding(ByRef bindingSource As IListSource, ByVal field As String) As Binding
        Dim moneyBinding As Binding = New Binding("Text", bindingSource, field)

        AddHandler moneyBinding.Format,
            Sub(sender As Object, e As ConvertEventArgs)
                If e.DesiredType Is GetType(String) Then
                    e.Value = FormatNumber(e.Value.ToString(), 0, TriState.False, TriState.UseDefault)
                End If
            End Sub

        Return moneyBinding
    End Function

    Public Function PrintPage(ByVal caller As Form, ByVal rollPage As RollPage)
        Dim printer As Printer = New Printer(My.Settings.DefaultPrinter)

        Try
            printer.Print(rollPage)
        Catch ex As InvalidPrinterException
            If MsgBox("Printer '" & printer.PrinterName & "'is not available. Choose another printer?", MsgBoxStyle.Critical Or MsgBoxStyle.YesNo, "Printer Error") = MsgBoxResult.Yes Then
                Dim definePrinterForm As _001_11_Set_Printer = New _001_11_Set_Printer()

                AddHandler definePrinterForm.PrinterDefined,
                    Sub()
                        PrintPage(caller, rollPage)
                    End Sub

                definePrinterForm.ShowDialog(caller)
            Else
                MsgBox("Transaction is not printer", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Warning")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
End Module

Structure BootstrapColor
    Public Shared Function Success() As Color
        Return Color.FromArgb(1, 92, 184, 92)
    End Function

    Public Shared Function Danger() As Color
        Return Color.FromArgb(1, 217, 83, 79)
    End Function

    Public Shared Function Primary() As Color
        Return Color.FromArgb(1, 51, 122, 183)
    End Function
End Structure

Public Enum BorderRadius
    None = &H0
    Left = &H2
    Right = &H4
    Top = &H8
    Bottom = &H10
    All = &HF1
End Enum