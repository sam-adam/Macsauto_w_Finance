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

    Public Sub New()
        My.Settings.Database = "macsauto"
        My.Settings.Password = "root"
        My.Settings.Username = "root"

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

        Dim dateBinding As New Binding("Text", _transactionHeaderDataTable, "trdat")

        AddHandler dateBinding.Format,
            Sub(sender As Object, e As ConvertEventArgs)
                If e.DesiredType Is GetType(String) Then
                    e.Value = Date.ParseExact(e.Value.ToString(), CurrentDateTimeFormat, CultureInfo.InvariantCulture).ToString("dd MMMM yyyy HH:mm tt")
                End If
            End Sub

        DateTxt.DataBindings.Add(dateBinding)

        DataBindings.Add("VehicleType", _transactionHeaderDataTable, "vtype")
    End Sub

    Private Sub FindCustomer()
        Dim transactionQuery As String =
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
                "   hcustomer.cname," & _
                "   hcustomer.cphon," & _
                "   hcustomer.ccpon," & _
                "   IF(hcustomer.cstat = 'Member', 1, 0) AS is_member" & _
                " FROM htransaction" & _
                " LEFT JOIN hcustomer ON htransaction.idcus = hcustomer.idcus" & _
                " WHERE htransaction.trsid = '" & TransactionIdTxt.Text & "'" & _
                " AND htransaction.trstat = 'PAID'"

        _transactionHeaderDataTable.Load(ExecQueryReader(transactionQuery))
    End Sub

    Private Sub TransactionIdTxt_TextChanged(sender As Object, e As EventArgs) Handles TransactionIdTxt.TextChanged
        If TransactionIdTxt.Text.Length = "001/03-2014/0001/001".Length Then
            FindCustomer()
        Else
            _transactionHeaderDataTable.Clear()
        End If

        PrintBtn.Enabled = (_transactionHeaderDataTable.Rows.Count > 0) Or True
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim transactionPage As New TransactionPage(RollPageWidth, New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular))

        transactionPage.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_

        reader = ExecQueryReader("SELECT cmnam, strta, ccity, phon1, phon2, webst FROM company")
        reader.read()
        transactionPage.AppendTitle(reader("cmnam").ToString)
        transactionPage.AppendTitle(reader("strta").ToString)
        transactionPage.AppendTitle(reader("ccity").ToString)
        transactionPage.AppendTitle("Phone : " & reader("phon1").ToString)
        transactionPage.AppendTitle("Hotline : " & reader("phon2").ToString)
        transactionPage.AppendTitle(reader("webst").ToString)

        transactionPage.SetTransactionInformation(TransactionIdTxt.Text, VehicleRegLbl.Text, VehicleBrandTxt.Text, VehicleModelTxt.Text, DateTxt.Text, DateTime.Now.ToShortTimeString(), "Saya")

        transactionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
        transactionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
        transactionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
        transactionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
        transactionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
        transactionPage.AppendFooter("© MACSAUTO INDONESIA")

        Try
            _printer.Print(transactionPage)
        Catch ex As InvalidPrinterException

        End Try
    End Sub
End Class