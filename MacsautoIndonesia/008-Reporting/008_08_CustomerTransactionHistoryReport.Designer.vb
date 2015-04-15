Imports MacsautoIndonesia.UserControls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _008_08_CustomerTransactionHistoryReport
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToDtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromDtp = New System.Windows.Forms.DateTimePicker()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.CustomerCbo = New System.Windows.Forms.ComboBox()
        Me.DataGridView = New MacsautoIndonesia.UserControls.MyDataGridView()
        Me.TransactionTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionAmountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentPointCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointTransactionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashierCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelTop.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExport.Location = New System.Drawing.Point(814, 14)
        Me.BtnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(88, 30)
        Me.BtnExport.TabIndex = 5
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(514, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "To"
        '
        'ToDtp
        '
        Me.ToDtp.Location = New System.Drawing.Point(543, 16)
        Me.ToDtp.Margin = New System.Windows.Forms.Padding(4)
        Me.ToDtp.Name = "ToDtp"
        Me.ToDtp.Size = New System.Drawing.Size(232, 25)
        Me.ToDtp.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'FromDtp
        '
        Me.FromDtp.Location = New System.Drawing.Point(266, 16)
        Me.FromDtp.Margin = New System.Windows.Forms.Padding(4)
        Me.FromDtp.Name = "FromDtp"
        Me.FromDtp.Size = New System.Drawing.Size(232, 25)
        Me.FromDtp.TabIndex = 4
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.SystemColors.Info
        Me.PanelTop.Controls.Add(Me.CustomerCbo)
        Me.PanelTop.Controls.Add(Me.BtnExport)
        Me.PanelTop.Controls.Add(Me.Label2)
        Me.PanelTop.Controls.Add(Me.ToDtp)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Controls.Add(Me.FromDtp)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(913, 57)
        Me.PanelTop.TabIndex = 4
        '
        'CustomerCbo
        '
        Me.CustomerCbo.FormattingEnabled = True
        Me.CustomerCbo.Location = New System.Drawing.Point(10, 16)
        Me.CustomerCbo.Name = "CustomerCbo"
        Me.CustomerCbo.Size = New System.Drawing.Size(181, 25)
        Me.CustomerCbo.TabIndex = 8
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionTypeCol, Me.TransactionIdCol, Me.TransactionAmountCol, Me.CurrentPointCol, Me.PointTransactionCol, Me.CashierCol, Me.TransactionDateCol})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.DataGridView.IsStripped = True
        Me.DataGridView.Location = New System.Drawing.Point(0, 57)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.Size = New System.Drawing.Size(913, 466)
        Me.DataGridView.StripBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.TabIndex = 3
        '
        'TransactionTypeCol
        '
        Me.TransactionTypeCol.HeaderText = "Type"
        Me.TransactionTypeCol.Name = "TransactionTypeCol"
        Me.TransactionTypeCol.ReadOnly = True
        Me.TransactionTypeCol.Width = 61
        '
        'TransactionIdCol
        '
        Me.TransactionIdCol.HeaderText = "Id"
        Me.TransactionIdCol.Name = "TransactionIdCol"
        Me.TransactionIdCol.ReadOnly = True
        Me.TransactionIdCol.Width = 44
        '
        'TransactionAmountCol
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        Me.TransactionAmountCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.TransactionAmountCol.HeaderText = "Amount"
        Me.TransactionAmountCol.Name = "TransactionAmountCol"
        Me.TransactionAmountCol.ReadOnly = True
        Me.TransactionAmountCol.Width = 78
        '
        'CurrentPointCol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        Me.CurrentPointCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.CurrentPointCol.HeaderText = "Current Point"
        Me.CurrentPointCol.Name = "CurrentPointCol"
        Me.CurrentPointCol.ReadOnly = True
        Me.CurrentPointCol.Width = 109
        '
        'PointTransactionCol
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        Me.PointTransactionCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.PointTransactionCol.HeaderText = "Point Transaction"
        Me.PointTransactionCol.Name = "PointTransactionCol"
        Me.PointTransactionCol.ReadOnly = True
        Me.PointTransactionCol.Width = 133
        '
        'CashierCol
        '
        Me.CashierCol.HeaderText = "Cashier"
        Me.CashierCol.Name = "CashierCol"
        Me.CashierCol.ReadOnly = True
        Me.CashierCol.Width = 76
        '
        'TransactionDateCol
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "f"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.TransactionDateCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.TransactionDateCol.HeaderText = "Created"
        Me.TransactionDateCol.Name = "TransactionDateCol"
        Me.TransactionDateCol.ReadOnly = True
        Me.TransactionDateCol.Width = 79
        '
        '_008_08_CustomerTransactionHistoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 523)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_008_08_CustomerTransactionHistoryReport"
        Me.Text = "Report - Customer Transaction History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FromDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents CustomerCbo As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView As MacsautoIndonesia.UserControls.MyDataGridView
    Friend WithEvents TransactionTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionAmountCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentPointCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PointTransactionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashierCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
