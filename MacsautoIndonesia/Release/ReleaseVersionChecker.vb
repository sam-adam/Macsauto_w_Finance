Imports MacsautoIndonesia.My

Namespace Release
    Public Class ReleaseVersionChecker
        Public Sub New()

        End Sub

        Public Function IsNextVersion() As Boolean
            If String.IsNullOrEmpty(Settings.CurrentVersion) Then
                Return True
            ElseIf Not Settings.CurrentVersion = Application.Deployment.CurrentVersion.Revision Then

            End If
        End Function
    End Class
End Namespace