<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _003_05_Cancel_Transaction
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
        Me.TransactionIdTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RemarkTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TransactionDetailView = New MacsautoIndonesia._005_14_TransactionDetail()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransactionIdTxt
        '
        Me.TransactionIdTxt.Location = New System.Drawing.Point(128, 13)
        Me.TransactionIdTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionIdTxt.Name = "TransactionIdTxt"
        Me.TransactionIdTxt.Size = New System.Drawing.Size(225, 23)
        Me.TransactionIdTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transaction #"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TransactionIdTxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 50)
        Me.Panel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CancelBtn)
        Me.Panel4.Controls.Add(Me.SubmitBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 553)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(901, 35)
        Me.Panel4.TabIndex = 6
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(706, 5)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(88, 27)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "Close"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubmitBtn.Enabled = False
        Me.SubmitBtn.Location = New System.Drawing.Point(800, 5)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(88, 27)
        Me.SubmitBtn.TabIndex = 3
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.RemarkTxt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 388)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(901, 165)
        Me.Panel3.TabIndex = 8
        '
        'RemarkTxt
        '
        Me.RemarkTxt.Location = New System.Drawing.Point(75, 7)
        Me.RemarkTxt.Multiline = True
        Me.RemarkTxt.Name = "RemarkTxt"
        Me.RemarkTxt.Size = New System.Drawing.Size(367, 105)
        Me.RemarkTxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Remark"
        '
        'TransactionDetailView
        '
        Me.TransactionDetailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDetailView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TransactionDetailView.Location = New System.Drawing.Point(0, 50)
        Me.TransactionDetailView.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionDetailView.MinimumSize = New System.Drawing.Size(867, 0)
        Me.TransactionDetailView.Name = "TransactionDetailView"
        Me.TransactionDetailView.PaymentType = "Credit"
        Me.TransactionDetailView.Size = New System.Drawing.Size(901, 338)
        Me.TransactionDetailView.TabIndex = 7
        Me.TransactionDetailView.VehicleType = "Motorcycle"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(360, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(406, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "*Only transaction that has not been cancelled can be cancelled"
        '
        '_003_05_Cancel_Transaction
        '
        Me.AcceptButton = Me.SubmitBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 588)
        Me.Controls.Add(Me.TransactionDetailView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_003_05_Cancel_Transaction"
        Me.Text = "Transaction - Cancel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TransactionIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents TransactionDetailView As MacsautoIndonesia._005_14_TransactionDetail
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RemarkTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
