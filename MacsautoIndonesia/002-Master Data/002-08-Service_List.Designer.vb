<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _002_08_Service_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_002_08_Service_List))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ServiceGridView = New System.Windows.Forms.DataGridView()
        Me.ServiceIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceGLAccountIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceGLAccountDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ServicePricesDataGrid = New System.Windows.Forms.DataGridView()
        Me.VehicleSizeIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleSizeDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicePriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AccountCbo = New System.Windows.Forms.ComboBox()
        Me.ServiceTypeCbo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServiceNameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServiceIdLbl = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        CType(Me.ServiceGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicePricesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(977, 35)
        Me.Panel8.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(975, 33)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "SERVICE MASTER DATA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainer.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.ServiceGridView)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer.Panel2.Controls.Add(Me.CancelBtn)
        Me.SplitContainer.Panel2.Controls.Add(Me.SaveBtn)
        Me.SplitContainer.Panel2.Controls.Add(Me.RemoveBtn)
        Me.SplitContainer.Panel2.Controls.Add(Me.EditBtn)
        Me.SplitContainer.Panel2.Controls.Add(Me.AddBtn)
        Me.SplitContainer.Panel2.Controls.Add(Me.ServicePricesDataGrid)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer.Panel2.Controls.Add(Me.AccountCbo)
        Me.SplitContainer.Panel2.Controls.Add(Me.ServiceTypeCbo)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel2.Controls.Add(Me.ServiceNameTxt)
        Me.SplitContainer.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer.Panel2.Controls.Add(Me.ServiceIdLbl)
        Me.SplitContainer.Size = New System.Drawing.Size(977, 648)
        Me.SplitContainer.SplitterDistance = 563
        Me.SplitContainer.SplitterWidth = 5
        Me.SplitContainer.TabIndex = 34
        '
        'ServiceGridView
        '
        Me.ServiceGridView.AllowUserToAddRows = False
        Me.ServiceGridView.AllowUserToDeleteRows = False
        Me.ServiceGridView.AllowUserToOrderColumns = True
        Me.ServiceGridView.AllowUserToResizeRows = False
        Me.ServiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiceGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceIdCol, Me.ServiceDescCol, Me.ServiceTypeCol, Me.ServiceGLAccountIdCol, Me.ServiceGLAccountDescCol})
        Me.ServiceGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceGridView.Location = New System.Drawing.Point(0, 0)
        Me.ServiceGridView.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ServiceGridView.Name = "ServiceGridView"
        Me.ServiceGridView.ReadOnly = True
        Me.ServiceGridView.RowHeadersVisible = False
        Me.ServiceGridView.Size = New System.Drawing.Size(563, 648)
        Me.ServiceGridView.TabIndex = 0
        '
        'ServiceIdCol
        '
        Me.ServiceIdCol.HeaderText = "Service Id"
        Me.ServiceIdCol.Name = "ServiceIdCol"
        Me.ServiceIdCol.ReadOnly = True
        Me.ServiceIdCol.Width = 87
        '
        'ServiceDescCol
        '
        Me.ServiceDescCol.HeaderText = "Description"
        Me.ServiceDescCol.Name = "ServiceDescCol"
        Me.ServiceDescCol.ReadOnly = True
        Me.ServiceDescCol.Width = 104
        '
        'ServiceTypeCol
        '
        Me.ServiceTypeCol.HeaderText = "Type"
        Me.ServiceTypeCol.Name = "ServiceTypeCol"
        Me.ServiceTypeCol.ReadOnly = True
        Me.ServiceTypeCol.Width = 65
        '
        'ServiceGLAccountIdCol
        '
        Me.ServiceGLAccountIdCol.HeaderText = "GL Account"
        Me.ServiceGLAccountIdCol.Name = "ServiceGLAccountIdCol"
        Me.ServiceGLAccountIdCol.ReadOnly = True
        Me.ServiceGLAccountIdCol.Width = 98
        '
        'ServiceGLAccountDescCol
        '
        Me.ServiceGLAccountDescCol.HeaderText = "GL Account Desc"
        Me.ServiceGLAccountDescCol.Name = "ServiceGLAccountDescCol"
        Me.ServiceGLAccountDescCol.ReadOnly = True
        Me.ServiceGLAccountDescCol.Width = 131
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackgroundImage = CType(resources.GetObject("CancelBtn.BackgroundImage"), System.Drawing.Image)
        Me.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelBtn.Location = New System.Drawing.Point(191, 349)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(100, 50)
        Me.CancelBtn.TabIndex = 25
        Me.CancelBtn.Text = "CANCEL"
        Me.CancelBtn.UseVisualStyleBackColor = True
        Me.CancelBtn.Visible = False
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.BackgroundImage = CType(resources.GetObject("SaveBtn.BackgroundImage"), System.Drawing.Image)
        Me.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaveBtn.Location = New System.Drawing.Point(297, 349)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(100, 50)
        Me.SaveBtn.TabIndex = 24
        Me.SaveBtn.Text = "SAVE"
        Me.SaveBtn.UseVisualStyleBackColor = True
        Me.SaveBtn.Visible = False
        '
        'RemoveBtn
        '
        Me.RemoveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveBtn.BackgroundImage = CType(resources.GetObject("RemoveBtn.BackgroundImage"), System.Drawing.Image)
        Me.RemoveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RemoveBtn.Location = New System.Drawing.Point(7, 349)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(100, 50)
        Me.RemoveBtn.TabIndex = 23
        Me.RemoveBtn.Text = "REMOVE"
        Me.RemoveBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditBtn.BackgroundImage = CType(resources.GetObject("EditBtn.BackgroundImage"), System.Drawing.Image)
        Me.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditBtn.Location = New System.Drawing.Point(191, 349)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(100, 50)
        Me.EditBtn.TabIndex = 22
        Me.EditBtn.Text = "EDIT"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddBtn.BackgroundImage = CType(resources.GetObject("AddBtn.BackgroundImage"), System.Drawing.Image)
        Me.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBtn.Location = New System.Drawing.Point(297, 349)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(100, 50)
        Me.AddBtn.TabIndex = 21
        Me.AddBtn.Text = "ADD"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ServicePricesDataGrid
        '
        Me.ServicePricesDataGrid.AllowUserToAddRows = False
        Me.ServicePricesDataGrid.AllowUserToDeleteRows = False
        Me.ServicePricesDataGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServicePricesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicePricesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VehicleSizeIdCol, Me.VehicleSizeDescCol, Me.ServicePriceCol})
        Me.ServicePricesDataGrid.Location = New System.Drawing.Point(6, 156)
        Me.ServicePricesDataGrid.Name = "ServicePricesDataGrid"
        Me.ServicePricesDataGrid.ReadOnly = True
        Me.ServicePricesDataGrid.RowHeadersVisible = False
        Me.ServicePricesDataGrid.Size = New System.Drawing.Size(390, 187)
        Me.ServicePricesDataGrid.TabIndex = 13
        '
        'VehicleSizeIdCol
        '
        Me.VehicleSizeIdCol.HeaderText = "Vehicle Size Id"
        Me.VehicleSizeIdCol.Name = "VehicleSizeIdCol"
        Me.VehicleSizeIdCol.ReadOnly = True
        Me.VehicleSizeIdCol.Visible = False
        '
        'VehicleSizeDescCol
        '
        Me.VehicleSizeDescCol.HeaderText = "Size"
        Me.VehicleSizeDescCol.Name = "VehicleSizeDescCol"
        Me.VehicleSizeDescCol.ReadOnly = True
        '
        'ServicePriceCol
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.ServicePriceCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.ServicePriceCol.HeaderText = "Price"
        Me.ServicePriceCol.Name = "ServicePriceCol"
        Me.ServicePriceCol.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "GL Account"
        '
        'AccountCbo
        '
        Me.AccountCbo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccountCbo.FormattingEnabled = True
        Me.AccountCbo.Location = New System.Drawing.Point(100, 126)
        Me.AccountCbo.Name = "AccountCbo"
        Me.AccountCbo.Size = New System.Drawing.Size(296, 24)
        Me.AccountCbo.TabIndex = 11
        '
        'ServiceTypeCbo
        '
        Me.ServiceTypeCbo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceTypeCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ServiceTypeCbo.FormattingEnabled = True
        Me.ServiceTypeCbo.Location = New System.Drawing.Point(100, 96)
        Me.ServiceTypeCbo.Name = "ServiceTypeCbo"
        Me.ServiceTypeCbo.Size = New System.Drawing.Size(296, 24)
        Me.ServiceTypeCbo.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Type"
        '
        'ServiceNameTxt
        '
        Me.ServiceNameTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceNameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ServiceNameTxt.Location = New System.Drawing.Point(100, 44)
        Me.ServiceNameTxt.Multiline = True
        Me.ServiceNameTxt.Name = "ServiceNameTxt"
        Me.ServiceNameTxt.ReadOnly = True
        Me.ServiceNameTxt.Size = New System.Drawing.Size(296, 46)
        Me.ServiceNameTxt.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Description"
        '
        'ServiceIdLbl
        '
        Me.ServiceIdLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceIdLbl.AutoSize = True
        Me.ServiceIdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ServiceIdLbl.Location = New System.Drawing.Point(2, 4)
        Me.ServiceIdLbl.Name = "ServiceIdLbl"
        Me.ServiceIdLbl.Size = New System.Drawing.Size(103, 24)
        Me.ServiceIdLbl.TabIndex = 0
        Me.ServiceIdLbl.Text = "[Service Id]"
        '
        '_002_08_Service_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 683)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.Panel8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "_002_08_Service_List"
        Me.Text = "Service - List And Detail"
        Me.Panel8.ResumeLayout(False)
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.Panel2.PerformLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.ServiceGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicePricesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ServiceGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceDescCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceGLAccountIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceGLAccountDescCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceIdLbl As System.Windows.Forms.Label
    Friend WithEvents ServiceNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ServiceTypeCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AccountCbo As System.Windows.Forms.ComboBox
    Friend WithEvents ServicePricesDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents VehicleSizeIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleSizeDescCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicePriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemoveBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
End Class
