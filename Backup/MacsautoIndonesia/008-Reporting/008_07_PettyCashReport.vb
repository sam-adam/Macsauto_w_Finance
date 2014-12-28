Public Class _008_07_PettyCashReport

    Private Sub LoadReport(ByVal from As DateTime, ByVal until As DateTime)
        DataGridView.Rows.Clear()

        Dim query As String = "SELECT date as nowdate, rmrk, type, ref, amt, " & _
                              " IFNULL((SELECT " & _
                              "     (SELECT SUM(amt) FROM pettycash WHERE date <= nowdate and type = 'In')" & _
                              "      - (SELECT SUM(amt) FROM pettycash WHERE date <= nowdate and type = 'Out')), 0) AS balance" & _
                              " FROM pettycash" & _
                              " WHERE date BETWEEN '" & from.ToString("yyyy-MM-dd 00:00:00") & "' AND '" & until.ToString("yyyy-MM-dd 23:59:59") & "'"

        reader = ExecQueryReader(query)

        If reader.HasRows Then
            While reader.Read()
                DataGridView.Rows.Add(reader(0).ToString() _
                                      , reader(1).ToString() _
                                      , reader(2).ToString() _
                                      , reader(3).ToString() _
                                      , String.Format("Rp {0:N}", If(reader(2).ToString().ToLowerInvariant() = "in", reader(4), 0)) _
                                      , String.Format("Rp {0:N}", If(reader(2).ToString().ToLowerInvariant() = "out", reader(4), 0)) _
                                      , String.Format("Rp {0:N}", reader(5)))
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

    Private Sub _008_06_PettyCashReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click
        excelExport(DataGridView, "PettyCashReport (" & DateTimePicker1.Value.ToString("ddMMyyyy") & " - " & DateTimePicker2.Value.ToString("ddMMyyyy") & ")")
    End Sub
End Class