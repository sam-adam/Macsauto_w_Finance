<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_03_01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_03_01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BrandView = New System.Windows.Forms.DataGridView()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.carRadio = New System.Windows.Forms.RadioButton()
        Me.BikeRadio = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewAddition = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Edited = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.BrandView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BrandView
        '
        Me.BrandView.AllowUserToDeleteRows = False
        Me.BrandView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrandView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BrandView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.NewAddition, Me.Edited})
        Me.BrandView.Location = New System.Drawing.Point(4, 30)
        Me.BrandView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BrandView.Name = "BrandView"
        Me.BrandView.Size = New System.Drawing.Size(350, 391)
        Me.BrandView.TabIndex = 0
        '
        'saveBtn
        '
        Me.saveBtn.BackgroundImage = CType(resources.GetObject("saveBtn.BackgroundImage"), System.Drawing.Image)
        Me.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saveBtn.Location = New System.Drawing.Point(264, 449)
        Me.saveBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(87, 36)
        Me.saveBtn.TabIndex = 1
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'carRadio
        '
        Me.carRadio.AutoSize = True
        Me.carRadio.Checked = True
        Me.carRadio.Location = New System.Drawing.Point(99, 5)
        Me.carRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.carRadio.Name = "carRadio"
        Me.carRadio.Size = New System.Drawing.Size(49, 20)
        Me.carRadio.TabIndex = 2
        Me.carRadio.TabStop = True
        Me.carRadio.Text = "CAR"
        Me.carRadio.UseVisualStyleBackColor = True
        '
        'BikeRadio
        '
        Me.BikeRadio.AutoSize = True
        Me.BikeRadio.Location = New System.Drawing.Point(154, 5)
        Me.BikeRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BikeRadio.Name = "BikeRadio"
        Me.BikeRadio.Size = New System.Drawing.Size(103, 20)
        Me.BikeRadio.TabIndex = 3
        Me.BikeRadio.Text = "MOTORCYCLE"
        Me.BikeRadio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Vehicle Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(13, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Double Click on the line item to add new Vehicle Model"
        '
        'Column1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Brand #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Brand Description"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
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
        '_001_03_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(359, 489)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BikeRadio)
        Me.Controls.Add(Me.carRadio)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.BrandView)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_03_01"
        Me.Text = "Define Vehicle Brand and Model"
        CType(Me.BrandView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrandView As System.Windows.Forms.DataGridView
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents carRadio As System.Windows.Forms.RadioButton
    Friend WithEvents BikeRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAddition As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Edited As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
