Imports MacsautoIndonesia.SmartCard.Reader
Imports MacsautoIndonesia.Printing.Page
Imports MacsautoIndonesia.Printing
Imports MySql.Data.MySqlClient
Imports System.Collections.ObjectModel

Public Class _003_02_TrDetail2
    Public SizeNumber, TrNumber As String
    Public remainAR As Integer = 0
    Dim smartCardReader As SmartCardReader
    Private Sub updateStock()
        Dim i As Integer
        If ProductGrid.Rows.Count <> 0 Then
            For i = 0 To ProductGrid.Rows.Count - 1
                ExecQueryNonReader("update DPRODUCT set SLQTY = SLQTY-" + ProductGrid.Rows(i).Cells(3).Value.ToString + " where idpdt like '" & ProductGrid.Rows(i).Cells(1).Value.ToString & "' and defsl = 'True'")
                ExecQueryNonReader("update HPRODUCT set pdQTY = pdQTY-" + ProductGrid.Rows(i).Cells(3).Value.ToString + " where idpdt like '" & ProductGrid.Rows(i).Cells(1).Value.ToString & "'")

            Next
        End If
    End Sub

    Public Function TransactionPerMonth(ByVal month As String)
        Dim i As Integer

        i = getText("select count(*) from HTransaction where substring(trdat,6,2) like '" + month + "' and substring(trdat,1,4) like Year(CURDATE())", 0)
        ' MsgBox(i)

        Return String.Format("{0:0000}", i + 1)
    End Function

    Public Function CreateNewCode()
        Dim Curdate, company As String
        Curdate = Date.Today.ToString("MM") & "-" & Date.Today.Year
        company = getText("select * from company", 0)
        reader = ExecQueryReader("SELECT *  FROM HTRANSACTION order by trdat DESC LIMIT 1")
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        '  MsgBox(reader(0).ToString.Substring(4, 2))
        If reader.HasRows Then
            Dim transactionDate As DateTime = DateTime.Parse(reader.GetDateTime("trdat"))

            If Date.Today.Month = transactionDate.Month Then
                If Date.Today.Date = transactionDate.Date Then
                    lastCode = reader("trsid").ToString().Substring(17, 3)
                Else
                    lastCode = 0
                End If

                newcode = company & "/" & Curdate & "/" & TransactionPerMonth(Date.Today.ToString("MM")) & "/" & String.Format("{0:000}", (lastCode + 1))
            Else
                newcode = company & "/" & Curdate & "/" & "0001" & "/" & "001"
            End If
        Else
            newcode = company & "/" & Curdate & "/" & "0001" & "/" & "001"
        End If
        Return newcode
    End Function
    Public Function CreateNewPaymentCode()
        Dim Curdate, company As String
        Curdate = Date.Today.Month & "-" & Date.Today.Year
        company = getText("select * from company", 0)
        reader = ExecQueryReader("SELECT *  FROM PAYMENT order by PAYID DESC")
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        If reader.HasRows Then
            Dim paymentDate As DateTime = DateTime.Parse(reader.GetDateTime("pydat"))

            If Date.Today.Year = paymentDate.Year Then
                lastCode = reader("payid").ToString().Substring(7, 5)

                newcode = String.Format("P{0}{1}.{2:00000}", Date.Today.Year.ToString.Substring(2, 2), company, lastCode + 1)
            Else
                newcode = "P" & Date.Today.Year.ToString.Substring(2, 2) & company & "." & "00001"
            End If
        Else
            newcode = "P" & Date.Today.Year.ToString.Substring(2, 2) & company & "." & "00001"
        End If
        Return newcode
    End Function
    Public Function CreatePointNewCode()
        Dim Curdate As String
        Curdate = Date.Today.Month & "-" & Date.Today.Year
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
    Public Function countSubtotal(ByVal dg As DataGridView)
        Try
            Dim i As Integer
            Dim total As Double
            For i = 0 To dg.Rows.Count - 1
                total = total + Integer.Parse(dg.Rows(i).Cells(3).Value.ToString) * Integer.Parse(dg.Rows(i).Cells(5).Value.ToString)
            Next i
            Return total
        Catch ex As Exception

        End Try

    End Function
    Private Function countDicSubtotal(ByVal dg As DataGridView)
        Try
            Dim i As Integer
            Dim total As Double
            For i = 0 To dg.Rows.Count - 1
                ' If String.IsNullOrEmpty(dg.Rows(i).Cells(6).Value.ToString) = True Then
                total = total + (Integer.Parse(dg.Rows(i).Cells(3).Value.ToString) * Integer.Parse(dg.Rows(i).Cells(5).Value.ToString)) - ((Integer.Parse(dg.Rows(i).Cells(6).Value.ToString) / 100) * (Integer.Parse(dg.Rows(i).Cells(3).Value.ToString) * Integer.Parse(dg.Rows(i).Cells(5).Value.ToString)))
                'Else
                ' total = total + Integer.Parse(dg.Rows(i).Cells(3).Value.ToString) * Integer.Parse(dg.Rows(i).Cells(5).Value.ToString)

                'End If

            Next i
            Return total
        Catch ex As Exception

        End Try

    End Function
    Public Function countGrandTotal()
        'Return countSubtotal(ProductGrid) + countSubtotal(ServiceGrid)
        Try
            Return Integer.Parse(totalProduct.Text) + Integer.Parse(totalService.Text)
        Catch ex As Exception

        End Try
    End Function
    Private Sub CreatePaymentRecord()
        Dim code As String
        code = CreateNewPaymentCode()
        'MsgBox(code)
        If TextBox4.Text <> "Auto-Generated" Then
            ExecQueryNonReader("INSERT INTO PAYMENT VALUES('" + code + "','" + TextBox4.Text + "','" + TotalPayment.Text + "',NOW())")
        Else
            ExecQueryNonReader("INSERT INTO PAYMENT VALUES('" + code + "','" + TrNumber + "','" + TotalPayment.Text + "',NOW())")
        End If

    End Sub
    Private Sub saveProductDetail()
        Dim i As Integer
        For i = 0 To ProductGrid.Rows.Count - 1
            ExecQueryNonReader("INSERT INTO DTransaction(TRSID,TTYPE,SEQNR,IDPDT,TRQTY,UOMDC,PRICE,idisc) VALUES('" + TrNumber + "','P','" + ProductGrid.Rows(i).Cells(0).Value.ToString + "','" + ProductGrid.Rows(i).Cells(1).Value.ToString + "','" + ProductGrid.Rows(i).Cells(3).Value.ToString + "','" + ProductGrid.Rows(i).Cells(4).Value.ToString + "','" + ProductGrid.Rows(i).Cells(5).Value.ToString + "','" + ProductGrid.Rows(i).Cells(6).Value.ToString + "')")

        Next i
    End Sub
    Private Sub saveServiceDetail()
        'Try
        Dim i As Integer
        For i = 0 To ServiceGrid.Rows.Count - 1
            ' MsgBox("INSERT INTO DTRANSACTION(TRSID,TTYPE,SEQNR,IDSVC,TRQTY,UOMDC,PRICE,RMARK) VALUES('" + TrNumber + "','S','" + ServiceGrid.Rows(i).Cells(0).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(1).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(3).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(4).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(5).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(6).Value.ToString + "')")
            ' MsgBox(ServiceGrid.Rows(i).Cells(6).Value.ToString)
            ExecQueryNonReader("INSERT INTO DTRANSACTION(TRSID,TTYPE,SEQNR,IDSVC,TRQTY,UOMDC,PRICE,RMARK,idisc,vpaym,vnumb) VALUES('" + TrNumber + "','S','" + ServiceGrid.Rows(i).Cells(0).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(1).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(3).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(4).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(5).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(7).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(6).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(8).Value.ToString + "','" + ServiceGrid.Rows(i).Cells(9).Value.ToString + "')")
        Next i

        '  Catch ex As Exception

        'End Try

    End Sub
    Public Sub addSeqNumber(ByVal dg As DataGridView)
        Dim i As Integer
        If dg.Rows.Count > 0 Then
            For i = 0 To dg.Rows.Count - 1
                dg.Rows(i).Cells(0).Value = i + 1
            Next i
        End If
    End Sub
    Private Sub clearVehicleData()
        vType.Clear()
        vBrand.Clear()
        vModel.Clear()
        vKilo.Clear()
        vColor.Clear()
        vExpDate.Value = Date.Today
        vNumber.Clear()
        vSize.Clear()
    End Sub
    Private Function generateCustomerPoint()
        Dim point As Integer

        If isCustomerMember.Checked = True Then
            point = Math.Round(Integer.Parse(totalService.Text) / Integer.Parse(getText("SELECT pbase from basepoint", 0)))
        Else
            point = 0
        End If
        Return point
    End Function
    Private Sub UpdateCustomerPoint()
        '  MsgBox("UPDATE HTransaction set TPoin = tpoin + " + Integer.Parse(generateCustomerPoint) + " where trsid like '" + TextBox4.Text + "'")
        ExecQueryNonReader("UPDATE HTransaction set TPoin = tpoin +'" & generateCustomerPoint() & "' where trsid like '" + TextBox4.Text + "'")
        'MsgBox("x")
        ExecQueryNonReader("UPDATE hcustomer set cPoin = cpoin + '" & generateCustomerPoint() & "' where idcus like '" + cNumber.Text + "'")
        ' MsgBox("y")
        'ADD CUSTOMER POINT TRANSACTION
        ExecQueryNonReader("INSERT INTO pointTrans(IDPOR,IDCUS,PTDAT,TRPON, TRTYPE) VALUES('" + CreatePointNewCode() + "','" + cNumber.Text + "',NOW(),'" & generateCustomerPoint() & "', 'ADD')")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _005_05_Search_Customer.ShowDialog()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cNumber.Text = "" Then
            MsgBox("Please enter the customer data")
        Else
            loadTable("select A.vtype as 'TYPE', C.brdsc as 'BRAND', D.modsc as 'MODEL', coldc as 'COLOR', E.sizdc as 'SIZE',  A.vkilo as 'KM REACHED', A.vexpd as 'License Exp.',e.idsiz as 'size code',linum as 'License Plate' FROM DCustomer A, Vehiclecolor B, vehicleBrand C, VehicleModel D, VehicleSize E where A.idbrn = C.idbrn AND C.idbrn = D.idbrn AND a.idvmd = d.idvmd AND a.idcol = b.idcol and d.idsiz = e.idsiz and idcus like '" + cNumber.Text + "'", _005_06_Customer_Vehicle.CustomerVehicle)
            Marking(_005_06_Customer_Vehicle.CustomerVehicle)
            _005_06_Customer_Vehicle.ShowDialog()
        End If
    End Sub

    Private Sub AddServiceBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddServiceBtn.Click
        If vNumber.Text = "" Then
            MsgBox("Please Select the customer vehicle")
        Else
            ServiceGrid.Rows.Add()
            Me.ServiceGrid.CurrentCell = ServiceGrid.Item(1, ServiceGrid.Rows.Count - 1)
            addSeqNumber(ServiceGrid)
            'loadTable("SELECT a.idsvc as 'SERVICE #',svcdc AS 'SERVICE DESCRIPTION',svprc AS 'SERVICE PRICE' FROM HService A, DSERVICE B WHERE A.IDSVC=B.IDSVC AND B.idsiz LIKE '" + SizeNumber + "'", _005_08_POS_Service.servSearchGrid)
            loadTable("SELECT a.idsvc as 'SERVICE#', svcdc as 'DESCRIPTION', svprc as 'PRICE',pmdcp AS 'PROMOTION',pdamt AS 'Disc Amount',pdpct as 'Disc %' FROM (HService as A JOIN DService as b on A.idsvc = B.idsvc and b.idsiz = '" + SizeNumber + "') left join promoAssignment as C on A.idsvc = C.iditm and C.atype = 'S' and C.begda <= curdate() and C.endda >= curdate() and C.astat = 'True'left join promotion as D on C.idpmt = D.idpmt order by a.idsvc asc", _005_08_POS_Service.servSearchGrid)
            Marking(_005_08_POS_Service.servSearchGrid)
            _005_08_POS_Service.servSearchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            _005_08_POS_Service.ShowDialog()
        End If

    End Sub

    Private Sub addProductBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addProductBtn.Click
        If cNAme.Text = "" Then
            MsgBox("Please enter customer data")
        Else

            _005_07_POS_Product.ShowDialog()
        End If

    End Sub

    Private Sub ProductGrid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductGrid.CellEndEdit
        If e.ColumnIndex = 3 Or e.ColumnIndex = 5 Then   ' Checking numeric value for Column1 only
            Dim value As String = ProductGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    ProductGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "0"
                    Exit Sub
                End If
            Next
            totalProduct.Text = countSubtotal(ProductGrid)
            GrandTotal.Text = countGrandTotal()
            DEBT.Text = countGrandTotal()
            remainAR = countGrandTotal()
        ElseIf e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            Dim value As String = ProductGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    ProductGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "0"
                    Exit Sub
                End If
            Next
            totalProduct.Text = countDicSubtotal(ProductGrid)
            GrandTotal.Text = countGrandTotal()
            DEBT.Text = countGrandTotal()
            remainAR = countGrandTotal()
        End If

    End Sub

    Private Sub cNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cNumber.TextChanged
        If cNumber.TextLength = 11 Then
            Try
                cNAme.Text = getText("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE' FROM HCustomer WHERE idcus LIKE '" + cNumber.Text + "'", 1)
                cAddress.Text = getText("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE' FROM HCustomer WHERE idcus LIKE '" + cNumber.Text + "'", 2)
                cPhone.Text = getText("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE' FROM HCustomer WHERE idcus LIKE '" + cNumber.Text + "'", 3)
                cCell.Text = getText("SELECT idcus as 'CUSTOMER #',Cname AS 'CUSTOMER NAME',cadd1 AS 'ADDRESS',cphon AS 'PHONE',ccpon AS 'CELLPHONE' FROM HCustomer WHERE idcus LIKE '" + cNumber.Text + "'", 4)
                If getText("SELECT cstat from HCUSTOMER WHERE idcus LIKE '" + cNumber.Text + "'", 0) = "Non-Member" Then
                    isCustomerMember.Checked = False
                Else
                    isCustomerMember.Checked = True
                    CheckPointExpiry(cNumber.Text)
                End If
            Catch ex As Exception
                MsgBox("No customer found")
            End Try
        Else
            clearVehicleData()
            cNAme.Clear()
            cAddress.Clear()
            cPhone.Clear()
            cCell.Clear()

        End If
    End Sub

    Private Sub RemoveServBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveServBtn.Click

        If ServiceGrid.Rows.Count <> 0 Then
            ServiceGrid.Rows.Remove(ServiceGrid.CurrentRow)
        End If
    End Sub

    Private Sub RemoveProductBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveProductBtn.Click
        If ProductGrid.Rows.Count <> 0 Then
            ProductGrid.Rows.Remove(ProductGrid.CurrentRow)
        End If
    End Sub

    Private Sub ServiceGrid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ServiceGrid.CellEndEdit
        If e.ColumnIndex = 3 Or e.ColumnIndex = 5 Then   ' Checking numeric value for Column1 only
            Dim value As String = ServiceGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    ServiceGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    Exit Sub
                End If
            Next
            'ServiceGrid.CurrentRow.Cells(7).Value = "-"
            totalService.Text = countSubtotal(ServiceGrid)
            GrandTotal.Text = countGrandTotal()
            DEBT.Text = countGrandTotal()
            remainAR = countGrandTotal()
        ElseIf e.ColumnIndex = 6 Then
            Dim value As String = ServiceGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    ServiceGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    Exit Sub
                End If
            Next
            'MsgBox(ServiceGrid.CurrentRow.Cells(6).Value.ToString)
            If Integer.Parse(ServiceGrid.CurrentRow.Cells(6).Value.ToString) = 0 Then
                totalService.Text = countSubtotal(ServiceGrid)
            Else
                totalService.Text = countDicSubtotal(ServiceGrid)


            End If
            GrandTotal.Text = countGrandTotal()
            DEBT.Text = countGrandTotal()
            remainAR = countGrandTotal()
        ElseIf e.ColumnIndex = 8 Then
            If ServiceGrid.CurrentRow.Cells(8).Value = "True" Then
                ' MsgBox("TRUE")
                ServiceGrid.CurrentRow.Cells(6).Value = 100
                If Integer.Parse(ServiceGrid.CurrentRow.Cells(6).Value.ToString) = 0 Then
                    totalService.Text = countSubtotal(ServiceGrid)
                Else
                    totalService.Text = countDicSubtotal(ServiceGrid)


                End If
                GrandTotal.Text = countGrandTotal()
                DEBT.Text = countGrandTotal()
                remainAR = countGrandTotal()
            Else
                ' MsgBox("FALSE")
                ServiceGrid.CurrentRow.Cells(6).Value = 0
                If Integer.Parse(ServiceGrid.CurrentRow.Cells(6).Value.ToString) = 0 Then
                    totalService.Text = countSubtotal(ServiceGrid)
                Else
                    totalService.Text = countDicSubtotal(ServiceGrid)


                End If
                GrandTotal.Text = countGrandTotal()
                DEBT.Text = countGrandTotal()
                remainAR = countGrandTotal()
            End If
        End If

    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If ServiceGrid.Rows.Count = 0 And ProductGrid.Rows.Count = 0 Then
            MsgBox("Please select at least one transaction detail")
        ElseIf PayMethod.SelectedIndex = -1 Then
            MsgBox("Please choose payment method")
        ElseIf PayMethod.SelectedIndex <> 0 And ServStatus.Text = "" Then
            MsgBox("Please enter " + PayMethod.SelectedItem.ToString + " number")
        ElseIf DEBT.Text <> "0" Then
            MsgBox("Please enter amount of payment")
        Else
            If MsgBox("Save Transaction", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                If TextBox4.Text = "Auto-Generated" Then 'save
                    TrNumber = CreateNewCode()
                    '  MsgBox("save")

                    'kalo 1x bayar & pake kembalian
                    If Integer.Parse(TotalPayment.Text) > Integer.Parse(GrandTotal.Text) Then
                        ExecQueryNonReader("INSERT INTO HTransaction (TRSID,TRDAT,IDCUS,VTYPE,VBRND,VMODL,VSIZE,VKMRE,LINUM,LIEXP,SVAMT,PDAMT,TOAMT,TOPAY,PTERM,SVSTS,TRSTAT,vcolr,tpoin,chnce,createdBy) VALUES('" + TrNumber + "','" + (TrDATE.Value.ToString("yyyy-MM-dd") & " " & Date.Now.ToString("HH:mm:ss")) + "','" + cNumber.Text + "','" + vType.Text + "','" + vBrand.Text + "','" + vModel.Text + "','" + vSize.Text + "','" + vKilo.Text + "','" + vNumber.Text + "','" + vExpDate.Value.ToString("yyyy-MM-dd") + "','" + totalService.Text + "','" + totalProduct.Text + "','" + GrandTotal.Text + "','" + TotalPayment.Text + "','" + PayMethod.SelectedItem.ToString + "','" + ServStatus.Text + "','Open','" + vColor.Text + "','0','" + totalChange.Text + "', '" & LoggedInEmployee.Id & "')")
                        'ExecQueryNonReader("INSERT INTO HTransaction (TRSID,TRDAT,IDCUS,VTYPE,VBRND,VMODL,VSIZE,VKMRE,LINUM,LIEXP,SVAMT,PDAMT,TOAMT,TOPAY,PTERM,SVSTS,TRSTAT,vcolr,tpoin,chnce,createdBy) VALUES('" + TrNumber + "','" + TrDATE.Value.ToString("yyyy-MM-dd") + "','','','','','','','','','','','','','','','Open','','0','', '')")

                        If ProductGrid.Rows.Count <> 0 Then
                            saveProductDetail()
                        End If
                        If ServiceGrid.Rows.Count <> 0 Then
                            saveServiceDetail()
                        End If
                        ExecQueryNonReader("UPDATE HTransaction SET trStat = 'PAID' WHERE trsid LIKE '" + TrNumber + "'")
                        If TotalPayment.Text <> "0" Then
                            CreatePaymentRecord()
                        End If
                        UpdateCustomerPoint()
                        PrintForm(TrNumber)
                        TryPostJournal(TrNumber)
                        MsgBox("Transaction Saved")
                        'kalo 1x bayar & tanpa pake kembalian (bayarnya uang pas)
                    Else
                        ' ExecQueryNonReader("INSERT INTO HTransaction (TRSID,TRDAT,IDCUS,VTYPE,VBRND,VMODL,VSIZE,VKMRE,LINUM,LIEXP,SVAMT,PDAMT,TOAMT,TOPAY,PTERM,SVSTS,TRSTAT,vcolr,tpoin,chnce,createdBy) VALUES('" + TrNumber + "','" + TrDATE.Value.ToString("yyyy-MM-dd") + "','','','','','','','','','','','','','','','Open','','0','', '')")

                        ExecQueryNonReader("INSERT INTO HTransaction (TRSID,TRDAT,IDCUS,VTYPE,VBRND,VMODL,VSIZE,VKMRE,LINUM,LIEXP,SVAMT,PDAMT,TOAMT,TOPAY,PTERM,SVSTS,TRSTAT,vcolr,tpoin,chnce,createdBy,TRTIM) VALUES('" + TrNumber + "','" + TrDATE.Value.ToString("yyyy-MM-dd") + "','" + cNumber.Text + "','" + vType.Text + "','" + vBrand.Text + "','" + vModel.Text + "','" + vSize.Text + "','" + vKilo.Text + "','" + vNumber.Text + "','" + vExpDate.Value.ToString("yyyy-MM-dd") + "','" + totalService.Text + "','" + totalProduct.Text + "','" + GrandTotal.Text + "','" + TotalPayment.Text + "','" + PayMethod.SelectedItem.ToString + "','" + ServStatus.Text + "','Open','" + vColor.Text + "','0','" + totalChange.Text + "', '" & LoggedInEmployee.Id & "',CURTIME())")
                        If ProductGrid.Rows.Count <> 0 Then
                            saveProductDetail()
                        End If
                        If ServiceGrid.Rows.Count <> 0 Then
                            saveServiceDetail()
                        End If
                        If DEBT.Text = "0" Or Integer.Parse(TotalPayment.Text) > Integer.Parse(GrandTotal.Text) Then
                            'ganti textbox4 untuk edit
                            ExecQueryNonReader("UPDATE HTransaction SET trStat = 'PAID' WHERE trsid LIKE '" + TrNumber + "'")
                            ExecQueryNonReader("UPDATE HTransaction SET toPay = (toPay + " + TotalPayment.Text + "-" + totalChange.Text + ") WHERE trsid LIKE '" + TextBox4.Text + "'")
                        End If
                        If TotalPayment.Text <> "0" Then
                            CreatePaymentRecord()
                        End If
                        UpdateCustomerPoint()
                        TryPostJournal(TrNumber)
                        MsgBox("Transaction Saved")
                        PrintForm(TrNumber)
                    End If

                    updateStock()

                Else
                    ' update (untuk kasus beberapa kali bayar misalnya bayar DP dlo baru pelunasan
                    '4   MsgBox("edit")
                    If totalChange.Text = "0" Then
                        ExecQueryNonReader("UPDATE HTransaction SET chnce = '" + totalChange.Text + "', toPay = (toPay + " + TotalPayment.Text + ") WHERE trsid LIKE '" + TextBox4.Text + "'")
                        If DEBT.Text = "0" Then
                            ExecQueryNonReader("UPDATE HTransaction SET  trStat = 'PAID' WHERE trsid LIKE '" + TextBox4.Text + "'")
                            UpdateCustomerPoint()
                        End If
                        If TotalPayment.Text <> "0" Then
                            CreatePaymentRecord()
                        End If
                        PrintForm(TextBox4.Text)
                        MsgBox("Transaction Updated")
                    ElseIf totalChange.Text <> "0" Then
                        ExecQueryNonReader("UPDATE HTransaction SET chnce = '" + totalChange.Text + "', toPay = (toPay + " + TotalPayment.Text + ") WHERE trsid LIKE '" + TextBox4.Text + "'")
                        ExecQueryNonReader("UPDATE HTransaction SET trStat = 'PAID' WHERE trsid LIKE '" + TextBox4.Text + "'")
                        UpdateCustomerPoint()
                        If TotalPayment.Text <> "0" Then
                            CreatePaymentRecord()
                        End If
                        PrintForm(TextBox4.Text)
                        MsgBox("Transaction Updated")
                    End If

                End If


                Dim POS As _003_01_TrList = CType(Application.OpenForms("_003_01_TrList"), _003_01_TrList)
                POS.loadTransactionList()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub TotalPayment_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TotalPayment.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PayMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayMethod.SelectedIndexChanged
        If PayMethod.SelectedIndex <> -1 Then
            RemainingAR.Enabled = True
            printBtn.Enabled = True

        End If

        If PayMethod.SelectedIndex = 1 Or PayMethod.SelectedIndex = 2 Then
            Label23.Text = PayMethod.SelectedItem.ToString & " Number"
            Label23.Visible = True
            ServStatus.Visible = True
        Else
            Label23.Visible = False
            ServStatus.Visible = False
        End If
    End Sub

    Private Sub TotalPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalPayment.TextChanged
        If TotalPayment.Text = "" Then
            DEBT.Text = remainAR
            toCurrencyFormat(DEBT.Text)
            totalChange.Text = "0"
        Else
            If Integer.Parse(TotalPayment.Text) > Integer.Parse(remainAR) Then
                DEBT.Text = "0"
                totalChange.Text = Integer.Parse(TotalPayment.Text) - Integer.Parse(remainAR)
                toCurrencyFormat(totalChange.Text)
            Else
                '  RemainingAR.Text = remainAR
                DEBT.Text = Integer.Parse(remainAR) - Integer.Parse(TotalPayment.Text)
                totalChange.Text = "0"
                toCurrencyFormat(DEBT.Text)
                'totalChange.Text = Integer.Parse(remainAR) - Integer.Parse(TotalPayment.Text)
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox(CreateNewCode)
    End Sub
    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        If MsgBox("Are you sure to close the transaction?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
            CustomerPanel.Enabled = False
            Panel2.Enabled = False
            ServicePanel.Enabled = False
            ProductPanel.Enabled = False
            PricePanel.Enabled = False
            PaymentPanel.Enabled = False
            SaveBtn.Enabled = False
            Column3.DefaultCellStyle.BackColor = Color.White
            Column5.DefaultCellStyle.BackColor = Color.White
            DataGridViewTextBoxColumn3.DefaultCellStyle.BackColor = Color.White
            DataGridViewTextBoxColumn4.DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

        End If
    End Sub

    Private Sub _003_02_TrDetail2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub PrintForm(ByVal transactionNumber As String)
        Dim printer As New Printer(My.Settings.DefaultPrinter)
        Dim transactionPage As New TransactionPage(250, New Font(SystemFonts.DialogFont.FontFamily, 6, FontStyle.Regular))

        transactionPage.Logo = My.Resources.Logo_MACSAUTO_only__background_putih__1_

        transactionPage.AppendTitle("JL. HOS. COKROAMINOTO (KOMP. SPBU PERTAMINA)")
        transactionPage.AppendTitle("SAMPING UBUD VILLAGE, CILEDUG RAYA")
        transactionPage.AppendTitle("021-7314783")
        transactionPage.AppendTitle("WWW.MACSAUTO-INDONESIA.COM")

        transactionPage.SetTransactionInformation(transactionNumber, vNumber.Text, vBrand.Text, vModel.Text, TrDATE.Value.ToString("dd/MM/yyyy"), DateTime.Now.ToShortTimeString())

        For i = 0 To ServiceGrid.Rows.Count - 1
            Dim detailName As String = ServiceGrid.Rows(i).Cells(2).Value.ToString
            Dim detailPrice As Long = Long.Parse(ServiceGrid.Rows(i).Cells(5).Value.ToString())
            Dim detailQty As Integer = CInt(ServiceGrid.Rows(i).Cells(3).Value.ToString)
            Dim detailDisc As Integer = CInt(ServiceGrid.Rows(i).Cells(6).Value.ToString())

            transactionPage.AppendItem(detailName, detailPrice, detailQty, detailDisc)
        Next

        For i = 0 To ProductGrid.Rows.Count - 1
            Dim detailName As String = ProductGrid.Rows(i).Cells(2).Value.ToString
            Dim detailPrice As Long = Long.Parse(ProductGrid.Rows(i).Cells(5).Value.ToString())
            Dim detailQty As Integer = CInt(ProductGrid.Rows(i).Cells(3).Value.ToString)
            Dim detailDisc As Integer = CInt(ProductGrid.Rows(i).Cells(6).Value.ToString())

            transactionPage.AppendItem(detailName, detailPrice, detailQty, detailDisc)
        Next

        If isCustomerMember.Checked Then
            Dim point As String = "0"
            Dim query As String = "SELECT cpoin" & _
                                  " FROM HCustomer" & _
                                  " WHERE cstat = 'Member'" & _
                                  " AND idcus = '" & cNumber.Text & "'"
            reader = ExecQueryReader(query)

            While reader.Read()
                point = reader(0).ToString()
            End While

            transactionPage.SetPayment(CType(TotalPayment.Text, Long), PayMethod.SelectedItem.ToString(), generateCustomerPoint(), point, DateTime.Now.AddYears(1).ToString("dd-MM-yyyy"))
        Else
            transactionPage.SetPayment(CType(TotalPayment.Text, Long), PayMethod.SelectedItem.ToString())
        End If

        transactionPage.AppendFooter("PERIKSA KEMBALI KONDISI")
        transactionPage.AppendFooter("KENDARAAN DAN BARANG BAWAAN ANDA.")
        transactionPage.AppendFooter("KAMI TIDAK BERTANGGUNG JAWAB ATAS")
        transactionPage.AppendFooter("SEGALA BENTUK KEHILANGAN SETELAH ANDA")
        transactionPage.AppendFooter("MENINGGALKAN OUTLET KAMI.")
        transactionPage.AppendFooter("© MACSAUTO INDONESIA")

        Try
            printer.Print(transactionPage)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub printBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintForm("-")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox(CreateNewCode)
        Dim printForm As Form2 = New Form2
        printForm.address.Text = getText("SELECT cmadd FROM Company where idcmp = '001'", 0)
        Dim i As Integer
        For i = 0 To ServiceGrid.Rows.Count - 1
            printForm.AddServiceItem(ServiceGrid.Rows(i).Cells(2).Value.ToString)
        Next
        printForm.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voidBtn.Click
        If TrRemark.Text = "" Then
            MsgBox("Please enter cancel reason")
        ElseIf GlobalModule.LoggedInEmployee.Position <> Position.Manager Then
            MsgBox("Void Process only authorized for manager    ")

        Else
            If MsgBox("Are you sure want to void the transaction", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                If TextBox4.Text <> "Auto-Generated" Then

                    ExecQueryNonReader("UPDATE HTransaction SET trStat = 'VOID' WHERE trsid LIKE '" + TextBox4.Text + "'")
                    MsgBox("Transaction void")
                    Me.Close()


                    Dim POS As _003_01_TrList = CType(Application.OpenForms("_003_01_TrList"), _003_01_TrList)
                    POS.loadTransactionList()
                Else
                    MsgBox("Transaction not created, can not be void")
                End If
            End If
        End If

    End Sub

    Private Sub DEBT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEBT.TextChanged

    End Sub

    Private Sub QUEUE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUEUE.Click

        If ServiceGrid.Rows.Count = 0 And ProductGrid.Rows.Count = 0 Then
            MsgBox("Please select at least one transaction detail")
        ElseIf PayMethod.SelectedIndex = -1 Then
            MsgBox("Please choose payment method")
        ElseIf PayMethod.SelectedIndex <> 0 And ServStatus.Text = "" Then
            MsgBox("Please enter " + PayMethod.SelectedItem.ToString + " number")

        Else
            If MsgBox("Queue Transaction", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                '  MsgBox("a")
                If TextBox4.Text = "Auto-Generated" Then 'save
                    TrNumber = CreateNewCode()

                    ' MsgBox("b")
                    'If Integer.Parse(TotalPayment.Text) > Integer.Parse(GrandTotal.Text) Then
                    'MsgBox("INSERT INTO HTransaction (TRSID,TRDAT,IDCUS,VTYPE,VBRND,VMODL,VSIZE,VKMRE,LINUM,LIEXP,SVAMT,PDAMT,TOAMT,TOPAY,PTERM,SVSTS,TRSTAT,vcolr,tpoin,createdBy) VALUES('" + TrNumber + "','" + TrDATE.Value.ToString("yyyy-MM-dd") + "','" + cNumber.Text + "','" + vType.Text + "','" + vBrand.Text + "','" + vModel.Text + "','" + vSize.Text + "','" + vKilo.Text + "','" + vNumber.Text + "','" + vExpDate.Value.ToString("yyyy-MM-dd") + "','" + totalService.Text + "','" + totalProduct.Text + "','" + GrandTotal.Text + "','0','" + PayMethod.SelectedItem.ToString + "','" + ServStatus.Text + "','Open','" + vColor.Text + "','0', '" & LoggedInEmployee.Id & "')")
                    ExecQueryNonReader("INSERT INTO HTransaction (TRSID,TRDAT,IDCUS,VTYPE,VBRND,VMODL,VSIZE,VKMRE,LINUM,LIEXP,SVAMT,PDAMT,TOAMT,TOPAY,PTERM,SVSTS,TRSTAT,vcolr,tpoin,createdBy,TRTIM) VALUES('" + TrNumber + "','" + TrDATE.Value.ToString("yyyy-MM-dd") + "','" + cNumber.Text + "','" + vType.Text + "','" + vBrand.Text + "','" + vModel.Text + "','" + vSize.Text + "','" + vKilo.Text + "','" + vNumber.Text + "','" + vExpDate.Value.ToString("yyyy-MM-dd") + "','" + totalService.Text + "','" + totalProduct.Text + "','" + GrandTotal.Text + "','0','" + PayMethod.SelectedItem.ToString + "','" + ServStatus.Text + "','Open','" + vColor.Text + "','0', '" & LoggedInEmployee.Id & "',CURTIME())")
                    'ExecQueryNonReader("INSERT INTO HTransaction (TRSID,TRDAT,IDCUS,VTYPE,VBRND,VMODL,VSIZE,VKMRE,LINUM,LIEXP,SVAMT,PDAMT,TOAMT,TOPAY,PTERM,SVSTS,TRSTAT,vcolr,tpoin,chnce,createdBy) VALUES('" + TrNumber + "','" + TrDATE.Value.ToString("yyyy-MM-dd") + "','','','','','','','','','','','','','','','Open','','0','', '')")

                    If ProductGrid.Rows.Count <> 0 Then
                        saveProductDetail()
                    End If
                    If ServiceGrid.Rows.Count <> 0 Then
                        saveServiceDetail()
                        'End If
                    End If

                    'untuk update stock, lebih baik di put di queue transaction atau di save transaction trakhir
                    updateStock()

                    MsgBox("Transasction queued")
                    Me.Close()
                    Dim POS As _003_01_TrList = CType(Application.OpenForms("_003_01_TrList"), _003_01_TrList)
                    POS.loadTransactionList()
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub TryPostJournal(ByVal transactionId As String)
        Dim glAccounts As New Dictionary(Of String, Dictionary(Of String, String))
        Dim serviceQuery As String = "SELECT idsvc, glnum" & _
            " FROM hservice" & _
            " WHERE idsvc IN (" & String.Join(", ", ServiceGrid.Rows.OfType(Of DataGridViewRow).Select(Function(row) "'" & row.Cells(1).Value.ToString() & "'")) & ")"
        Dim productQuery As String = "SELECT idpdt, glnum" & _
            " FROM hproduct" & _
            " WHERE idpdt IN (" & String.Join(", ", ProductGrid.Rows.OfType(Of DataGridViewRow).Select(Function(row) "'" & row.Cells(1).Value.ToString() & "'")) & ")"
        Dim reader As MySqlDataReader

        If ServiceGrid.Rows.Count > 0 Then
            reader = ExecQueryReader(serviceQuery)

            While reader.Read()
                Dim dictionary As New Dictionary(Of String, String)
                Dim row As DataGridViewRow = ServiceGrid.Rows.OfType(Of DataGridViewRow).First(Function(rowItem) rowItem.Cells(1).Value.ToString() = reader("idsvc").ToString())
                Dim subTotal As Double = Double.Parse(row.Cells(3).Value) * Double.Parse(row.Cells(5).Value)

                If Not String.IsNullOrEmpty(row.Cells(6).Value) And Not row.Cells(6).Value = "0" Then
                    subTotal -= (subTotal * (Integer.Parse(row.Cells(6).Value)) / 100)
                End If

                dictionary.Add("id", reader("idsvc").ToString())
                dictionary.Add("glaccount", reader("glnum").ToString())
                dictionary.Add("amount", subTotal)

                glAccounts.Add("SERVICE-" & reader("idsvc").ToString(), dictionary)
            End While
        End If

        If ProductGrid.Rows.Count > 0 Then
            reader = ExecQueryReader(productQuery)

            While reader.Read()
                Dim dictionary As New Dictionary(Of String, String)
                Dim row As DataGridViewRow = ProductGrid.Rows.OfType(Of DataGridViewRow).First(Function(rowItem) rowItem.Cells(1).Value.ToString() = reader("idpdt").ToString())
                Dim subTotal As Double = Double.Parse(row.Cells(3).Value) * Double.Parse(row.Cells(5).Value)

                If Not String.IsNullOrEmpty(row.Cells(6).Value) And Not row.Cells(6).Value = "0" Then
                    subTotal -= (subTotal * (Integer.Parse(row.Cells(6).Value)) / 100)
                End If

                dictionary.Add("id", reader("idpdt").ToString())
                dictionary.Add("glaccount", reader("glnum").ToString())
                dictionary.Add("amount", subTotal)
                glAccounts.Add("PRODUCT-" & reader("idpdt").ToString(), dictionary)
            End While
        End If

        If glAccounts.Count = (ServiceGrid.Rows.Count + ProductGrid.Rows.Count) Then
            DoInTransaction(
                Function()
                    ExecQueryNonReader("INSERT INTO jourhd (SELECT (COUNT(*) + 1), NOW(), NOW(), '" & transactionId & "', 'AUTOPOST TRANSAKSI', '', '" & LoggedInEmployee.Id & "', '0000-00-00', 'TR', '' FROM jourhd)")

                    Dim jourReader As MySqlDataReader = ExecQueryReader("SELECT docid FROM jourhd ORDER BY docid DESC LIMIT 1")

                    If (jourReader.Read()) Then
                        Dim newJournalId As String = jourReader(0)

                        If PayMethod.SelectedItem.ToString() = "Cash" Then
                            ExecQueryNonReader("INSERT INTO jourdt VALUES('" & newJournalId & "', '1000.01', '10', '" & GrandTotal.Text & "', '')")
                        Else
                            ExecQueryNonReader("INSERT INTO jourdt VALUES('" & newJournalId & "', '1000.02', '10', '" & GrandTotal.Text & "', '')")
                        End If

                        For Each glAccount In glAccounts
                            ExecQueryNonReader("INSERT INTO jourdt VALUES('" & newJournalId & "', '" & glAccount.Value("glaccount") & "', '20', '" & glAccount.Value("amount") & "', '')")
                        Next
                    End If

                    jourReader.Close()

                    Return True
                End Function)
        End If
    End Sub
End Class