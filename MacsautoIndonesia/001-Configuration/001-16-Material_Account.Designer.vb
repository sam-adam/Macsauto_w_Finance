<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_16_Material_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_16_Material_Account))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.glact = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sales = New System.Windows.Forms.ComboBox()
        Me.COGS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(527, 72)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 29)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cash/Bank Account for Material Transaction"
        '
        'glact
        '
        Me.glact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.glact.FormattingEnabled = True
        Me.glact.Location = New System.Drawing.Point(263, 9)
        Me.glact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.glact.Name = "glact"
        Me.glact.Size = New System.Drawing.Size(248, 24)
        Me.glact.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sales Account for Material Transaction"
        '
        'Sales
        '
        Me.Sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sales.FormattingEnabled = True
        Me.Sales.Location = New System.Drawing.Point(263, 39)
        Me.Sales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(248, 24)
        Me.Sales.TabIndex = 6
        '
        'COGS
        '
        Me.COGS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COGS.FormattingEnabled = True
        Me.COGS.Location = New System.Drawing.Point(263, 72)
        Me.COGS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.COGS.Name = "COGS"
        Me.COGS.Size = New System.Drawing.Size(248, 24)
        Me.COGS.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "COGS Account for Material Transaction"
        '
        '_001_16_Material_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(604, 111)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.COGS)
        Me.Controls.Add(Me.Sales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.glact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_001_16_Material_Account"
        Me.Text = "_001_16_Material_Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents glact As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Sales As System.Windows.Forms.ComboBox
    Friend WithEvents COGS As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
