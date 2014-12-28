<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_10_Define_Base_point
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_10_Define_Base_point))
        Me.basePoint = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.CompName = New System.Windows.Forms.TextBox()
        Me.CompCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'basePoint
        '
        Me.basePoint.Location = New System.Drawing.Point(162, 112)
        Me.basePoint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.basePoint.MaxLength = 9
        Me.basePoint.Name = "basePoint"
        Me.basePoint.Size = New System.Drawing.Size(146, 22)
        Me.basePoint.TabIndex = 37
        '
        'Cancel
        '
        Me.Cancel.BackgroundImage = CType(resources.GetObject("Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cancel.Location = New System.Drawing.Point(321, 155)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(84, 39)
        Me.Cancel.TabIndex = 39
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.BackgroundImage = CType(resources.GetObject("Edit.BackgroundImage"), System.Drawing.Image)
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Edit.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Edit.Location = New System.Drawing.Point(224, 155)
        Me.Edit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(84, 39)
        Me.Edit.TabIndex = 40
        Me.Edit.Text = "SAVE"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'CompName
        '
        Me.CompName.Enabled = False
        Me.CompName.Location = New System.Drawing.Point(162, 52)
        Me.CompName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompName.MaxLength = 50
        Me.CompName.Multiline = True
        Me.CompName.Name = "CompName"
        Me.CompName.Size = New System.Drawing.Size(210, 52)
        Me.CompName.TabIndex = 33
        '
        'CompCode
        '
        Me.CompCode.Enabled = False
        Me.CompCode.Location = New System.Drawing.Point(162, 17)
        Me.CompCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompCode.MaxLength = 3
        Me.CompCode.Name = "CompCode"
        Me.CompCode.Size = New System.Drawing.Size(116, 22)
        Me.CompCode.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Base amount for Point"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Company Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Company Code"
        '
        '_001_10_Define_Base_point
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(428, 208)
        Me.Controls.Add(Me.basePoint)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.CompName)
        Me.Controls.Add(Me.CompCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_001_10_Define_Base_point"
        Me.Text = "Define base point for customer point"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents basePoint As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents CompName As System.Windows.Forms.TextBox
    Friend WithEvents CompCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
