Imports MacsautoIndonesia.UserControls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _002_09_Customer
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.MemberOnlyChk = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerNameTxt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CustomerDataGrid = New MacsautoIndonesia.UserControls.MyDataGridView()
        Me.CustomerIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDoBCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerCellphoneCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIsMemberCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CustomerNameLbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CustomerDataGrid)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 399)
        Me.Panel1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RefreshBtn)
        Me.Panel2.Controls.Add(Me.MemberOnlyChk)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CustomerNameTxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 39)
        Me.Panel2.TabIndex = 0
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshBtn.Location = New System.Drawing.Point(681, 3)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(88, 30)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'MemberOnlyChk
        '
        Me.MemberOnlyChk.AutoSize = True
        Me.MemberOnlyChk.Location = New System.Drawing.Point(245, 9)
        Me.MemberOnlyChk.Name = "MemberOnlyChk"
        Me.MemberOnlyChk.Size = New System.Drawing.Size(118, 21)
        Me.MemberOnlyChk.TabIndex = 2
        Me.MemberOnlyChk.Text = "Members Only"
        Me.MemberOnlyChk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CustomerNameTxt.Location = New System.Drawing.Point(63, 7)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.Size = New System.Drawing.Size(176, 23)
        Me.CustomerNameTxt.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel3.Location = New System.Drawing.Point(0, 181)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(781, 218)
        Me.Panel3.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(363, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(418, 218)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(410, 189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vehicles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(525, 189)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transaction History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CustomerNameLbl)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(363, 218)
        Me.Panel4.TabIndex = 0
        '
        'CustomerDataGrid
        '
        Me.CustomerDataGrid.AllowUserToAddRows = False
        Me.CustomerDataGrid.AllowUserToDeleteRows = False
        Me.CustomerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CustomerDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIdCol, Me.CustomerNameCol, Me.CustomerDoBCol, Me.CustomerCellphoneCol, Me.CustomerAddressCol, Me.CustomerIsMemberCol})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CustomerDataGrid.IsStripped = True
        Me.CustomerDataGrid.Location = New System.Drawing.Point(0, 39)
        Me.CustomerDataGrid.Name = "CustomerDataGrid"
        Me.CustomerDataGrid.ReadOnly = True
        Me.CustomerDataGrid.RowHeadersVisible = False
        Me.CustomerDataGrid.Size = New System.Drawing.Size(781, 142)
        Me.CustomerDataGrid.StripBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDataGrid.TabIndex = 1
        '
        'CustomerIdCol
        '
        Me.CustomerIdCol.HeaderText = "Id"
        Me.CustomerIdCol.Name = "CustomerIdCol"
        Me.CustomerIdCol.ReadOnly = True
        Me.CustomerIdCol.Visible = False
        '
        'CustomerNameCol
        '
        Me.CustomerNameCol.HeaderText = "Name"
        Me.CustomerNameCol.Name = "CustomerNameCol"
        Me.CustomerNameCol.ReadOnly = True
        Me.CustomerNameCol.Width = 70
        '
        'CustomerDoBCol
        '
        Me.CustomerDoBCol.HeaderText = "Birth Date"
        Me.CustomerDoBCol.Name = "CustomerDoBCol"
        Me.CustomerDoBCol.ReadOnly = True
        Me.CustomerDoBCol.Width = 96
        '
        'CustomerCellphoneCol
        '
        Me.CustomerCellphoneCol.HeaderText = "Cellphone"
        Me.CustomerCellphoneCol.Name = "CustomerCellphoneCol"
        Me.CustomerCellphoneCol.ReadOnly = True
        Me.CustomerCellphoneCol.Width = 96
        '
        'CustomerAddressCol
        '
        Me.CustomerAddressCol.HeaderText = "Address"
        Me.CustomerAddressCol.Name = "CustomerAddressCol"
        Me.CustomerAddressCol.ReadOnly = True
        Me.CustomerAddressCol.Width = 85
        '
        'CustomerIsMemberCol
        '
        Me.CustomerIsMemberCol.HeaderText = "Is Member"
        Me.CustomerIsMemberCol.Name = "CustomerIsMemberCol"
        Me.CustomerIsMemberCol.ReadOnly = True
        Me.CustomerIsMemberCol.Width = 79
        '
        'CustomerNameLbl
        '
        Me.CustomerNameLbl.AutoSize = True
        Me.CustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLbl.Location = New System.Drawing.Point(15, 12)
        Me.CustomerNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CustomerNameLbl.Name = "CustomerNameLbl"
        Me.CustomerNameLbl.Size = New System.Drawing.Size(157, 24)
        Me.CustomerNameLbl.TabIndex = 4
        Me.CustomerNameLbl.Text = "[Customer Name]"
        '
        '_002_09_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 399)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "_002_09_Customer"
        Me.Text = "Customer - List And Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.CustomerDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents MemberOnlyChk As System.Windows.Forms.CheckBox
    Friend WithEvents CustomerDataGrid As MyDataGridView
    Friend WithEvents CustomerIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerDoBCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerCellphoneCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIsMemberCol As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CustomerNameLbl As System.Windows.Forms.Label
End Class
