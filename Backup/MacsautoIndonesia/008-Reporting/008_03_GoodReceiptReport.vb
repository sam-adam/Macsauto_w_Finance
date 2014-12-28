Public Class _008_03_GoodReceiptReport
    Private Sub _008_03_GoodReceiptReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub LoadReport(ByVal from As DateTime, ByVal until As DateTime)
        DataGridView.Rows.Clear()

        Dim query As String = "SELECT h.pmvid AS Id, h.mdate AS MovementDate, h.redoc AS Reference, h.reamv AS Reason, d.idpdt AS ProductId, p.pdtds AS ProductDesc, d.ppdtqty, d.mvqty AS MovementQty, d.mpric AS MovementPrice FROM hpmovement h LEFT JOIN dpmovement d ON h.pmvid = d.pmvid LEFT JOIN hproduct p ON d.idpdt = p.idpdt WHERE h.mtype = 'Goods Receipt' AND h.mdate BETWEEN '" & from.ToString("yyyy-MM-dd") & "' AND '" & until.ToString("yyyy-MM-dd") & "'"

        reader = ExecQueryReader(query)

        If reader.HasRows Then
            While reader.Read()
                DataGridView.Rows.Add(reader(0).ToString(), reader(1).ToString(), reader(2).ToString(), reader(3).ToString(), reader(4).ToString(), reader(5).ToString(), reader(6).ToString(), reader(7).ToString(), reader(8).ToString())
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
        excelExport(DataGridView, "GoodReceiptReport (" & DateTimePicker1.Value.ToString("ddMMyyyy") & " - " & DateTimePicker2.Value.ToString("ddMMyyyy") & ")")
    End Sub
End Class