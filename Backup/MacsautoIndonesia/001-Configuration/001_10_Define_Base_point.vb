Public Class _001_10_Define_Base_point
    Private Sub LoadCompanyData()
        reader = ExecQueryReader("SELECT * FROM company")
        While reader.read()
            CompCode.Text = reader(0).ToString
            CompName.Text = reader(1).ToString
        End While
    End Sub
    Private Sub getPoint()
        reader = ExecQueryReader("select pbase from basePoint")
        If reader.hasrows Then
            reader.read()
            basePoint.Text = reader(0).ToString
        Else
            MsgBox("No base point defined")
            basePoint.Text = "0"
        End If
    End Sub

    Private Sub _001_10_Define_Base_point_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCompanyData()
        getPoint()
    End Sub

    Private Sub basePoint_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        reader = ExecQueryReader("select pbase from basePoint")
        If MsgBox("Save new base amount for point?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            If reader.hasrows Then
                ExecQueryNonReader("UPDATE basepoint set pbase = '" + basePoint.Text + "' where idcmp like '" + CompCode.Text + "' ")
            Else
                ExecQueryNonReader("INSERT INTO basepoint values('" + CompCode.Text + "','" + basePoint.Text + "')")
            End If
            MsgBox("base amount saved")
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class