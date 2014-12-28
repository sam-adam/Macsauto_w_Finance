<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _004_02_Stock_Transfers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_004_02_Stock_Transfers))
        Me.TransferID = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToQTY = New System.Windows.Forms.TextBox()
        Me.fromQTY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fromCBO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.toCbo = New System.Windows.Forms.ComboBox()
        Me.TransferQTY = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Prodesc = New System.Windows.Forms.Label()
        Me.productID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MoveRea = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MoveRef = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.trfid = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TransferID.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransferID
        '
        Me.TransferID.Controls.Add(Me.GroupBox1)
        Me.TransferID.Controls.Add(Me.TransferQTY)
        Me.TransferID.Controls.Add(Me.Label9)
        Me.TransferID.Controls.Add(Me.Prodesc)
        Me.TransferID.Controls.Add(Me.productID)
        Me.TransferID.Controls.Add(Me.Label5)
        Me.TransferID.Controls.Add(Me.Label2)
        Me.TransferID.Location = New System.Drawing.Point(12, 70)
        Me.TransferID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferID.Name = "TransferID"
        Me.TransferID.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferID.Size = New System.Drawing.Size(469, 228)
        Me.TransferID.TabIndex = 7
        Me.TransferID.TabStop = False
        Me.TransferID.Text = "Stock Transfer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToQTY)
        Me.GroupBox1.Controls.Add(Me.fromQTY)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.fromCBO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.toCbo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 99)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destination"
        '
        'ToQTY
        '
        Me.ToQTY.Enabled = False
        Me.ToQTY.Location = New System.Drawing.Point(262, 62)
        Me.ToQTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToQTY.Name = "ToQTY"
        Me.ToQTY.Size = New System.Drawing.Size(140, 22)
        Me.ToQTY.TabIndex = 28
        Me.ToQTY.Text = "0"
        '
        'fromQTY
        '
        Me.fromQTY.Enabled = False
        Me.fromQTY.Location = New System.Drawing.Point(82, 63)
        Me.fromQTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fromQTY.Name = "fromQTY"
        Me.fromQTY.Size = New System.Drawing.Size(140, 22)
        Me.fromQTY.TabIndex = 27
        Me.fromQTY.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "QTY"
        '
        'fromCBO
        '
        Me.fromCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fromCBO.FormattingEnabled = True
        Me.fromCBO.Location = New System.Drawing.Point(82, 29)
        Me.fromCBO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fromCBO.Name = "fromCBO"
        Me.fromCBO.Size = New System.Drawing.Size(140, 24)
        Me.fromCBO.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "To"
        '
        'toCbo
        '
        Me.toCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.toCbo.FormattingEnabled = True
        Me.toCbo.Location = New System.Drawing.Point(262, 28)
        Me.toCbo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.toCbo.Name = "toCbo"
        Me.toCbo.Size = New System.Drawing.Size(140, 24)
        Me.toCbo.TabIndex = 25
        '
        'TransferQTY
        '
        Me.TransferQTY.Location = New System.Drawing.Point(97, 194)
        Me.TransferQTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferQTY.MaxLength = 9
        Me.TransferQTY.Name = "TransferQTY"
        Me.TransferQTY.Size = New System.Drawing.Size(116, 22)
        Me.TransferQTY.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "QTY Transfer"
        '
        'Prodesc
        '
        Me.Prodesc.AutoSize = True
        Me.Prodesc.Location = New System.Drawing.Point(145, 55)
        Me.Prodesc.Name = "Prodesc"
        Me.Prodesc.Size = New System.Drawing.Size(48, 16)
        Me.Prodesc.TabIndex = 19
        Me.Prodesc.Text = "XXXXX"
        '
        'productID
        '
        Me.productID.AutoSize = True
        Me.productID.Location = New System.Drawing.Point(145, 28)
        Me.productID.Name = "productID"
        Me.productID.Size = New System.Drawing.Size(48, 16)
        Me.productID.TabIndex = 18
        Me.productID.Text = "XXXXX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Product Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product ID"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(370, 378)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Stock Transfer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MoveRea
        '
        Me.MoveRea.Location = New System.Drawing.Point(150, 332)
        Me.MoveRea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MoveRea.Multiline = True
        Me.MoveRea.Name = "MoveRea"
        Me.MoveRea.Size = New System.Drawing.Size(277, 38)
        Me.MoveRea.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Reference Document"
        '
        'MoveRef
        '
        Me.MoveRef.Location = New System.Drawing.Point(150, 302)
        Me.MoveRef.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MoveRef.Name = "MoveRef"
        Me.MoveRef.Size = New System.Drawing.Size(191, 22)
        Me.MoveRef.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Reason for Product " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Movement"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "STOCK TRANSFER REQUEST #"
        '
        'trfid
        '
        Me.trfid.AutoSize = True
        Me.trfid.Location = New System.Drawing.Point(191, 50)
        Me.trfid.Name = "trfid"
        Me.trfid.Size = New System.Drawing.Size(48, 16)
        Me.trfid.TabIndex = 20
        Me.trfid.Text = "XXXXX"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(496, 35)
        Me.Panel8.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(75, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(378, 19)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "STOCK TRANSFER (FROM STORAGE TO STORAGE)"
        '
        '_004_02_Stock_Transfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(496, 422)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.trfid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MoveRea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MoveRef)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TransferID)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_004_02_Stock_Transfers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfers"
        Me.TransferID.ResumeLayout(False)
        Me.TransferID.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransferID As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MoveRea As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MoveRef As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TransferQTY As System.Windows.Forms.TextBox
    Friend WithEvents toCbo As System.Windows.Forms.ComboBox
    Friend WithEvents fromCBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Prodesc As System.Windows.Forms.Label
    Friend WithEvents productID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents trfid As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToQTY As System.Windows.Forms.TextBox
    Friend WithEvents fromQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
