Imports MacsautoIndonesia.SmartCard.Reader
Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing

Public Class _003_04_TrMerchandiseRedemption
    Dim smartCardReader As SmartCardReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _005_09_Search_Member.ShowDialog()
    End Sub

    Private Sub AddServiceBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddServiceBtn.Click
        If cNAme.Text = "" Then
            MsgBox("Please enter customer data")
        Else
            _005_10_POS_Merchandise.ShowDialog()

            Recalculate()
        End If
    End Sub

    Private Sub Recalculate()
        Dim pointsInHand As Integer = If(String.IsNullOrEmpty(cPoin.Text), 0, Integer.Parse(cPoin.Text))
        Dim totalPointsRequired As Integer = 0

        If MerchandiseGrid.Rows.Count > 0 Then
            totalPointsRequired = MerchandiseGrid.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) Integer.Parse(row.Cells(5).Value.ToString()) * Integer.Parse(row.Cells(3).Value.ToString()))

            If totalPointsRequired > pointsInHand Then
                MsgBox("Not enough points", "Warning")

                MerchandiseGrid.Rows.RemoveAt(MerchandiseGrid.Rows.Count - 1)
            End If
        End If

        TotalPointRequired.Text = totalPointsRequired.ToString()
    End Sub

    Private Sub addSeqNumber(ByVal dg As DataGridView)
        Dim i As Integer
        If dg.Rows.Count > 0 Then
            For i = 0 To dg.Rows.Count - 1
                dg.Rows(i).Cells(0).Value = i + 1
            Next i
        End If
    End Sub

    Private Sub RemoveServBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveServBtn.Click
        If MerchandiseGrid.Rows.Count <> 0 Then
            MerchandiseGrid.Rows.Remove(MerchandiseGrid.CurrentRow)

            Recalculate()
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        If MsgBox("Are you sure to close the transaction?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Dispose()
        End If
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim TrNumber = CreateNewCode()
        If MerchandiseGrid.Rows.Count = 0 Then
            MsgBox("Please select at least one merchandise")
        Else
            If MsgBox("Save Transaction", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("INSERT INTO hredemption VALUES('" + TrNumber + "', '" + TrDATE.Value.ToString("yyyy-MM-dd") + "', '" + cNumber.Text + "', " + TotalPointRequired.Text + ")")

                For Each row As DataGridViewRow In MerchandiseGrid.Rows
                    If row.Cells(3).Value <> Nothing And row.Cells(5).Value <> Nothing Then
                        ExecQueryNonReader("INSERT INTO dredemption VALUES('" + TrNumber + "', '" + row.Cells(1).Value.ToString() + "', '" + row.Cells(5).Value.ToString() + "', " + row.Cells(3).Value.ToString() + ")")
                    End If
                Next

                ExecQueryNonReader("INSERT INTO pointTrans(IDPOR,IDCUS,PTDAT,TRPON, TRTYPE) VALUES('" + CreatePointNewCode() + "','" + cNumber.Text + "',NOW(),'" + TotalPointRequired.Text + "', 'SUB')")
                ExecQueryNonReader("UPDATE hcustomer SET cpoin = " + (Integer.Parse(cPoin.Text) - Integer.Parse(TotalPointRequired.Text)).ToString() + " WHERE idcus = '" + cNumber.Text + "'")

                updateStock()

                PrintForm(TrNumber)

                MsgBox("Transaction saved")

                Close()
            End If
        End If
    End Sub

    Public Function CreatePointNewCode()
        Dim Curdate, company As String
        Curdate = Date.Today.Month & "-" & Date.Today.Year
        company = getText("select * from pointTrans", 0)
        reader = ExecQueryReader("SELECT *  FROM pointTrans  order by idpor DESC")
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        If reader.HasRows Then
            lastCode = reader(0).ToString()
            newcode = lastCode + 1
        Else
            newcode = 1
        End If

        Return newcode
    End Function

    Private Sub updateStock()
        Dim i As Integer
        If MerchandiseGrid.Rows.Count <> 0 Then
            For i = 0 To MerchandiseGrid.Rows.Count - 1
                ExecQueryNonReader("update DPRODUCT set SLQTY = SLQTY-" + MerchandiseGrid.Rows(i).Cells(3).Value.ToString + " where idpdt like '" & MerchandiseGrid.Rows(i).Cells(1).Value.ToString & "' and defsl = 'True'")
                ExecQueryNonReader("update HPRODUCT set pdQTY = pdQTY-" + MerchandiseGrid.Rows(i).Cells(3).Value.ToString + " where idpdt like '" & MerchandiseGrid.Rows(i).Cells(1).Value.ToString & "'")
            Next
        End If
    End Sub

    Public Function TransactionPerMonth(ByVal year As String, ByVal month As Integer)
        Dim i As Integer
        i = getText("select count(*) from hredemption where substring(rdmpdat,6,2) = '" + String.Format("{0:00}", month) + "' and substring(rdmpdat,1,4) = '" & year & "'", 0)

        Return i
    End Function

    Public Function CreateNewCode()
        Dim Curdate, company As String
        Curdate = String.Format("{0:00}", Date.Today.Month) & "-" & Date.Today.Year
        company = getText("select * from company", 0)
        reader = ExecQueryReader("SELECT *  FROM hredemption order by rdmpid DESC")
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        '  MsgBox(reader(0).ToString.Substring(4, 2))
        If reader.HasRows Then
            If Date.Today.Year.ToString.Substring(2, 2) = reader(0).ToString().Substring(9, 2) Then
                If String.Format("{0:00}", Date.Today.Month) = reader(0).ToString().Substring(4, 2) Then
                    lastCode = Integer.Parse(reader(0).ToString().Substring(17, 3))
                    newcode = String.Format("{0}/{1}/{2}/{3:000}", company, Curdate, String.Format("{0:0000}", TransactionPerMonth(Date.Today.Year, Date.Today.Month) + 1), (lastCode + 1))
                Else
                    newcode = company & "/" & Curdate & "/" & "0001" & "/" & "001"
                End If
            Else
                newcode = company & "/" & Curdate & "/" & "0001" & "/" & "001"
            End If
        Else
            newcode = company & "/" & Curdate & "/" & "0001" & "/" & "001"
        End If

        Return newcode
    End Function

    Private Sub MerchandiseGrid_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MerchandiseGrid.CellValueChanged
        If MerchandiseGrid.Rows.Count > 0 Then
            If e.ColumnIndex = 3 And MerchandiseGrid(5, e.RowIndex).Value <> Nothing Then
                Recalculate()
            End If
        End If
    End Sub

    Private Sub _003_04_TrMerchandiseRedemption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            smartCardReader = getCardReader()
            AddHandler smartCardReader.ReaderCardStateChanged, AddressOf smartCardReader_readerCardStateChanged
            smartCardReader.StartPolling(400)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub smartCardReader_readerCardStateChanged(ByVal sender As Object, ByVal e As ReaderCardStateChangedEventArgs)
        If cNumber.Text = "" Then
            If e.ReaderCardState = ReaderCardState.CARD_PRESENT Then
                cNumber.Text = smartCardReader.GetCardBlockValue(1)
            Else
                cNumber.Text = ""
            End If
        End If
    End Sub

    Private Sub cNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cNumber.TextChanged
        Dim query As String
        Dim reader As MySqlDataReader

        query = "SELECT Cname, cadd1, cphon, ccpon, cpoin" & _
                " FROM HCustomer" & _
                " WHERE cstat = 'Member'" & _
                " AND idcus = '" & cNumber.Text & "'"
        reader = ExecQueryReader(query)

        While reader.Read()
            cNAme.Text = reader(0).ToString()
            cAddress.Text = reader(1).ToString()
            cPhone.Text = reader(2).ToString()
            cCell.Text = reader(3).ToString()
            cPoin.Text = reader(4).ToString()
        End While

        CheckPointExpiry(cNumber.Text)
    End Sub

    Private Sub PrintForm(ByVal transactionNumber As String)
        Dim printer As New Printer(My.Settings.DefaultPrinter)
        Dim redemptionPage As New RedemptionPage(250, New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular))

        Dim pointsLeft As String = "0"
        Dim query As String = "SELECT cpoin" & _
                              " FROM HCustomer" & _
                              " WHERE cstat = 'Member'" & _
                              " AND idcus = '" & cNumber.Text & "'"
        reader = ExecQueryReader(query)

        While reader.Read()
            pointsLeft = reader(0).ToString()
        End While

        redemptionPage.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_

        redemptionPage.AppendTitle("JL. HOS. COKROAMINOTO (KOMP. SPBU PERTAMINA)")
        redemptionPage.AppendTitle("SAMPING UBUD VILLAGE, CILEDUG RAYA")
        redemptionPage.AppendTitle("021-7314783")
        redemptionPage.AppendTitle("WWW.MACSAUTO-INDONESIA.COM")

        redemptionPage.SetTransactionInformation(transactionNumber, TrDATE.Value.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString())

        redemptionPage.SetData(cNumber.Text, cNAme.Text, TotalPointRequired.Text, pointsLeft, DateTime.Now.AddYears(1).ToString("dd/MM/yyyy"))

        redemptionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
        redemptionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
        redemptionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
        redemptionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
        redemptionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
        redemptionPage.AppendFooter("© MACSAUTO INDONESIA")

        printer.Print(redemptionPage)
    End Sub
End Class