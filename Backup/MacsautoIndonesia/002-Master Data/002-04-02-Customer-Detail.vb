Public Class _002_04_01_Customer_Detail
    Dim brand As String
    Private Sub LoadVehicleBrand(ByVal query As String)
        vBrand.Items.Clear()
        reader = ExecQueryReader(query)
        While reader.read
            vBrand.Items.Add(reader(0).ToString & "-" & reader(2).ToString())
        End While
    End Sub
    Private Sub LoadVehicleType()
        vType.Items.Clear()
        reader = ExecQueryReader("SELECT * FROM vehiclemODEL where idbrn LIKE '" + vBrand.SelectedItem.ToString.Substring(0, 3) + "'")
        While reader.read
            vType.Items.Add(reader(0).ToString & "-" & reader(2).ToString())
        End While
    End Sub
    Public Sub loadVehicleColor()
        vColor.Items.Clear()
        reader = ExecQueryReader("SELECT * FROM vehicleColor")
        While reader.read
            vColor.Items.Add(reader(0).ToString & "-" & reader(1).ToString())
        End While
    End Sub
    Private Sub clearForm()
        vYear.Text = "0"
        vKilo.Text = "0"
        vType.SelectedIndex = -1
        vBrand.SelectedIndex = -1
        Expdate.Value = Date.Today
        LicensePlate.Clear()
    End Sub
    Private Function getVehicleType()
        If RadioButton1.Checked Then
            Return "Car"
        Else
            Return "Motorcycle"
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clearForm()
    End Sub
    Private Sub vYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vYear.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub vKilo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vKilo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub _002_04_01_Customer_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If RadioButton1.Checked = True Then
            LoadVehicleBrand("SELECT * FROM VEHICLEBRAND WHERE VTYPE LIKE 'CAR'")
        Else
            LoadVehicleBrand("SELECT * FROM VEHICLEBRAND WHERE VTYPE ='MOTORCYCLE'")
        End If
        loadVehicleColor()
    End Sub

    Private Sub vBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vBrand.SelectedIndexChanged
        Try
            LoadVehicleType()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim header As _002_04_Customer = CType(Application.OpenForms("_002_04_Customer"), _002_04_Customer)

        Dim rowIdx = header.cDetailGrid.Rows.Add()

        header.cDetailGrid(0, rowIdx).Value = Me.vBrand.Text.Substring(4, vBrand.Text.Length - 4)
        header.cDetailGrid(1, rowIdx).Value = Me.vType.Text.Substring(7, vType.Text.Length - 7)
        header.cDetailGrid(2, rowIdx).Value = Me.vType.Text.Substring(0, 3)
        header.cDetailGrid(3, rowIdx).Value = Me.vType.Text.Substring(0, 6)
        header.cDetailGrid(6, rowIdx).Value = Me.LicensePlate.Text
        header.cDetailGrid(4, rowIdx).Value = Me.vColor.Text.Substring(0, 3)
        header.cDetailGrid(5, rowIdx).Value = Me.vColor.Text.Substring(4, vColor.Text.Length - 4)
        header.cDetailGrid(7, rowIdx).Value = Me.Expdate.Value.ToString("yyyy-MM-dd")
        header.cDetailGrid(8, rowIdx).Value = Me.vYear.Text
        header.cDetailGrid(9, rowIdx).Value = Me.vKilo.Text
        header.cDetailGrid(10, rowIdx).Value = getVehicleType()
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        LoadVehicleBrand("SELECT * FROM VEHICLEBRAND WHERE VTYPE LIKE 'CAR'")
        clearForm()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        LoadVehicleBrand("SELECT * FROM VEHICLEBRAND WHERE VTYPE ='MOTORCYCLE'")
        clearForm()

    End Sub

    Private Sub vType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vType.SelectedIndexChanged
        GetVehicleSize()
    End Sub

    Private Sub GetVehicleSize()
        reader = ExecQueryReader("SELECT vehicleSize.sizdc FROM vehiclemodel vehicleModel, vehiclesize vehicleSize where vehicleModel.idvmd = '" + vType.SelectedItem.ToString.Substring(0, 6) + "' and vehicleModel.idsiz = vehicleSize.idsiz")
        While reader.read
            LblVehicleSize.Text = reader(0).ToString()
        End While
    End Sub
End Class