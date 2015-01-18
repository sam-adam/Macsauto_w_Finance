Imports MySql.Data.MySqlClient

Namespace Services
    Public Class CompanyService
        Public Shared Function GetCurrentCompany() As Company
            Dim currentCompany As Company = Nothing
            Dim selectQuery As String =
                "SELECT idcmp," & _
                "   cmnam," & _
                "   cmadd," & _
                "   ccity," & _
                "   ccode," & _
                "   strta," & _
                "   phon1," & _
                "   phon2," & _
                "   webst" & _
                " FROM company"

            Dim reader As MySqlDataReader = ExecQueryReader(selectQuery)

            While reader.Read()
                currentCompany = New Company(
                    reader("idcmp").ToString(),
                    reader("cmnam").ToString(),
                    reader("cmadd").ToString(),
                    reader("ccity").ToString())

                currentCompany.Street = reader("strta").ToString()
                currentCompany.Phone1 = reader("phon1").ToString()
                currentCompany.Phone2 = reader("phon2").ToString()
                currentCompany.Website = reader("webst").ToString()
            End While

            Return currentCompany
        End Function
    End Class
End Namespace