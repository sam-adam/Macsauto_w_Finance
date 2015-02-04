<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_19_Accounting_Configuration
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
        Me.TransactionGroup = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CashPaymentCbo = New System.Windows.Forms.ComboBox()
        Me.CardPaymentCbo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.TransactionGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransactionGroup
        '
        Me.TransactionGroup.Controls.Add(Me.CardPaymentCbo)
        Me.TransactionGroup.Controls.Add(Me.Label2)
        Me.TransactionGroup.Controls.Add(Me.CashPaymentCbo)
        Me.TransactionGroup.Controls.Add(Me.Label1)
        Me.TransactionGroup.Location = New System.Drawing.Point(12, 12)
        Me.TransactionGroup.Name = "TransactionGroup"
        Me.TransactionGroup.Size = New System.Drawing.Size(510, 102)
        Me.TransactionGroup.TabIndex = 0
        Me.TransactionGroup.TabStop = False
        Me.TransactionGroup.Text = "Transaction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash Payment"
        '
        'CashPaymentCbo
        '
        Me.CashPaymentCbo.FormattingEnabled = True
        Me.CashPaymentCbo.Location = New System.Drawing.Point(168, 24)
        Me.CashPaymentCbo.Name = "CashPaymentCbo"
        Me.CashPaymentCbo.Size = New System.Drawing.Size(329, 25)
        Me.CashPaymentCbo.TabIndex = 1
        '
        'CardPaymentCbo
        '
        Me.CardPaymentCbo.FormattingEnabled = True
        Me.CardPaymentCbo.Location = New System.Drawing.Point(168, 55)
        Me.CardPaymentCbo.Name = "CardPaymentCbo"
        Me.CardPaymentCbo.Size = New System.Drawing.Size(329, 25)
        Me.CardPaymentCbo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Debit / Credit Payment"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 37)
        Me.Panel1.TabIndex = 1
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.Location = New System.Drawing.Point(440, 4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(90, 30)
        Me.SaveBtn.TabIndex = 0
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        '_001_19_Accounting_Configuration
        '
        Me.AcceptButton = Me.SaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 295)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TransactionGroup)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_001_19_Accounting_Configuration"
        Me.Text = "Accounting - Configuration"
        Me.TransactionGroup.ResumeLayout(False)
        Me.TransactionGroup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TransactionGroup As System.Windows.Forms.GroupBox
    Friend WithEvents CashPaymentCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CardPaymentCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
End Class
