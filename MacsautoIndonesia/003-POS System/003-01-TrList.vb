Imports MacsautoIndonesia.Services

Public Class _003_01_TrList
    Const AccountingNotReadyMsg As String = "Autopost configuration is invalid, please configure autopost accounts"

    Public Sub New()
        InitializeComponent()

        loadTransactionList()

        Label2.Text = DateTime.Now.ToString("HH:mm:ss")

        Timer1.Interval = 1000
        Timer1.Start()
        Label3.Text = Today.Date
    End Sub

    Public Sub loadTransactionList()
        TrlistGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM HTRANSACTION WHERE trstat = 'Open' OR trstat = 'OPEN' order by trdat,trsid desc")
        While reader.read
            TrlistGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9).ToString, reader(10).ToString, reader(11).ToString, reader(12).ToString, reader(13).ToString, reader(14).ToString, reader(15).ToString, reader(16).ToString, reader(17).ToString, reader(18).ToString)
        End While
        Marking(TrlistGrid)
    End Sub
    Public Sub loadServiceTable()
        _003_02_TrDetail2.ServiceGrid.Rows.Clear()
        reader = ExecQueryReader("select seqnr,a.idsvc,svcdc,trqty,uomdc,price,idisc,rmark from DTransaction A, HService B WHERE A.idsvc = B.idsvc AND TTYPE = 'S' AND a.trsid LIKE '" + TrlistGrid.CurrentRow.Cells(0).Value.ToString + "' ORder by seqnr")
        While reader.read()
            _003_02_TrDetail2.ServiceGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString)
        End While
    End Sub
    Public Sub loadProductTable()
        _003_02_TrDetail2.ProductGrid.Rows.Clear()
        ' reader = ExecQueryReader("select seqnr,a.idpdt,pdtds,trqty,uomdc,idisc,price from DTransaction A, HProduct B WHERE A.idpdt = B.idpdt AND TTYPE = 'P' AND a.trsid LIKE '" + TrlistGrid.CurrentRow.Cells(0).Value.ToString + "' ORder by seqnr")
        reader = ExecQueryReader("select seqnr,a.idpdt,pdtds,trqty,uomdc,idisc,price,C.slqty,uomdc from DTransaction A, HProduct B,DProduct C WHERE A.idpdt = B.idpdt AND B.idpdt = C.idpdt AND TTYPE = 'P'AND c.defsl = 'True' and a.trsid LIKE '" + TrlistGrid.CurrentRow.Cells(0).Value.ToString + "' ORder by seqnr")

        While reader.read()
            _003_02_TrDetail2.ProductGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(6).ToString, reader(5).ToString, reader(7).ToString, reader(8).ToString)
        End While
    End Sub

    Private Sub TrListDisplaybtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrListDisplaybtn.Click
        If TrlistGrid.Rows.Count <> 0 Then
            _003_02_TrDetail2.TextBox4.Text = TrlistGrid.CurrentRow.Cells(0).Value.ToString
            _003_02_TrDetail2.cNumber.Text = TrlistGrid.CurrentRow.Cells(2).Value.ToString
            _003_02_TrDetail2.vType.Text = TrlistGrid.CurrentRow.Cells(3).Value.ToString
            _003_02_TrDetail2.vBrand.Text = TrlistGrid.CurrentRow.Cells(4).Value.ToString
            _003_02_TrDetail2.vModel.Text = TrlistGrid.CurrentRow.Cells(5).Value.ToString
            _003_02_TrDetail2.vColor.Text = TrlistGrid.CurrentRow.Cells(6).Value.ToString
            _003_02_TrDetail2.vSize.Text = TrlistGrid.CurrentRow.Cells(7).Value.ToString
            _003_02_TrDetail2.vKilo.Text = TrlistGrid.CurrentRow.Cells(8).Value.ToString
            _003_02_TrDetail2.vNumber.Text = TrlistGrid.CurrentRow.Cells(9).Value.ToString
            _003_02_TrDetail2.vExpDate.Value = TrlistGrid.CurrentRow.Cells(10).Value.ToString()
            _003_02_TrDetail2.totalService.Text = TrlistGrid.CurrentRow.Cells(11).Value.ToString()
            _003_02_TrDetail2.totalProduct.Text = TrlistGrid.CurrentRow.Cells(12).Value.ToString()
            _003_02_TrDetail2.GrandTotal.Text = TrlistGrid.CurrentRow.Cells(13).Value.ToString()
            loadServiceTable()
            loadProductTable()

            _003_02_TrDetail2.Column3.DefaultCellStyle.BackColor = Color.LightGray
            _003_02_TrDetail2.Column5.DefaultCellStyle.BackColor = Color.LightGray


            _003_02_TrDetail2.DataGridViewTextBoxColumn3.DefaultCellStyle.BackColor = Color.LightGray
            _003_02_TrDetail2.DataGridViewTextBoxColumn4.DefaultCellStyle.BackColor = Color.LightGray
            _003_02_TrDetail2.ShowDialog()
        End If

    End Sub

    Private Sub TrListViewPayBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrListViewPayBtn.Click
        If TrlistGrid.Rows.Count <> 0 Then
            _003_03_TrViewPayment.DataGridView1.Rows.Clear()
            reader = ExecQueryReader("SELECT * FROM payment where trsid like '" + TrlistGrid.CurrentRow.Cells(0).Value.ToString + "'")
            While reader.read
                _003_03_TrViewPayment.DataGridView1.Rows.Add(reader(0).ToString, reader(1).ToString, "Rp. " & toCurrencyFormat(reader(2).ToString), reader(3).ToString)
            End While
            Marking(_003_03_TrViewPayment.DataGridView1)
            _003_03_TrViewPayment.ShowDialog()
        End If
    End Sub

    Private Sub ExportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportBtn.Click
        If TrlistGrid.Rows.Count <> 0 Then
            If MsgBox("Export Transaction List?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                'exportToExcel(TrlistGrid, "List")
                excelExport(TrlistGrid)
            End If
        Else
            MsgBox("No Data to be exported")
        End If

    End Sub

    Private Sub RefreshBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.Click
        loadTransactionList()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TrlistGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM HTRANSACTION WHERE trstat LIKE 'PAID' order by trdat,trsid desc")
        While reader.read
            TrlistGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9).ToString, reader(10).ToString, reader(11).ToString, reader(12).ToString, reader(13).ToString, reader(14).ToString, reader(15).ToString, reader(16).ToString, reader(17).ToString, reader(18).ToString)
        End While
        Marking(TrlistGrid)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            loadTransactionList()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TrlistGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM HTRANSACTION order by trdat,trsid desc")
        While reader.read
            TrlistGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9).ToString, reader(10).ToString, reader(11).ToString, reader(12).ToString, reader(13).ToString, reader(14).ToString, reader(15).ToString, reader(16).ToString, reader(17).ToString, reader(18).ToString)
        End While
        Marking(TrlistGrid)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles NewTransactionBtn.Click
        If Not TransactionService.IsAutopostReady() Then
            MsgBox(AccountingNotReadyMsg, MsgBoxStyle.Critical Or vbOKOnly, "Warning")

            Dim accountingConfiguration As _001_19_Accounting_Configuration = New _001_19_Accounting_Configuration()

            accountingConfiguration.ShowDialog(Me)
        Else
            Dim trDetail As _003_07_TrDetail2 = New _003_07_TrDetail2(PointOfSalesMode.NewTransaction)

            AddHandler trDetail.TransactionUpdated,
                Sub()
                    loadTransactionList()
                End Sub

            trDetail.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles UpdateTransactionBtn.Click
        If Not TransactionService.IsAutopostReady() Then
            MsgBox(AccountingNotReadyMsg, MsgBoxStyle.Critical Or vbOKOnly, "Warning")

            Dim accountingConfiguration As _001_19_Accounting_Configuration = New _001_19_Accounting_Configuration()

            accountingConfiguration.ShowDialog(Me)
        Else
            Dim trDetail As _003_07_TrDetail2 = New _003_07_TrDetail2(PointOfSalesMode.ExistingTransaction, TrlistGrid.CurrentRow.Cells(0).Value)

            AddHandler trDetail.TransactionUpdated,
                Sub()
                    loadTransactionList()
                End Sub

            trDetail.ShowDialog()
        End If
    End Sub

    Private Sub TrlistGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TrlistGrid.CellDoubleClick
        If Not TransactionService.IsAutopostReady() Then
            MsgBox(AccountingNotReadyMsg, MsgBoxStyle.Critical Or vbOKOnly, "Warning")

            Dim accountingConfiguration As _001_19_Accounting_Configuration = New _001_19_Accounting_Configuration()

            accountingConfiguration.ShowDialog(Me)
        Else
            Dim trDetail As _003_07_TrDetail2 = New _003_07_TrDetail2(PointOfSalesMode.ExistingTransaction, TrlistGrid.CurrentRow.Cells(0).Value)

            AddHandler trDetail.TransactionUpdated,
                Sub()
                    loadTransactionList()
                End Sub

            trDetail.ShowDialog()
        End If
    End Sub
End Class