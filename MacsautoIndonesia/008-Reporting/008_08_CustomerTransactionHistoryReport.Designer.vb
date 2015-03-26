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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToDtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromDtp = New System.Windows.Forms.DateTimePicker()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.CustomerCbo = New System.Windows.Forms.ComboBox()
        Me.TransactionTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionAmountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelTop.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExport.Location = New System.Drawing.Point(930, 13)
        Me.BtnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(100, 28)
        Me.BtnExport.TabIndex = 5
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(579, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "To"
        '
        'ToDtp
        '
        Me.ToDtp.Location = New System.Drawing.Point(613, 15)
        Me.ToDtp.Margin = New System.Windows.Forms.Padding(4)
        Me.ToDtp.Name = "ToDtp"
        Me.ToDtp.Size = New System.Drawing.Size(265, 23)
        Me.ToDtp.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'FromDtp
        '
        Me.FromDtp.Location = New System.Drawing.Point(304, 15)
        Me.FromDtp.Margin = New System.Windows.Forms.Padding(4)
        Me.FromDtp.Name = "FromDtp"
        Me.FromDtp.Size = New System.Drawing.Size(265, 23)
        Me.FromDtp.TabIndex = 4
        '
        'PanelTop
        '
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
        Me.PanelTop.Size = New System.Drawing.Size(1043, 54)
        Me.PanelTop.TabIndex = 4
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionTypeCol, Me.TransactionIdCol, Me.TransactionDateCol, Me.TransactionAmountCol})
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 54)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.Size = New System.Drawing.Size(1043, 438)
        Me.DataGridView.TabIndex = 3
        '
        'CustomerCbo
        '
        Me.CustomerCbo.FormattingEnabled = True
        Me.CustomerCbo.Location = New System.Drawing.Point(12, 16)
        Me.CustomerCbo.Name = "CustomerCbo"
        Me.CustomerCbo.Size = New System.Drawing.Size(206, 24)
        Me.CustomerCbo.TabIndex = 8
        '
        'TransactionTypeCol
        '
        Me.TransactionTypeCol.HeaderText = "Type (Transaction / Redemption)"
        Me.TransactionTypeCol.Name = "TransactionTypeCol"
        Me.TransactionTypeCol.ReadOnly = True
        Me.TransactionTypeCol.Width = 242
        '
        'TransactionIdCol
        '
        Me.TransactionIdCol.HeaderText = "Transaction Id"
        Me.TransactionIdCol.Name = "TransactionIdCol"
        Me.TransactionIdCol.ReadOnly = True
        Me.TransactionIdCol.Width = 123
        '
        'TransactionDateCol
        '
        DataGridViewCellStyle5.Format = "D"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.TransactionDateCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.TransactionDateCol.HeaderText = "Transaction Date"
        Me.TransactionDateCol.Name = "TransactionDateCol"
        Me.TransactionDateCol.ReadOnly = True
        Me.TransactionDateCol.Width = 142
        '
        'TransactionAmountCol
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N0"
        Me.TransactionAmountCol.DefaultCellStyle = DataGridViewCellStyle6
        Me.TransactionAmountCol.HeaderText = "Transaction Amount"
        Me.TransactionAmountCol.Name = "TransactionAmountCol"
        Me.TransactionAmountCol.ReadOnly = True
        Me.TransactionAmountCol.Width = 160
        '
        '_008_08_CustomerTransactionHistoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 492)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerCbo As System.Windows.Forms.ComboBox
    Friend WithEvents TransactionTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionAmountCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
