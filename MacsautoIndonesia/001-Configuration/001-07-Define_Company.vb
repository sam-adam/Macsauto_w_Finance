Public Class _001_07_Define_Company
    Private Sub LoadCompanyData()
        reader = ExecQueryReader("SELECT * FROM company")
        While reader.read()
            CompCode.Text = reader(0).ToString
            CompName.Text = reader(1).ToString
            CompAddress.Text = reader(2).ToString
            CompCity.Text = reader(3).ToString
            street.Text = reader(5).ToString
            phone1.Text = reader(6).ToString
            phone2.Text = reader(7).ToString
            website.Text = reader(8).ToString
        End While

    End Sub
    Private Sub _001_07_Define_Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If getText("SELECT Count(*) from company", 0) <> 0 Then
            Edit.Visible = True
            CompCode.Enabled = False
            LoadCompanyData()
        Else
            Add.Visible = True
        End If
    End Sub
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        ExecQueryNonReader("INSERT into company values('" + CompCode.Text + "','" + CompName.Text + "','" + CompAddress.Text + "','" + CompCity.Text + ",'','" + street.Text + "','" + phone1.Text + "','" + phone2.Text + "','" + website.Text + "')")
        MsgBox("Company Defined")
        Me.Close()
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        ExecQueryNonReader("UPDATE company set strta = '" + street.Text + "',phon1 = '" + phone1.Text + "',phon2 = '" + phone2.Text + "', webst = '" + website.Text + "', cmnam = '" + CompName.Text + "', cmadd = '" + CompAddress.Text + "',ccity='" + CompCity.Text + "' WHERE idcmp LIKE '" + CompCode.Text + "'")
        MsgBox("Company Data modified")
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

  
End Class