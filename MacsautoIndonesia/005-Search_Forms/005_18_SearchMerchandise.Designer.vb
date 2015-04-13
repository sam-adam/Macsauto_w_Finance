<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_18_SearchMerchandise
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.MerchandiseDataGrid = New System.Windows.Forms.DataGridView()
        Me.MerchandiseIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseStockCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseUoMCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandisePointCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MerchandiseDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.RefreshBtn)
        Me.Panel1.Controls.Add(Me.SearchTxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 50)
        Me.Panel1.TabIndex = 4
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(345, 9)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(90, 30)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(140, 13)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(199, 25)
        Me.SearchTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Merchandise Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Controls.Add(Me.SelectBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(842, 40)
        Me.Panel2.TabIndex = 6
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(644, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(90, 30)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SelectBtn
        '
        Me.SelectBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectBtn.Location = New System.Drawing.Point(740, 4)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(90, 30)
        Me.SelectBtn.TabIndex = 2
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = True
        '
        'MerchandiseDataGrid
        '
        Me.MerchandiseDataGrid.AllowUserToAddRows = False
        Me.MerchandiseDataGrid.AllowUserToDeleteRows = False
        Me.MerchandiseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MerchandiseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MerchandiseDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MerchandiseIdCol, Me.ProductIdCol, Me.MerchandiseDescriptionCol, Me.MerchandiseStockCol, Me.MerchandiseUoMCol, Me.MerchandisePointCol})
        Me.MerchandiseDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MerchandiseDataGrid.Location = New System.Drawing.Point(0, 50)
        Me.MerchandiseDataGrid.Name = "MerchandiseDataGrid"
        Me.MerchandiseDataGrid.ReadOnly = True
        Me.MerchandiseDataGrid.RowHeadersVisible = False
        Me.MerchandiseDataGrid.Size = New System.Drawing.Size(842, 296)
        Me.MerchandiseDataGrid.TabIndex = 7
        '
        'MerchandiseIdCol
        '
        Me.MerchandiseIdCol.HeaderText = "MerchandiseId"
        Me.MerchandiseIdCol.Name = "MerchandiseIdCol"
        Me.MerchandiseIdCol.ReadOnly = True
        Me.MerchandiseIdCol.Visible = False
        '
        'ProductIdCol
        '
        Me.ProductIdCol.HeaderText = "ProductId"
        Me.ProductIdCol.Name = "ProductIdCol"
        Me.ProductIdCol.ReadOnly = True
        Me.ProductIdCol.Visible = False
        Me.ProductIdCol.Width = 70
        '
        'MerchandiseDescriptionCol
        '
        Me.MerchandiseDescriptionCol.HeaderText = "Merchandise"
        Me.MerchandiseDescriptionCol.Name = "MerchandiseDescriptionCol"
        Me.MerchandiseDescriptionCol.ReadOnly = True
        Me.MerchandiseDescriptionCol.Width = 108
        '
        'MerchandiseStockCol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N0"
        Me.MerchandiseStockCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.MerchandiseStockCol.HeaderText = "Stock"
        Me.MerchandiseStockCol.Name = "MerchandiseStockCol"
        Me.MerchandiseStockCol.ReadOnly = True
        Me.MerchandiseStockCol.Width = 64
        '
        'MerchandiseUoMCol
        '
        Me.MerchandiseUoMCol.HeaderText = "Unit"
        Me.MerchandiseUoMCol.Name = "MerchandiseUoMCol"
        Me.MerchandiseUoMCol.ReadOnly = True
        Me.MerchandiseUoMCol.Width = 56
        '
        'MerchandisePointCol
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        Me.MerchandisePointCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.MerchandisePointCol.HeaderText = "Point Cost"
        Me.MerchandisePointCol.Name = "MerchandisePointCol"
        Me.MerchandisePointCol.ReadOnly = True
        Me.MerchandisePointCol.Width = 92
        '
        '_005_18_SearchMerchandise
        '
        Me.AcceptButton = Me.SelectBtn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(842, 386)
        Me.Controls.Add(Me.MerchandiseDataGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.KeyPreview = True
        Me.Name = "_005_18_SearchMerchandise"
        Me.Text = "Merchandise - Search"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.MerchandiseDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents SearchTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SelectBtn As System.Windows.Forms.Button
    Friend WithEvents MerchandiseDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MerchandiseIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseDescriptionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseStockCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseUoMCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandisePointCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
