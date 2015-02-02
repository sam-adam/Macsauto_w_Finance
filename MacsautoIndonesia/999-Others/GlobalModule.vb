﻿Imports System.Runtime.CompilerServices
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.ComponentModel
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
Imports System.Drawing.Printing

Module GlobalModule
#If DEBUG Then
    Public LoggedInEmployee As Employee = New DummyEmployee()
#Else
    Public LoggedInEmployee As Employee
#End If
    Public MySqlDateFormat As String = "yyyy-MM-dd"
    Public MySqlDateTimeFormat As String = "yyyy-MM-dd HH:ii:ss"
    Public LongFriendlyDateTimeFormat As String = "dd MMMM yyyy HH:mm tt"
    Public CurrentDateTimeFormat As String = (DateTimeFormatInfo.CurrentInfo.ShortDatePattern & " " & DateTimeFormatInfo.CurrentInfo.LongTimePattern)
    Public RollPageWidth As Integer = 250

    <Extension()>
    Public Function IsIn(ByVal anObject As DockStyle, ByVal listToCompare As DockStyle()) As Boolean
        If listToCompare.Any(Function(item) item = anObject) Then
            Return True
        End If

        Return False
    End Function

    <Extension()>
    Public Function ToDateTime(ByVal value As String) As DateTime
        Dim parts = value.Split(" ")

        Return IIf(parts.Count() = 2, DateTime.ParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture))
    End Function

    <Extension()>
    Public Function ToMySQLDateTime(ByVal value As DateTime) As String
        Return value.ToString("yyyy-MM-dd HH:mm:ss")
    End Function

    <Extension()>
    Public Function ToLongFriendlyDateTimeFormat(ByVal value As DateTime) As String
        Return value.ToString(LongFriendlyDateTimeFormat)
    End Function

    <Extension()>
    <DebuggerStepThrough()>
    Public Function SameAsKey(ByVal character As Char, ByVal control As Keys) As Boolean
        Return AscW(character) = control
    End Function

    <Extension>
    Public Sub ValidateIntegerInput(ByVal dataGridView As DataGridView, ByVal colIndex As Integer, Optional ByVal maxValue As Integer = 0)
        Dim handler =
            Sub(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
                If dataGridView.CurrentCell.ColumnIndex = colIndex Then
                    Dim txt As TextBox = CType(e.Control, TextBox)

                    IntegerInputHandler(txt, maxValue)
                End If
            End Sub

        AddHandler dataGridView.EditingControlShowing, handler
    End Sub

    <Extension>
    Public Sub ValidateIntegerInput(ByVal txt As TextBox, Optional ByVal maxValue As Integer = 0)
        IntegerInputHandler(txt, maxValue)
    End Sub

    Private Sub IntegerInputHandler(ByVal txt As TextBox, Optional ByVal maxValue As Integer = 0)
        If Not txt Is Nothing Then
            AddHandler txt.KeyPress,
                Sub(txtSender As Object, txtEvt As KeyPressEventArgs)
                    If Not (Char.IsControl(txtEvt.KeyChar) Or Char.IsNumber(txtEvt.KeyChar)) Then
                        txtEvt.Handled = True
                    ElseIf (txtEvt.KeyChar.SameAsKey(Keys.Back)) And (txt.Text.Length = 1) Then
                        txtEvt.Handled = True
                        txt.Text = 0
                    ElseIf Char.IsNumber(txtEvt.KeyChar) AndAlso txt.Text = "0" Then
                        txtEvt.Handled = True
                        txt.Text = Integer.Parse(txtEvt.KeyChar)
                        txt.SelectionStart = 1
                    ElseIf Not maxValue = 0 And Not Char.IsControl(txtEvt.KeyChar) Then
                        Dim inputtedValue As Integer

                        Integer.TryParse(txtEvt.KeyChar, inputtedValue)

                        Dim nextValue As Integer = Integer.Parse(
                            txt.Text.Substring(0, txt.SelectionStart) &
                            inputtedValue.ToString() &
                            txt.Text.Substring(txt.SelectionStart))

                        If nextValue > maxValue Then
                            txtEvt.Handled = True
                        End If
                    End If
                End Sub
        End If
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