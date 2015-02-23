<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _002_05_Mechandise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_002_05_Mechandise))
        Me.MerchandiseDataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MerchandiseIDLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MerchandisePointTxt = New System.Windows.Forms.TextBox()
        Me.ProductIDLbl = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.MerchandiseDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'MerchandiseDataGrid
        '
        Me.MerchandiseDataGrid.AllowUserToAddRows = False
        Me.MerchandiseDataGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MerchandiseDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MerchandiseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MerchandiseDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.MerchandiseID, Me.Column2, Me.Column3, Me.Column12, Me.Column4, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MerchandiseDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.MerchandiseDataGrid.Location = New System.Drawing.Point(12, 43)
        Me.MerchandiseDataGrid.Name = "MerchandiseDataGrid"
        Me.MerchandiseDataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MerchandiseDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MerchandiseDataGrid.Size = New System.Drawing.Size(960, 339)
        Me.MerchandiseDataGrid.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'MerchandiseID
        '
        Me.MerchandiseID.HeaderText = "MerchandiseID"
        Me.MerchandiseID.Name = "MerchandiseID"
        Me.MerchandiseID.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Purchase Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column12
        '
        Me.Column12.HeaderText = "Point"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "Unit"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 397)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 182)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.save)
        Me.Panel2.Controls.Add(Me.Cancel)
        Me.Panel2.Controls.Add(Me.Edit)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.MerchandiseIDLbl)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.MerchandisePointTxt)
        Me.Panel2.Controls.Add(Me.ProductIDLbl)
        Me.Panel2.Location = New System.Drawing.Point(12, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 164)
        Me.Panel2.TabIndex = 3
        '
        'save
        '
        Me.save.BackgroundImage = CType(resources.GetObject("save.BackgroundImage"), System.Drawing.Image)
        Me.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.save.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save.Location = New System.Drawing.Point(13, 100)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(100, 50)
        Me.save.TabIndex = 22
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        Me.save.Visible = False
        '
        'Cancel
        '
        Me.Cancel.BackgroundImage = CType(resources.GetObject("Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cancel.Location = New System.Drawing.Point(138, 100)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 50)
        Me.Cancel.TabIndex = 24
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        Me.Cancel.Visible = False
        '
        'Edit
        '
        Me.Edit.BackgroundImage = CType(resources.GetObject("Edit.BackgroundImage"), System.Drawing.Image)
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Edit.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Edit.Location = New System.Drawing.Point(13, 100)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(100, 50)
        Me.Edit.TabIndex = 23
        Me.Edit.Text = "EDIT"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Merchandise ID"
        '
        'MerchandiseIDLbl
        '
        Me.MerchandiseIDLbl.AutoSize = True
        Me.MerchandiseIDLbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MerchandiseIDLbl.Location = New System.Drawing.Point(158, 31)
        Me.MerchandiseIDLbl.Name = "MerchandiseIDLbl"
        Me.MerchandiseIDLbl.Size = New System.Drawing.Size(50, 17)
        Me.MerchandiseIDLbl.TabIndex = 3
        Me.MerchandiseIDLbl.Text = "xxxxxx"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Point"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID"
        '
        'MerchandisePointTxt
        '
        Me.MerchandisePointTxt.Enabled = False
        Me.MerchandisePointTxt.Location = New System.Drawing.Point(161, 54)
        Me.MerchandisePointTxt.MaxLength = 9
        Me.MerchandisePointTxt.Name = "MerchandisePointTxt"
        Me.MerchandisePointTxt.Size = New System.Drawing.Size(47, 20)
        Me.MerchandisePointTxt.TabIndex = 3
        Me.MerchandisePointTxt.Text = "0"
        Me.MerchandisePointTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProductIDLbl
        '
        Me.ProductIDLbl.AutoSize = True
        Me.ProductIDLbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDLbl.Location = New System.Drawing.Point(158, 8)
        Me.ProductIDLbl.Name = "ProductIDLbl"
        Me.ProductIDLbl.Size = New System.Drawing.Size(50, 17)
        Me.ProductIDLbl.TabIndex = 1
        Me.ProductIDLbl.Text = "xxxxxx"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(979, 35)
        Me.Panel8.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(977, 33)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "MERCHANDISE MASTER DATA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_002_05_Mechandise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(979, 579)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.MerchandiseDataGrid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "_002_05_Mechandise"
        Me.Text = "Merchandise Master Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MerchandiseDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MerchandiseDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MerchandisePointTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductIDLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MerchandiseIDLbl As System.Windows.Forms.Label
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
