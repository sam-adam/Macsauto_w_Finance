Public Class _005_06_Customer_Vehicle
   
    Private Sub CustomerVehicle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerVehicle.DoubleClick
        Dim vdetail As _003_01_02_TransactionDetail_Old = CType(Application.OpenForms("_003_01_02_TransactionDetail_Old"), _003_01_02_TransactionDetail_Old)
        vdetail.vType.Text = Me.CustomerVehicle.CurrentRow.Cells(0).Value.ToString
        vdetail.vBrand.Text = Me.CustomerVehicle.CurrentRow.Cells(1).Value.ToString
        vdetail.vModel.Text = Me.CustomerVehicle.CurrentRow.Cells(2).Value.ToString
        vdetail.vColor.Text = Me.CustomerVehicle.CurrentRow.Cells(3).Value.ToString
        vdetail.vSize.Text = Me.CustomerVehicle.CurrentRow.Cells(4).Value.ToString
        vdetail.vKilo.Text = Me.CustomerVehicle.CurrentRow.Cells(5).Value.ToString
        vdetail.vExpDate.Value = Me.CustomerVehicle.CurrentRow.Cells(6).Value.ToString()
        vdetail.vNumber.Text = Me.CustomerVehicle.CurrentRow.Cells(8).Value.ToString()
        vdetail.SizeNumber = Me.CustomerVehicle.CurrentRow.Cells(7).Value.ToString()
        Me.Close()
    End Sub

    Private Sub _005_06_Customer_Vehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Marking(CustomerVehicle)
    End Sub
End Class