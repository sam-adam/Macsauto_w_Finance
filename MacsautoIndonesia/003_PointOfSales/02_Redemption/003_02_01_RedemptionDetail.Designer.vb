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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_003_04_TrMerchandiseRedemption))
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ServicePanel = New System.Windows.Forms.Panel()
        Me.MerchandiseGrid = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Point = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.RemoveServBtn = New System.Windows.Forms.Button()
        Me.AddServiceBtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TotalPointRequired = New System.Windows.Forms.TextBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RedemptionIdLbl = New System.Windows.Forms.Label()
        Me.RedemptionDate = New System.Windows.Forms.DateTimePicker()
        Me.CustomerPanel = New System.Windows.Forms.Panel()
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
        Me.HelpF1Lbl = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.HelpF2Lbl = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        Me.ServicePanel.SuspendLayout()
        CType(Me.MerchandiseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel8.Size = New System.Drawing.Size(924, 51)
        Me.Panel8.TabIndex = 30
        '
        'ServicePanel
        '
        Me.ServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServicePanel.Controls.Add(Me.MerchandiseGrid)
        Me.ServicePanel.Controls.Add(Me.Panel5)
        Me.ServicePanel.Controls.Add(Me.RemoveServBtn)
        Me.ServicePanel.Controls.Add(Me.AddServiceBtn)
        Me.ServicePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicePanel.Location = New System.Drawing.Point(528, 26)
        Me.ServicePanel.Name = "ServicePanel"
        Me.ServicePanel.Size = New System.Drawing.Size(381, 206)
        Me.ServicePanel.TabIndex = 34
        '
        'MerchandiseGrid
        '
        Me.MerchandiseGrid.AllowUserToAddRows = False
        Me.MerchandiseGrid.AllowUserToDeleteRows = False
        Me.MerchandiseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MerchandiseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column8, Me.Point})
        Me.MerchandiseGrid.Location = New System.Drawing.Point(3, 3)
        Me.MerchandiseGrid.Name = "MerchandiseGrid"
        Me.MerchandiseGrid.Size = New System.Drawing.Size(587, 162)
        Me.MerchandiseGrid.TabIndex = 16
        '
        'Column7
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column7.HeaderText = "Seq"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn1.HeaderText = "Merchandise ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle19.Format = "N0"
        DataGridViewCellStyle19.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn3.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'Column8
        '
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column8.HeaderText = "UoM"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
        '
        'Point
        '
        Me.Point.HeaderText = "Point"
        Me.Point.Name = "Point"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gold
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Location = New System.Drawing.Point(-3, 186)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(151, 22)
        Me.Panel5.TabIndex = 15
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(15, 1)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(126, 14)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Redemption Item Detail"
        '
        'RemoveServBtn
        '
        Me.RemoveServBtn.BackgroundImage = CType(resources.GetObject("RemoveServBtn.BackgroundImage"), System.Drawing.Image)
        Me.RemoveServBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveServBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RemoveServBtn.Location = New System.Drawing.Point(402, 171)
        Me.RemoveServBtn.Name = "RemoveServBtn"
        Me.RemoveServBtn.Size = New System.Drawing.Size(188, 29)
        Me.RemoveServBtn.TabIndex = 2
        Me.RemoveServBtn.Text = "REMOVE MERCHANDISE"
        Me.RemoveServBtn.UseVisualStyleBackColor = True
        '
        'AddServiceBtn
        '
        Me.AddServiceBtn.BackgroundImage = CType(resources.GetObject("AddServiceBtn.BackgroundImage"), System.Drawing.Image)
        Me.AddServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddServiceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddServiceBtn.Location = New System.Drawing.Point(245, 171)
        Me.AddServiceBtn.Name = "AddServiceBtn"
        Me.AddServiceBtn.Size = New System.Drawing.Size(151, 29)
        Me.AddServiceBtn.TabIndex = 1
        Me.AddServiceBtn.Text = "ADD MERCHANDISE"
        Me.AddServiceBtn.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 26)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Total Point Required"
        '
        'TotalPointRequired
        '
        Me.TotalPointRequired.Enabled = False
        Me.TotalPointRequired.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPointRequired.Location = New System.Drawing.Point(219, 18)
        Me.TotalPointRequired.Name = "TotalPointRequired"
        Me.TotalPointRequired.Size = New System.Drawing.Size(256, 33)
        Me.TotalPointRequired.TabIndex = 18
        Me.TotalPointRequired.Text = "0"
        Me.TotalPointRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackgroundImage = CType(resources.GetObject("CancelBtn.BackgroundImage"), System.Drawing.Image)
        Me.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelBtn.Location = New System.Drawing.Point(811, 8)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(101, 53)
        Me.CancelBtn.TabIndex = 36
        Me.CancelBtn.Text = "CANCEL"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.BackgroundImage = CType(resources.GetObject("SaveBtn.BackgroundImage"), System.Drawing.Image)
        Me.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaveBtn.Location = New System.Drawing.Point(704, 8)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(101, 53)
        Me.SaveBtn.TabIndex = 35
        Me.SaveBtn.Text = "SAVE"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CustomerPanel)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.ServicePanel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 291)
        Me.Panel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TotalPointRequired)
        Me.Panel3.Controls.Add(Me.SaveBtn)
        Me.Panel3.Controls.Add(Me.CancelBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 224)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(924, 67)
        Me.Panel3.TabIndex = 37
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
        Me.RedemptionDate.Location = New System.Drawing.Point(669, 12)
        Me.RedemptionDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RedemptionDate.Name = "RedemptionDate"
        Me.RedemptionDate.Size = New System.Drawing.Size(242, 25)
        Me.RedemptionDate.TabIndex = 17
        '
        'CustomerPanel
        '
        Me.CustomerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.CustomerPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustomerPanel.Name = "CustomerPanel"
        Me.CustomerPanel.Size = New System.Drawing.Size(511, 227)
        Me.CustomerPanel.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Location = New System.Drawing.Point(330, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Label26.Text = "CUSTOMER DATA"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IsMemberChk
        '
        Me.IsMemberChk.AutoCheck = False
        Me.IsMemberChk.AutoSize = True
        Me.IsMemberChk.Location = New System.Drawing.Point(323, 191)
        Me.IsMemberChk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.CustomerCellphoneTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.FindCustomerBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.CustomerPhoneTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustomerPhoneTxt.Name = "CustomerPhoneTxt"
        Me.CustomerPhoneTxt.Size = New System.Drawing.Size(227, 25)
        Me.CustomerPhoneTxt.TabIndex = 7
        '
        'CustomerAddressTxt
        '
        Me.CustomerAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerAddressTxt.Location = New System.Drawing.Point(88, 78)
        Me.CustomerAddressTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustomerAddressTxt.Multiline = True
        Me.CustomerAddressTxt.Name = "CustomerAddressTxt"
        Me.CustomerAddressTxt.Size = New System.Drawing.Size(300, 71)
        Me.CustomerAddressTxt.TabIndex = 6
        '
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerNameTxt.Location = New System.Drawing.Point(88, 45)
        Me.CustomerNameTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.Size = New System.Drawing.Size(300, 25)
        Me.CustomerNameTxt.TabIndex = 5
        '
        'CustomerIdTxt
        '
        Me.CustomerIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerIdTxt.Location = New System.Drawing.Point(88, 12)
        Me.CustomerIdTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Panel7.Location = New System.Drawing.Point(0, 342)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(924, 32)
        Me.Panel7.TabIndex = 38
        '
        'HelpF4Lbl
        '
        Me.HelpF4Lbl.AutoSize = True
        Me.HelpF4Lbl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.HelpF4Lbl.ForeColor = System.Drawing.Color.Red
        Me.HelpF4Lbl.Location = New System.Drawing.Point(297, 7)
        Me.HelpF4Lbl.Name = "HelpF4Lbl"
        Me.HelpF4Lbl.Size = New System.Drawing.Size(174, 17)
        Me.HelpF4Lbl.TabIndex = 4
        Me.HelpF4Lbl.Text = "F4 - Read From RFID Reader"
        Me.HelpF4Lbl.Visible = False
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
        Me.Label32.Location = New System.Drawing.Point(709, 9)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(209, 14)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Copyrights © 2013 – Macsauto Indonesia"
        '
        'HelpF2Lbl
        '
        Me.HelpF2Lbl.AutoSize = True
        Me.HelpF2Lbl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.HelpF2Lbl.ForeColor = System.Drawing.Color.Red
        Me.HelpF2Lbl.Location = New System.Drawing.Point(159, 7)
        Me.HelpF2Lbl.Name = "HelpF2Lbl"
        Me.HelpF2Lbl.Size = New System.Drawing.Size(122, 17)
        Me.HelpF2Lbl.TabIndex = 3
        Me.HelpF2Lbl.Text = "F2 - Search Product"
        '
        '_003_04_TrMerchandiseRedemption
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(924, 374)
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
        CType(Me.MerchandiseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.CustomerPanel.ResumeLayout(False)
        Me.CustomerPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ServicePanel As System.Windows.Forms.Panel
    Friend WithEvents RemoveServBtn As System.Windows.Forms.Button
    Friend WithEvents AddServiceBtn As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents MerchandiseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Point As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TotalPointRequired As System.Windows.Forms.TextBox
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
End Class
