Public Class _002_01_Product
    Dim flag As Boolean
    Dim s As Integer

    Public Sub New()
        InitializeComponent()

        Add.Visible = (LoggedInEmployee.Position = Position.Manager)
        Edit.Visible = (LoggedInEmployee.Position = Position.Manager)
        Remove.Visible = (LoggedInEmployee.Position = Position.Manager)
    End Sub

    Private Function checkToTransaction(ByVal pcode As String)
        Dim i As Integer
        i = 0
        reader = ExecQueryReader("select count(trsid) from dtransaction where idpdt like '" + pcode + "'")
        While reader.read

            If reader(0).ToString <> "0" Then
                i = 1
            End If
        End While
        Return i
    End Function
    Private Sub getProductcons()
        Try
            reader = ExecQueryReader("SELECT iscnsm FROM productType WHERE idptp LIKE '" + ProductType.SelectedItem.ToString.Substring(0, 4) + "'")
            reader.read()
            If reader(0).ToString = "False" Then
                consume.Checked = False
                ProdSAmt.Text = "0"
                ProdSAmt.Enabled = True
            Else
                consume.Checked = True
                ProdSAmt.Text = "0"
                ProdSAmt.Enabled = False

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadProductType()
        reader = ExecQueryReader("SELECT * FROM productType")
        While reader.read
            ProductType.Items.Add(reader(0).ToString & "-" & reader(1).ToString())
        End While
    End Sub
    Private Sub LoadUnitofMeasure()
        reader = ExecQueryReader("SELECT uodsc FROM uom")
        While reader.read
            UOMcBo.Items.Add(reader(0).ToString)
        End While
    End Sub
    Private Sub loadProductTable()
        ProductGridView.Rows.Clear()
        ' reader = ExecQueryReader("select a.idpdt,a.idptp,d.ptpdc, a.pdtds,a.ppamt,a.psamt,sum(slqty),c.uodsc  from hproduct a , dproduct b ,uom c,producttype d where a.idpdt = b.idpdt and a.iduom = c.iduom and a.idptp = d.idptp and d.ismrch = 0 group by idpdt")
        reader = ExecQueryReader("select a.idpdt,a.idptp,d.ptpdc, a.pdtds,a.ppamt,a.psamt,sum(slqty),c.uodsc,a.glnum, d.iscnsm  from hproduct a , dproduct b ,uom c,producttype d where a.idpdt = b.idpdt and a.iduom = c.iduom and a.idptp = d.idptp group by idpdt")

        While reader.read
            ProductGridView.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4), reader(5), reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9))
        End While
        Marking(ProductGridView)
    End Sub
    Private Sub loadProductTabledetail()
        ProdSLoc.Rows.Clear()
        reader = ExecQueryReader("select a.idslc, slocd, slqty,defsl from dproduct a, sloc b where a.idslc = b.idslc and a.idpdt = '" + ProductID.Text + "'")
        While reader.read
            ProdSLoc.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString)
        End While
    End Sub

    Public Sub clearAll()
        ProductDesc.Clear()
        ProductType.SelectedIndex = -1
        prodAmt.Text = "0"
        ProdSAmt.Text = "0"
        TotalStock.Text = "0"
        GLNumber.Clear()
        consume.Checked = False
    End Sub
    Public Sub entryClose()
        Add.Visible = False
        Edit.Visible = False
        Remove.Visible = False
        save.Visible = True
        Cancel.Visible = True

        PanelInfo.Enabled = True
        PANELLocation.Enabled = True
        PANELAct.Enabled = True
        Column5.DefaultCellStyle.BackColor = Color.White
        Column6.DefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub entryOpen()
        Add.Visible = True
        Edit.Visible = True
        Remove.Visible = True
        save.Visible = False
        Cancel.Visible = False
        PanelInfo.Enabled = False
        PANELLocation.Enabled = False
        PANELAct.Enabled = False
        prodAmt.Text = "0"
        Column5.DefaultCellStyle.BackColor = Color.LightGray
        Column6.DefaultCellStyle.BackColor = Color.LightGray
        ProdSLoc.Rows.Clear()

    End Sub
    Private Function SlocViewValidation()
        Dim i, j As Integer
        For i = 0 To ProdSLoc.Rows.Count - 2
            If i > 0 Then
                If ProdSLoc.CurrentRow.Cells(0).Value.ToString = ProdSLoc.Rows(i - 1).SetValues.ToString Then
                    j = 1
                    MsgBox(ProdSLoc.Rows(i - 1).SetValues.ToString)
                    Exit For
                Else
                    j = 2
                End If

            End If
        Next
        Return j
    End Function
    Private Sub _002_01_Product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUnitofMeasure()
        loadProductTable()
        LoadProductType()
        If ProductGridView.Rows.Count > 0 Then
            LoadProductDetail()
        End If
        PanelInfo.Enabled = False
        PANELLocation.Enabled = False
        PANELAct.Enabled = False
        TabControl2.TabPages.Remove(TabPage5)
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        TabControl2.SelectedIndex = 0
        flag = True
        ProductID.Text = CreateNewCode("SELECT * FROM Hproduct order by idpdt desc", "M", 4, 4)
        clearAll()
        entryClose()
        ProdSLoc.Enabled = True
        ProdSLoc.Rows.Clear()
        prodAmt.Clear()
        TotalStock.Text = "0"
        notes.Visible = True
        UOMcBo.SelectedIndex = -1
        ProductGridView.Enabled = False
        addItem.Visible = True
        removeItem.Visible = True

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        ProductID.Text = "xxxxxx"
        clearAll()
        entryOpen()
        'TabControl1.SelectedIndex = 0
        TabControl2.TabPages.Remove(TabPage5)
        notes.Visible = False
        TotalStock.Text = 0
        UOMcBo.SelectedIndex = -1
        ProductGridView.Enabled = True
        addItem.Visible = False
        removeItem.Visible = False
        TabControl2.SelectedIndex = 0
        'stockTransferBtn.Visible = False
        'GroupBox1.Enabled = False
    End Sub



    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If ProductDesc.Text = "" Then
            MsgBox("Select Product to be modify")
        Else
            flag = False
            entryClose()
            TabControl2.TabPages.Add(TabPage5)
            ProdSLoc.Enabled = False
            ProductGridView.Enabled = False

            'stockTransferBtn.Visible = True
            GroupBox1.Enabled = True
        End If
    End Sub



    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click

        If flag = True Then ' add
            If ProductDesc.Text = "" Then
                MsgBox("Please entry product Description")
            ElseIf prodAmt.Text = "0" Or prodAmt.Text = "" Then
                MsgBox("Please entry product Price")
            ElseIf ProductType.SelectedIndex = -1 Then
                MsgBox("Please select product type")
            ElseIf UOMcBo.SelectedIndex = -1 Then
                MsgBox("Please entry select unit of measure")
            ElseIf ProdSLoc.Rows.Count = 0 Then
                MsgBox("Please assign Product to storage location")
            ElseIf checkDefault() = 0 Then
                MsgBox("Please select the default storage location")
            ElseIf GLNumber.Text = "" Then
                MsgBox("Please enter GL Account for Product")
            Else
                If MsgBox("Add new product", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

                    Dim isMerchandise = False
                    Dim productTypeReader = ExecQueryReader("SELECT ismrch FROM producttype WHERE idptp = '" & ProductType.SelectedItem.ToString().Substring(0, 4) & "'")

                    While productTypeReader.Read()
                        If productTypeReader(0) Then
                            isMerchandise = True
                        End If
                    End While

                    ExecQueryNonReader("INSERT INTO HPRODUCT VALUES('" + ProductID.Text + "','" + ProductType.SelectedItem.ToString.Substring(0, 4) + "','" + ProductDesc.Text + "','0','" + getText("SELECT iduom FROM uom WHERE uodsc ='" + UOMcBo.SelectedItem.ToString + "'", 0) + "','" + prodAmt.Text + "','" + ProdSAmt.Text + "','" + GLNumber.Text + "')")

                    If isMerchandise Then
                        Dim merchandiseId = CreateNewCode("SELECT * FROM hmerchandise ORDER BY idmrch DESC", "H", 4, 4)

                        ExecQueryNonReader("INSERT INTO hmerchandise VALUES('" & merchandiseId & "', '" & ProductID.Text & "', 0)")
                    End If

                    For Me.s = 0 To ProdSLoc.Rows.Count - 1
                        If ProdSLoc.Rows(s).Cells(0).Value.ToString <> "" Then
                            ExecQueryNonReader("INSERT INTO DPRODUCT VALUES('" + ProductID.Text + "','" + ProdSLoc.Rows(Me.s).Cells(0).Value.ToString + "','0','" + ProdSLoc.Rows(Me.s).Cells(3).Value.ToString + "')")
                        End If
                    Next s
                    MsgBox("New product Added")
                    notes.Visible = False
                    Reset()
                    entryOpen()
                    addItem.Visible = False
                    removeItem.Visible = False
                End If

            End If

        Else 'edit
            If ProductDesc.Text = "" Then
                MsgBox("Please entry product Description")
            ElseIf prodAmt.Text = "0" Or prodAmt.Text = "" Then
                MsgBox("Please entry product Price")
            ElseIf ProductType.SelectedIndex = -1 Then
                MsgBox("Please select product type")
            ElseIf UOMcBo.SelectedIndex = -1 Then
                MsgBox("Please entry select unit of measure")
            ElseIf ProdSLoc.Rows.Count = 0 Then
                MsgBox("Please assign Product to storage location")
            ElseIf checkDefault() = 0 Then
                MsgBox("Please select the default storage location")
            ElseIf GLNumber.Text = "" Then
                MsgBox("Please enter GL Account for Product")
            Else
                If MsgBox("modify product", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("UPDATE hProduct set idptp = '" + ProductType.SelectedItem.ToString.Substring(0, 4) + "',ppamt = '" + prodAmt.Text + "',pdtds='" + ProductDesc.Text + "',psamt = '" + ProdSAmt.Text + "',glnum = '" + GLNumber.Text + "' WHERE idpdt='" + ProductID.Text + "'")
                    ' ExecQueryNonReader("DELETE FROM dproduct WHERE idpdt LIKE '" + ProductID.Text + "'")
                    ' For Me.s = 0 To ProdSLoc.Rows.Count - 1
                    'If ProdSLoc.Rows(s).Cells(0).Value.ToString <> "" Then
                    'ExecQueryNonReader("INSERT INTO DPRODUCT VALUES('" + ProductID.Text + "','" + ProdSLoc.Rows(Me.s).Cells(0).Value.ToString + "','0','" + ProdSLoc.Rows(Me.s).Cells(3).Value.ToString + "')")
                    '  End If
                    '   Next s
                    MsgBox("product modified")
                    loadProductTable()

                    entryOpen()
                    ProductID.Text = "xxxxxx"
                    clearAll()

                    'stockTransferBtn.Visible = False
                End If
            End If


            'TabControl1.SelectedIndex = 0

        End If
        loadProductTable()
        ProductGridView.Enabled = True
        TabControl2.TabPages.Remove(TabPage5)
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        _005_01_Storage_Location.ShowDialog()

    End Sub


    Private Sub SlocView_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProdSLoc.KeyDown
        If e.KeyCode = Keys.F4 Then
            _005_01_Storage_Location.ShowDialog()

        End If
    End Sub

    Private Sub SlocView_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ProdSLoc.UserDeletingRow
        If ProdSLoc.CurrentRow.Cells(2).Value.ToString <> 0 Then
            MsgBox("cannot delete")
            e.Cancel = True
        Else

        End If
    End Sub

    Private Sub prodAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove.Click
        If checkToTransaction(ProductID.Text) = 1 Then
            MsgBox("This product cannot be remove because it has been used in transaction")
        ElseIf ProductID.Text = "xxxxxx" Then
            MsgBox("Please select product to be deleted")
        Else
            If MsgBox("Delete product?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("DELETE FROM hproduct WHERE idpdt = '" + ProductID.Text + "'")
                ExecQueryNonReader("DELETE FROM dproduct WHERE idpdt = '" + ProductID.Text + "'")
                MsgBox("Product data removed")
                loadProductTable()
                ProductID.Text = "xxxxxx"
                ProdSLoc.Rows.Clear()
                clearAll()

            End If
        End If
    End Sub
    Private Function checkDefault()
        Dim i, y As Integer
        y = 0
        For i = 0 To ProdSLoc.Rows.Count - 1
            If ProdSLoc.Rows(i).Cells(3).Value = True Then
                y = y + 1
            End If
        Next
        Return y
    End Function

    Private Sub SlocView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProdSLoc.CellEndEdit
        If e.ColumnIndex = 0 Then
            Try
                ProdSLoc.CurrentRow.Cells(1).Value = getText("SELECT slocd FROM sloc WHERE idslc LIKE '" + ProdSLoc.CurrentRow.Cells(0).Value.ToString + "'", 0)
                ProdSLoc.CurrentRow.Cells(2).Value = "0"
                ProdSLoc.CurrentRow.Cells(3).Value = False
                If SlocViewValidation() = 1 Then
                    MsgBox("false")
                Else
                    MsgBox("true")
                End If
            Catch ex As Exception
                Try
                    MsgBox("Storage Location with code '" + ProdSLoc.CurrentRow.Cells(0).Value.ToString + "' not found")
                    ProdSLoc.Rows.Remove(ProdSLoc.CurrentRow)
                    ProdSLoc.CurrentRow.Cells(1).Value = ""
                Catch ex1 As Exception
                End Try
            End Try
        ElseIf e.ColumnIndex = 1 Then
            Try
                ProdSLoc.CurrentRow.Cells(0).Value = getText("SELECT idslc FROM sloc WHERE slocd LIKE '" + ProdSLoc.CurrentRow.Cells(1).Value.ToString + "'", 0)
                ProdSLoc.CurrentRow.Cells(2).Value = "0"
                ProdSLoc.CurrentRow.Cells(3).Value = False
            Catch ex As Exception
                Try
                    MsgBox("Storage Location with desription '" + ProdSLoc.CurrentRow.Cells(1).Value.ToString + "' not found")
                    'SlocView.Rows.Remove(SlocView.CurrentRow)
                    'SlocView.CurrentRow.Cells(0).Value = ""
                Catch ex1 As Exception
                End Try
            End Try
        ElseIf e.ColumnIndex = 3 Then
            If checkDefault() > 1 Then
                MsgBox("Only one storage location that can be a default storage")
                ProdSLoc.CurrentRow.Cells(3).Value = False
            End If
        End If

    End Sub

    Private Sub LoadProductDetail()
        ProductID.Text = ProductGridView.CurrentRow.Cells(0).Value.ToString
        ProductType.Text = ProductGridView.CurrentRow.Cells(1).Value.ToString & "-" & ProductGridView.CurrentRow.Cells(2).Value.ToString
        ProductDesc.Text = ProductGridView.CurrentRow.Cells(3).Value.ToString
        prodAmt.Text = FormatNumber(ProductGridView.CurrentRow.Cells(4).Value.ToString, 0, TriState.False, TriState.False, TriState.False)
        ProdSAmt.Text = FormatNumber(ProductGridView.CurrentRow.Cells(5).Value.ToString, 0, TriState.False, TriState.False, TriState.False)
        TotalStock.Text = ProductGridView.CurrentRow.Cells(6).Value.ToString
        UOMcBo.Text = ProductGridView.CurrentRow.Cells(7).Value.ToString
        GLNumber.Text = ProductGridView.CurrentRow.Cells(8).Value.ToString
        'TabControl1.SelectedIndex = 1
        loadProductTabledetail()
    End Sub

    Private Sub ProductGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductGridView.CellClick
        LoadProductDetail()
    End Sub

    Private Sub addItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addItem.Click
        Dim last As Integer
        last = ProdSLoc.Rows.Count - 1
        If ProdSLoc.Rows.Count = 0 Then
            _005_01_Storage_Location.ShowDialog()

        Else
            If ProdSLoc.CurrentRow.Cells(0).Value = "" And ProdSLoc.CurrentRow.Cells(0).Value = "" Then
                MsgBox("Please Complete the storage location data")
            Else
                _005_01_Storage_Location.ShowDialog()
            End If
        End If

    End Sub

    Private Sub removeItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeItem.Click
        ProdSLoc.Rows.Remove(ProdSLoc.CurrentRow)
    End Sub


    Private Sub ProdSAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub prodAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If prodAmt.Text = "" Then
            prodAmt.Text = "0"
        End If
    End Sub

    Private Sub ProdSAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ProdSAmt.Text = "" Then
            ProdSAmt.Text = "0"
        End If
    End Sub
    Private Sub addSTFromCbo()
        Dim i As Integer
        For i = 0 To ProdSLoc.Rows.Count - 1
            _004_02_Stock_Transfers.toCbo.Items.Add(ProdSLoc.Rows(i).Cells(0).Value.ToString & " - " & ProdSLoc.Rows(i).Cells(1).Value.ToString)
            _004_02_Stock_Transfers.fromCBO.Items.Add(ProdSLoc.Rows(i).Cells(0).Value.ToString & " - " & ProdSLoc.Rows(i).Cells(1).Value.ToString)
        Next i
        _004_02_Stock_Transfers.toCbo.SelectedIndex = -1
        _004_02_Stock_Transfers.fromCBO.SelectedIndex = -1
    End Sub
    Private Sub stockTransferBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stockTransferBtn.Click
        If TotalStock.Text = "0" Then
            MsgBox("Stock Transfer can not be performed with no quantity")
        ElseIf ProdSLoc.Rows.Count < 2 Then
            MsgBox("Stock Transfer can not be performed only on 1 storage location")
        Else
            _004_02_Stock_Transfers.productID.Text = Me.ProductID.Text
            _004_02_Stock_Transfers.Prodesc.Text = Me.ProductDesc.Text
            addSTFromCbo()
            _004_02_Stock_Transfers.ShowDialog()
        End If
    End Sub




    Private Sub ProductType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductType.SelectedIndexChanged
        getProductcons()
    End Sub

    Private Sub prodAmt_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prodAmt.TextChanged
        If prodAmt.Text = "" Then
            prodAmt.Text = "0"
        End If
    End Sub

    Private Sub ProdSAmt_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdSAmt.TextChanged
        If ProdSAmt.Text = "" Then
            ProdSAmt.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If consume.Checked = True Then
            _005_13_Product_GL_Act.flag = "6"
        Else
            _005_13_Product_GL_Act.flag = "2"
        End If
        _005_13_Product_GL_Act.Show()

    End Sub
    Private Function getDescription()
        Try
            reader = ExecQueryReader("SELECT GLDES FROM GLACCOUNTMS WHERE GLNUM LIKE '" + GLNumber.Text + "'")
            reader.read()
            Return reader(0).ToString
        Catch ex As Exception

        End Try

    End Function

    Private Sub GLNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLNumber.TextChanged
        GLDesc.Text = getDescription()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ProductGridView.Rows.Count = 0 Then
            MsgBox("No data to be exported")
        Else
            excelExport(ProductGridView, "PRODUCT DATA AS OF " + Date.Today)
        End If
    End Sub
End Class