Imports System.Text

Public Class _008_06_BrutoReport
    Private Sub LoadReport(ByVal from As DateTime, ByVal until As DateTime)
        DataGridView.Rows.Clear()

        Dim query As StringBuilder = New StringBuilder()
        Dim totalCar As Integer = 0
        Dim totalMotorcycle As Integer = 0
        Dim totalPayment As Long = 0

        query.Append("SELECT ht.trsid, ht.trdat, ht.linum, ht.toAmt, ht.topay, ht.chnce, emp.name, ht.vtype, ht.vbrnd, ht.vmodl, ht.vsize, ht.vcolr ")
        query.Append("FROM htransaction ht ")
        query.Append("JOIN employee emp ON ht.createdBy = emp.id ")
        query.Append("WHERE ht.trdat BETWEEN '" & from.ToString("yyyy-MM-dd 00:00:00") & "' AND '" & until.ToString("yyyy-MM-dd 23:59:59") & "'")

        reader = ExecQueryReader(query.ToString())

        If reader.HasRows Then
            While reader.Read()
                DataGridView.Rows.Add(reader(0).ToString(), DateTime.Parse(reader(1).ToString()).ToString("dd/MM/yyyy HH:mm:ss"), reader(2).ToString(), String.Format("Rp {0:N}", Integer.Parse(reader(3))), String.Format("Rp {0:N}", Integer.Parse(reader(4))), String.Format("Rp {0:N}", Integer.Parse(reader(5))), reader(6).ToString(), reader(7).ToString(), reader(8).ToString(), reader(9).ToString(), reader(10).ToString(), reader(11).ToString())

                If reader(7).ToString().ToUpper() = "CAR" Then
                    totalCar += 1
                Else
                    totalMotorcycle += 1
                End If

                totalPayment += Long.Parse(reader(3).ToString())
            End While
        End If

        TotalCarLabel.Text = totalCar.ToString()
        TotalMotorcycleLabel.Text = totalMotorcycle.ToString()
        TotalPaymentLabel.Text = String.Format("Total payment: Rp{0:N}", totalPayment)

        Marking(DataGridView)
    End Sub


    Private Sub _008_06_BrutoReport_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub DateTimePicker1_ValueChanged( sender As System.Object,  e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub DateTimePicker2_ValueChanged( sender As System.Object,  e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click
        excelExport(DataGridView, "BrutoReport (" & DateTimePicker1.Value.ToString("ddMMyyyy") & " - " & DateTimePicker2.Value.ToString("ddMMyyyy") & ")")
    End Sub
End Class