<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_17_Search_Product
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductDataGrid = New System.Windows.Forms.DataGridView()
        Me.ProductIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTypeIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTypeDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductStockCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductUoMCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPurchasePriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSellPriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Controls.Add(Me.SelectBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(842, 40)
        Me.Panel2.TabIndex = 2
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(674, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 30)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SelectBtn
        '
        Me.SelectBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectBtn.Location = New System.Drawing.Point(755, 4)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(75, 30)
        Me.SelectBtn.TabIndex = 2
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RefreshBtn)
        Me.Panel1.Controls.Add(Me.SearchTxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 50)
        Me.Panel1.TabIndex = 3
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(321, 9)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(75, 30)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(116, 13)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(199, 23)
        Me.SearchTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'ProductDataGrid
        '
        Me.ProductDataGrid.AllowUserToAddRows = False
        Me.ProductDataGrid.AllowUserToDeleteRows = False
        Me.ProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIdCol, Me.ProductDescriptionCol, Me.ProductTypeIdCol, Me.ProductTypeDescriptionCol, Me.ProductStockCol, Me.ProductUoMCol, Me.ProductPurchasePriceCol, Me.ProductSellPriceCol})
        Me.ProductDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGrid.Location = New System.Drawing.Point(0, 50)
        Me.ProductDataGrid.Name = "ProductDataGrid"
        Me.ProductDataGrid.ReadOnly = True
        Me.ProductDataGrid.RowHeadersVisible = False
        Me.ProductDataGrid.Size = New System.Drawing.Size(842, 296)
        Me.ProductDataGrid.TabIndex = 4
        '
        'ProductIdCol
        '
        Me.ProductIdCol.HeaderText = "ProductId"
        Me.ProductIdCol.Name = "ProductIdCol"
        Me.ProductIdCol.ReadOnly = True
        Me.ProductIdCol.Visible = False
        Me.ProductIdCol.Width = 74
        '
        'ProductDescriptionCol
        '
        Me.ProductDescriptionCol.HeaderText = "Product"
        Me.ProductDescriptionCol.Name = "ProductDescriptionCol"
        Me.ProductDescriptionCol.ReadOnly = True
        Me.ProductDescriptionCol.Width = 82
        '
        'ProductTypeIdCol
        '
        Me.ProductTypeIdCol.HeaderText = "Product Type"
        Me.ProductTypeIdCol.Name = "ProductTypeIdCol"
        Me.ProductTypeIdCol.ReadOnly = True
        Me.ProductTypeIdCol.Visible = False
        Me.ProductTypeIdCol.Width = 118
        '
        'ProductTypeDescriptionCol
        '
        Me.ProductTypeDescriptionCol.HeaderText = "Type"
        Me.ProductTypeDescriptionCol.Name = "ProductTypeDescriptionCol"
        Me.ProductTypeDescriptionCol.ReadOnly = True
        Me.ProductTypeDescriptionCol.Width = 65
        '
        'ProductStockCol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N0"
        Me.ProductStockCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.ProductStockCol.HeaderText = "Stock"
        Me.ProductStockCol.Name = "ProductStockCol"
        Me.ProductStockCol.ReadOnly = True
        Me.ProductStockCol.Width = 68
        '
        'ProductUoMCol
        '
        Me.ProductUoMCol.HeaderText = "Unit"
        Me.ProductUoMCol.Name = "ProductUoMCol"
        Me.ProductUoMCol.ReadOnly = True
        Me.ProductUoMCol.Width = 58
        '
        'ProductPurchasePriceCol
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        Me.ProductPurchasePriceCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.ProductPurchasePriceCol.HeaderText = "Purchase Price"
        Me.ProductPurchasePriceCol.Name = "ProductPurchasePriceCol"
        Me.ProductPurchasePriceCol.ReadOnly = True
        Me.ProductPurchasePriceCol.Visible = False
        Me.ProductPurchasePriceCol.Width = 129
        '
        'ProductSellPriceCol
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N0"
        Me.ProductSellPriceCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductSellPriceCol.HeaderText = "Price"
        Me.ProductSellPriceCol.Name = "ProductSellPriceCol"
        Me.ProductSellPriceCol.ReadOnly = True
        Me.ProductSellPriceCol.Width = 65
        '
        '_005_17_Search_Product
        '
        Me.AcceptButton = Me.SelectBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 386)
        Me.Controls.Add(Me.ProductDataGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_005_17_Search_Product"
        Me.Text = "Product - Search"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SelectBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents SearchTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ProductIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductTypeIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductTypeDescriptionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductStockCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductUoMCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductPurchasePriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductSellPriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
