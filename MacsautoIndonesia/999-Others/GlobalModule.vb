Imports System.Runtime.CompilerServices
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.ComponentModel

Module GlobalModule
    Public LoggedInEmployee As Employee
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

    <Extension>
    Public Sub ValidateIntegerInput(ByVal dataGridView As DataGridView, ByVal colIndex As Integer)
        Dim handler =
            Sub(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
                If dataGridView.CurrentCell.ColumnIndex = colIndex Then
                    Dim servicePriceTxt As TextBox = CType(e.Control, TextBox)

                    If Not servicePriceTxt Is Nothing Then
                        AddHandler servicePriceTxt.KeyPress,
                            Sub(txtSender As Object, txtEvt As KeyPressEventArgs)
                                If Not (Char.IsControl(txtEvt.KeyChar) Or Char.IsNumber(txtEvt.KeyChar)) Then
                                    txtEvt.Handled = True
                                ElseIf (AscW(txtEvt.KeyChar) = Keys.Back) And (servicePriceTxt.Text.Length = 1) Then
                                    txtEvt.Handled = True
                                End If
                            End Sub
                    End If
                End If
            End Sub

        AddHandler dataGridView.EditingControlShowing, handler
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
End Module