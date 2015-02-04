<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _003_09_Void_Remark
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.VoidReasonTxt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.VoidBtn = New System.Windows.Forms.Button()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gold
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.TitleLbl)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(378, 51)
        Me.Panel8.TabIndex = 31
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(4, 12)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(174, 25)
        Me.TitleLbl.TabIndex = 3
        Me.TitleLbl.Text = "Enter Void Reason"
        '
        'VoidReasonTxt
        '
        Me.VoidReasonTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VoidReasonTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.VoidReasonTxt.Location = New System.Drawing.Point(0, 51)
        Me.VoidReasonTxt.Multiline = True
        Me.VoidReasonTxt.Name = "VoidReasonTxt"
        Me.VoidReasonTxt.Size = New System.Drawing.Size(378, 141)
        Me.VoidReasonTxt.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.VoidBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(378, 45)
        Me.Panel3.TabIndex = 33
        '
        'VoidBtn
        '
        Me.VoidBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VoidBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VoidBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.VoidBtn.ForeColor = System.Drawing.Color.White
        Me.VoidBtn.Location = New System.Drawing.Point(0, 0)
        Me.VoidBtn.Name = "VoidBtn"
        Me.VoidBtn.Size = New System.Drawing.Size(378, 45)
        Me.VoidBtn.TabIndex = 0
        Me.VoidBtn.Text = "Void"
        Me.VoidBtn.UseVisualStyleBackColor = False
        '
        '_003_09_Void_Remark
        '
        Me.AcceptButton = Me.VoidBtn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(378, 192)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.VoidReasonTxt)
        Me.Controls.Add(Me.Panel8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_003_09_Void_Remark"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction - Void Remark"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents TitleLbl As System.Windows.Forms.Label
    Friend WithEvents VoidReasonTxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents VoidBtn As System.Windows.Forms.Button
End Class
