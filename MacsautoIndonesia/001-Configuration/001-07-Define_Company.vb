Imports MacsautoIndonesia.EventsModule.Events.Company
Imports MacsautoIndonesia.EventsModule
Imports MacsautoIndonesia.Services
Imports MySql.Data.MySqlClient

Public Class _001_07_Define_Company
    Property Company() As Company

    Public Sub New()
        InitializeComponent()

        Company = CompanyService.GetCurrentCompany()

        CompanyCodeTxt.DataBindings.Add("Text", Company, "Id", False, DataSourceUpdateMode.Never)
        CompanyNameTxt.DataBindings.Add("Text", Company, "Name", False, DataSourceUpdateMode.Never)
        CompanyAddressTxt.DataBindings.Add("Text", Company, "Address", False, DataSourceUpdateMode.Never)
        CompanyCityTxt.DataBindings.Add("Text", Company, "City", False, DataSourceUpdateMode.Never)
        CompanyStreetTxt.DataBindings.Add("Text", Company, "Street", False, DataSourceUpdateMode.Never)
        CompanyPhone1Txt.DataBindings.Add("Text", Company, "Phone1", False, DataSourceUpdateMode.Never)
        CompanyPhone2Txt.DataBindings.Add("Text", Company, "Phone2", False, DataSourceUpdateMode.Never)
        CompanyWebsiteTxt.DataBindings.Add("Text", Company, "Website", False, DataSourceUpdateMode.Never)

        If Company Is Nothing Then
            Add.Visible = True
        Else
            Edit.Visible = True
            CompanyCodeTxt.Enabled = False
        End If
    End Sub

    Private Sub LoadCompanyData()
        reader = ExecQueryReader("SELECT * FROM company")
        While reader.read()
            CompanyCodeTxt.Text = reader(0).ToString
            CompanyNameTxt.Text = reader(1).ToString
            CompanyAddressTxt.Text = reader(2).ToString
            CompanyCityTxt.Text = reader(3).ToString
            CompanyStreetTxt.Text = reader(5).ToString
            CompanyPhone1Txt.Text = reader(6).ToString
            CompanyPhone2Txt.Text = reader(7).ToString
            CompanyWebsiteTxt.Text = reader(8).ToString
        End While
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Add.Click
        ExecQueryNonReader("INSERT into company values('" + CompanyCodeTxt.Text + "','" + CompanyNameTxt.Text + "','" + CompanyAddressTxt.Text + "','" + CompanyCityTxt.Text + ",'','" + CompanyStreetTxt.Text + "','" + CompanyPhone1Txt.Text + "','" + CompanyPhone2Txt.Text + "','" + CompanyWebsiteTxt.Text + "')")
        MsgBox("Company Defined")
        'EventBus.Publish(Of CompanyDataChangedEvent, CompanyDataChangedEventArgs)(Me, New CompanyDataChangedEvent(Me, ))
        Me.Close()
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Edit.Click
        If String.IsNullOrEmpty(CompanyNameTxt.Text) Then
            ErrorInput(CompanyNameTxt, "Company name is required")
        ElseIf String.IsNullOrEmpty(CompanyAddressTxt.Text) Then
            ErrorInput(CompanyAddressTxt, "Company address is required")
        ElseIf String.IsNullOrEmpty(CompanyCityTxt.Text) Then
            ErrorInput(CompanyCityTxt, "Company city is required")
        ElseIf MsgBox("Print footer will change according to new data. Edit company data?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            DoInTransaction(
                Function(command As MySqlCommand)
                    command.CommandText =
                        "UPDATE company SET cmnam = @companyName," & _
                        "   cmadd = @companyAddress," & _
                        "   ccity = @companyCity," & _
                        "   strta = @companyStreet," & _
                        "   phon1 = @companyPhone1," & _
                        "   phon2 = @companyPhone2," & _
                        "   webst = @companyWebsite" & _
                        " WHERE idcmp = @companyId"
                    command.CreateParameter()

                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("companyName", CompanyNameTxt.Text)
                    command.Parameters.AddWithValue("companyAddress", CompanyAddressTxt.Text)
                    command.Parameters.AddWithValue("companyStreet", CompanyStreetTxt.Text)
                    command.Parameters.AddWithValue("companyCity", CompanyCityTxt.Text)
                    command.Parameters.AddWithValue("companyPhone1", CompanyPhone1Txt.Text)
                    command.Parameters.AddWithValue("companyPhone2", CompanyPhone2Txt.Text)
                    command.Parameters.AddWithValue("companyWebsite", CompanyWebsiteTxt.Text)
                    command.Parameters.AddWithValue("companyId", CompanyCodeTxt.Text)

                    command.ExecuteNonQuery()

                    Return True
                End Function)

            MsgBox("Company data updated", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success")

            Company = CompanyService.GetCurrentCompany()

            EventBus.Publish(Of CompanyDataChangedEvent, CompanyDataChangedEventArgs)(Me, New CompanyDataChangedEvent(Me, New CompanyDataChangedEventArgs(Company)))

            Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
End Class