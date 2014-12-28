Public Class _005_02_Vehicle_Size

    Private Sub _005_02_Vehicle_Size_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable("SELECT idsiz as'Size #',sizdc as 'Size Description' FROM vehicleSize", vsizeView)
        Marking(vsizeView)
    End Sub

    Private Sub vsizeView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vsizeView.DoubleClick
        Dim vmodel As _001_03_02 = CType(Application.OpenForms("_001_03_02"), _001_03_02)
        vmodel.ModelView.CurrentRow.Cells(2).Value = Me.vsizeView.CurrentRow.Cells(0).Value.ToString & " - " & Me.vsizeView.CurrentRow.Cells(1).Value.ToString
        Me.Close()
    End Sub
End Class