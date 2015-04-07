Public Class _005_05_Search_Customer
    Private Sub _005_05_Search_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE',cstat as 'STATUS' FROM HCustomer", CustomerGrid)
        Marking(CustomerGrid)
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cName.TextChanged
        loadTable("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE',cStat as 'STATUS' FROM HCustomer WHERE cname LIKE '%" + cName.Text + "%'", CustomerGrid)
        Marking(CustomerGrid)
    End Sub
    Private Sub CustomerGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerGrid.DoubleClick
        Dim cust As _003_01_02_TransactionDetail_Old = CType(Application.OpenForms("_003_01_02_TransactionDetail_Old"), _003_01_02_TransactionDetail_Old)
        cust.cNumber.Text = Me.CustomerGrid.CurrentRow.Cells(0).Value.ToString
        cust.cNAme.Text = Me.CustomerGrid.CurrentRow.Cells(1).Value.ToString
        cust.cAddress.Text = Me.CustomerGrid.CurrentRow.Cells(2).Value.ToString
        cust.cPhone.Text = Me.CustomerGrid.CurrentRow.Cells(3).Value.ToString
        cust.cCell.Text = Me.CustomerGrid.CurrentRow.Cells(4).Value.ToString
        If CustomerGrid.CurrentRow.Cells(5).Value = "Non-Member" Then
            cust.isCustomerMember.Checked = False
        Else
            cust.isCustomerMember.Checked = True
        End If
        Me.Close()
    End Sub
End Class