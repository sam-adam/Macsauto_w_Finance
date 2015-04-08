<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_15_Search_Vehicle
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MemberOnlyChk = New System.Windows.Forms.CheckBox()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CustomerDataGrid = New System.Windows.Forms.DataGridView()
        Me.CustomerIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerGenderCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDoBCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerCellphoneCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerMailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPointCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIsMember = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VehicleDataGrid = New System.Windows.Forms.DataGridView()
        Me.VehicleRegColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleModelCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBrandCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleColorCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.MemberOnlyChk)
        Me.Panel1.Controls.Add(Me.RefreshBtn)
        Me.Panel1.Controls.Add(Me.SearchTxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 56)
        Me.Panel1.TabIndex = 0
        '
        'MemberOnlyChk
        '
        Me.MemberOnlyChk.AutoSize = True
        Me.MemberOnlyChk.Location = New System.Drawing.Point(356, 16)
        Me.MemberOnlyChk.Name = "MemberOnlyChk"
        Me.MemberOnlyChk.Size = New System.Drawing.Size(148, 21)
        Me.MemberOnlyChk.TabIndex = 4
        Me.MemberOnlyChk.Text = "Show Members Only"
        Me.MemberOnlyChk.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(510, 10)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(90, 32)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(175, 14)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(175, 25)
        Me.SearchTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name Or Vehicle Number"
        '
        'SelectBtn
        '
        Me.SelectBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectBtn.Location = New System.Drawing.Point(706, 4)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(90, 32)
        Me.SelectBtn.TabIndex = 2
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 56)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CustomerDataGrid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel2.Controls.Add(Me.VehicleDataGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(808, 402)
        Me.SplitContainer1.SplitterDistance = 264
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'CustomerDataGrid
        '
        Me.CustomerDataGrid.AllowUserToAddRows = False
        Me.CustomerDataGrid.AllowUserToDeleteRows = False
        Me.CustomerDataGrid.AllowUserToOrderColumns = True
        Me.CustomerDataGrid.AllowUserToResizeRows = False
        Me.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIdCol, Me.CustomerNameCol, Me.CustomerGenderCol, Me.CustomerDoBCol, Me.CustomerPhoneCol, Me.CustomerCellphoneCol, Me.CustomerMailCol, Me.CustomerAddressCol, Me.CustomerPointCol, Me.CustomerIsMember})
        Me.CustomerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.CustomerDataGrid.Name = "CustomerDataGrid"
        Me.CustomerDataGrid.ReadOnly = True
        Me.CustomerDataGrid.RowHeadersVisible = False
        Me.CustomerDataGrid.Size = New System.Drawing.Size(804, 260)
        Me.CustomerDataGrid.TabIndex = 0
        '
        'CustomerIdCol
        '
        Me.CustomerIdCol.HeaderText = "Customer Id"
        Me.CustomerIdCol.Name = "CustomerIdCol"
        Me.CustomerIdCol.ReadOnly = True
        Me.CustomerIdCol.Visible = False
        '
        'CustomerNameCol
        '
        Me.CustomerNameCol.HeaderText = "Name"
        Me.CustomerNameCol.Name = "CustomerNameCol"
        Me.CustomerNameCol.ReadOnly = True
        '
        'CustomerGenderCol
        '
        Me.CustomerGenderCol.HeaderText = "Gender"
        Me.CustomerGenderCol.Name = "CustomerGenderCol"
        Me.CustomerGenderCol.ReadOnly = True
        Me.CustomerGenderCol.Visible = False
        '
        'CustomerDoBCol
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CustomerDoBCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDoBCol.HeaderText = "Birthdate"
        Me.CustomerDoBCol.Name = "CustomerDoBCol"
        Me.CustomerDoBCol.ReadOnly = True
        '
        'CustomerPhoneCol
        '
        Me.CustomerPhoneCol.HeaderText = "Phone"
        Me.CustomerPhoneCol.Name = "CustomerPhoneCol"
        Me.CustomerPhoneCol.ReadOnly = True
        '
        'CustomerCellphoneCol
        '
        Me.CustomerCellphoneCol.HeaderText = "Cellphone"
        Me.CustomerCellphoneCol.Name = "CustomerCellphoneCol"
        Me.CustomerCellphoneCol.ReadOnly = True
        '
        'CustomerMailCol
        '
        Me.CustomerMailCol.HeaderText = "Email"
        Me.CustomerMailCol.Name = "CustomerMailCol"
        Me.CustomerMailCol.ReadOnly = True
        '
        'CustomerAddressCol
        '
        Me.CustomerAddressCol.HeaderText = "Address"
        Me.CustomerAddressCol.Name = "CustomerAddressCol"
        Me.CustomerAddressCol.ReadOnly = True
        Me.CustomerAddressCol.Visible = False
        '
        'CustomerPointCol
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        Me.CustomerPointCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerPointCol.HeaderText = "Point"
        Me.CustomerPointCol.Name = "CustomerPointCol"
        Me.CustomerPointCol.ReadOnly = True
        '
        'CustomerIsMember
        '
        Me.CustomerIsMember.HeaderText = "Is Member"
        Me.CustomerIsMember.Name = "CustomerIsMember"
        Me.CustomerIsMember.ReadOnly = True
        '
        'VehicleDataGrid
        '
        Me.VehicleDataGrid.AllowUserToAddRows = False
        Me.VehicleDataGrid.AllowUserToDeleteRows = False
        Me.VehicleDataGrid.AllowUserToOrderColumns = True
        Me.VehicleDataGrid.AllowUserToResizeRows = False
        Me.VehicleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.VehicleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehicleDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VehicleRegColumn, Me.VehicleModelCol, Me.VehicleBrandCol, Me.VehicleColorCol, Me.VehicleTypeCol})
        Me.VehicleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VehicleDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.VehicleDataGrid.Name = "VehicleDataGrid"
        Me.VehicleDataGrid.ReadOnly = True
        Me.VehicleDataGrid.RowHeadersVisible = False
        Me.VehicleDataGrid.Size = New System.Drawing.Size(804, 129)
        Me.VehicleDataGrid.TabIndex = 0
        '
        'VehicleRegColumn
        '
        Me.VehicleRegColumn.HeaderText = "Vehicle Reg."
        Me.VehicleRegColumn.Name = "VehicleRegColumn"
        Me.VehicleRegColumn.ReadOnly = True
        Me.VehicleRegColumn.Width = 104
        '
        'VehicleModelCol
        '
        Me.VehicleModelCol.HeaderText = "Model"
        Me.VehicleModelCol.Name = "VehicleModelCol"
        Me.VehicleModelCol.ReadOnly = True
        Me.VehicleModelCol.Width = 71
        '
        'VehicleBrandCol
        '
        Me.VehicleBrandCol.HeaderText = "Brand"
        Me.VehicleBrandCol.Name = "VehicleBrandCol"
        Me.VehicleBrandCol.ReadOnly = True
        Me.VehicleBrandCol.Width = 67
        '
        'VehicleColorCol
        '
        Me.VehicleColorCol.HeaderText = "Color"
        Me.VehicleColorCol.Name = "VehicleColorCol"
        Me.VehicleColorCol.ReadOnly = True
        Me.VehicleColorCol.Width = 65
        '
        'VehicleTypeCol
        '
        Me.VehicleTypeCol.HeaderText = "Type"
        Me.VehicleTypeCol.Name = "VehicleTypeCol"
        Me.VehicleTypeCol.ReadOnly = True
        Me.VehicleTypeCol.Width = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Controls.Add(Me.SelectBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 458)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 42)
        Me.Panel2.TabIndex = 1
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(610, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(90, 32)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        '_005_15_Search_Vehicle
        '
        Me.AcceptButton = Me.SelectBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 500)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(824, 539)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(824, 539)
        Me.Name = "_005_15_Search_Vehicle"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Vehicle - Search"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SearchTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents SelectBtn As System.Windows.Forms.Button
    Friend WithEvents VehicleDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents VehicleRegColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleModelCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleBrandCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleColorCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerGenderCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerDoBCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerCellphoneCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerMailCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPointCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIsMember As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents MemberOnlyChk As System.Windows.Forms.CheckBox
End Class
