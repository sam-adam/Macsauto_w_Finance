<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_14_TransactionDetail
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CurrentPointLbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PointLbl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChangeTxt = New System.Windows.Forms.TextBox()
        Me.CreditRadio = New System.Windows.Forms.RadioButton()
        Me.DebitRadio = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CashRadio = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GrandTotalLbl = New System.Windows.Forms.Label()
        Me.PaymentTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VehicleRegLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VehicleSizeTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VehicleColorTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VehicleModelTxt = New System.Windows.Forms.TextBox()
        Me.MotorRadio = New System.Windows.Forms.RadioButton()
        Me.CarRadio = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VehicleBrandTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerCellphoneTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerPhoneTxt = New System.Windows.Forms.TextBox()
        Me.IsMemberChk = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerNameTxt = New System.Windows.Forms.TextBox()
        Me.TransactionDetailDataGrid = New System.Windows.Forms.DataGridView()
        Me.ItemTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemUoMCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDiscountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemSubTotalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRemarkcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TransactionDetailDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer.Panel1.Controls.Add(Me.DateTxt)
        Me.SplitContainer.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer.Panel1.Controls.Add(Me.CustomerCellphoneTxt)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer.Panel1.Controls.Add(Me.CustomerPhoneTxt)
        Me.SplitContainer.Panel1.Controls.Add(Me.IsMemberChk)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel1.Controls.Add(Me.CustomerNameTxt)
        Me.SplitContainer.Panel1MinSize = 250
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.TransactionDetailDataGrid)
        Me.SplitContainer.Size = New System.Drawing.Size(867, 455)
        Me.SplitContainer.SplitterDistance = 260
        Me.SplitContainer.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.CurrentPointLbl)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.PointLbl)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ChangeTxt)
        Me.GroupBox2.Controls.Add(Me.CreditRadio)
        Me.GroupBox2.Controls.Add(Me.DebitRadio)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CashRadio)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.GrandTotalLbl)
        Me.GroupBox2.Controls.Add(Me.PaymentTxt)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 153)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Data"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(237, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 17)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Points Had:"
        '
        'CurrentPointLbl
        '
        Me.CurrentPointLbl.AutoSize = True
        Me.CurrentPointLbl.Location = New System.Drawing.Point(346, 91)
        Me.CurrentPointLbl.Name = "CurrentPointLbl"
        Me.CurrentPointLbl.Size = New System.Drawing.Size(0, 17)
        Me.CurrentPointLbl.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(237, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Points Eearned:"
        '
        'PointLbl
        '
        Me.PointLbl.AutoSize = True
        Me.PointLbl.Location = New System.Drawing.Point(346, 120)
        Me.PointLbl.Name = "PointLbl"
        Me.PointLbl.Size = New System.Drawing.Size(0, 17)
        Me.PointLbl.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Change"
        '
        'ChangeTxt
        '
        Me.ChangeTxt.ForeColor = System.Drawing.Color.Black
        Me.ChangeTxt.Location = New System.Drawing.Point(83, 117)
        Me.ChangeTxt.Name = "ChangeTxt"
        Me.ChangeTxt.ReadOnly = True
        Me.ChangeTxt.Size = New System.Drawing.Size(148, 23)
        Me.ChangeTxt.TabIndex = 18
        Me.ChangeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CreditRadio
        '
        Me.CreditRadio.AutoCheck = False
        Me.CreditRadio.AutoSize = True
        Me.CreditRadio.ForeColor = System.Drawing.Color.Black
        Me.CreditRadio.Location = New System.Drawing.Point(244, 60)
        Me.CreditRadio.Name = "CreditRadio"
        Me.CreditRadio.Size = New System.Drawing.Size(97, 21)
        Me.CreditRadio.TabIndex = 17
        Me.CreditRadio.TabStop = True
        Me.CreditRadio.Text = "Credit Card"
        Me.CreditRadio.UseVisualStyleBackColor = True
        '
        'DebitRadio
        '
        Me.DebitRadio.AutoCheck = False
        Me.DebitRadio.AutoSize = True
        Me.DebitRadio.ForeColor = System.Drawing.Color.Black
        Me.DebitRadio.Location = New System.Drawing.Point(147, 60)
        Me.DebitRadio.Name = "DebitRadio"
        Me.DebitRadio.Size = New System.Drawing.Size(91, 21)
        Me.DebitRadio.TabIndex = 15
        Me.DebitRadio.TabStop = True
        Me.DebitRadio.Text = "Debit card"
        Me.DebitRadio.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Grand Total:"
        '
        'CashRadio
        '
        Me.CashRadio.AutoCheck = False
        Me.CashRadio.AutoSize = True
        Me.CashRadio.ForeColor = System.Drawing.Color.Black
        Me.CashRadio.Location = New System.Drawing.Point(83, 60)
        Me.CashRadio.Name = "CashRadio"
        Me.CashRadio.Size = New System.Drawing.Size(58, 21)
        Me.CashRadio.TabIndex = 14
        Me.CashRadio.TabStop = True
        Me.CashRadio.Text = "Cash"
        Me.CashRadio.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(14, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Payment"
        '
        'GrandTotalLbl
        '
        Me.GrandTotalLbl.AutoSize = True
        Me.GrandTotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GrandTotalLbl.ForeColor = System.Drawing.Color.Black
        Me.GrandTotalLbl.Location = New System.Drawing.Point(132, 32)
        Me.GrandTotalLbl.Name = "GrandTotalLbl"
        Me.GrandTotalLbl.Size = New System.Drawing.Size(0, 24)
        Me.GrandTotalLbl.TabIndex = 14
        '
        'PaymentTxt
        '
        Me.PaymentTxt.ForeColor = System.Drawing.Color.Black
        Me.PaymentTxt.Location = New System.Drawing.Point(83, 88)
        Me.PaymentTxt.Name = "PaymentTxt"
        Me.PaymentTxt.ReadOnly = True
        Me.PaymentTxt.Size = New System.Drawing.Size(148, 23)
        Me.PaymentTxt.TabIndex = 14
        Me.PaymentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Date"
        '
        'DateTxt
        '
        Me.DateTxt.Location = New System.Drawing.Point(126, 34)
        Me.DateTxt.Name = "DateTxt"
        Me.DateTxt.ReadOnly = True
        Me.DateTxt.Size = New System.Drawing.Size(250, 23)
        Me.DateTxt.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VehicleRegLbl)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.VehicleSizeTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.VehicleColorTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.VehicleModelTxt)
        Me.GroupBox1.Controls.Add(Me.MotorRadio)
        Me.GroupBox1.Controls.Add(Me.CarRadio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.VehicleBrandTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 153)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle Data"
        '
        'VehicleRegLbl
        '
        Me.VehicleRegLbl.AutoSize = True
        Me.VehicleRegLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.VehicleRegLbl.ForeColor = System.Drawing.Color.Black
        Me.VehicleRegLbl.Location = New System.Drawing.Point(59, 32)
        Me.VehicleRegLbl.Name = "VehicleRegLbl"
        Me.VehicleRegLbl.Size = New System.Drawing.Size(0, 24)
        Me.VehicleRegLbl.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(228, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Size"
        '
        'VehicleSizeTxt
        '
        Me.VehicleSizeTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleSizeTxt.Location = New System.Drawing.Point(269, 117)
        Me.VehicleSizeTxt.Name = "VehicleSizeTxt"
        Me.VehicleSizeTxt.ReadOnly = True
        Me.VehicleSizeTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleSizeTxt.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Color"
        '
        'VehicleColorTxt
        '
        Me.VehicleColorTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleColorTxt.Location = New System.Drawing.Point(63, 117)
        Me.VehicleColorTxt.Name = "VehicleColorTxt"
        Me.VehicleColorTxt.ReadOnly = True
        Me.VehicleColorTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleColorTxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(217, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Model"
        '
        'VehicleModelTxt
        '
        Me.VehicleModelTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleModelTxt.Location = New System.Drawing.Point(269, 88)
        Me.VehicleModelTxt.Name = "VehicleModelTxt"
        Me.VehicleModelTxt.ReadOnly = True
        Me.VehicleModelTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleModelTxt.TabIndex = 7
        '
        'MotorRadio
        '
        Me.MotorRadio.AutoCheck = False
        Me.MotorRadio.AutoSize = True
        Me.MotorRadio.ForeColor = System.Drawing.Color.Black
        Me.MotorRadio.Location = New System.Drawing.Point(117, 60)
        Me.MotorRadio.Name = "MotorRadio"
        Me.MotorRadio.Size = New System.Drawing.Size(94, 21)
        Me.MotorRadio.TabIndex = 6
        Me.MotorRadio.TabStop = True
        Me.MotorRadio.Text = "Motorcycle"
        Me.MotorRadio.UseVisualStyleBackColor = True
        '
        'CarRadio
        '
        Me.CarRadio.AutoCheck = False
        Me.CarRadio.AutoSize = True
        Me.CarRadio.ForeColor = System.Drawing.Color.Black
        Me.CarRadio.Location = New System.Drawing.Point(63, 60)
        Me.CarRadio.Name = "CarRadio"
        Me.CarRadio.Size = New System.Drawing.Size(48, 21)
        Me.CarRadio.TabIndex = 5
        Me.CarRadio.TabStop = True
        Me.CarRadio.Text = "Car"
        Me.CarRadio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Brand"
        '
        'VehicleBrandTxt
        '
        Me.VehicleBrandTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleBrandTxt.Location = New System.Drawing.Point(63, 88)
        Me.VehicleBrandTxt.Name = "VehicleBrandTxt"
        Me.VehicleBrandTxt.ReadOnly = True
        Me.VehicleBrandTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleBrandTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cellphone"
        '
        'CustomerCellphoneTxt
        '
        Me.CustomerCellphoneTxt.Location = New System.Drawing.Point(587, 34)
        Me.CustomerCellphoneTxt.Name = "CustomerCellphoneTxt"
        Me.CustomerCellphoneTxt.ReadOnly = True
        Me.CustomerCellphoneTxt.Size = New System.Drawing.Size(160, 23)
        Me.CustomerCellphoneTxt.TabIndex = 17
        Me.CustomerCellphoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(532, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Phone"
        '
        'CustomerPhoneTxt
        '
        Me.CustomerPhoneTxt.Location = New System.Drawing.Point(587, 5)
        Me.CustomerPhoneTxt.Name = "CustomerPhoneTxt"
        Me.CustomerPhoneTxt.ReadOnly = True
        Me.CustomerPhoneTxt.Size = New System.Drawing.Size(160, 23)
        Me.CustomerPhoneTxt.TabIndex = 15
        Me.CustomerPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IsMemberChk
        '
        Me.IsMemberChk.AutoSize = True
        Me.IsMemberChk.Enabled = False
        Me.IsMemberChk.Location = New System.Drawing.Point(126, 63)
        Me.IsMemberChk.Name = "IsMemberChk"
        Me.IsMemberChk.Size = New System.Drawing.Size(78, 21)
        Me.IsMemberChk.TabIndex = 14
        Me.IsMemberChk.Text = "Member"
        Me.IsMemberChk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer"
        '
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.Location = New System.Drawing.Point(126, 5)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.ReadOnly = True
        Me.CustomerNameTxt.Size = New System.Drawing.Size(250, 23)
        Me.CustomerNameTxt.TabIndex = 12
        '
        'TransactionDetailDataGrid
        '
        Me.TransactionDetailDataGrid.AllowUserToAddRows = False
        Me.TransactionDetailDataGrid.AllowUserToDeleteRows = False
        Me.TransactionDetailDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TransactionDetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDetailDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemTypeCol, Me.ItemNameCol, Me.ItemUoMCol, Me.ItemPriceCol, Me.ItemQuantityCol, Me.ItemDiscountCol, Me.ItemSubTotalCol, Me.ItemRemarkcol})
        Me.TransactionDetailDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDetailDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.TransactionDetailDataGrid.Name = "TransactionDetailDataGrid"
        Me.TransactionDetailDataGrid.ReadOnly = True
        Me.TransactionDetailDataGrid.RowHeadersVisible = False
        Me.TransactionDetailDataGrid.Size = New System.Drawing.Size(863, 187)
        Me.TransactionDetailDataGrid.TabIndex = 1
        '
        'ItemTypeCol
        '
        Me.ItemTypeCol.HeaderText = "Item Type"
        Me.ItemTypeCol.Name = "ItemTypeCol"
        Me.ItemTypeCol.ReadOnly = True
        Me.ItemTypeCol.Width = 95
        '
        'ItemNameCol
        '
        Me.ItemNameCol.HeaderText = "Name"
        Me.ItemNameCol.Name = "ItemNameCol"
        Me.ItemNameCol.ReadOnly = True
        Me.ItemNameCol.Width = 70
        '
        'ItemUoMCol
        '
        Me.ItemUoMCol.HeaderText = "Measurement"
        Me.ItemUoMCol.Name = "ItemUoMCol"
        Me.ItemUoMCol.ReadOnly = True
        Me.ItemUoMCol.Width = 119
        '
        'ItemPriceCol
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ItemPriceCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.ItemPriceCol.HeaderText = "Price"
        Me.ItemPriceCol.Name = "ItemPriceCol"
        Me.ItemPriceCol.ReadOnly = True
        Me.ItemPriceCol.Width = 65
        '
        'ItemQuantityCol
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ItemQuantityCol.DefaultCellStyle = DataGridViewCellStyle6
        Me.ItemQuantityCol.HeaderText = "Quantity"
        Me.ItemQuantityCol.Name = "ItemQuantityCol"
        Me.ItemQuantityCol.ReadOnly = True
        Me.ItemQuantityCol.Width = 86
        '
        'ItemDiscountCol
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        Me.ItemDiscountCol.DefaultCellStyle = DataGridViewCellStyle7
        Me.ItemDiscountCol.HeaderText = "Discount"
        Me.ItemDiscountCol.Name = "ItemDiscountCol"
        Me.ItemDiscountCol.ReadOnly = True
        Me.ItemDiscountCol.Width = 88
        '
        'ItemSubTotalCol
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ItemSubTotalCol.DefaultCellStyle = DataGridViewCellStyle8
        Me.ItemSubTotalCol.HeaderText = "SubTotal"
        Me.ItemSubTotalCol.Name = "ItemSubTotalCol"
        Me.ItemSubTotalCol.ReadOnly = True
        Me.ItemSubTotalCol.Width = 90
        '
        'ItemRemarkcol
        '
        Me.ItemRemarkcol.HeaderText = "Remark"
        Me.ItemRemarkcol.Name = "ItemRemarkcol"
        Me.ItemRemarkcol.ReadOnly = True
        Me.ItemRemarkcol.Width = 82
        '
        '_005_14_TransactionDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(867, 0)
        Me.Name = "_005_14_TransactionDetail"
        Me.Size = New System.Drawing.Size(867, 455)
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TransactionDetailDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CurrentPointLbl As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PointLbl As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ChangeTxt As System.Windows.Forms.TextBox
    Friend WithEvents CreditRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DebitRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CashRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GrandTotalLbl As System.Windows.Forms.Label
    Friend WithEvents PaymentTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VehicleRegLbl As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VehicleSizeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents VehicleColorTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VehicleModelTxt As System.Windows.Forms.TextBox
    Friend WithEvents MotorRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CarRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VehicleBrandTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomerCellphoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustomerPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents IsMemberChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomerNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents TransactionDetailDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ItemTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemUoMCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemPriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDiscountCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemSubTotalCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemRemarkcol As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
