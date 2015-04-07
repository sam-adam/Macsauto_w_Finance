Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
Imports System.Drawing.Printing
Imports System.Globalization

Public Class _003_06_Print_Transaction
    Public Sub New()
        InitializeComponent()

        MinimumSize = TransactionDetailView.MinimumSize

        PrintBtn.DataBindings.Add("Enabled", TransactionDetailView, "HasResult", False, DataSourceUpdateMode.Never)
        TransactionDetailView.PerformBinding()
    End Sub

    Private Sub TransactionIdTxt_TextChanged(sender As Object, e As EventArgs) Handles TransactionIdTxt.TextChanged
        TransactionDetailView.FindTransaction(TransactionIdTxt.Text, "PAID")
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Dispose()
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        If TransactionDetailView.TransactionHeaderDataTable.Rows.Count = 0 Then
            MsgBox("No transaction found", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        ElseIf MsgBox("Print transaction?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Dim transactionPage As New TransactionPage(RollPageWidth, New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular))
            Dim transactionTime As DateTime = DateTime.ParseExact(TransactionDetailView.DateTxt.Text, TransactionDetailView.DateTimeFormatUsed, CultureInfo.InvariantCulture)

            transactionPage.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_

            transactionPage.SetTransactionInformation(TransactionIdTxt.Text, TransactionDetailView.VehicleRegLbl.Text, TransactionDetailView.VehicleBrandTxt.Text, TransactionDetailView.VehicleModelTxt.Text, transactionTime.ToString("dd/MM/yyyy"), transactionTime.ToShortTimeString(), LoggedInEmployee.Name)

            For Each row As DataGridViewRow In TransactionDetailView.TransactionDetailDataGrid.Rows
                transactionPage.AppendItem(
                    row.Cells(TransactionDetailView.ItemNameCol.Index).Value,
                    Long.Parse(row.Cells(TransactionDetailView.ItemPriceCol.Index).Value),
                    Integer.Parse(row.Cells(TransactionDetailView.ItemQuantityCol.Index).Value),
                    Integer.Parse(row.Cells(TransactionDetailView.ItemDiscountCol.Index).Value))
            Next

            If TransactionDetailView.IsMemberChk.Checked Then
                transactionPage.SetPayment(Double.Parse(TransactionDetailView.PaymentTxt.Text), TransactionDetailView.PaymentType, TransactionDetailView.PointLbl.Text, TransactionDetailView.CurrentPointLbl.Text, transactionTime.AddYears(1).ToString("dd-MM-yyyy"))
            Else
                transactionPage.SetPayment(Double.Parse(TransactionDetailView.PaymentTxt.Text), TransactionDetailView.PaymentType)
            End If

            transactionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
            transactionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
            transactionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
            transactionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
            transactionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
            transactionPage.AppendFooter("© MACSAUTO INDONESIA")

            Try
                Dim printer = New Printer(My.Settings.DefaultPrinter)
                printer.Print(transactionPage)

                If MsgBox("Transaction printed", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success") = MsgBoxResult.Ok Then
                    Close()
                End If
            Catch ex As InvalidPrinterException

            End Try
        End If
    End Sub
End Class