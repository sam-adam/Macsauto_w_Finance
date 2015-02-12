Public Class _004_01_Product_Movement
    Dim subtotal As Double
    Dim flag As Integer
    Dim note, glaccount, salesAct, COGSAct As String
    Public moveTypeIndex
    Private Function getGLAccount(ByVal query)
        reader = ExecQueryReader(query)
        reader.read()
        Return (reader(0).ToString)
    End Function
    Private Sub incomingFIPosting()
        Dim Code As String
        'Initial stock entry  & Goods Receipt
        '==============================================================
        'u/yg non-consumables
        'EXPENSE (Expense account yang nempel ke material)
        '               CASH IN BANK 
        '==============================================================
        '==============================================================
        'u/yg consumables
        'Inventory account (inventory account yang nempel ke material)
        '               CASH IN BANK 
        '==============================================================
        ExecQueryNonReader("INSERT INTO jourhd VALUES('" + Code + "',NOW(),'" + MoveDate.Value.ToString("yyyy-MM-dd") + "','" + MoveID.Text + "','" + MoveRea.Text + "','','" + LoggedInEmployee.Name + "','0000-00-00 00:00:00','GR','')")
        Dim i As Integer
        For i = 0 To ProdMoveGrid.Rows.Count - 2
            ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + ProdMoveGrid.Rows(i).Cells(8).Value.ToString + "','10','" + (ProdMoveGrid.Rows(i).Cells(2).Value * ProdMoveGrid.Rows(i).Cells(3).Value).ToString + "','" + ProdMoveGrid.Rows(i).Cells(1).Value.ToString + "')")
        Next i
        ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + glaccount + "','20','" + MoveTotalPrice.Text + "','')")
    End Sub
    Private Sub outGoingFIPosting()
        Dim Code As String
        'Goods Issue
        '==============================================================
        'u/yg non-consumables
        '(Dr)CASH (
        '(Cr)SALES (Sales Account config)
        '(Dr)COGS (Cogs Account config)
        '(Cr)Inventory
        '==============================================================
        Dim sumtotal, Subtotal, cogs As Double
        ExecQueryNonReader("INSERT INTO jourhd VALUES('" + Code + "',NOW(),'" + MoveDate.Value.ToString("yyyy-MM-dd") + "','" + MoveID.Text + "','" + MoveRea.Text + "','','" + LoggedInEmployee.Name + "','0000-00-00 00:00:00','GI','')")
        Dim i As Integer
        sumtotal = 0
        cogs = 0
        For i = 0 To ProdMoveGrid.Rows.Count - 1
            If ProdMoveGrid.Rows(i).Cells(9).Value = "False" Then
                Subtotal = 0
                Subtotal = (getGLAccount("SELECT ppamt FROM hproduct WHERE idpdt LIKE '" + ProdMoveGrid.Rows(i).Cells(0).Value + "'") * ProdMoveGrid.Rows(i).Cells(2).Value)
                ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + ProdMoveGrid.Rows(i).Cells(8).Value.ToString + "','20','" + Subtotal.ToString + "','" + ProdMoveGrid.Rows(i).Cells(1).Value.ToString + "')")
                sumtotal = sumtotal + (ProdMoveGrid.Rows(i).Cells(2).Value * ProdMoveGrid.Rows(i).Cells(3).Value)
                cogs = cogs + Subtotal
            End If
        Next i

        ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + glaccount + "','10','" + sumtotal.ToString + "','')")
        ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + salesAct + "','20','" + sumtotal.ToString + "','')")
        ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + COGSAct + "','10','" + cogs.ToString + "','')")

    End Sub
    Private Sub autoPosting()
        Dim Code As String
        Code = NewJournalCode()
        If MoveType.SelectedItem.ToString.Equals("Goods Issue") Then
            'Goods Issue
            '==============================================================
            'u/yg non-consumables
            '(Dr)CASH (
            '(Cr)SALES (Sales Account config)
            '(Dr)COGS (Cogs Account config)
            '(Cr)Inventory
            '==============================================================
            Dim sumtotal, Subtotal, cogs As Double
            If checkAnyConsumables() = False Then
                ExecQueryNonReader("INSERT INTO jourhd VALUES('" + Code + "',NOW(),'" + MoveDate.Value.ToString("yyyy-MM-dd") + "','" + MoveID.Text + "','" + MoveRea.Text + "','','" + LoggedInEmployee.Name + "','0000-00-00 00:00:00','GI','')")
                Dim i As Integer
                sumtotal = 0
                cogs = 0
                For i = 0 To ProdMoveGrid.Rows.Count - 1
                    If ProdMoveGrid.Rows(i).Cells(9).Value = "False" Then
                        Subtotal = 0
                        Subtotal = (getGLAccount("SELECT ppamt FROM hproduct WHERE idpdt LIKE '" + ProdMoveGrid.Rows(i).Cells(0).Value + "'") * ProdMoveGrid.Rows(i).Cells(2).Value)
                        ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + ProdMoveGrid.Rows(i).Cells(8).Value.ToString + "','20','" + Subtotal.ToString + "','" + ProdMoveGrid.Rows(i).Cells(1).Value.ToString + "')")
                        sumtotal = sumtotal + (ProdMoveGrid.Rows(i).Cells(2).Value * ProdMoveGrid.Rows(i).Cells(3).Value)
                        cogs = cogs + Subtotal
                    End If
                Next i

                ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + glaccount + "','10','" + sumtotal.ToString + "','')")
                ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + salesAct + "','20','" + sumtotal.ToString + "','')")
                ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + COGSAct + "','10','" + cogs.ToString + "','')")

            End If


        Else
            'Initial stock entry  & Goods Receipt
            '==============================================================
            'u/yg non-consumables
            'EXPENSE (Expense account yang nempel ke material)
            '               CASH IN BANK 
            '==============================================================
            '==============================================================
            'u/yg consumables
            'Inventory account (inventory account yang nempel ke material)
            '               CASH IN BANK 
            '==============================================================
            ExecQueryNonReader("INSERT INTO jourhd VALUES('" + Code + "',NOW(),'" + MoveDate.Value.ToString("yyyy-MM-dd") + "','" + MoveID.Text + "','" + MoveRea.Text + "','','" + LoggedInEmployee.Name + "','0000-00-00 00:00:00','GR','')")
            Dim i As Integer
            For i = 0 To ProdMoveGrid.Rows.Count - 2
                ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + ProdMoveGrid.Rows(i).Cells(8).Value.ToString + "','10','" + (ProdMoveGrid.Rows(i).Cells(2).Value * ProdMoveGrid.Rows(i).Cells(3).Value).ToString + "','" + ProdMoveGrid.Rows(i).Cells(1).Value.ToString + "')")
            Next i
            ExecQueryNonReader("INSERT INTO jourdt VALUES('" + Code + "','" + glaccount + "','20','" + MoveTotalPrice.Text + "','')")
        End If
    End Sub
    Private Sub UpdateAveragePrice()
        Dim i As Integer
        Dim newMAP As String
        For i = 0 To ProdMoveGrid.Rows.Count - 1
            reader = ExecQueryReader("SELECT ROUND((SUM(CASE WHEN pstky = '10' THEN b.psamt ELSE '0' END)- SUM(CASE WHEN pstky = '20' THEN b.psamt ELSE '0' END))/pdqty) AS 'amount' FROM hproduct a, jourdt b where a.glnum = b.glnum AND idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "' GROUP BY idpdt")
            reader.read()
            newMAP = reader(0).ToString
            ExecQueryNonReader("UPDATE hproduct SET ppamt = '" + newMAP + "' WHERE idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value + "'")

        Next i
    End Sub


    Private Function countTotal()
        Dim i As Integer
        Dim total As Double
        total = 0
        For i = 0 To ProdMoveGrid.Rows.Count - 2
            total = total + Double.Parse(ProdMoveGrid.Rows(i).Cells(2).Value.ToString) * Double.Parse(ProdMoveGrid.Rows(i).Cells(3).Value.ToString)
        Next
        Return total
    End Function
    Private Function countTotalqty()
        Dim i, total As Integer
        total = 0
        For i = 0 To ProdMoveGrid.Rows.Count - 2
            total = total + Integer.Parse(ProdMoveGrid.Rows(i).Cells(2).Value.ToString)
        Next
        Return total
    End Function
    Private Sub clearForm()
        MoveRef.Clear()
        MoveRea.Clear()
        ProdMoveGrid.Rows.Clear()
    End Sub
    Public Function CreateNewCode()
        Dim lastCode As Integer
        Dim newcode, prefix As String
        prefix = "M" & getText("SELECT * FROM company", 0)
        reader = ExecQueryReader("SELECT * FROM hpmovement ORDER BY PMVID DESC")
        reader.read()
        If reader.HasRows Then
            If Date.Today.Year.ToString.Substring(2, 2) = reader(0).ToString().Substring(5, 2) Then
                lastCode = reader(0).ToString().Substring(8, 4)

                newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & String.Format("{0:0000}", lastCode + 1)
            Else
                newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
            End If
        Else
            newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
        End If

        Return newcode
    End Function
    Private Sub _004_01_Product_Movement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveType.SelectedIndex = 0
        MoveID.Text = CreateNewCode()
        _005_03_Product.indexType = 1
        Try '
            glaccount = getGLAccount("SELECT glnum FROM mtrac WHERE mtrid ='1'")
            salesAct = getGLAccount("SELECT glnum FROM mtrac WHERE mtrid ='2'")
            COGSAct = getGLAccount("SELECT glnum FROM mtrac WHERE mtrid ='3'")
        Catch ex As Exception
            MsgBox("Please complete configuration for material account in order to continue product movement transaction ")
            _001_16_Material_Account.ShowDialog()
            Close()
        End Try
    End Sub

    Private Sub MoveType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveType.SelectedIndexChanged
        If MoveType.SelectedIndex = 0 Then
            Button2.Text = "Goods Issue"
            flag = 1
            _005_03_Product.indexType = 1
        ElseIf MoveType.SelectedIndex = 1 Then
            Button2.Text = "Goods Receipt"
            flag = 2
            _005_03_Product.indexType = 2
        Else
            Button2.Text = "Set Initial Stock Balance"
            flag = 3
            _005_03_Product.indexType = 3

        End If
        clearForm()
        MoveTotalPrice.Text = "0"
        TotalProductQTY.Text = "0"
    End Sub
    Private Function checkActPeriod()
        reader = ExecQueryReader("SELECT acmon,acyer FROM PRACT WHERE activ = '1'")
        reader.read()
        Return reader(1).ToString & "-" & reader(0).ToString
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If flag = 1 Then
            note = "Goods issue"
        ElseIf flag = 2 Then
            note = "Goods receipt"
        Else
            note = "initial stock"
        End If
        If ProdMoveGrid.Rows.Count = 1 Then
            MsgBox("Please enter the product data")
        Else
            If (MoveDate.Value.Year.ToString & "-" & MoveDate.Value.Month.ToString("00")) <> checkActPeriod() Then
                MsgBox("Accounting Period '" & MoveDate.Value.Year.ToString & "-" & MoveDate.Value.Month.ToString("00") & "' is not activated (Current active Accounting Period : '" + checkActPeriod() + "')")
            Else

                If MsgBox(note & "?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("INSERT INTO hpmovement VALUES('" + MoveID.Text + "','" + MoveType.SelectedItem.ToString + "','" + (MoveDate.Value.ToString("yyyy-MM-dd") & " " & DateTime.Now.ToString("HH:mm:ss")) + "','" + MoveRef.Text + "','" + MoveRea.Text + "','" + Date.Today.ToString("yyyy-MM-dd") + "')")

                    For i = 0 To ProdMoveGrid.Rows.Count - 2
                        Dim previousStock As Integer = 0

                        reader = ExecQueryReader("SELECT pdqty FROM hproduct WHERE idpdt = '" & ProdMoveGrid.Rows(i).Cells(0).Value.ToString & "'")
                        reader.Read()

                        If reader.HasRows Then
                            previousStock = Integer.Parse(reader(0).ToString())
                        End If

                        If ProdMoveGrid.Rows(i).Cells(0).Value.ToString <> "" Then
                            ExecQueryNonReader("INSERT INTO dpmovement VALUES('" + MoveID.Text + "','" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "','" + ProdMoveGrid.Rows(i).Cells(1).Value.ToString + "','" + ProdMoveGrid.Rows(i).Cells(2).Value.ToString + "','" + ProdMoveGrid.Rows(i).Cells(3).Value.ToString + "','" + ProdMoveGrid.Rows(i).Cells(4).Value.ToString + "','" + ProdMoveGrid.Rows(i).Cells(5).Value.ToString + "', " & previousStock & ")")

                            If flag = 1 Then
                                ExecQueryNonReader("update hproduct set pdqty = pdqty -" + ProdMoveGrid.Rows(i).Cells(2).Value.ToString + " where idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "'")
                                ExecQueryNonReader("update dproduct set slqty = slqty -" + ProdMoveGrid.Rows(i).Cells(2).Value.ToString + " where idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "' AND idslc like '" + ProdMoveGrid.Rows(i).Cells(5).Value.ToString + "'")
                            ElseIf flag = 2 Then
                                ExecQueryNonReader("update hproduct set pdqty = pdqty +" + ProdMoveGrid.Rows(i).Cells(2).Value.ToString + " where idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "'")
                                ExecQueryNonReader("update dproduct set slqty = slqty +" + ProdMoveGrid.Rows(i).Cells(2).Value.ToString + " where idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "' AND idslc like '" + ProdMoveGrid.Rows(i).Cells(5).Value.ToString + "'")
                            Else
                                ExecQueryNonReader("update hproduct set pdqty = pdqty +" + ProdMoveGrid.Rows(i).Cells(2).Value.ToString + " where idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "'")
                                ExecQueryNonReader("update dproduct set slqty = slqty +" + ProdMoveGrid.Rows(i).Cells(2).Value.ToString + " where idpdt = '" + ProdMoveGrid.Rows(i).Cells(0).Value.ToString + "' AND idslc like '" + ProdMoveGrid.Rows(i).Cells(5).Value.ToString + "'")
                            End If
                        End If
                    Next i


                    autoPosting()


                    If flag = 2 Then
                        Try
                            UpdateAveragePrice()
                        Catch ex As Exception

                        End Try

                    End If
                    MsgBox(note & " Transaction complete with the number " & MoveID.Text)
                    Me.Close()
            End If

            End If
        End If

    End Sub
    Private Function checkAnyConsumables()
        Dim i As Integer
        For i = 0 To ProdMoveGrid.Rows.Count - 2
            If ProdMoveGrid.Rows(i).Cells(9).Value = True Then
                Return True
            Else
                Return False
            End If
        Next
    End Function

    Private Sub ProdMoveGrid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProdMoveGrid.KeyDown
        If e.KeyCode = Keys.F4 Then
            If ProdMoveGrid.CurrentCell.ColumnIndex <> 5 Then
                _005_03_Product.ShowDialog()
            Else
                loadTable("SELECT a.idslc, slocd, slqty FROM DPRODUCT a, sloc b  WHERE a.idslc = b.idslc and idpdt LIKE '" + ProdMoveGrid.CurrentRow.Cells(0).Value.ToString + "'", _005_04_Storage_Location__Movement_.SearchSloc)
                _005_04_Storage_Location__Movement_.ShowDialog()

            End If
        End If

    End Sub

    Private Sub ProdMoveGrid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProdMoveGrid.CellEndEdit
        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then   ' Checking numeric value for Column1 only
            Dim value As String = ProdMoveGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    ProdMoveGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    Exit Sub
                End If
            Next
            ' ProdMoveGrid.CurrentRow.Cells(5).Value = Integer.Parse(ProdMoveGrid.CurrentRow.Cells(2).Value.ToString) * Integer.Parse(ProdMoveGrid.CurrentRow.Cells(3).Value.ToString)
            MoveTotalPrice.Text = countTotal()
            TotalProductQTY.Text = countTotalqty()
            If flag = 1 Then
                If Integer.Parse(ProdMoveGrid.CurrentRow.Cells(7).Value.ToString) < Integer.Parse(ProdMoveGrid.CurrentRow.Cells(2).Value.ToString) Then
                    MsgBox("Issue quantity can not bigger than storage quantity")
                    ProdMoveGrid.Rows.Remove(ProdMoveGrid.CurrentRow)
                End If
            End If
            MoveTotalPrice.Text = countTotal()
            TotalProductQTY.Text = countTotalqty()
        ElseIf e.ColumnIndex = 5 Then
            ProdMoveGrid.CurrentRow.Cells(6).Value = getText("SELECT a.idslc, slocd, slqty FROM DPRODUCT a, sloc b  WHERE a.idslc = b.idslc and idpdt LIKE '" + ProdMoveGrid.CurrentRow.Cells(0).Value.ToString + "'", 1)
            ProdMoveGrid.CurrentRow.Cells(7).Value = getText("SELECT a.idslc, slocd, slqty FROM DPRODUCT a, sloc b  WHERE a.idslc = b.idslc and idpdt LIKE '" + ProdMoveGrid.CurrentRow.Cells(0).Value.ToString + "'", 2)

        End If
    End Sub
End Class