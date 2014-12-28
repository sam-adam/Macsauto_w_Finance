Imports System.Security.Cryptography
Imports System.Text

Module HashModule
    Public Function GetMD5(ByVal input As String) As String
        Dim output As String = ""

        Using md5Hash = MD5.Create()
            Dim data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim sBuilder = New StringBuilder

            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next

            output = sBuilder.ToString()
        End Using

        Return output
    End Function
End Module
