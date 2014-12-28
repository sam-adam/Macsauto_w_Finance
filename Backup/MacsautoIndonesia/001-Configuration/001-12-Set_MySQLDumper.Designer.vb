<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_12_MySQLDumper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_12_MySQLDumper))
        Me.save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.MySQLDumperTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Folder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.BackgroundImage = CType(resources.GetObject("save.BackgroundImage"), System.Drawing.Image)
        Me.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.save.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save.Location = New System.Drawing.Point(15, 52)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(100, 50)
        Me.save.TabIndex = 18
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.BackgroundImage = CType(resources.GetObject("Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cancel.Location = New System.Drawing.Point(121, 52)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 50)
        Me.Cancel.TabIndex = 22
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'MySQLDumperTxt
        '
        Me.MySQLDumperTxt.Location = New System.Drawing.Point(15, 26)
        Me.MySQLDumperTxt.Name = "MySQLDumperTxt"
        Me.MySQLDumperTxt.Size = New System.Drawing.Size(206, 20)
        Me.MySQLDumperTxt.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Executable (mysqldump.exe) path:"
        '
        'Folder
        '
        Me.Folder.Location = New System.Drawing.Point(227, 26)
        Me.Folder.Name = "Folder"
        Me.Folder.Size = New System.Drawing.Size(34, 20)
        Me.Folder.TabIndex = 25
        Me.Folder.Text = "..."
        Me.Folder.UseVisualStyleBackColor = True
        '
        '_001_12_MySQLDumper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 119)
        Me.Controls.Add(Me.Folder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MySQLDumperTxt)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.save)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_12_MySQLDumper"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set MySQL Dumper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents MySQLDumperTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Folder As System.Windows.Forms.Button
End Class
