Public Class _005_09_Search_Member
    Private Sub _005_09_Search_Member_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
        loadTable("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE', cpoin AS 'POINT' FROM HCustomer WHERE cstat = 'Member'", CustomerGrid)
        Marking(CustomerGrid)
    End Sub

    Private Sub cName_TextChanged( sender As System.Object,  e As System.EventArgs) Handles cName.TextChanged
        loadTable("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE', cpoin AS 'POINT' FROM HCustomer WHERE cstat = 'Member' AND cname LIKE '%" + cName.Text + "%'", CustomerGrid)
        Marking(CustomerGrid)
    End Sub

    Private Sub CustomerGrid_CellContentClick( sender As System.Object,  e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CustomerGrid.CellContentClick
        Dim cust As _003_04_TrMerchandiseRedemption = CType(Application.OpenForms("_003_04_TrMerchandiseRedemption"), _003_04_TrMerchandiseRedemption)
        cust.cNumber.Text = Me.CustomerGrid.CurrentRow.Cells(0).Value.ToString
        Me.Close()
    End Sub
End Class