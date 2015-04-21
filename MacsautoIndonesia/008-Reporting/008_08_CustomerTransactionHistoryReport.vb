Public Class _008_08_CustomerTransactionHistoryReport
    Private ReadOnly _allTransactionDataTable As DataTable
    Private ReadOnly _allCustomerDataTable As DataTable
    Private ReadOnly _transactionPreviewerForm As Form
    Private ReadOnly _transactionPreviewer As _005_14_TransactionDetail
    Private ReadOnly _redemptionPreviewerForm As Form
    Private ReadOnly _redemptionPreviewer As _005_18_RedemptionDetail

    Public Sub New()
        InitializeComponent()

        _allTransactionDataTable = New DataTable()
        _allCustomerDataTable = New DataTable()

        _allCustomerDataTable.Load(ExecQueryReader("SELECT idcus, cname FROM hcustomer"))

        CustomerCbo.DataSource = _allCustomerDataTable
        CustomerCbo.AutoCompleteSource = AutoCompleteSource.ListItems
        CustomerCbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CustomerCbo.DisplayMember = "cname"
        CustomerCbo.ValueMember = "idcus"

        _transactionPreviewerForm = New Form()
        _transactionPreviewer = New _005_14_TransactionDetail()

        _redemptionPreviewerForm = New Form()
        _redemptionPreviewer = New _005_18_RedemptionDetail()

        Dim transactionPanel As Panel = New Panel()

        transactionPanel.Controls.Add(_transactionPreviewer)
        transactionPanel.Dock = DockStyle.Fill
        
        _transactionPreviewer.PerformBinding()

        With _transactionPreviewerForm
            .Controls.Add(transactionPanel)

            .Size = _transactionPreviewer.Size
            .MaximumSize = _transactionPreviewer.Size
            .MinimumSize = _transactionPreviewer.Size
            .SizeGripStyle = SizeGripStyle.Hide
        End With

        Dim redemptionPanel As Panel = New Panel()

        redemptionPanel.Controls.Add(_redemptionPreviewer)
        redemptionPanel.Dock = DockStyle.Fill

        _redemptionPreviewer.PerformBinding()

        With _redemptionPreviewerForm
            .Controls.Add(redemptionPanel)

            .Size = _redemptionPreviewer.Size
            .MaximumSize = _redemptionPreviewer.Size
            .MinimumSize = _redemptionPreviewer.Size
            .SizeGripStyle = SizeGripStyle.Hide
        End With

        Dim viewDetailToolItem As ToolStripMenuItem = New ToolStripMenuItem("View detail")

        AddHandler viewDetailToolItem.Click,
            Sub()
                If DataGridView(TransactionTypeCol.Index, DataGridView.CurrentRow.Index).Value = "transaction" Then
                    _transactionPreviewer.FindTransaction(DataGridView(TransactionIdCol.Index, DataGridView.CurrentRow.Index).Value)
                    _transactionPreviewerForm.ShowDialog(Me)
                ElseIf DataGridView(TransactionTypeCol.Index, DataGridView.CurrentRow.Index).Value = "redemption" Then
                    _redemptionPreviewer.FindRedemption(DataGridView(TransactionIdCol.Index, DataGridView.CurrentRow.Index).Value)
                    _redemptionPreviewerForm.ShowDialog(Me)
                End If
            End Sub

        DataGridView.AddContextMenuItem({viewDetailToolItem})

        FromDtp.Value = Date.Now.Subtract(TimeSpan.FromDays(7))
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
                "       `htransaction`.`toamt` AS `transaction_total`, " & _
                "       `htransaction`.`cpoin` AS `current_poin`, " & _
                "       CONCAT('+', `htransaction`.`tpoin`) AS `point_transaction`, " & _
                "       `employee`.`name` AS `cashier` " & _
                "   FROM " & _
                "       `htransaction` " & _
                "   LEFT JOIN " & _
                "       `employee` ON `htransaction`.`createdBy` = `employee`.`id` " & _
                "   WHERE " & _
                "       `htransaction`.`idcus` = '" & CustomerCbo.SelectedValue.ToString() & "' " & _
                "           AND DATE(`htransaction`.`trdat`) BETWEEN '" & FromDtp.Value.ToString("yyyy-MM-dd") & "' AND '" & ToDtp.Value.ToString("yyyy-MM-dd") & "' UNION SELECT " & _
                "       'redemption' AS `transaction_type`, " & _
                "       `hredemption`.`rdmpid` AS `transaction_id`, " & _
                "       `hredemption`.`rdmpdat` AS `transaction_date`, " & _
                "       `hredemption`.`tpoin` AS `transaction_total`, " & _
                "       `hredemption`.`cpoin` AS `current_poin`, " & _
                "       CONCAT('-', `hredemption`.`tpoin`) AS `point_transaction`, " & _
                "       `employee`.`name` AS `cashier` " & _
                "   FROM " & _
                "       `hredemption` " & _
                "   LEFT JOIN " & _
                "       `employee` ON `hredemption`.`createdBy` = `employee`.`id` " & _
                "   WHERE " & _
                "       `hredemption`.`idcus` = '" & CustomerCbo.SelectedValue.ToString() & "' " & _
                "           AND DATE(`hredemption`.`rdmpdat`) BETWEEN '" & FromDtp.Value.ToString("yyyy-MM-dd") & "' AND '" & ToDtp.Value.ToString("yyyy-MM-dd") & "') `temp` " & _
                "ORDER BY `transaction_date` DESC"

            _allTransactionDataTable.Load(ExecQueryReader(query))

            With DataGridView
                .AutoGenerateColumns = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                .DataSource = _allTransactionDataTable

                .RowBackgroundColorAssesment =
                    Function(row As DataGridViewRow)
                        Dim pointValue As String = row.Cells(PointTransactionCol.Index).Value.ToString()

                        If pointValue.Substring(0, 1) = "+" AndAlso Integer.Parse(pointValue.Substring(1)) > 0 Then
                            Return Color.LightGreen
                        ElseIf pointValue.Substring(0, 1) = "-" Then
                            Return Color.LightPink
                        Else
                            Return Nothing
                        End If
                    End Function

                .Columns(TransactionTypeCol.Index).DataPropertyName = "transaction_type"
                .Columns(TransactionIdCol.Index).DataPropertyName = "transaction_id"
                .Columns(TransactionDateCol.Index).DataPropertyName = "transaction_date"
                .Columns(TransactionAmountCol.Index).DataPropertyName = "transaction_total"
                .Columns(CashierCol.Index).DataPropertyName = "cashier"
                .Columns(CurrentPointCol.Index).DataPropertyName = "current_poin"
                .Columns(PointTransactionCol.Index).DataPropertyName = "point_transaction"
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

    Private Sub DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        If DataGridView(TransactionTypeCol.Index, e.RowIndex).Value = "transaction" Then
            _transactionPreviewer.FindTransaction(DataGridView(TransactionIdCol.Index, e.RowIndex).Value)
            _transactionPreviewerForm.ShowDialog(Me)
        ElseIf DataGridView(TransactionTypeCol.Index, e.RowIndex).Value = "redemption" Then
            _redemptionPreviewer.FindRedemption(DataGridView(TransactionIdCol.Index, e.RowIndex).Value)
            _redemptionPreviewerForm.ShowDialog(Me)
        End If
    End Sub

    Private Sub DataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView.KeyDown
        If e.KeyData = Keys.Enter AndAlso DataGridView.Rows.Count > 0 Then
            If DataGridView(TransactionTypeCol.Index, DataGridView.CurrentRow.Index).Value = "transaction" Then
                _transactionPreviewer.FindTransaction(DataGridView(TransactionIdCol.Index, DataGridView.CurrentRow.Index).Value)
                _transactionPreviewerForm.ShowDialog(Me)
            ElseIf DataGridView(TransactionTypeCol.Index, DataGridView.CurrentRow.Index).Value = "redemption" Then
                _redemptionPreviewer.FindRedemption(DataGridView(TransactionIdCol.Index, DataGridView.CurrentRow.Index).Value)
                _redemptionPreviewerForm.ShowDialog(Me)
            End If

            e.SuppressKeyPress = True
        End If
    End Sub
End Class