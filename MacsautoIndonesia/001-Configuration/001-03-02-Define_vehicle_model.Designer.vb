<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_03_02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_03_02))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ModelView = New System.Windows.Forms.DataGridView()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleSizeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewAddition = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Edited = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.ModelView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModelView
        '
        Me.ModelView.AllowUserToDeleteRows = False
        Me.ModelView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ModelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.VehicleSizeCol, Me.NewAddition, Me.Edited})
        Me.ModelView.Location = New System.Drawing.Point(2, 1)
        Me.ModelView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ModelView.Name = "ModelView"
        Me.ModelView.Size = New System.Drawing.Size(493, 384)
        Me.ModelView.TabIndex = 1
        '
        'Savebtn
        '
        Me.Savebtn.BackgroundImage = CType(resources.GetObject("Savebtn.BackgroundImage"), System.Drawing.Image)
        Me.Savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Savebtn.Location = New System.Drawing.Point(397, 393)
        Me.Savebtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(91, 36)
        Me.Savebtn.TabIndex = 2
        Me.Savebtn.Text = "SAVE"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Press F4 on the line item to search vehicle size "
        '
        'Column1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Model #"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Model Description"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'VehicleSizeCol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VehicleSizeCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.VehicleSizeCol.HeaderText = "Vehicle Size"
        Me.VehicleSizeCol.Name = "VehicleSizeCol"
        Me.VehicleSizeCol.ReadOnly = True
        Me.VehicleSizeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VehicleSizeCol.Width = 150
        '
        'NewAddition
        '
        Me.NewAddition.HeaderText = "NewAddition"
        Me.NewAddition.Name = "NewAddition"
        Me.NewAddition.ReadOnly = True
        Me.NewAddition.Visible = False
        '
        'Edited
        '
        Me.Edited.HeaderText = "Edited"
        Me.Edited.Name = "Edited"
        Me.Edited.ReadOnly = True
        Me.Edited.Visible = False
        '
        '_001_03_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(500, 442)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.ModelView)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_03_02"
        Me.Text = "Define Vehicle Model per Brand"
        CType(Me.ModelView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModelView As System.Windows.Forms.DataGridView
    Friend WithEvents Savebtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleSizeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAddition As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Edited As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
