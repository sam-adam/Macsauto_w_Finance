<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_01_Define_UOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_01_Define_UOM))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UOMGridView = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewUoMCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.UOMGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UOMGridView
        '
        Me.UOMGridView.AllowUserToDeleteRows = False
        Me.UOMGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UOMGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.UOMGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UOMGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.NewUoMCol})
        Me.UOMGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UOMGridView.Location = New System.Drawing.Point(0, 0)
        Me.UOMGridView.Name = "UOMGridView"
        Me.UOMGridView.Size = New System.Drawing.Size(314, 360)
        Me.UOMGridView.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(206, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 50)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UOMGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSave)
        Me.SplitContainer1.Size = New System.Drawing.Size(314, 424)
        Me.SplitContainer1.SplitterDistance = 360
        Me.SplitContainer1.TabIndex = 2
        '
        'Column1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "UOM #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "UOM Description"
        Me.Column2.MaxInputLength = 10
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 160
        '
        'NewUoMCol
        '
        Me.NewUoMCol.HeaderText = "NewUoM"
        Me.NewUoMCol.Name = "NewUoMCol"
        Me.NewUoMCol.ReadOnly = True
        Me.NewUoMCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NewUoMCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NewUoMCol.Visible = False
        '
        '_001_01_Define_UOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(314, 424)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_01_Define_UOM"
        Me.Text = " Define Unit of Measure"
        CType(Me.UOMGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UOMGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewUoMCol As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
