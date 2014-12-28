Imports MySql.Data.MySqlClient

Public Class _008_05_TransactionReport
    Private Sub _008_05_TransactionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub LoadReport(ByVal from As DateTime, ByVal until As DateTime)
        DataGridView.Rows.Clear()

        Dim query As String = "SELECT h.trsid AS Id, h.trdat AS TransactionDate, c.cname AS Customer, h.vtype AS VehicleType, h.vbrnd AS VehicleBrand, h.vmodl AS VehicleModel, h.vsize AS VehicleSize, h.vkmre AS CurrentKM, h.svamt AS TotalService, h.pdamt AS TotalProduct, h.toAmt AS TotalAmount, h.topay AS TotalPayment, h.trstat AS TransactionStatus, d.ttype AS TransactionType, d.idsvc AS Service, d.idpdt AS Product, d.trqty AS TransactionQty, d.price AS Price, d.rmark AS Remark FROM htransaction h LEFT JOIN dtransaction d ON h.trsid = d.trsid LEFT JOIN hcustomer c ON h.idcus = c.idcus WHERE h.trdat BETWEEN '" & from.ToString("yyyy-MM-dd") & "' AND '" & until.ToString("yyyy-MM-dd") & "'"

        Dim reader As MySqlDataReader = ExecQueryReader(query)

        If reader.HasRows Then
            For i As Integer = 0 To reader.FieldCount - 1
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()

                column.Name = reader.GetName(i)
                column.HeaderText = reader.GetName(i)

                DataGridView.Columns.Add(column)
            Next

            While reader.Read()
                DataGridView.Rows.Add(reader(0).ToString(), reader(1).ToString(), reader(2).ToString(), reader(3).ToString(), reader(4).ToString(), reader(5).ToString(), reader(6).ToString(), reader(7).ToString())
            End While
        End If

        Marking(DataGridView)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click
        excelExport(DataGridView, "TransactionReport (" & DateTimePicker1.Value.ToString("ddMMyyyy") & " - " & DateTimePicker2.Value.ToString("ddMMyyyy") & ")")
    End Sub
End Class