<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _003_04_TrMerchandiseRedemption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_003_04_TrMerchandiseRedemption))
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.RedemptionIdLbl = New System.Windows.Forms.Label()
        Me.RedemptionDate = New System.Windows.Forms.DateTimePicker()
        Me.ServicePanel = New System.Windows.Forms.Panel()
        Me.AddProductBtn = New System.Windows.Forms.Button()
        Me.RemoveProductBtn = New System.Windows.Forms.Button()
        Me.MerchandiseDataGrid = New System.Windows.Forms.DataGridView()
        Me.ProductIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductQuantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductRemainingQtyCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductMeasurementCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandisePointCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPurchasePriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.PricePanel = New System.Windows.Forms.Panel()
        Me.PointLeftLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PointRequiredLbl = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CustomerPanel = New System.Windows.Forms.Panel()
        Me.CustomerPointTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.IsMemberChk = New System.Windows.Forms.CheckBox()
        Me.CustomerCellphoneTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FindCustomerBtn = New System.Windows.Forms.Button()
        Me.CustomerPhoneTxt = New System.Windows.Forms.TextBox()
        Me.CustomerAddressTxt = New System.Windows.Forms.TextBox()
        Me.CustomerNameTxt = New System.Windows.Forms.TextBox()
        Me.CustomerIdTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.HelpF4Lbl = New System.Windows.Forms.Label()
        Me.HelpF2Lbl = New System.Windows.Forms.Label()
        Me.HelpF1Lbl = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        Me.ServicePanel.SuspendLayout()
        CType(Me.MerchandiseDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PricePanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.CustomerPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gold
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.RedemptionIdLbl)
        Me.Panel8.Controls.Add(Me.RedemptionDate)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1054, 51)
        Me.Panel8.TabIndex = 30
        '
        'RedemptionIdLbl
        '
        Me.RedemptionIdLbl.AutoSize = True
        Me.RedemptionIdLbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedemptionIdLbl.Location = New System.Drawing.Point(4, 12)
        Me.RedemptionIdLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RedemptionIdLbl.Name = "RedemptionIdLbl"
        Me.RedemptionIdLbl.Size = New System.Drawing.Size(166, 25)
        Me.RedemptionIdLbl.TabIndex = 16
        Me.RedemptionIdLbl.Text = "New Redemption"
        '
        'RedemptionDate
        '
        Me.RedemptionDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RedemptionDate.Enabled = False
        Me.RedemptionDate.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.RedemptionDate.Location = New System.Drawing.Point(799, 12)
        Me.RedemptionDate.Margin = New System.Windows.Forms.Padding(4)
        Me.RedemptionDate.Name = "RedemptionDate"
        Me.RedemptionDate.Size = New System.Drawing.Size(242, 25)
        Me.RedemptionDate.TabIndex = 17
        '
        'ServicePanel
        '
        Me.ServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServicePanel.Controls.Add(Me.AddProductBtn)
        Me.ServicePanel.Controls.Add(Me.RemoveProductBtn)
        Me.ServicePanel.Controls.Add(Me.MerchandiseDataGrid)
        Me.ServicePanel.Controls.Add(Me.Panel4)
        Me.ServicePanel.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ServicePanel.Location = New System.Drawing.Point(528, 8)
        Me.ServicePanel.Name = "ServicePanel"
        Me.ServicePanel.Size = New System.Drawing.Size(514, 157)
        Me.ServicePanel.TabIndex = 34
        '
        'AddProductBtn
        '
        Me.AddProductBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddProductBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.AddProductBtn.Location = New System.Drawing.Point(255, 121)
        Me.AddProductBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddProductBtn.Name = "AddProductBtn"
        Me.AddProductBtn.Size = New System.Drawing.Size(113, 30)
        Me.AddProductBtn.TabIndex = 20
        Me.AddProductBtn.Text = "Add Product"
        Me.AddProductBtn.UseVisualStyleBackColor = True
        '
        'RemoveProductBtn
        '
        Me.RemoveProductBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveProductBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveProductBtn.Enabled = False
        Me.RemoveProductBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.RemoveProductBtn.Location = New System.Drawing.Point(376, 121)
        Me.RemoveProductBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RemoveProductBtn.Name = "RemoveProductBtn"
        Me.RemoveProductBtn.Size = New System.Drawing.Size(132, 30)
        Me.RemoveProductBtn.TabIndex = 19
        Me.RemoveProductBtn.Text = "Remove Product"
        Me.RemoveProductBtn.UseVisualStyleBackColor = True
        '
        'MerchandiseDataGrid
        '
        Me.MerchandiseDataGrid.AllowUserToAddRows = False
        Me.MerchandiseDataGrid.AllowUserToDeleteRows = False
        Me.MerchandiseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MerchandiseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MerchandiseDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIdCol, Me.MerchandiseIdCol, Me.ProductDescCol, Me.ProductQuantityCol, Me.ProductRemainingQtyCol, Me.ProductMeasurementCol, Me.MerchandisePointCol, Me.ProductPurchasePriceCol})
        Me.MerchandiseDataGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.MerchandiseDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.MerchandiseDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.MerchandiseDataGrid.Name = "MerchandiseDataGrid"
        Me.MerchandiseDataGrid.RowHeadersVisible = False
        Me.MerchandiseDataGrid.Size = New System.Drawing.Size(512, 110)
        Me.MerchandiseDataGrid.TabIndex = 18
        '
        'ProductIdCol
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProductIdCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.ProductIdCol.HeaderText = "Product ID"
        Me.ProductIdCol.Name = "ProductIdCol"
        Me.ProductIdCol.ReadOnly = True
        Me.ProductIdCol.Visible = False
        Me.ProductIdCol.Width = 75
        '
        'MerchandiseIdCol
        '
        Me.MerchandiseIdCol.HeaderText = "Merchandise ID"
        Me.MerchandiseIdCol.Name = "MerchandiseIdCol"
        Me.MerchandiseIdCol.ReadOnly = True
        Me.MerchandiseIdCol.Visible = False
        Me.MerchandiseIdCol.Width = 105
        '
        'ProductDescCol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProductDescCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.ProductDescCol.HeaderText = "Merchandise"
        Me.ProductDescCol.Name = "ProductDescCol"
        Me.ProductDescCol.ReadOnly = True
        Me.ProductDescCol.Width = 108
        '
        'ProductQuantityCol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.ProductQuantityCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductQuantityCol.HeaderText = "Quantity"
        Me.ProductQuantityCol.Name = "ProductQuantityCol"
        Me.ProductQuantityCol.Width = 81
        '
        'ProductRemainingQtyCol
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Format = "N0"
        Me.ProductRemainingQtyCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.ProductRemainingQtyCol.HeaderText = "Stock"
        Me.ProductRemainingQtyCol.Name = "ProductRemainingQtyCol"
        Me.ProductRemainingQtyCol.ReadOnly = True
        Me.ProductRemainingQtyCol.Width = 64
        '
        'ProductMeasurementCol
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProductMeasurementCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.ProductMeasurementCol.HeaderText = "Measurement"
        Me.ProductMeasurementCol.Name = "ProductMeasurementCol"
        Me.ProductMeasurementCol.ReadOnly = True
        Me.ProductMeasurementCol.Width = 113
        '
        'MerchandisePointCol
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        Me.MerchandisePointCol.DefaultCellStyle = DataGridViewCellStyle6
        Me.MerchandisePointCol.HeaderText = "Point"
        Me.MerchandisePointCol.Name = "MerchandisePointCol"
        Me.MerchandisePointCol.ReadOnly = True
        Me.MerchandisePointCol.Width = 62
        '
        'ProductPurchasePriceCol
        '
        Me.ProductPurchasePriceCol.HeaderText = "Purchase Price"
        Me.ProductPurchasePriceCol.Name = "ProductPurchasePriceCol"
        Me.ProductPurchasePriceCol.ReadOnly = True
        Me.ProductPurchasePriceCol.Visible = False
        Me.ProductPurchasePriceCol.Width = 117
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(-1, 126)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(180, 30)
        Me.Panel4.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "MERCHANDISE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Controls.Add(Me.SaveBtn)
        Me.Panel2.Controls.Add(Me.PricePanel)
        Me.Panel2.Controls.Add(Me.CustomerPanel)
        Me.Panel2.Controls.Add(Me.ServicePanel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1054, 290)
        Me.Panel2.TabIndex = 38
        '
        'CancelBtn
        '
        Me.CancelBtn.BackgroundImage = CType(resources.GetObject("CancelBtn.BackgroundImage"), System.Drawing.Image)
        Me.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelBtn.Location = New System.Drawing.Point(981, 225)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(61, 56)
        Me.CancelBtn.TabIndex = 40
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.BackgroundImage = CType(resources.GetObject("SaveBtn.BackgroundImage"), System.Drawing.Image)
        Me.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaveBtn.Location = New System.Drawing.Point(913, 225)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(60, 57)
        Me.SaveBtn.TabIndex = 39
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'PricePanel
        '
        Me.PricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PricePanel.Controls.Add(Me.PointLeftLbl)
        Me.PricePanel.Controls.Add(Me.Label8)
        Me.PricePanel.Controls.Add(Me.Panel6)
        Me.PricePanel.Controls.Add(Me.PointRequiredLbl)
        Me.PricePanel.Controls.Add(Me.Label16)
        Me.PricePanel.Location = New System.Drawing.Point(528, 172)
        Me.PricePanel.Name = "PricePanel"
        Me.PricePanel.Size = New System.Drawing.Size(354, 109)
        Me.PricePanel.TabIndex = 38
        '
        'PointLeftLbl
        '
        Me.PointLeftLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PointLeftLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PointLeftLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PointLeftLbl.Location = New System.Drawing.Point(175, 68)
        Me.PointLeftLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PointLeftLbl.Name = "PointLeftLbl"
        Me.PointLeftLbl.Size = New System.Drawing.Size(174, 25)
        Me.PointLeftLbl.TabIndex = 26
        Me.PointLeftLbl.Text = "0"
        Me.PointLeftLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(63, 68)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Point Left"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gold
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(352, 30)
        Me.Panel6.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(350, 28)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "SUMMARY"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PointRequiredLbl
        '
        Me.PointRequiredLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PointRequiredLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PointRequiredLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PointRequiredLbl.Location = New System.Drawing.Point(175, 34)
        Me.PointRequiredLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PointRequiredLbl.Name = "PointRequiredLbl"
        Me.PointRequiredLbl.Size = New System.Drawing.Size(174, 25)
        Me.PointRequiredLbl.TabIndex = 16
        Me.PointRequiredLbl.Text = "0"
        Me.PointRequiredLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(20, 34)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 25)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Point Required"
        '
        'CustomerPanel
        '
        Me.CustomerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerPanel.Controls.Add(Me.CustomerPointTxt)
        Me.CustomerPanel.Controls.Add(Me.Label5)
        Me.CustomerPanel.Controls.Add(Me.Panel1)
        Me.CustomerPanel.Controls.Add(Me.IsMemberChk)
        Me.CustomerPanel.Controls.Add(Me.CustomerCellphoneTxt)
        Me.CustomerPanel.Controls.Add(Me.Label12)
        Me.CustomerPanel.Controls.Add(Me.FindCustomerBtn)
        Me.CustomerPanel.Controls.Add(Me.CustomerPhoneTxt)
        Me.CustomerPanel.Controls.Add(Me.CustomerAddressTxt)
        Me.CustomerPanel.Controls.Add(Me.CustomerNameTxt)
        Me.CustomerPanel.Controls.Add(Me.CustomerIdTxt)
        Me.CustomerPanel.Controls.Add(Me.Label2)
        Me.CustomerPanel.Controls.Add(Me.Label4)
        Me.CustomerPanel.Controls.Add(Me.Label1)
        Me.CustomerPanel.Controls.Add(Me.Label3)
        Me.CustomerPanel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerPanel.Location = New System.Drawing.Point(10, 8)
        Me.CustomerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerPanel.Name = "CustomerPanel"
        Me.CustomerPanel.Size = New System.Drawing.Size(511, 273)
        Me.CustomerPanel.TabIndex = 37
        '
        'CustomerPointTxt
        '
        Me.CustomerPointTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerPointTxt.Location = New System.Drawing.Point(88, 223)
        Me.CustomerPointTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerPointTxt.Name = "CustomerPointTxt"
        Me.CustomerPointTxt.ReadOnly = True
        Me.CustomerPointTxt.Size = New System.Drawing.Size(72, 25)
        Me.CustomerPointTxt.TabIndex = 14
        Me.CustomerPointTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 225)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Point"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Location = New System.Drawing.Point(330, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 30)
        Me.Panel1.TabIndex = 12
        '
        'Label26
        '
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(0, 0)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(178, 28)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "MEMBER DATA"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IsMemberChk
        '
        Me.IsMemberChk.AutoCheck = False
        Me.IsMemberChk.AutoSize = True
        Me.IsMemberChk.Location = New System.Drawing.Point(168, 224)
        Me.IsMemberChk.Margin = New System.Windows.Forms.Padding(4)
        Me.IsMemberChk.Name = "IsMemberChk"
        Me.IsMemberChk.Size = New System.Drawing.Size(162, 21)
        Me.IsMemberChk.TabIndex = 11
        Me.IsMemberChk.Text = "Macsauto Membership"
        Me.IsMemberChk.UseVisualStyleBackColor = True
        '
        'CustomerCellphoneTxt
        '
        Me.CustomerCellphoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerCellphoneTxt.Location = New System.Drawing.Point(88, 190)
        Me.CustomerCellphoneTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerCellphoneTxt.Name = "CustomerCellphoneTxt"
        Me.CustomerCellphoneTxt.Size = New System.Drawing.Size(227, 25)
        Me.CustomerCellphoneTxt.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 192)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Cellphone "
        '
        'FindCustomerBtn
        '
        Me.FindCustomerBtn.Location = New System.Drawing.Point(265, 12)
        Me.FindCustomerBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.FindCustomerBtn.Name = "FindCustomerBtn"
        Me.FindCustomerBtn.Size = New System.Drawing.Size(49, 25)
        Me.FindCustomerBtn.TabIndex = 8
        Me.FindCustomerBtn.Text = "..."
        Me.FindCustomerBtn.UseVisualStyleBackColor = True
        '
        'CustomerPhoneTxt
        '
        Me.CustomerPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerPhoneTxt.Location = New System.Drawing.Point(88, 157)
        Me.CustomerPhoneTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerPhoneTxt.Name = "CustomerPhoneTxt"
        Me.CustomerPhoneTxt.Size = New System.Drawing.Size(227, 25)
        Me.CustomerPhoneTxt.TabIndex = 7
        '
        'CustomerAddressTxt
        '
        Me.CustomerAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerAddressTxt.Location = New System.Drawing.Point(88, 78)
        Me.CustomerAddressTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerAddressTxt.Multiline = True
        Me.CustomerAddressTxt.Name = "CustomerAddressTxt"
        Me.CustomerAddressTxt.Size = New System.Drawing.Size(300, 71)
        Me.CustomerAddressTxt.TabIndex = 6
        '
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerNameTxt.Location = New System.Drawing.Point(88, 45)
        Me.CustomerNameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.Size = New System.Drawing.Size(300, 25)
        Me.CustomerNameTxt.TabIndex = 5
        '
        'CustomerIdTxt
        '
        Me.CustomerIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerIdTxt.Location = New System.Drawing.Point(88, 12)
        Me.CustomerIdTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerIdTxt.MaxLength = 11
        Me.CustomerIdTxt.Name = "CustomerIdTxt"
        Me.CustomerIdTxt.ReadOnly = True
        Me.CustomerIdTxt.Size = New System.Drawing.Size(170, 25)
        Me.CustomerIdTxt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gold
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.HelpF4Lbl)
        Me.Panel7.Controls.Add(Me.HelpF2Lbl)
        Me.Panel7.Controls.Add(Me.HelpF1Lbl)
        Me.Panel7.Controls.Add(Me.Label32)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 341)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1054, 32)
        Me.Panel7.TabIndex = 38
        '
        'HelpF4Lbl
        '
        Me.HelpF4Lbl.AutoSize = True
        Me.HelpF4Lbl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.HelpF4Lbl.ForeColor = System.Drawing.Color.Red
        Me.HelpF4Lbl.Location = New System.Drawing.Point(326, 7)
        Me.HelpF4Lbl.Name = "HelpF4Lbl"
        Me.HelpF4Lbl.Size = New System.Drawing.Size(174, 17)
        Me.HelpF4Lbl.TabIndex = 4
        Me.HelpF4Lbl.Text = "F4 - Read From RFID Reader"
        '
        'HelpF2Lbl
        '
        Me.HelpF2Lbl.AutoSize = True
        Me.HelpF2Lbl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.HelpF2Lbl.ForeColor = System.Drawing.Color.Red
        Me.HelpF2Lbl.Location = New System.Drawing.Point(159, 7)
        Me.HelpF2Lbl.Name = "HelpF2Lbl"
        Me.HelpF2Lbl.Size = New System.Drawing.Size(152, 17)
        Me.HelpF2Lbl.TabIndex = 3
        Me.HelpF2Lbl.Text = "F2 - Search Merchandise"
        '
        'HelpF1Lbl
        '
        Me.HelpF1Lbl.AutoSize = True
        Me.HelpF1Lbl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.HelpF1Lbl.ForeColor = System.Drawing.Color.Red
        Me.HelpF1Lbl.Location = New System.Drawing.Point(10, 7)
        Me.HelpF1Lbl.Name = "HelpF1Lbl"
        Me.HelpF1Lbl.Size = New System.Drawing.Size(133, 17)
        Me.HelpF1Lbl.TabIndex = 1
        Me.HelpF1Lbl.Text = "F1 - Search Customer"
        '
        'Label32
        '
        Me.Label32.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(839, 9)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(209, 14)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Copyrights © 2013 – Macsauto Indonesia"
        '
        '_003_04_TrMerchandiseRedemption
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1054, 373)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_003_04_TrMerchandiseRedemption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ServicePanel.ResumeLayout(False)
        CType(Me.MerchandiseDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PricePanel.ResumeLayout(False)
        Me.PricePanel.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.CustomerPanel.ResumeLayout(False)
        Me.CustomerPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ServicePanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RedemptionIdLbl As System.Windows.Forms.Label
    Friend WithEvents RedemptionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustomerPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents IsMemberChk As System.Windows.Forms.CheckBox
    Friend WithEvents CustomerCellphoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FindCustomerBtn As System.Windows.Forms.Button
    Friend WithEvents CustomerPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents CustomerAddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents CustomerIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents HelpF4Lbl As System.Windows.Forms.Label
    Friend WithEvents HelpF1Lbl As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents HelpF2Lbl As System.Windows.Forms.Label
    Friend WithEvents CustomerPointTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MerchandiseDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AddProductBtn As System.Windows.Forms.Button
    Friend WithEvents RemoveProductBtn As System.Windows.Forms.Button
    Friend WithEvents PricePanel As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PointRequiredLbl As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PointLeftLbl As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents ProductIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductDescCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductQuantityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductRemainingQtyCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductMeasurementCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandisePointCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductPurchasePriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
