Imports System.Globalization
Imports MacsautoIndonesia.SmartCard
Imports MacsautoIndonesia.SmartCard.Reader

Public Class _002_04_Customer
    Dim flag, i As Integer
    Dim smartCardReader As SmartCardReader
    Dim smartCard As SmartCard.Card.SmartCard
    Dim savable As Boolean



    Public Function getPrefix()
        Return getText("SELECT * FROM COMPANY", 0)
    End Function
    Public Sub clearHeaderForm()
        CNAME.Clear()
        cusMale.Checked = True
        cphone.Clear()
        ccell.Clear()
        cmail.Clear()
        caddress.Clear()
        cStatus.Checked = False
        cPoint.Text = "0"
    End Sub
    Public Function CreateNewCode()
        Dim lastCode As Integer
        Dim newcode, prefix As String
        prefix = "C" & getPrefix()
        reader = ExecQueryReader("SELECT * FROM HCUSTOMER ORDER BY IDCUS DESC")
        reader.read()
        If reader.HasRows Then
            If Date.Today.Year.ToString.Substring(2, 2) = reader(0).ToString().Substring(4, 2) Then
                lastCode = reader(0).ToString().Substring(7, 4)

                newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & String.Format(".{0:0000}", lastCode + 1)
            Else
                newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "." & "0001"
            End If
        Else
            newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "." & "0001"
        End If

        Return newcode
    End Function
    Private Sub enableSave()
        Add.Visible = False
        Edit.Visible = False
        Remove.Visible = False
        save.Visible = True
        Cancel.Visible = True
        CustomerDetail.Enabled = True
        cDetailGrid.Enabled = True
        Button1.Visible = True
        Button2.Visible = True
    End Sub
    Private Sub disableSave()
        Add.Visible = True
        Edit.Visible = True
        Remove.Visible = True
        save.Visible = False
        Cancel.Visible = False
        CustomerDetail.Enabled = False
        cDetailGrid.Enabled = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub
    Private Sub ClearCustomerDetail()
        CNumber.Text = "xxxxx"
        CNAME.Clear()
        cphone.Clear()
        ccell.Clear()
        cmail.Clear()
        caddress.Clear()
        cPoint.Text = "0"
        cStatus.Checked = False
        CDOB.Value = Today.ToShortDateString
        cDetailGrid.Rows.Clear()
    End Sub
    Private Function getGender()
        If cusMale.Checked = True Then
            Return "Male"
        Else
            Return "Female"
        End If
    End Function
    Private Sub setGender()
        If cHeaderGrid.CurrentRow.Cells(2).Value.ToString = "Male" Then
            cusMale.Checked = True
        Else
            cfemale.Checked = True
        End If
    End Sub
    Private Function getCustomerStatus()
        If cStatus.Checked = True Then
            Return "Member"
        Else
            Return "Non-Member"
        End If
    End Function
    Private Sub setCustomerStatus()
        If cHeaderGrid.CurrentRow.Cells(9).Value.ToString = "Member" Then
            cStatus.Checked = True
        Else
            cStatus.Checked = False
        End If
    End Sub
    Private Sub loadCustomerDATA()
        cHeaderGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM hcustomer")
        While reader.read
            cHeaderGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9).ToString)
        End While
        Marking(cHeaderGrid)
    End Sub

    Private Sub loadcustomerVehicleData()
        cDetailGrid.Rows.Clear()
        reader = ExecQueryReader("select brdsc, modsc ,a.idbrn, a.idvmd,a.idcol,d.coldc, linum, vexpd,vyear,vkilo,A.VTYPE from dcustomer a, vehicleBrand b, vehicleModel c,vehicleColor d where a.idcol = d.idcol AND a.idbrn = b.idbrn and a.idvmd = c.idvmd and idcus = '" + cHeaderGrid.CurrentRow.Cells(0).Value.ToString + "'")
        While reader.read
            cDetailGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString(), reader(5).ToString(), reader(6).ToString, ToDate(reader(7).ToString), reader(8).ToString, reader(9).ToString, reader(10).ToString)
        End While
    End Sub
    Private Sub _002_04_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadCustomerDATA()
            InitCardReader()
            smartCardReader = getCardReader()

            If smartCardReader IsNot Nothing Then
                AddHandler smartCardReader.ReaderCardStateChanged, AddressOf smartCardReader_readerCardStateChanged
                smartCardReader.StartPolling(400)
                savable = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _002_04_01_Customer_Detail.ShowDialog()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cDetailGrid.Rows.Remove(cDetailGrid.CurrentRow)
        Catch ex As Exception
            MsgBox("No row to be deleted")
        End Try
    End Sub

    Private Sub cDetailGrid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles cDetailGrid.CellEndEdit
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then   ' Checking numeric value for Column1 only
            Dim value As String = cDetailGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    cDetailGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub cDetailGrid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cDetailGrid.KeyDown
        If cDetailGrid.Rows.Count = 0 Then
            MsgBox("Please add Customer vehicle detail data")
        Else
            If e.KeyCode = Keys.F4 Then
                _002_04_01_Customer_Detail.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        CNumber.Text = CreateNewCode()
        flag = 0
        enableSave()
        TabControl1.SelectedIndex = 1
        clearHeaderForm()
        cDetailGrid.Rows.Clear()
        'MsgBox(CreateNewCode())
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If CNAME.Text = "" Then
            MsgBox("Please select customer data to be edit")
        Else
            flag = 1
            enableSave()
            TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If flag = 0 Then 'add
            If CNAME.Text = "" Then
                MsgBox("Please enter customer name")
            ElseIf cusMale.Checked = False And cfemale.Checked = False Then
                MsgBox("Please select the customer gender")
            Else
                If MsgBox("Add new Customer", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

                    If cStatus.Checked Then
                        Try
                            smartCardReader.UpdateCardBlockValue(1, CNumber.Text)
                        Catch ex As Exception
                            Throw New Exception("Failed to write card", ex)
                        End Try
                    End If

                    ExecQueryNonReader("INSERT INTO HCUSTOMER VALUES('" + CNumber.Text + "','" + CNAME.Text + "','" + getGender() + "','" + CDOB.Value.ToString("yyyy-MM-dd") + "','" + cphone.Text + "','" + ccell.Text + "','" + cmail.Text + "','" + caddress.Text + "','0','" + getCustomerStatus() + "')")
                    For i = 0 To cDetailGrid.Rows.Count - 1
                        If cDetailGrid.Rows(i).Cells(0).Value.ToString <> "" Then
                            Dim query As String

                            query = "INSERT INTO DCUSTOMER VALUES('" + CNumber.Text + "','" + cDetailGrid.Rows(i).Cells(2).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(3).Value.ToString.Trim("-") + "','" + cDetailGrid.Rows(i).Cells(4).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(6).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(7).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(8).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(9).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(10).Value.ToString + "')"

                            ExecQueryNonReader(query)
                        End If
                    Next i
                    MsgBox("New Customer added")
                    disableSave()
                    ClearCustomerDetail()
                    loadCustomerDATA()
                    CNumber.Text = "xxxxx"

                    TabControl1.SelectedIndex = 0
                End If
            End If

        Else 'edit
            If MsgBox("Edit Customer data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                If cStatus.Checked Then
                    Try
                        smartCardReader.UpdateCardBlockValue(1, CNumber.Text)
                    Catch ex As Exception
                        Throw New Exception("Failed to write card", ex)
                    End Try
                End If

                If cStatus.Checked Then
                    smartCardReader.UpdateCardBlockValue(1, CNumber.Text)
                End If

                ExecQueryNonReader("UPDATE HCUSTOMER set CNAME ='" + CNAME.Text + "',CGNDR = '" + getGender() + "',CUDOB = '" + CDOB.Value.ToString("yyyy-MM-dd") + "',cphon = '" + cphone.Text + "',ccpon = '" + ccell.Text + "', cmail = '" + cmail.Text + "', cadd1 = '" + caddress.Text + "', cstat = '" + getCustomerStatus() + "' WHERE IDCUS LIKE '" + CNumber.Text + "'")
                ExecQueryNonReader("delete from dcustomer where idcus LIKE '" + CNumber.Text + "'")
                For i = 0 To cDetailGrid.Rows.Count - 1
                    If cDetailGrid.Rows(i).Cells(0).Value.ToString <> "" Then
                        Dim query As String

                        query = "INSERT INTO DCUSTOMER" & _
                                " VALUES('" + CNumber.Text + "','" + cDetailGrid.Rows(i).Cells(2).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(3).Value.ToString.Trim("-") + "','" + cDetailGrid.Rows(i).Cells(4).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(6).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(7).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(8).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(9).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(10).Value.ToString + "')"
                        'MsgBox(cDetailGrid.Rows(i).Cells(5).Value.ToString & "-" & cDetailGrid.Rows(i).Cells(6).Value.ToString)

                        ' ExecQueryNonReader("INSERT INTO DCUSTOMER VALUES('" + CNumber.Text + "','" + cDetailGrid.Rows(i).Cells(2).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(3).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(4).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(6).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(7).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(8).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(9).Value.ToString + "','" + cDetailGrid.Rows(i).Cells(10).Value.ToString + "')")
                        ExecQueryNonReader(query)

                    End If
                Next i
                MsgBox("Customer data modified")
                disableSave()
                ClearCustomerDetail()
                loadCustomerDATA()
                CNumber.Text = "xxxxx"

                TabControl1.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If MsgBox("Are you sure want to cancel?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            disableSave()
            CNumber.Text = "xxxxx"
        End If
    End Sub


    Private Sub cHeaderGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles cHeaderGrid.CellClick
        CNumber.Text = cHeaderGrid.CurrentRow.Cells(0).Value.ToString
        CNAME.Text = cHeaderGrid.CurrentRow.Cells(1).Value.ToString
        CDOB.Value = cHeaderGrid.CurrentRow.Cells(3).Value.ToString
        cphone.Text = cHeaderGrid.CurrentRow.Cells(4).Value.ToString
        ccell.Text = cHeaderGrid.CurrentRow.Cells(5).Value.ToString
        cmail.Text = cHeaderGrid.CurrentRow.Cells(6).Value.ToString
        caddress.Text = cHeaderGrid.CurrentRow.Cells(7).Value.ToString
        cPoint.Text = cHeaderGrid.CurrentRow.Cells(8).Value.ToString
        loadcustomerVehicleData()
        setGender()
        setCustomerStatus()
    End Sub

    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove.Click
        If CNAME.Text = "" Then
            MsgBox("Select Promotion to be deleted")
        Else
            If MsgBox("Delete Customer?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("DELETE FROM hcustomer WHERE idcus = '" + CNumber.Text + "'")
                ExecQueryNonReader("DELETE FROM dcustomer WHERE idcus = '" + CNumber.Text + "'")
                MsgBox("customer data Deleted")
                Reset()
            End If
        End If
    End Sub

    Private Sub cHeaderGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cHeaderGrid.DoubleClick
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox(MsgBox(cDetailGrid.Rows(0).Cells(10).Value.ToString))
    End Sub

    Private Sub smartCardReader_readerCardStateChanged(ByVal sender As Object, ByVal e As ReaderCardStateChangedEventArgs)
        If e.ReaderCardState = ReaderCardState.CARD_PRESENT Then
            smartCard = smartCardReader.SmartCard
        Else
            smartCard = Nothing
        End If
        savable = (e.ReaderCardState = ReaderCardState.CARD_PRESENT)
    End Sub
End Class