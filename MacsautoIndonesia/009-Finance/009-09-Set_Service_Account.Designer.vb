<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _009_09_Set_Service_Account
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SetByAccountTab = New System.Windows.Forms.TabControl()
        Me.SetByServiceItemTabPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ServiceItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ServiceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceGLAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceGLAccountDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AccountTypeChk = New System.Windows.Forms.CheckBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServiceIdTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ServiceTypeTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ServiceDescTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchAccountBtn = New System.Windows.Forms.Button()
        Me.AccountPnLChk = New System.Windows.Forms.CheckBox()
        Me.AccountTypeTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AccountDescTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AccountNoTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SetByServiceTypeTabPage = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ServiceTypeItemsGridView = New System.Windows.Forms.DataGridView()
        Me.ServiceTypeServiceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeServiceDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeServiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeServiceGLAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeServiceGLAccountDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ServiceTypeSearchAccountBtn = New System.Windows.Forms.Button()
        Me.ServiceTypeAccountPnLChk = New System.Windows.Forms.CheckBox()
        Me.ServiceTypeAccountTypeTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ServiceTypeAccountDescTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ServiceTypeAccountNoTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ServiceTypeCbo = New System.Windows.Forms.ComboBox()
        Me.TotalServicesTxt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SetByAccountTab.SuspendLayout()
        Me.SetByServiceItemTabPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ServiceItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SetByServiceTypeTabPage.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.ServiceTypeItemsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SetByAccountTab)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 660)
        Me.Panel1.TabIndex = 0
        '
        'SetByAccountTab
        '
        Me.SetByAccountTab.Controls.Add(Me.SetByServiceItemTabPage)
        Me.SetByAccountTab.Controls.Add(Me.SetByServiceTypeTabPage)
        Me.SetByAccountTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetByAccountTab.Location = New System.Drawing.Point(0, 0)
        Me.SetByAccountTab.Margin = New System.Windows.Forms.Padding(4)
        Me.SetByAccountTab.Name = "SetByAccountTab"
        Me.SetByAccountTab.SelectedIndex = 0
        Me.SetByAccountTab.Size = New System.Drawing.Size(844, 660)
        Me.SetByAccountTab.TabIndex = 0
        '
        'SetByServiceItemTabPage
        '
        Me.SetByServiceItemTabPage.Controls.Add(Me.SplitContainer1)
        Me.SetByServiceItemTabPage.Location = New System.Drawing.Point(4, 25)
        Me.SetByServiceItemTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.SetByServiceItemTabPage.Name = "SetByServiceItemTabPage"
        Me.SetByServiceItemTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.SetByServiceItemTabPage.Size = New System.Drawing.Size(836, 631)
        Me.SetByServiceItemTabPage.TabIndex = 0
        Me.SetByServiceItemTabPage.Text = "Set By Service Item"
        Me.SetByServiceItemTabPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Size = New System.Drawing.Size(828, 623)
        Me.SplitContainer1.SplitterDistance = 410
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ServiceItemsDataGridView)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(828, 359)
        Me.Panel3.TabIndex = 1
        '
        'ServiceItemsDataGridView
        '
        Me.ServiceItemsDataGridView.AllowUserToAddRows = False
        Me.ServiceItemsDataGridView.AllowUserToDeleteRows = False
        Me.ServiceItemsDataGridView.AllowUserToResizeRows = False
        Me.ServiceItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ServiceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiceItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceId, Me.ServiceDesc, Me.ServiceType, Me.ServiceGLAccount, Me.ServiceGLAccountDesc})
        Me.ServiceItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceItemsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ServiceItemsDataGridView.Name = "ServiceItemsDataGridView"
        Me.ServiceItemsDataGridView.ReadOnly = True
        Me.ServiceItemsDataGridView.RowHeadersVisible = False
        Me.ServiceItemsDataGridView.Size = New System.Drawing.Size(828, 359)
        Me.ServiceItemsDataGridView.TabIndex = 0
        '
        'ServiceId
        '
        Me.ServiceId.HeaderText = "Id"
        Me.ServiceId.Name = "ServiceId"
        Me.ServiceId.ReadOnly = True
        Me.ServiceId.Width = 44
        '
        'ServiceDesc
        '
        Me.ServiceDesc.HeaderText = "Description"
        Me.ServiceDesc.Name = "ServiceDesc"
        Me.ServiceDesc.ReadOnly = True
        Me.ServiceDesc.Width = 104
        '
        'ServiceType
        '
        Me.ServiceType.HeaderText = "Type"
        Me.ServiceType.Name = "ServiceType"
        Me.ServiceType.ReadOnly = True
        Me.ServiceType.Width = 65
        '
        'ServiceGLAccount
        '
        Me.ServiceGLAccount.HeaderText = "Account"
        Me.ServiceGLAccount.Name = "ServiceGLAccount"
        Me.ServiceGLAccount.ReadOnly = True
        Me.ServiceGLAccount.Width = 84
        '
        'ServiceGLAccountDesc
        '
        Me.ServiceGLAccountDesc.HeaderText = "Account Desc"
        Me.ServiceGLAccountDesc.Name = "ServiceGLAccountDesc"
        Me.ServiceGLAccountDesc.ReadOnly = True
        Me.ServiceGLAccountDesc.Width = 120
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Info
        Me.Panel4.Controls.Add(Me.AccountTypeChk)
        Me.Panel4.Controls.Add(Me.SearchBtn)
        Me.Panel4.Controls.Add(Me.SearchTxt)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(828, 51)
        Me.Panel4.TabIndex = 2
        '
        'AccountTypeChk
        '
        Me.AccountTypeChk.AutoSize = True
        Me.AccountTypeChk.Location = New System.Drawing.Point(481, 14)
        Me.AccountTypeChk.Name = "AccountTypeChk"
        Me.AccountTypeChk.Size = New System.Drawing.Size(230, 21)
        Me.AccountTypeChk.TabIndex = 3
        Me.AccountTypeChk.Text = "Show only account not assigned"
        Me.AccountTypeChk.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(388, 10)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(75, 27)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(129, 12)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(253, 23)
        Me.SearchTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Id / Name"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Info
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.ServiceIdTxt)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.ServiceTypeTxt)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.ServiceDescTxt)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(828, 209)
        Me.Panel5.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Service Id"
        '
        'ServiceIdTxt
        '
        Me.ServiceIdTxt.Location = New System.Drawing.Point(94, 8)
        Me.ServiceIdTxt.Name = "ServiceIdTxt"
        Me.ServiceIdTxt.ReadOnly = True
        Me.ServiceIdTxt.Size = New System.Drawing.Size(149, 23)
        Me.ServiceIdTxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Type"
        '
        'ServiceTypeTxt
        '
        Me.ServiceTypeTxt.Location = New System.Drawing.Point(94, 37)
        Me.ServiceTypeTxt.Name = "ServiceTypeTxt"
        Me.ServiceTypeTxt.ReadOnly = True
        Me.ServiceTypeTxt.Size = New System.Drawing.Size(276, 23)
        Me.ServiceTypeTxt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description"
        '
        'ServiceDescTxt
        '
        Me.ServiceDescTxt.Location = New System.Drawing.Point(94, 66)
        Me.ServiceDescTxt.Multiline = True
        Me.ServiceDescTxt.Name = "ServiceDescTxt"
        Me.ServiceDescTxt.ReadOnly = True
        Me.ServiceDescTxt.Size = New System.Drawing.Size(276, 85)
        Me.ServiceDescTxt.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchAccountBtn)
        Me.GroupBox1.Controls.Add(Me.AccountPnLChk)
        Me.GroupBox1.Controls.Add(Me.AccountTypeTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AccountDescTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.AccountNoTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(376, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 143)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Data"
        '
        'SearchAccountBtn
        '
        Me.SearchAccountBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchAccountBtn.Location = New System.Drawing.Point(262, 20)
        Me.SearchAccountBtn.Name = "SearchAccountBtn"
        Me.SearchAccountBtn.Size = New System.Drawing.Size(41, 27)
        Me.SearchAccountBtn.TabIndex = 2
        Me.SearchAccountBtn.Text = "..."
        Me.SearchAccountBtn.UseVisualStyleBackColor = True
        '
        'AccountPnLChk
        '
        Me.AccountPnLChk.AutoSize = True
        Me.AccountPnLChk.Enabled = False
        Me.AccountPnLChk.Location = New System.Drawing.Point(107, 109)
        Me.AccountPnLChk.Name = "AccountPnLChk"
        Me.AccountPnLChk.Size = New System.Drawing.Size(136, 21)
        Me.AccountPnLChk.TabIndex = 11
        Me.AccountPnLChk.Text = "Is Profit and Loss"
        Me.AccountPnLChk.UseVisualStyleBackColor = True
        '
        'AccountTypeTxt
        '
        Me.AccountTypeTxt.Location = New System.Drawing.Point(107, 80)
        Me.AccountTypeTxt.Name = "AccountTypeTxt"
        Me.AccountTypeTxt.ReadOnly = True
        Me.AccountTypeTxt.Size = New System.Drawing.Size(149, 23)
        Me.AccountTypeTxt.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Account Type"
        '
        'AccountDescTxt
        '
        Me.AccountDescTxt.Location = New System.Drawing.Point(107, 51)
        Me.AccountDescTxt.Name = "AccountDescTxt"
        Me.AccountDescTxt.ReadOnly = True
        Me.AccountDescTxt.Size = New System.Drawing.Size(149, 23)
        Me.AccountDescTxt.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Account Desc"
        '
        'AccountNoTxt
        '
        Me.AccountNoTxt.Location = New System.Drawing.Point(107, 22)
        Me.AccountNoTxt.Name = "AccountNoTxt"
        Me.AccountNoTxt.ReadOnly = True
        Me.AccountNoTxt.Size = New System.Drawing.Size(149, 23)
        Me.AccountNoTxt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Account No."
        '
        'SetByServiceTypeTabPage
        '
        Me.SetByServiceTypeTabPage.Controls.Add(Me.Panel7)
        Me.SetByServiceTypeTabPage.Controls.Add(Me.Panel6)
        Me.SetByServiceTypeTabPage.Location = New System.Drawing.Point(4, 25)
        Me.SetByServiceTypeTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.SetByServiceTypeTabPage.Name = "SetByServiceTypeTabPage"
        Me.SetByServiceTypeTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.SetByServiceTypeTabPage.Size = New System.Drawing.Size(836, 631)
        Me.SetByServiceTypeTabPage.TabIndex = 1
        Me.SetByServiceTypeTabPage.Text = "Set By Service Type"
        Me.SetByServiceTypeTabPage.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ServiceTypeItemsGridView)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(4, 191)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(828, 436)
        Me.Panel7.TabIndex = 5
        '
        'ServiceTypeItemsGridView
        '
        Me.ServiceTypeItemsGridView.AllowUserToAddRows = False
        Me.ServiceTypeItemsGridView.AllowUserToDeleteRows = False
        Me.ServiceTypeItemsGridView.AllowUserToResizeRows = False
        Me.ServiceTypeItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ServiceTypeItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiceTypeItemsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceTypeServiceId, Me.ServiceTypeServiceDesc, Me.ServiceTypeServiceType, Me.ServiceTypeServiceGLAccount, Me.ServiceTypeServiceGLAccountDesc})
        Me.ServiceTypeItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceTypeItemsGridView.Location = New System.Drawing.Point(0, 0)
        Me.ServiceTypeItemsGridView.Name = "ServiceTypeItemsGridView"
        Me.ServiceTypeItemsGridView.ReadOnly = True
        Me.ServiceTypeItemsGridView.RowHeadersVisible = False
        Me.ServiceTypeItemsGridView.Size = New System.Drawing.Size(828, 436)
        Me.ServiceTypeItemsGridView.TabIndex = 1
        '
        'ServiceTypeServiceId
        '
        Me.ServiceTypeServiceId.HeaderText = "Id"
        Me.ServiceTypeServiceId.Name = "ServiceTypeServiceId"
        Me.ServiceTypeServiceId.ReadOnly = True
        Me.ServiceTypeServiceId.Width = 44
        '
        'ServiceTypeServiceDesc
        '
        Me.ServiceTypeServiceDesc.HeaderText = "Description"
        Me.ServiceTypeServiceDesc.Name = "ServiceTypeServiceDesc"
        Me.ServiceTypeServiceDesc.ReadOnly = True
        Me.ServiceTypeServiceDesc.Width = 104
        '
        'ServiceTypeServiceType
        '
        Me.ServiceTypeServiceType.HeaderText = "Type"
        Me.ServiceTypeServiceType.Name = "ServiceTypeServiceType"
        Me.ServiceTypeServiceType.ReadOnly = True
        Me.ServiceTypeServiceType.Width = 65
        '
        'ServiceTypeServiceGLAccount
        '
        Me.ServiceTypeServiceGLAccount.HeaderText = "Account"
        Me.ServiceTypeServiceGLAccount.Name = "ServiceTypeServiceGLAccount"
        Me.ServiceTypeServiceGLAccount.ReadOnly = True
        Me.ServiceTypeServiceGLAccount.Width = 84
        '
        'ServiceTypeServiceGLAccountDesc
        '
        Me.ServiceTypeServiceGLAccountDesc.HeaderText = "Account Desc"
        Me.ServiceTypeServiceGLAccountDesc.Name = "ServiceTypeServiceGLAccountDesc"
        Me.ServiceTypeServiceGLAccountDesc.ReadOnly = True
        Me.ServiceTypeServiceGLAccountDesc.Width = 120
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.GroupBox2)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.ServiceTypeCbo)
        Me.Panel6.Controls.Add(Me.TotalServicesTxt)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(828, 187)
        Me.Panel6.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(4, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(495, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "* Setting account by service type will overwrite all individual service account s" & _
    "etting"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ServiceTypeSearchAccountBtn)
        Me.GroupBox2.Controls.Add(Me.ServiceTypeAccountPnLChk)
        Me.GroupBox2.Controls.Add(Me.ServiceTypeAccountTypeTxt)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ServiceTypeAccountDescTxt)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ServiceTypeAccountNoTxt)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 151)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Account"
        '
        'ServiceTypeSearchAccountBtn
        '
        Me.ServiceTypeSearchAccountBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceTypeSearchAccountBtn.Location = New System.Drawing.Point(262, 20)
        Me.ServiceTypeSearchAccountBtn.Name = "ServiceTypeSearchAccountBtn"
        Me.ServiceTypeSearchAccountBtn.Size = New System.Drawing.Size(41, 27)
        Me.ServiceTypeSearchAccountBtn.TabIndex = 2
        Me.ServiceTypeSearchAccountBtn.Text = "..."
        Me.ServiceTypeSearchAccountBtn.UseVisualStyleBackColor = True
        '
        'ServiceTypeAccountPnLChk
        '
        Me.ServiceTypeAccountPnLChk.AutoSize = True
        Me.ServiceTypeAccountPnLChk.Enabled = False
        Me.ServiceTypeAccountPnLChk.Location = New System.Drawing.Point(107, 109)
        Me.ServiceTypeAccountPnLChk.Name = "ServiceTypeAccountPnLChk"
        Me.ServiceTypeAccountPnLChk.Size = New System.Drawing.Size(136, 21)
        Me.ServiceTypeAccountPnLChk.TabIndex = 11
        Me.ServiceTypeAccountPnLChk.Text = "Is Profit and Loss"
        Me.ServiceTypeAccountPnLChk.UseVisualStyleBackColor = True
        '
        'ServiceTypeAccountTypeTxt
        '
        Me.ServiceTypeAccountTypeTxt.Location = New System.Drawing.Point(107, 80)
        Me.ServiceTypeAccountTypeTxt.Name = "ServiceTypeAccountTypeTxt"
        Me.ServiceTypeAccountTypeTxt.ReadOnly = True
        Me.ServiceTypeAccountTypeTxt.Size = New System.Drawing.Size(149, 23)
        Me.ServiceTypeAccountTypeTxt.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Account Type"
        '
        'ServiceTypeAccountDescTxt
        '
        Me.ServiceTypeAccountDescTxt.Location = New System.Drawing.Point(107, 51)
        Me.ServiceTypeAccountDescTxt.Name = "ServiceTypeAccountDescTxt"
        Me.ServiceTypeAccountDescTxt.ReadOnly = True
        Me.ServiceTypeAccountDescTxt.Size = New System.Drawing.Size(149, 23)
        Me.ServiceTypeAccountDescTxt.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Account Desc"
        '
        'ServiceTypeAccountNoTxt
        '
        Me.ServiceTypeAccountNoTxt.Location = New System.Drawing.Point(107, 22)
        Me.ServiceTypeAccountNoTxt.Name = "ServiceTypeAccountNoTxt"
        Me.ServiceTypeAccountNoTxt.ReadOnly = True
        Me.ServiceTypeAccountNoTxt.Size = New System.Drawing.Size(149, 23)
        Me.ServiceTypeAccountNoTxt.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Account No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Service Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Total Services"
        '
        'ServiceTypeCbo
        '
        Me.ServiceTypeCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ServiceTypeCbo.FormattingEnabled = True
        Me.ServiceTypeCbo.Location = New System.Drawing.Point(107, 15)
        Me.ServiceTypeCbo.Name = "ServiceTypeCbo"
        Me.ServiceTypeCbo.Size = New System.Drawing.Size(222, 24)
        Me.ServiceTypeCbo.TabIndex = 0
        '
        'TotalServicesTxt
        '
        Me.TotalServicesTxt.Location = New System.Drawing.Point(107, 45)
        Me.TotalServicesTxt.Name = "TotalServicesTxt"
        Me.TotalServicesTxt.ReadOnly = True
        Me.TotalServicesTxt.Size = New System.Drawing.Size(113, 23)
        Me.TotalServicesTxt.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.MessageLabel)
        Me.Panel2.Controls.Add(Me.SaveBtn)
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 702)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 40)
        Me.Panel2.TabIndex = 1
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MessageLabel.Location = New System.Drawing.Point(10, 9)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(0, 17)
        Me.MessageLabel.TabIndex = 2
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.Location = New System.Drawing.Point(762, 6)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 27)
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(681, 6)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 27)
        Me.CancelBtn.TabIndex = 0
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(844, 42)
        Me.Panel8.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(844, 42)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "SET SERVICE GL ACCOUNT"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_009_09_Set_Service_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 742)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_009_09_Set_Service_Account"
        Me.Text = "Set Service Account"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.SetByAccountTab.ResumeLayout(False)
        Me.SetByServiceItemTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.ServiceItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SetByServiceTypeTabPage.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.ServiceTypeItemsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SetByAccountTab As System.Windows.Forms.TabControl
    Friend WithEvents SetByServiceItemTabPage As System.Windows.Forms.TabPage
    Friend WithEvents SetByServiceTypeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents ServiceItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents AccountTypeChk As System.Windows.Forms.CheckBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents SearchTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ServiceDescTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ServiceTypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ServiceIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AccountPnLChk As System.Windows.Forms.CheckBox
    Friend WithEvents AccountTypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AccountDescTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AccountNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SearchAccountBtn As System.Windows.Forms.Button
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ServiceId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceGLAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceGLAccountDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ServiceTypeCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TotalServicesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ServiceTypeItemsGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ServiceTypeSearchAccountBtn As System.Windows.Forms.Button
    Friend WithEvents ServiceTypeAccountPnLChk As System.Windows.Forms.CheckBox
    Friend WithEvents ServiceTypeAccountTypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ServiceTypeAccountDescTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ServiceTypeAccountNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ServiceTypeServiceId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeServiceDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeServiceType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeServiceGLAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeServiceGLAccountDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
