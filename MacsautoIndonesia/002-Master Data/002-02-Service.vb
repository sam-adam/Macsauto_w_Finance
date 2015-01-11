Public Class _002_02_Service
    Dim flag As Boolean
    Dim i As Integer

    Public Sub New()
        InitializeComponent()

        Add.Visible = (LoggedInEmployee.Position = Position.Manager)
        Edit.Visible = (LoggedInEmployee.Position = Position.Manager)
    End Sub

    Private Sub loadServiceType()
        reader = ExecQueryReader("SELECT * FROM serviceType")
        ServiceType.Items.Clear()
        While reader.Read()
            ServiceType.Items.Add(reader(0).ToString & "-" & reader(1).ToString)
        End While
    End Sub

    Private Sub LoadServiceTable()
        reader = ExecQueryReader("select idsvc,a.idsvt, svtdc, svcdc,vcpmt from Hservice A, serviceType B where A.idsvt = b.idsvt")
        ServiceGridView.Rows.Clear()
        While reader.Read()
            ServiceGridView.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString)
        End While
        Marking(ServiceGridView)
    End Sub
    Private Sub getPriceDetail()
        reader = ExecQueryReader("select A.idsiz,sizdc,svprc from vehicleSize a left join(select * from dService where idsvc like '" + ServiceID.Text + "')as b On a.idsiz = b.idsiz")
        SPriceView.Rows.Clear()
        While reader.Read()
            SPriceView.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString)
        End While
    End Sub
    Private Sub LoadVehicleSize()
        reader = ExecQueryReader("SELECT * from VehicleSize")
        SPriceView.Rows.Clear()
        While reader.Read()
            SPriceView.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
    End Sub
    Public Sub clearAll()
        ServiceDesc.Clear()
        isVoucherPayment.Checked = False
    End Sub
    Public Sub entryClose()
        Add.Visible = False
        Edit.Visible = False
        Remove.Visible = False
        save.Visible = True
        Cancel.Visible = True
        ServiceGridView.Enabled = False
        SPriceView.Enabled = True
        Column6.DefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub entryOpen()
        Add.Visible = True
        Edit.Visible = True
        Remove.Visible = True
        save.Visible = False
        Cancel.Visible = False
        ServiceGridView.Enabled = True
        SPriceView.Enabled = False
        SPriceView.Rows.Clear()
        Column6.DefaultCellStyle.BackColor = Color.LightGray
        ServiceType.SelectedIndex = -1
    End Sub
    Public Sub reset()
        clearAll()
        ServiceID.Text = "xxxxxx"
        GroupBox1.Enabled = False
        LoadServiceTable()
    End Sub
    Private Function checkPriceGrid()
        Dim i, y As Integer
        y = 0
        For i = 0 To SPriceView.Rows.Count - 1
            'MsgBox(SPriceView.Rows(0).Cells(2).Value.ToString())
            If SPriceView.Rows(i).Cells(2).Value Is Nothing Then
                y = y + 1
            End If
        Next i
        Return y
    End Function
    Private Sub _002_02_Service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadServiceTable()
        loadServiceType()

        If ServiceGridView.Rows.Count > 0 Then
            LoadServiceDetail()
        End If
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        flag = True
        ServiceID.Text = CreateNewCode("SELECT * FROM hservice order by idsvc desc", "S", 4, 4)
        GroupBox1.Enabled = True
        clearAll()
        entryClose()
        LoadVehicleSize()

    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If ServiceDesc.Text = "" Then
            MsgBox("Select Service to be modify")
        Else
            flag = False
            entryClose()
            GroupBox1.Enabled = True
            SPriceView.Enabled = True

        End If
    End Sub

    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove.Click
        If ServiceDesc.Text = "" Then
            MsgBox("Select Service to be deleted")
        Else
            If MsgBox("Delete Service", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("DELETE FROM Hservice WHERE idsvc = '" + ServiceID.Text + "'")
                ExecQueryNonReader("DELETE FROM Dservice WHERE idsvc = '" + ServiceID.Text + "'")
                MsgBox("Service Deleted")
                SPriceView.Rows.Clear()

                reset()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ServiceID.Text = "xxxxxx"
        clearAll()
        entryOpen()
        GroupBox1.Enabled = False
    End Sub
    Private Function getVoucherPaymentStatus()
        If isVoucherPayment.Checked = True Then
            Return "X"
        Else
            Return " "
        End If
    End Function
    Private Sub setVoucherPaymentStatus()
        If ServiceGridView.CurrentRow.Cells(4).Value.ToString = "X" Then
            isVoucherPayment.Checked = True
        Else
            isVoucherPayment.Checked = False

        End If
    End Sub
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If flag = True Then
            If ServiceDesc.Text = "" Then
                MsgBox("Please fill the Service Description")
            ElseIf checkPriceGrid() = SPriceView.Rows.Count Then
                MsgBox("Please fill at least one Pricing")
            ElseIf ServiceType.SelectedIndex = -1 Then
                MsgBox("Please select the service type")
            Else
                If MsgBox("Add new service", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("INSERT INTO Hservice VALUES('" + ServiceID.Text + "','" + ServiceType.SelectedItem.ToString.Substring(0, 4) + "','" + ServiceDesc.Text + "','" + getVoucherPaymentStatus() + "')")
                    For i = 0 To SPriceView.Rows.Count - 1
                        If SPriceView.Rows(i).Cells(2).Value IsNot Nothing Then
                            ExecQueryNonReader("INSERT INTO dservice VALUE('" + ServiceID.Text + "','" + SPriceView.Rows(i).Cells(0).Value.ToString + "','" + SPriceView.Rows(i).Cells(2).Value.ToString + "')")
                        End If
                    Next i
                    MsgBox("New service Added")
                End If
                SPriceView.Rows.Clear()
                reset()
                entryOpen()
            End If
        Else
            If ServiceDesc.Text = "" Then
                MsgBox("Please fill the Promotion Description")
            Else
                If MsgBox("modify promotion?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("UPDATE Hservice SET SVCDC = '" + ServiceDesc.Text + "', VCPMT = '" + getVoucherPaymentStatus() + "' WHERE IDSVC = '" + ServiceID.Text + "'")
                    ExecQueryNonReader("DELETE FROM DSERVICE WHERE idsvc LIKE '" + ServiceID.Text + "'")
                    For i = 0 To SPriceView.Rows.Count - 1
                        If SPriceView.Rows(i).Cells(2).Value.ToString <> "" Then
                            ExecQueryNonReader("INSERT INTO dservice VALUE('" + ServiceID.Text + "','" + SPriceView.Rows(i).Cells(0).Value.ToString + "','" + SPriceView.Rows(i).Cells(2).Value.ToString + "')")
                        End If
                    Next i
                    MsgBox("Promotion Updated")
                    reset()
                    entryOpen()
                    SPriceView.Rows.Clear()
                End If
            End If
        End If

    End Sub

    Private Sub LoadServiceDetail()
        ServiceID.Text = ServiceGridView.CurrentRow.Cells(0).Value.ToString
        ServiceDesc.Text = ServiceGridView.CurrentRow.Cells(3).Value.ToString
        ServiceType.Text = ServiceGridView.CurrentRow.Cells(1).Value.ToString & "-" & ServiceGridView.CurrentRow.Cells(2).Value.ToString
        setVoucherPaymentStatus()
        getPriceDetail()
    End Sub

    Private Sub ServiceGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ServiceGridView.CellClick
        LoadServiceDetail()
    End Sub



    Private Sub SPriceView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SPriceView.CellEndEdit
        If (e.ColumnIndex = 2) Then   ' Checking numeric value for Column1 only
            Dim value As String = SPriceView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    SPriceView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    Exit Sub
                End If
            Next
        End If
    End Sub


    Private Sub ServiceGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ServiceGridView.CellContentClick

    End Sub
End Class