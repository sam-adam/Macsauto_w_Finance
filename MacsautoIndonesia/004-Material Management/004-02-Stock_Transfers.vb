Public Class _004_02_Stock_Transfers
    Public Function CreateNewCode()
        Dim lastCode As Integer
        Dim newcode, prefix As String
        prefix = "T" & getText("SELECT * FROM company", 0)
        reader = ExecQueryReader("SELECT * FROM stockTransfer ORDER BY stfid DESC")
        reader.read()
        If reader.HasRows Then
            If Date.Today.Year.ToString.Substring(2, 2) = reader(0).ToString().Substring(5, 2) Then
                lastCode = reader(0).ToString().Substring(8, 4)

                If lastCode < 9 Then
                    newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "000" & (lastCode + 1)
                ElseIf lastCode < 100 Then
                    newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "00" & (lastCode + 1)
                ElseIf lastCode < 1000 Then
                    newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0" & (lastCode + 1)
                Else
                    newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "." & (lastCode + 1)
                End If
            Else
                newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
            End If
        Else
            newcode = prefix & "/" & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
        End If

        Return newcode
    End Function
    Private Sub fromCBO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fromCBO.SelectedIndexChanged
        Try
            If fromCBO.SelectedItem.ToString.Equals(toCbo.SelectedItem.ToString) Then
                MsgBox("Destination from cannot be the same with to")
                fromCBO.SelectedIndex = -1
            Else
                fromQTY.Text = getText("Select slqty from DProduct where idpdt = '" + productID.Text + "' and idslc = '" + fromCBO.SelectedItem.ToString().Substring(0, 6) + "'", 0)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub toCbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toCbo.SelectedIndexChanged
        Try
            If fromCBO.SelectedItem.ToString = toCbo.SelectedItem.ToString Then
                MsgBox("Destination to cannot be the same with from")
                toCbo.SelectedIndex = -1
            Else
            ' MsgBox("Select slqty from DProduct where idpdt = '" + productID.Text + "' and slqty = '" + toCbo.SelectedItem.ToString().Substring(0, 6) + "'")
            ToQTY.Text = getText("Select slqty from DProduct where idpdt = '" + productID.Text + "' and idslc = '" + toCbo.SelectedItem.ToString().Substring(0, 6) + "'", 0)
                MsgBox(fromCBO.SelectedItem.ToString.Substring(8, fromCBO.SelectedItem.ToString.Length - 7))
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Integer.Parse(fromQTY.Text) < Integer.Parse(TransferQTY.Text) Then
            MsgBox("Transfer quantity cannot bigger that destination from quantity")
        Else
            If MsgBox("Perform Stock Transfer", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("INSERT INTO stockTransfer VALUES('" + trfid.Text + "','" + productID.Text + "','" + fromCBO.SelectedItem.ToString.Substring(0, 6) + "','" + fromCBO.SelectedItem.ToString.Substring(9, fromCBO.SelectedItem.ToString().Length - 9) + "','" + fromQTY.Text + "','" + toCbo.SelectedItem.ToString.Substring(0, 6) + "','" + toCbo.SelectedItem.ToString.Substring(9, toCbo.SelectedItem.ToString().Length - 9) + "','" + ToQTY.Text + "','" + TransferQTY.Text + "','" + (Today.Date.ToString("yyyy-MM-dd") & " " & DateTime.Now.ToString("HH:mm:ss")) + "','" + MoveRef.Text + "','" + MoveRea.Text + "')")
                ExecQueryNonReader("UPDATE DPRODUCT SET SLQTY = SLQTY - " + TransferQTY.Text + " WHERE idslc = '" + fromCBO.SelectedItem.ToString.Substring(0, 6) + "' and idpdt = '" + productID.Text + "' ")
                ExecQueryNonReader("UPDATE DPRODUCT SET SLQTY = SLQTY + " + TransferQTY.Text + " WHERE idslc = '" + toCbo.SelectedItem.ToString.Substring(0, 6) + "' and idpdt = '" + productID.Text + "' ")
                MsgBox("Stock Transfered")
                _002_01_Product.ProdSLoc.Rows.Clear()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub _004_02_Stock_Transfers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        trfid.Text = CreateNewCode()
    End Sub

    Private Sub TransferQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TransferQTY.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    
    
End Class