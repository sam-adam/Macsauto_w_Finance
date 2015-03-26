Public Class _008_08_CustomerTransactionHistoryReport
    Private ReadOnly _allTransactionDataTable As DataTable
    Private ReadOnly _allCustomerDataTable As DataTable

    Public Sub New()
        InitializeComponent()

        _allTransactionDataTable = New DataTable()
        _allCustomerDataTable = New DataTable()

        _allCustomerDataTable.Load(ExecQueryReader("SELECT idcus, cname FROM hcustomer"))

        CustomerCbo.DataSource = _allCustomerDataTable
        CustomerCbo.DisplayMember = "cname"
        CustomerCbo.ValueMember = "idcus"
    End Sub

    Private Sub RefreshData()
        _allTransactionDataTable.Rows.Clear()

        If CustomerCbo.SelectedIndex <> -1 Then
            Dim query As String =
                "SELECT " & _
                "   * " & _
                "FROM " & _
                "   (SELECT " & _
                "       'transaction' AS `transaction_type`, " & _
                "       `htransaction`.`trsid` AS `transaction_id`, " & _
                "       `htransaction`.`trdat` AS `transaction_date`, " & _
                "       `htransaction`.`toamt` AS `transaction_total` " & _
                "   FROM " & _
                "       `htransaction` " & _
                "   WHERE " & _
                "       `htransaction`.`idcus` = '" & CustomerCbo.SelectedValue.ToString() & "' " & _
                "           AND DATE(`htransaction`.`trdat`) BETWEEN '" & FromDtp.Value.ToString("yyyy-MM-dd") & "' AND '" & ToDtp.Value.ToString("yyyy-MM-dd") & "' UNION SELECT " & _
                "       'redemption' AS `transaction_type`, " & _
                "       `hredemption`.`rdmpid` AS `transaction_id`, " & _
                "       `hredemption`.`rdmpdat` AS `transaction_date`, " & _
                "       `hredemption`.`tpoin` AS `transaction_total` " & _
                "   FROM " & _
                "       `hredemption` " & _
                "   WHERE " & _
                "       `hredemption`.`idcus` = '" & CustomerCbo.SelectedValue.ToString() & "' " & _
                "           AND DATE(`hredemption`.`rdmpdat`) BETWEEN '" & FromDtp.Value.ToString("yyyy-MM-dd") & "' AND '" & ToDtp.Value.ToString("yyyy-MM-dd") & "') `temp` " & _
                "ORDER BY `transaction_date` DESC"

            _allTransactionDataTable.Load(ExecQueryReader(query))

            With DataGridView
                .AutoGenerateColumns = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                .DataSource = _allTransactionDataTable
                .Columns(TransactionTypeCol.Index).DataPropertyName = "transaction_type"
                .Columns(TransactionIdCol.Index).DataPropertyName = "transaction_id"
                .Columns(TransactionDateCol.Index).DataPropertyName = "transaction_date"
                .Columns(TransactionAmountCol.Index).DataPropertyName = "transaction_total"
            End With
        End If
    End Sub

    Private Sub CustomerCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomerCbo.SelectedIndexChanged
        If CustomerCbo.SelectedIndex <> -1 Then
            RefreshData()
        End If
    End Sub

    Private Sub FromDtp_ValueChanged(sender As Object, e As EventArgs) Handles FromDtp.ValueChanged
        If CustomerCbo.SelectedIndex <> -1 Then
            RefreshData()
        End If
    End Sub

    Private Sub ToDtp_ValueChanged(sender As Object, e As EventArgs) Handles ToDtp.ValueChanged
        If CustomerCbo.SelectedIndex <> -1 Then
            RefreshData()
        End If
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        excelExport(DataGridView, "CustomerHistory - " & CustomerCbo.SelectedValue.ToString() & " -(" & FromDtp.Value.ToString("ddMMyyyy") & " - " & ToDtp.Value.ToString("ddMMyyyy") & ")")
    End Sub
End Class