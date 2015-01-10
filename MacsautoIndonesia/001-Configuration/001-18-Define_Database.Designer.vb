<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_18_Define_Database
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
        Me.DbNameTxt = New System.Windows.Forms.TextBox()
        Me.DbUsernameTxt = New System.Windows.Forms.TextBox()
        Me.DbPasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DbNameTxt
        '
        Me.DbNameTxt.Location = New System.Drawing.Point(156, 15)
        Me.DbNameTxt.Name = "DbNameTxt"
        Me.DbNameTxt.Size = New System.Drawing.Size(199, 23)
        Me.DbNameTxt.TabIndex = 0
        '
        'DbUsernameTxt
        '
        Me.DbUsernameTxt.Location = New System.Drawing.Point(156, 44)
        Me.DbUsernameTxt.Name = "DbUsernameTxt"
        Me.DbUsernameTxt.Size = New System.Drawing.Size(199, 23)
        Me.DbUsernameTxt.TabIndex = 2
        '
        'DbPasswordTxt
        '
        Me.DbPasswordTxt.Location = New System.Drawing.Point(156, 73)
        Me.DbPasswordTxt.Name = "DbPasswordTxt"
        Me.DbPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DbPasswordTxt.Size = New System.Drawing.Size(199, 23)
        Me.DbPasswordTxt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Database Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Database Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Database Password"
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(252, 102)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(103, 37)
        Me.SaveBtn.TabIndex = 7
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        '_001_18_Define_Database
        '
        Me.AcceptButton = Me.SaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 156)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DbPasswordTxt)
        Me.Controls.Add(Me.DbUsernameTxt)
        Me.Controls.Add(Me.DbNameTxt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "_001_18_Define_Database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Database Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents DbUsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents DbPasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
End Class
