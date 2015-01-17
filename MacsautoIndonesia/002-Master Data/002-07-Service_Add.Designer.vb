<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _002_07_Service_Add
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AddServiceTabControl = New System.Windows.Forms.TabControl()
        Me.GeneralTabPage = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToPricingBtn = New System.Windows.Forms.Button()
        Me.ServiceTypeCbo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServiceNameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PricingTabPage = New System.Windows.Forms.TabPage()
        Me.ServicePriceGridView = New System.Windows.Forms.DataGridView()
        Me.VehicleSizeIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleSizeDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicePriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToGeneralBtn = New System.Windows.Forms.Button()
        Me.ToAccountingBtn = New System.Windows.Forms.Button()
        Me.AccountTabPage = New System.Windows.Forms.TabPage()
        Me.BackToPricingBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.IsPnLChk = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AccountCbo = New System.Windows.Forms.ComboBox()
        Me.AddServiceTabControl.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.PricingTabPage.SuspendLayout()
        CType(Me.ServicePriceGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.AccountTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddServiceTabControl
        '
        Me.AddServiceTabControl.Controls.Add(Me.GeneralTabPage)
        Me.AddServiceTabControl.Controls.Add(Me.PricingTabPage)
        Me.AddServiceTabControl.Controls.Add(Me.AccountTabPage)
        Me.AddServiceTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddServiceTabControl.Location = New System.Drawing.Point(0, 0)
        Me.AddServiceTabControl.Name = "AddServiceTabControl"
        Me.AddServiceTabControl.SelectedIndex = 0
        Me.AddServiceTabControl.Size = New System.Drawing.Size(495, 191)
        Me.AddServiceTabControl.TabIndex = 0
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label3)
        Me.GeneralTabPage.Controls.Add(Me.ToPricingBtn)
        Me.GeneralTabPage.Controls.Add(Me.ServiceTypeCbo)
        Me.GeneralTabPage.Controls.Add(Me.Label2)
        Me.GeneralTabPage.Controls.Add(Me.ServiceNameTxt)
        Me.GeneralTabPage.Controls.Add(Me.Label1)
        Me.GeneralTabPage.Location = New System.Drawing.Point(4, 25)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralTabPage.Size = New System.Drawing.Size(487, 162)
        Me.GeneralTabPage.TabIndex = 0
        Me.GeneralTabPage.Text = "General"
        Me.GeneralTabPage.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "[Auto Generated]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Id"
        '
        'ToPricingBtn
        '
        Me.ToPricingBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToPricingBtn.Location = New System.Drawing.Point(339, 124)
        Me.ToPricingBtn.Name = "ToPricingBtn"
        Me.ToPricingBtn.Size = New System.Drawing.Size(140, 30)
        Me.ToPricingBtn.TabIndex = 9
        Me.ToPricingBtn.Text = "Next to Pricing"
        Me.ToPricingBtn.UseVisualStyleBackColor = True
        '
        'ServiceTypeCbo
        '
        Me.ServiceTypeCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ServiceTypeCbo.FormattingEnabled = True
        Me.ServiceTypeCbo.Location = New System.Drawing.Point(109, 91)
        Me.ServiceTypeCbo.Name = "ServiceTypeCbo"
        Me.ServiceTypeCbo.Size = New System.Drawing.Size(315, 24)
        Me.ServiceTypeCbo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Type"
        '
        'ServiceNameTxt
        '
        Me.ServiceNameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ServiceNameTxt.Location = New System.Drawing.Point(109, 39)
        Me.ServiceNameTxt.Multiline = True
        Me.ServiceNameTxt.Name = "ServiceNameTxt"
        Me.ServiceNameTxt.Size = New System.Drawing.Size(315, 46)
        Me.ServiceNameTxt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Service Desc"
        '
        'PricingTabPage
        '
        Me.PricingTabPage.Controls.Add(Me.ServicePriceGridView)
        Me.PricingTabPage.Controls.Add(Me.Panel1)
        Me.PricingTabPage.Location = New System.Drawing.Point(4, 25)
        Me.PricingTabPage.Name = "PricingTabPage"
        Me.PricingTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PricingTabPage.Size = New System.Drawing.Size(487, 162)
        Me.PricingTabPage.TabIndex = 1
        Me.PricingTabPage.Text = "Pricing"
        Me.PricingTabPage.UseVisualStyleBackColor = True
        '
        'ServicePriceGridView
        '
        Me.ServicePriceGridView.AllowUserToAddRows = False
        Me.ServicePriceGridView.AllowUserToDeleteRows = False
        Me.ServicePriceGridView.AllowUserToResizeRows = False
        Me.ServicePriceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ServicePriceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicePriceGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VehicleSizeIdCol, Me.VehicleSizeDescCol, Me.ServicePriceCol})
        Me.ServicePriceGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServicePriceGridView.Location = New System.Drawing.Point(3, 3)
        Me.ServicePriceGridView.Name = "ServicePriceGridView"
        Me.ServicePriceGridView.RowHeadersVisible = False
        Me.ServicePriceGridView.Size = New System.Drawing.Size(481, 115)
        Me.ServicePriceGridView.TabIndex = 0
        '
        'VehicleSizeIdCol
        '
        Me.VehicleSizeIdCol.HeaderText = "Vehicle Size Id"
        Me.VehicleSizeIdCol.Name = "VehicleSizeIdCol"
        Me.VehicleSizeIdCol.ReadOnly = True
        Me.VehicleSizeIdCol.Visible = False
        Me.VehicleSizeIdCol.Width = 106
        '
        'VehicleSizeDescCol
        '
        Me.VehicleSizeDescCol.HeaderText = "Vehicle Size"
        Me.VehicleSizeDescCol.Name = "VehicleSizeDescCol"
        Me.VehicleSizeDescCol.ReadOnly = True
        Me.VehicleSizeDescCol.Width = 110
        '
        'ServicePriceCol
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.ServicePriceCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.ServicePriceCol.HeaderText = "Price"
        Me.ServicePriceCol.Name = "ServicePriceCol"
        Me.ServicePriceCol.Width = 65
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToGeneralBtn)
        Me.Panel1.Controls.Add(Me.ToAccountingBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 41)
        Me.Panel1.TabIndex = 1
        '
        'ToGeneralBtn
        '
        Me.ToGeneralBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToGeneralBtn.Location = New System.Drawing.Point(5, 6)
        Me.ToGeneralBtn.Name = "ToGeneralBtn"
        Me.ToGeneralBtn.Size = New System.Drawing.Size(140, 30)
        Me.ToGeneralBtn.TabIndex = 11
        Me.ToGeneralBtn.Text = "Back to General"
        Me.ToGeneralBtn.UseVisualStyleBackColor = True
        '
        'ToAccountingBtn
        '
        Me.ToAccountingBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToAccountingBtn.Location = New System.Drawing.Point(337, 6)
        Me.ToAccountingBtn.Name = "ToAccountingBtn"
        Me.ToAccountingBtn.Size = New System.Drawing.Size(140, 30)
        Me.ToAccountingBtn.TabIndex = 10
        Me.ToAccountingBtn.Text = "Next to Accounting"
        Me.ToAccountingBtn.UseVisualStyleBackColor = True
        '
        'AccountTabPage
        '
        Me.AccountTabPage.Controls.Add(Me.BackToPricingBtn)
        Me.AccountTabPage.Controls.Add(Me.SubmitBtn)
        Me.AccountTabPage.Controls.Add(Me.IsPnLChk)
        Me.AccountTabPage.Controls.Add(Me.Label7)
        Me.AccountTabPage.Controls.Add(Me.Label6)
        Me.AccountTabPage.Controls.Add(Me.Label5)
        Me.AccountTabPage.Controls.Add(Me.AccountCbo)
        Me.AccountTabPage.Location = New System.Drawing.Point(4, 25)
        Me.AccountTabPage.Name = "AccountTabPage"
        Me.AccountTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AccountTabPage.Size = New System.Drawing.Size(487, 162)
        Me.AccountTabPage.TabIndex = 2
        Me.AccountTabPage.Text = "Accounting"
        Me.AccountTabPage.UseVisualStyleBackColor = True
        '
        'BackToPricingBtn
        '
        Me.BackToPricingBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackToPricingBtn.Location = New System.Drawing.Point(6, 126)
        Me.BackToPricingBtn.Name = "BackToPricingBtn"
        Me.BackToPricingBtn.Size = New System.Drawing.Size(140, 30)
        Me.BackToPricingBtn.TabIndex = 13
        Me.BackToPricingBtn.Text = "Back to Pricing"
        Me.BackToPricingBtn.UseVisualStyleBackColor = True
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubmitBtn.Location = New System.Drawing.Point(389, 126)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(90, 30)
        Me.SubmitBtn.TabIndex = 12
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'IsPnLChk
        '
        Me.IsPnLChk.AutoSize = True
        Me.IsPnLChk.Enabled = False
        Me.IsPnLChk.Location = New System.Drawing.Point(112, 68)
        Me.IsPnLChk.Name = "IsPnLChk"
        Me.IsPnLChk.Size = New System.Drawing.Size(178, 21)
        Me.IsPnLChk.TabIndex = 4
        Me.IsPnLChk.Text = "Profit And Loss Account"
        Me.IsPnLChk.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Account Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Account"
        '
        'AccountCbo
        '
        Me.AccountCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccountCbo.FormattingEnabled = True
        Me.AccountCbo.Location = New System.Drawing.Point(112, 38)
        Me.AccountCbo.Name = "AccountCbo"
        Me.AccountCbo.Size = New System.Drawing.Size(367, 24)
        Me.AccountCbo.TabIndex = 0
        '
        '_002_07_Service_Add
        '
        Me.AcceptButton = Me.ToPricingBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 191)
        Me.Controls.Add(Me.AddServiceTabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_002_07_Service_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Service - Create New"
        Me.AddServiceTabControl.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        Me.PricingTabPage.ResumeLayout(False)
        CType(Me.ServicePriceGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.AccountTabPage.ResumeLayout(False)
        Me.AccountTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddServiceTabControl As System.Windows.Forms.TabControl
    Friend WithEvents GeneralTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ToPricingBtn As System.Windows.Forms.Button
    Friend WithEvents ServiceTypeCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ServiceNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PricingTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ServicePriceGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToGeneralBtn As System.Windows.Forms.Button
    Friend WithEvents ToAccountingBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AccountTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AccountCbo As System.Windows.Forms.ComboBox
    Friend WithEvents IsPnLChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BackToPricingBtn As System.Windows.Forms.Button
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents VehicleSizeIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleSizeDescCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicePriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
