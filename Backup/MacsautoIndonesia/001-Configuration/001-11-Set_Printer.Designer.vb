<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_11_Set_Printer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_11_Set_Printer))
        Me.ListBoxPrinter = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkPrintPreview = New System.Windows.Forms.CheckBox()
        Me.save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxPrinter
        '
        Me.ListBoxPrinter.FormattingEnabled = True
        Me.ListBoxPrinter.Location = New System.Drawing.Point(12, 25)
        Me.ListBoxPrinter.Name = "ListBoxPrinter"
        Me.ListBoxPrinter.Size = New System.Drawing.Size(232, 147)
        Me.ListBoxPrinter.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Set default printer"
        '
        'ChkPrintPreview
        '
        Me.ChkPrintPreview.AutoSize = True
        Me.ChkPrintPreview.Location = New System.Drawing.Point(128, 178)
        Me.ChkPrintPreview.Name = "ChkPrintPreview"
        Me.ChkPrintPreview.Size = New System.Drawing.Size(116, 17)
        Me.ChkPrintPreview.TabIndex = 2
        Me.ChkPrintPreview.Text = "Show print preview"
        Me.ChkPrintPreview.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.BackgroundImage = CType(resources.GetObject("save.BackgroundImage"), System.Drawing.Image)
        Me.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.save.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save.Location = New System.Drawing.Point(250, 9)
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
        Me.Cancel.Location = New System.Drawing.Point(250, 65)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 50)
        Me.Cancel.TabIndex = 22
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        '_001_11_Set_Printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 203)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.ChkPrintPreview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxPrinter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_11_Set_Printer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxPrinter As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkPrintPreview As System.Windows.Forms.CheckBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
