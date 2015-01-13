Public Class FormValidator
    Private ReadOnly _form As Form

    Public Sub New(ByRef form As Form)
        _form = form
    End Sub

    Public Sub Required(ByRef input As Control)

    End Sub

    Public Function Validate() As Boolean

    End Function

    Private Function GetControlAlertName(ByVal input As Control) As String
        If input.GetType() Is GetType(TextBox) Then
            Dim textInput As TextBox = CType(input, TextBox)
            Dim inputName As String = textInput.Name.Replace("Txt", "")

            Return inputName
        ElseIf input.GetType() Is GetType(ComboBox) Then
            Dim textInput As ComboBox = CType(input, ComboBox)
            Dim inputName As String = textInput.Name.Replace("Cbo", "")

            Return inputName
        Else
            Return input.Name
        End If
    End Function
End Class
