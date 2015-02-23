Imports System.Runtime.CompilerServices
Imports System.Globalization
Imports System.ComponentModel
Imports System.Net.Mail

Module ExtensionModule

#Region "DateTime Extensions"
    <Extension()>
    <DebuggerStepThrough()>
    Public Function ToDateTime(ByVal value As String) As DateTime
        Dim parts = value.Split(" ")

        Return IIf(parts.Count() = 2, DateTime.ParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture))
    End Function

    <Extension()>
    <DebuggerStepThrough()>
    Public Function ToMySqlDateTime(ByVal value As DateTime) As String
        Return value.ToString("yyyy-MM-dd HH:mm:ss")
    End Function

    <Extension()>
    <DebuggerStepThrough()>
    Public Function ToLongFriendlyDateTimeFormat(ByVal value As DateTime) As String
        Return value.ToString(LongFriendlyDateTimeFormat)
    End Function
#End Region

#Region "UserControl Extensions"
    <Extension()>
    <DebuggerStepThrough()>
    Public Function SameAsKey(ByVal character As Char, ByVal control As Keys) As Boolean
        Return AscW(character) = control
    End Function

    <Extension>
    <DebuggerStepThrough()>
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
#End Region

    <Extension()>
    Public Function IsIn(ByVal anObject As DockStyle, ByVal listToCompare As DockStyle()) As Boolean
        If listToCompare.Any(Function(item) item = anObject) Then
            Return True
        End If

        Return False
    End Function

    <Extension>
    Public Sub SafeAdd(ByVal collection As ArrayList, ByVal key As String, ByVal value As String)
        Dim needToBeRemoved As List(Of String) = New List(Of String)()

        For Each item As String In collection
            If item.IndexOf(key & "=", StringComparison.Ordinal) = 0 Then
                needToBeRemoved.Add(item)
            End If
        Next

        For Each item As String In needToBeRemoved
            collection.Remove(item)
        Next

        collection.Add(key & "=" & value)
    End Sub

    <Extension>
    <DebuggerStepThrough()>
    Public Function Find(ByVal collection As ArrayList, ByVal key As String) As String
        For Each item As String In collection
            Dim itemExploded As String() = item.Split("=")

            If itemExploded.Count() = 0 Then
                Return Nothing
            Else
                If itemExploded(0) = key Then
                    Return itemExploded(1)
                End If
            End If
        Next

        Return Nothing
    End Function

#Region "Primitive Extensions"
    <Extension>
    <DebuggerStepThrough()>
    Public Function IsOdd(ByVal value As Integer) As Boolean
        Return Not value Mod 2 = 0
    End Function

    <Extension>
    <DebuggerStepThrough()>
    Public Function IsEven(ByVal value As Integer) As Boolean
        Return Not value.IsOdd()
    End Function
#End Region

    <Extension>
    Public Sub Handle(ByVal exception As Exception)
        Dim backgroundWorker As BackgroundWorker = New BackgroundWorker()

        AddHandler backgroundWorker.DoWork,
            Sub(sender As Object, evt As DoWorkEventArgs)
                Dim ex As Exception = CType(evt.Argument, Exception)
                Dim body As String = ex.Message

                body &= Environment.NewLine
                body &= ex.StackTrace

                body &= Environment.NewLine & Environment.NewLine

                body &= "Open Forms:"
                body &= Environment.NewLine

                For Each form As Form In Application.OpenForms
                    body &= form.Name & " - "
                Next

                Dim graph As Graphics
                Dim bmp As Bitmap = New Bitmap(1280, 768)

                graph = Graphics.FromImage(bmp)
                graph.CopyFromScreen(0, 0, 0, 0, New Size(1280, 768))

                Dim path As String = (IO.Path.GetTempPath() & "/" & Guid.NewGuid().ToString() & ".png")
                bmp.Save(path)

                bmp.Dispose()
                graph.Dispose()

                Dim attachment As Attachment = New Attachment(path, "image/png")

                SendMail("Macsauto Auto Exception Report - " & LoggedInEmployee.Company.Name, body, {attachment})
            End Sub

        backgroundWorker.RunWorkerAsync(exception)

        Throw exception
    End Sub
End Module
