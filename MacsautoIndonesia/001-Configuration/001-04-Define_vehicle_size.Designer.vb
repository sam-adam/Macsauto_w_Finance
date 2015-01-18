<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_04_Define_vehicle_size
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_04_Define_vehicle_size))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SizeView = New System.Windows.Forms.DataGridView()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewSizeCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SizeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SizeView
        '
        Me.SizeView.AllowUserToDeleteRows = False
        Me.SizeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SizeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SizeView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.NewSizeCol})
        Me.SizeView.Location = New System.Drawing.Point(2, 4)
        Me.SizeView.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SizeView.Name = "SizeView"
        Me.SizeView.Size = New System.Drawing.Size(346, 337)
        Me.SizeView.TabIndex = 2
        '
        'savebtn
        '
        Me.savebtn.BackgroundImage = CType(resources.GetObject("savebtn.BackgroundImage"), System.Drawing.Image)
        Me.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.savebtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.savebtn.Location = New System.Drawing.Point(246, 349)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(100, 50)
        Me.savebtn.TabIndex = 3
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'Column1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "SIZE #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "SIZE DESCRIPTION"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'NewSizeCol
        '
        Me.NewSizeCol.HeaderText = "NewSize"
        Me.NewSizeCol.Name = "NewSizeCol"
        Me.NewSizeCol.ReadOnly = True
        Me.NewSizeCol.Visible = False
        '
        '_001_04_Define_vehicle_size
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(350, 407)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.SizeView)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_04_Define_vehicle_size"
        Me.Text = "Define Vehicle Size"
        CType(Me.SizeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SizeView As System.Windows.Forms.DataGridView
    Friend WithEvents savebtn As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewSizeCol As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
