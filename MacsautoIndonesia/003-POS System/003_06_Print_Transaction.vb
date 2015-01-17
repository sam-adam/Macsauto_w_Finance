Imports System.Globalization
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
Imports System.Drawing.Printing

Public Class _003_06_Print_Transaction
    Private ReadOnly _transactionHeaderDataTable As DataTable
    Private ReadOnly _transactionDetailDataTable As DataTable
    Private ReadOnly _printer As Printer

    Property VehicleType() As String
        Set(ByVal value As String)
            CarRadio.Checked = (value = "Car")
            MotorRadio.Checked = (value = "Motorcycle")
        End Set
        Get
            If CarRadio.Checked Then
                Return "Car"
            Else
                Return "Motorcycle"
            End If
        End Get
    End Property

    Property PaymentType() As String
        Set(ByVal value As String)
            CashRadio.Checked = (Not value Is Nothing AndAlso Not String.IsNullOrEmpty(value) AndAlso value.ToLower() = "cash")
            DebitRadio.Checked = (Not value Is Nothing AndAlso Not String.IsNullOrEmpty(value) AndAlso value.ToLower() = "debit")
            CreditRadio.Checked = (Not value Is Nothing AndAlso Not String.IsNullOrEmpty(value) AndAlso value.ToLower() = "credit")
        End Set
        Get
            If CashRadio.Checked Then
                Return "Cash"
            ElseIf DebitRadio.Checked Then
                Return "Debit"
            Else
                Return "Credit"
            End If
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        _transactionHeaderDataTable = New DataTable()
        _transactionDetailDataTable = New DataTable()
        _printer = New Printer(My.Settings.DefaultPrinter)

        FindCustomer()

        CustomerNameTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "cname", False, DataSourceUpdateMode.Never)
        CustomerPhoneTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "cphon", False, DataSourceUpdateMode.Never)
        CustomerCellphoneTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "ccpon", False, DataSourceUpdateMode.Never)
        IsMemberChk.DataBindings.Add("Checked", _transactionHeaderDataTable, "is_member", False, DataSourceUpdateMode.Never)
        VehicleRegLbl.DataBindings.Add("Text", _transactionHeaderDataTable, "linum", False, DataSourceUpdateMode.Never)
        VehicleBrandTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "vbrnd", False, DataSourceUpdateMode.Never)
        VehicleModelTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "vmodl", False, DataSourceUpdateMode.Never)
        VehicleSizeTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "vsize", False, DataSourceUpdateMode.Never)
        VehicleColorTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "vcolr", False, DataSourceUpdateMode.Never)
        PointLbl.DataBindings.Add("Text", _transactionHeaderDataTable, "tpoin", False, DataSourceUpdateMode.Never)
        CurrentPointLbl.DataBindings.Add("Text", _transactionHeaderDataTable, "cpoin", False, DataSourceUpdateMode.Never)

        Dim dateBinding As New Binding("Text", _transactionHeaderDataTable, "trdat")
        AddHandler dateBinding.Format,
            Sub(sender As Object, e As ConvertEventArgs)
                If e.DesiredType Is GetType(String) Then
                    e.Value = Date.ParseExact(e.Value.ToString(), CurrentDateTimeFormat, CultureInfo.InvariantCulture).ToString(LongFriendlyDateTimeFormat)
                End If
            End Sub
        DateTxt.DataBindings.Add(dateBinding)

        GrandTotalLbl.DataBindings.Add(GetMoneyBinding(_transactionHeaderDataTable, "toamt"))
        PaymentTxt.DataBindings.Add(GetMoneyBinding(_transactionHeaderDataTable, "topay"))
        ChangeTxt.DataBindings.Add(GetMoneyBinding(_transactionHeaderDataTable, "chnce"))

        DataBindings.Add("VehicleType", _transactionHeaderDataTable, "vtype")
        DataBindings.Add("PaymentType", _transactionHeaderDataTable, "pterm")
    End Sub

    Private Sub FindCustomer()
        Dim transactionHeaderQuery As String =
            "SELECT" & _
            "   htransaction.trsid," & _
            "   htransaction.trdat," & _
            "   htransaction.idcus," & _
            "   htransaction.linum," & _
            "   htransaction.vtype," & _
            "   htransaction.vbrnd," & _
            "   htransaction.vmodl," & _
            "   htransaction.vsize," & _
            "   htransaction.vcolr," & _
            "   htransaction.trdat," & _
            "   htransaction.pterm," & _
            "   htransaction.toamt," & _
            "   htransaction.topay," & _
            "   htransaction.chnce," & _
            "   htransaction.cpoin," & _
            "   htransaction.tpoin," & _
            "   hcustomer.cname," & _
            "   hcustomer.cphon," & _
            "   hcustomer.ccpon," & _
            "   IF(hcustomer.cstat = 'Member', 1, 0) AS is_member" & _
            " FROM htransaction" & _
            " LEFT JOIN hcustomer ON htransaction.idcus = hcustomer.idcus" & _
            " WHERE htransaction.trsid = '" & TransactionIdTxt.Text & "'" & _
            "   AND htransaction.trstat = 'PAID'"
        Dim transactionDetailQuery As String =
            "SELECT" & _
            "   dtransaction.trsid," & _
            "   dtransaction.ttype," & _
            "   dtransaction.idsvc," & _
            "   dtransaction.idpdt," & _
            "   dtransaction.trqty," & _
            "   dtransaction.uomdc," & _
            "   dtransaction.price," & _
            "   dtransaction.idisc," & _
            "   dtransaction.rmark," & _
            "   hproduct.pdtds," & _
            "   producttype.ptpdc," & _
            "   hservice.svcdc," & _
            "   servicetype.svtdc" & _
            " FROM dtransaction" & _
            " LEFT JOIN hproduct ON dtransaction.idpdt = hproduct.idpdt" & _
            " LEFT JOIN producttype ON hproduct.idptp = producttype.idptp" & _
            " LEFT JOIN hservice ON dtransaction.idsvc = hservice.idsvc" & _
            " LEFT JOIN servicetype ON hservice.idsvt = servicetype.idsvt" & _
            " LEFT JOIN htransaction ON dtransaction.trsid = htransaction.trsid" & _
            " WHERE dtransaction.trsid = '" & TransactionIdTxt.Text & "'" & _
            "   AND htransaction.trstat = 'PAID'"

        _transactionHeaderDataTable.Load(ExecQueryReader(transactionHeaderQuery))
        _transactionDetailDataTable.Load(ExecQueryReader(transactionDetailQuery))

        For Each detail As DataRow In _transactionDetailDataTable.Rows
            With TransactionDetailDataGrid
                Dim hasDiscount As Boolean = (Not String.IsNullOrEmpty(detail("idisc")) AndAlso detail("idisc") > 0)

                If detail("ttype") = "P" Then
                    TransactionDetailDataGrid.Rows.Add(
                        "Product",
                         detail("pdtds"),
                         detail("uomdc"),
                         detail("price"),
                         detail("trqty"),
                         detail("idisc"),
                         If(hasDiscount, (detail("price") * (100 - detail("idisc")) / 100), detail("price")),
                         detail("rmark"))
                Else
                    TransactionDetailDataGrid.Rows.Add(
                        "Service",
                         detail("svcdc"),
                         detail("uomdc"),
                         detail("price"),
                         detail("trqty"),
                         detail("idisc"),
                         If(hasDiscount, (detail("price") * (100 - detail("idisc")) / 100), detail("price")),
                         detail("rmark"))
                End If
            End With
        Next
    End Sub

    Private Sub TransactionIdTxt_TextChanged(sender As Object, e As EventArgs) Handles TransactionIdTxt.TextChanged
        If TransactionIdTxt.Text.Length = "001/03-2014/0001/001".Length Then
            FindCustomer()
        Else
            _transactionHeaderDataTable.Clear()
            _transactionDetailDataTable.Clear()
            TransactionDetailDataGrid.Rows.Clear()
        End If

        PrintBtn.Enabled = (_transactionHeaderDataTable.Rows.Count > 0)
    End Sub

    Private Sub _003_06_Print_Transaction_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        SplitContainer.SplitterDistance = SplitContainer.Panel1MinSize
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Dispose()
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        If _transactionHeaderDataTable.Rows.Count = 0 Then
            MsgBox("No transaction found", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        ElseIf MsgBox("Print transaction?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Dim transactionPage As New TransactionPage(RollPageWidth, New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular))
            Dim transactionTime As DateTime = DateTime.ParseExact(DateTxt.Text, LongFriendlyDateTimeFormat, CultureInfo.InvariantCulture)

            transactionPage.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_

            reader = ExecQueryReader("SELECT cmnam, strta, ccity, phon1, phon2, webst FROM company")
            reader.read()
            transactionPage.AppendTitle(reader("cmnam").ToString)
            transactionPage.AppendTitle(reader("strta").ToString)
            transactionPage.AppendTitle(reader("ccity").ToString)
            transactionPage.AppendTitle("Phone : " & reader("phon1").ToString)
            transactionPage.AppendTitle("Hotline : " & reader("phon2").ToString)
            transactionPage.AppendTitle(reader("webst").ToString)

            transactionPage.SetTransactionInformation(TransactionIdTxt.Text, VehicleRegLbl.Text, VehicleBrandTxt.Text, VehicleModelTxt.Text, transactionTime.ToString("dd/MM/yyyy"), transactionTime.ToShortTimeString(), LoggedInEmployee.Name)

            For Each row As DataGridViewRow In TransactionDetailDataGrid.Rows
                transactionPage.AppendItem(
                    row.Cells(ItemNameCol.Index).Value,
                    Long.Parse(row.Cells(ItemPriceCol.Index).Value),
                    Integer.Parse(row.Cells(ItemQuantityCol.Index).Value),
                    Integer.Parse(row.Cells(ItemDiscountCol.Index).Value))
            Next

            If IsMemberChk.Checked Then
                transactionPage.SetPayment(Double.Parse(PaymentTxt.Text), PaymentType, PointLbl.Text, CurrentPointLbl.Text, transactionTime.AddYears(1).ToString("dd-MM-yyyy"))
            Else
                transactionPage.SetPayment(Double.Parse(PaymentTxt.Text), PaymentType)
            End If

            transactionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
            transactionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
            transactionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
            transactionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
            transactionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
            transactionPage.AppendFooter("© MACSAUTO INDONESIA")

            Try
                _printer.Print(transactionPage)

                If MsgBox("Transaction printed", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Success") = MsgBoxResult.Ok Then
                    Close()
                End If
            Catch ex As InvalidPrinterException

            End Try
        End If
    End Sub
End Class