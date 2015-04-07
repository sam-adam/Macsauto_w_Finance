<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _003_01_04_CreatePayment
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
        Me.CashRadio = New System.Windows.Forms.RadioButton()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.CreditRadio = New System.Windows.Forms.RadioButton()
        Me.TransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.DebitRadio = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.DebitPnl = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DebitCardTxt = New System.Windows.Forms.TextBox()
        Me.CreditPnl = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CreditCardTxt = New System.Windows.Forms.TextBox()
        Me.CashPnl = New System.Windows.Forms.Panel()
        Me.ChangeLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CashPaymentTxt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GrandTotalLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.DebitPnl.SuspendLayout()
        Me.CreditPnl.SuspendLayout()
        Me.CashPnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gold
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.CashRadio)
        Me.Panel8.Controls.Add(Me.TitleLbl)
        Me.Panel8.Controls.Add(Me.CreditRadio)
        Me.Panel8.Controls.Add(Me.TransactionDate)
        Me.Panel8.Controls.Add(Me.DebitRadio)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(564, 51)
        Me.Panel8.TabIndex = 30
        '
        'CashRadio
        '
        Me.CashRadio.AutoSize = True
        Me.CashRadio.Location = New System.Drawing.Point(311, 14)
        Me.CashRadio.Name = "CashRadio"
        Me.CashRadio.Size = New System.Drawing.Size(54, 21)
        Me.CashRadio.TabIndex = 0
        Me.CashRadio.Text = "Cash"
        Me.CashRadio.UseVisualStyleBackColor = True
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(4, 12)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(144, 25)
        Me.TitleLbl.TabIndex = 3
        Me.TitleLbl.Text = "Make Payment"
        '
        'CreditRadio
        '
        Me.CreditRadio.AutoSize = True
        Me.CreditRadio.Location = New System.Drawing.Point(466, 14)
        Me.CreditRadio.Name = "CreditRadio"
        Me.CreditRadio.Size = New System.Drawing.Size(93, 21)
        Me.CreditRadio.TabIndex = 2
        Me.CreditRadio.TabStop = True
        Me.CreditRadio.Text = "Credit Card"
        Me.CreditRadio.UseVisualStyleBackColor = True
        '
        'TransactionDate
        '
        Me.TransactionDate.Enabled = False
        Me.TransactionDate.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TransactionDate.Location = New System.Drawing.Point(792, 12)
        Me.TransactionDate.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.Size = New System.Drawing.Size(242, 25)
        Me.TransactionDate.TabIndex = 15
        '
        'DebitRadio
        '
        Me.DebitRadio.AutoSize = True
        Me.DebitRadio.Location = New System.Drawing.Point(371, 14)
        Me.DebitRadio.Name = "DebitRadio"
        Me.DebitRadio.Size = New System.Drawing.Size(89, 21)
        Me.DebitRadio.TabIndex = 1
        Me.DebitRadio.TabStop = True
        Me.DebitRadio.Text = "Debit Card"
        Me.DebitRadio.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.CashPnl)
        Me.Panel1.Controls.Add(Me.DebitPnl)
        Me.Panel1.Controls.Add(Me.CreditPnl)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 200)
        Me.Panel1.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SubmitBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 155)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(564, 45)
        Me.Panel3.TabIndex = 2
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.SubmitBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubmitBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.SubmitBtn.Location = New System.Drawing.Point(0, 0)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(564, 45)
        Me.SubmitBtn.TabIndex = 0
        Me.SubmitBtn.Text = "Pay"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'DebitPnl
        '
        Me.DebitPnl.Controls.Add(Me.Label5)
        Me.DebitPnl.Controls.Add(Me.DebitCardTxt)
        Me.DebitPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DebitPnl.Location = New System.Drawing.Point(0, 46)
        Me.DebitPnl.Name = "DebitPnl"
        Me.DebitPnl.Size = New System.Drawing.Size(564, 154)
        Me.DebitPnl.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(84, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Debit Card #"
        '
        'DebitCardTxt
        '
        Me.DebitCardTxt.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.DebitCardTxt.Location = New System.Drawing.Point(240, 12)
        Me.DebitCardTxt.Name = "DebitCardTxt"
        Me.DebitCardTxt.Size = New System.Drawing.Size(312, 39)
        Me.DebitCardTxt.TabIndex = 5
        '
        'CreditPnl
        '
        Me.CreditPnl.Controls.Add(Me.Label4)
        Me.CreditPnl.Controls.Add(Me.CreditCardTxt)
        Me.CreditPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreditPnl.Location = New System.Drawing.Point(0, 46)
        Me.CreditPnl.Name = "CreditPnl"
        Me.CreditPnl.Size = New System.Drawing.Size(564, 154)
        Me.CreditPnl.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(78, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Credit Card #"
        '
        'CreditCardTxt
        '
        Me.CreditCardTxt.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.CreditCardTxt.Location = New System.Drawing.Point(240, 12)
        Me.CreditCardTxt.Name = "CreditCardTxt"
        Me.CreditCardTxt.Size = New System.Drawing.Size(312, 39)
        Me.CreditCardTxt.TabIndex = 3
        '
        'CashPnl
        '
        Me.CashPnl.Controls.Add(Me.ChangeLbl)
        Me.CashPnl.Controls.Add(Me.Label3)
        Me.CashPnl.Controls.Add(Me.Label2)
        Me.CashPnl.Controls.Add(Me.CashPaymentTxt)
        Me.CashPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CashPnl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashPnl.Location = New System.Drawing.Point(0, 46)
        Me.CashPnl.Name = "CashPnl"
        Me.CashPnl.Size = New System.Drawing.Size(564, 154)
        Me.CashPnl.TabIndex = 5
        '
        'ChangeLbl
        '
        Me.ChangeLbl.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.ChangeLbl.Location = New System.Drawing.Point(298, 60)
        Me.ChangeLbl.Name = "ChangeLbl"
        Me.ChangeLbl.Size = New System.Drawing.Size(259, 30)
        Me.ChangeLbl.TabIndex = 5
        Me.ChangeLbl.Text = "0"
        Me.ChangeLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(137, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Change"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(126, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Payment"
        '
        'CashPaymentTxt
        '
        Me.CashPaymentTxt.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.CashPaymentTxt.Location = New System.Drawing.Point(293, 12)
        Me.CashPaymentTxt.Name = "CashPaymentTxt"
        Me.CashPaymentTxt.Size = New System.Drawing.Size(259, 39)
        Me.CashPaymentTxt.TabIndex = 1
        Me.CashPaymentTxt.Text = "0"
        Me.CashPaymentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GrandTotalLbl)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 46)
        Me.Panel2.TabIndex = 3
        '
        'GrandTotalLbl
        '
        Me.GrandTotalLbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GrandTotalLbl.Location = New System.Drawing.Point(293, 5)
        Me.GrandTotalLbl.Name = "GrandTotalLbl"
        Me.GrandTotalLbl.Size = New System.Drawing.Size(263, 30)
        Me.GrandTotalLbl.TabIndex = 1
        Me.GrandTotalLbl.Text = "0"
        Me.GrandTotalLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(79, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grand Total:"
        '
        '_003_01_04_CreatePayment
        '
        Me.AcceptButton = Me.SubmitBtn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(564, 251)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(580, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(580, 290)
        Me.Name = "_003_01_04_CreatePayment"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.DebitPnl.ResumeLayout(False)
        Me.DebitPnl.PerformLayout()
        Me.CreditPnl.ResumeLayout(False)
        Me.CreditPnl.PerformLayout()
        Me.CashPnl.ResumeLayout(False)
        Me.CashPnl.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents TitleLbl As System.Windows.Forms.Label
    Friend WithEvents TransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CreditRadio As System.Windows.Forms.RadioButton
    Friend WithEvents DebitRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CashRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CashPnl As System.Windows.Forms.Panel
    Friend WithEvents DebitPnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CashPaymentTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChangeLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents GrandTotalLbl As System.Windows.Forms.Label
    Friend WithEvents CreditPnl As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CreditCardTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DebitCardTxt As System.Windows.Forms.TextBox
End Class
