<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _003_01_06_TransactionPrint
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TransactionIdTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.TransactionDetailView = New MacsautoIndonesia._005_14_TransactionDetail()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TransactionIdTxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(381, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(255, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "*Only paid transaction can be reprinted"
        '
        'TransactionIdTxt
        '
        Me.TransactionIdTxt.Location = New System.Drawing.Point(125, 12)
        Me.TransactionIdTxt.Name = "TransactionIdTxt"
        Me.TransactionIdTxt.Size = New System.Drawing.Size(250, 23)
        Me.TransactionIdTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction #"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Controls.Add(Me.PrintBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 514)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(837, 35)
        Me.Panel2.TabIndex = 2
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(678, 2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 30)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'PrintBtn
        '
        Me.PrintBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(759, 2)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(75, 30)
        Me.PrintBtn.TabIndex = 3
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'TransactionDetailView
        '
        Me.TransactionDetailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDetailView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TransactionDetailView.Location = New System.Drawing.Point(0, 50)
        Me.TransactionDetailView.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionDetailView.MinimumSize = New System.Drawing.Size(867, 455)
        Me.TransactionDetailView.Name = "TransactionDetailView"
        Me.TransactionDetailView.PaymentType = "Credit"
        Me.TransactionDetailView.Size = New System.Drawing.Size(867, 464)
        Me.TransactionDetailView.TabIndex = 3
        Me.TransactionDetailView.VehicleType = "Motorcycle"
        '
        '_003_01_06_TransactionPrint
        '
        Me.AcceptButton = Me.PrintBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 549)
        Me.Controls.Add(Me.TransactionDetailView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_003_01_06_TransactionPrint"
        Me.Text = "Transaction - Print"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TransactionIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TransactionDetailView As MacsautoIndonesia._005_14_TransactionDetail
End Class
