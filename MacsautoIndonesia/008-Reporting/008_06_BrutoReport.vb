Imports System.Text

Public Class _008_06_BrutoReport
    Private ReadOnly _allTransactionsDataTable As DataTable
    Private ReadOnly _brutoReportQuery As String =
        "SELECT htransaction.trsid," & _
        "   htransaction.trdat," & _
        "   htransaction.toamt," & _
        "   htransaction.topay," & _
        "   htransaction.chnce," & _
        "   htransaction.linum," & _
        "   htransaction.vtype," & _
        "   htransaction.vbrnd," & _
        "   htransaction.vmodl," & _
        "   htransaction.vsize," & _
        "   htransaction.vcolr," & _
        "   htransaction.svamt," & _
        "   htransaction.pdamt," & _
        "   htransaction.trstat," & _
        "   htransaction.remrk," & _
        "   employee.name" & _
        " FROM htransaction" & _
        " LEFT JOIN employee ON htransaction.createdBy = employee.id" & _
        " WHERE htransaction.trdat BETWEEN '{0}' AND '{1}'"

    Public Sub New()
        InitializeComponent()

        _allTransactionsDataTable = New DataTable()

        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)

        With DataGridView
            .AutoGenerateColumns = False
            .DataSource = _allTransactionsDataTable

            .Columns(IdCol.Index).DataPropertyName = "trsid"
            .Columns(DateCol.Index).DataPropertyName = "trdat"
            .Columns(StatusCol.Index).DataPropertyName = "trstat"
            .Columns(RegistrationNumberCol.Index).DataPropertyName = "linum"
            .Columns(TotalServiceCol.Index).DataPropertyName = "svamt"
            .Columns(TotalProductCol.Index).DataPropertyName = "pdamt"
            .Columns(TotalCostCol.Index).DataPropertyName = "toamt"
            .Columns(TotalPaymentCol.Index).DataPropertyName = "topay"
            .Columns(TotalChangeCol.Index).DataPropertyName = "chnce"
            .Columns(EmployeeCol.Index).DataPropertyName = "name"
            .Columns(VehicleTypeCol.Index).DataPropertyName = "vtype"
            .Columns(VehicleBrandCol.Index).DataPropertyName = "vbrnd"
            .Columns(VehicleModelCol.Index).DataPropertyName = "vmodl"
            .Columns(VehicleSizeCol.Index).DataPropertyName = "vsize"
            .Columns(VehicleColorCol.Index).DataPropertyName = "vcolr"
            .Columns(RemarkCol.Index).DataPropertyName = "remrk"
        End With
    End Sub

    Private Sub LoadReport(ByVal from As DateTime, ByVal until As DateTime)
        _allTransactionsDataTable.Rows.Clear()
        _allTransactionsDataTable.Load(ExecQueryReader(String.Format(_brutoReportQuery, from.ToString("yyyy-MM-dd 00:00:00"), until.ToString("yyyy-MM-dd 23:59:59"))))

        Dim totalPayment = _allTransactionsDataTable.Compute("SUM(toamt)", "")

        If TypeOf totalPayment Is DBNull Then
            totalPayment = 0
        End If

        TotalCarLabel.Text = (_allTransactionsDataTable.Select("vtype = 'Car'").Count())
        TotalMotorcycleLabel.Text = (_allTransactionsDataTable.Select("vtype = 'Motorcycle'").Count())
        TotalPaymentLabel.Text = "Total payment: Rp. " & FormatNumber(totalPayment, 0)

        Marking(DataGridView)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click
        excelExport(DataGridView, "BrutoReport (" & DateTimePicker1.Value.ToString("ddMMyyyy") & " - " & DateTimePicker2.Value.ToString("ddMMyyyy") & ")")
    End Sub
End Class