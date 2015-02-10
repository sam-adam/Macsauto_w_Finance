<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_08_Define_Vehicle_Color
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_08_Define_Vehicle_Color))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ColorGridView = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ColorIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewColorCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ColorGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ColorGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSave)
        Me.SplitContainer1.Size = New System.Drawing.Size(385, 426)
        Me.SplitContainer1.SplitterDistance = 361
        Me.SplitContainer1.TabIndex = 5
        '
        'ColorGridView
        '
        Me.ColorGridView.AllowUserToDeleteRows = False
        Me.ColorGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColorGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ColorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ColorGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColorIdCol, Me.ColorDescriptionCol, Me.NewColorCol})
        Me.ColorGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorGridView.Location = New System.Drawing.Point(0, 0)
        Me.ColorGridView.Name = "ColorGridView"
        Me.ColorGridView.Size = New System.Drawing.Size(385, 361)
        Me.ColorGridView.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(282, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 50)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ColorIdCol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ColorIdCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColorIdCol.HeaderText = "Color #"
        Me.ColorIdCol.Name = "ColorIdCol"
        Me.ColorIdCol.ReadOnly = True
        Me.ColorIdCol.Visible = False
        Me.ColorIdCol.Width = 120
        '
        'ColorDescriptionCol
        '
        Me.ColorDescriptionCol.HeaderText = "Color Description"
        Me.ColorDescriptionCol.MaxInputLength = 50
        Me.ColorDescriptionCol.Name = "ColorDescriptionCol"
        Me.ColorDescriptionCol.Width = 200
        '
        'NewColorCol
        '
        Me.NewColorCol.HeaderText = "New Color"
        Me.NewColorCol.Name = "NewColorCol"
        Me.NewColorCol.ReadOnly = True
        Me.NewColorCol.Visible = False
        '
        '_001_08_Define_Vehicle_Color
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 426)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "_001_08_Define_Vehicle_Color"
        Me.Text = "Define Vehicle Color"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ColorGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ColorGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ColorIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDescriptionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewColorCol As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
