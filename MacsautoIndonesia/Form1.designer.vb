<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PRemainingAR = New System.Windows.Forms.Label()
        Me.PTotalPayment = New System.Windows.Forms.Label()
        Me.PTotalPrice = New System.Windows.Forms.Label()
        Me.PCustNo = New System.Windows.Forms.Label()
        Me.PTransDat = New System.Windows.Forms.Label()
        Me.PInvNo = New System.Windows.Forms.Label()
        Me.PlistPrice = New System.Windows.Forms.ListBox()
        Me.PListDisc = New System.Windows.Forms.ListBox()
        Me.PListQty = New System.Windows.Forms.ListBox()
        Me.PListTrans = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PCmpAdd = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PRemainingAR)
        Me.Panel1.Controls.Add(Me.PTotalPayment)
        Me.Panel1.Controls.Add(Me.PTotalPrice)
        Me.Panel1.Controls.Add(Me.PCustNo)
        Me.Panel1.Controls.Add(Me.PTransDat)
        Me.Panel1.Controls.Add(Me.PInvNo)
        Me.Panel1.Controls.Add(Me.PlistPrice)
        Me.Panel1.Controls.Add(Me.PListDisc)
        Me.Panel1.Controls.Add(Me.PListQty)
        Me.Panel1.Controls.Add(Me.PListTrans)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.PCmpAdd)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 408)
        Me.Panel1.TabIndex = 0
        '
        'PRemainingAR
        '
        Me.PRemainingAR.AutoSize = True
        Me.PRemainingAR.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRemainingAR.Location = New System.Drawing.Point(582, 349)
        Me.PRemainingAR.Name = "PRemainingAR"
        Me.PRemainingAR.Size = New System.Drawing.Size(57, 16)
        Me.PRemainingAR.TabIndex = 28
        Me.PRemainingAR.Text = "KEMBALI"
        '
        'PTotalPayment
        '
        Me.PTotalPayment.AutoSize = True
        Me.PTotalPayment.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PTotalPayment.Location = New System.Drawing.Point(581, 328)
        Me.PTotalPayment.Name = "PTotalPayment"
        Me.PTotalPayment.Size = New System.Drawing.Size(85, 16)
        Me.PTotalPayment.TabIndex = 27
        Me.PTotalPayment.Text = "TOTAL BAYAR"
        '
        'PTotalPrice
        '
        Me.PTotalPrice.AutoSize = True
        Me.PTotalPrice.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PTotalPrice.Location = New System.Drawing.Point(582, 307)
        Me.PTotalPrice.Name = "PTotalPrice"
        Me.PTotalPrice.Size = New System.Drawing.Size(85, 16)
        Me.PTotalPrice.TabIndex = 26
        Me.PTotalPrice.Text = "TOTAL HARGA"
        '
        'PCustNo
        '
        Me.PCustNo.AutoSize = True
        Me.PCustNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCustNo.Location = New System.Drawing.Point(586, 61)
        Me.PCustNo.Name = "PCustNo"
        Me.PCustNo.Size = New System.Drawing.Size(91, 14)
        Me.PCustNo.TabIndex = 25
        Me.PCustNo.Text = "No. Customer"
        '
        'PTransDat
        '
        Me.PTransDat.AutoSize = True
        Me.PTransDat.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PTransDat.Location = New System.Drawing.Point(585, 103)
        Me.PTransDat.Name = "PTransDat"
        Me.PTransDat.Size = New System.Drawing.Size(126, 14)
        Me.PTransDat.TabIndex = 24
        Me.PTransDat.Text = "Tanggal Transaksi"
        '
        'PInvNo
        '
        Me.PInvNo.AutoSize = True
        Me.PInvNo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PInvNo.Location = New System.Drawing.Point(586, 82)
        Me.PInvNo.Name = "PInvNo"
        Me.PInvNo.Size = New System.Drawing.Size(84, 14)
        Me.PInvNo.TabIndex = 23
        Me.PInvNo.Text = "No. Invoice"
        '
        'PlistPrice
        '
        Me.PlistPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlistPrice.FormattingEnabled = True
        Me.PlistPrice.ItemHeight = 14
        Me.PlistPrice.Location = New System.Drawing.Point(505, 160)
        Me.PlistPrice.Name = "PlistPrice"
        Me.PlistPrice.Size = New System.Drawing.Size(98, 126)
        Me.PlistPrice.TabIndex = 22
        '
        'PListDisc
        '
        Me.PListDisc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PListDisc.FormattingEnabled = True
        Me.PListDisc.ItemHeight = 14
        Me.PListDisc.Location = New System.Drawing.Point(430, 160)
        Me.PListDisc.Name = "PListDisc"
        Me.PListDisc.Size = New System.Drawing.Size(67, 126)
        Me.PListDisc.TabIndex = 21
        '
        'PListQty
        '
        Me.PListQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PListQty.FormattingEnabled = True
        Me.PListQty.ItemHeight = 14
        Me.PListQty.Location = New System.Drawing.Point(326, 160)
        Me.PListQty.Name = "PListQty"
        Me.PListQty.Size = New System.Drawing.Size(67, 126)
        Me.PListQty.TabIndex = 20
        '
        'PListTrans
        '
        Me.PListTrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PListTrans.FormattingEnabled = True
        Me.PListTrans.ItemHeight = 14
        Me.PListTrans.Location = New System.Drawing.Point(14, 160)
        Me.PListTrans.Name = "PListTrans"
        Me.PListTrans.Size = New System.Drawing.Size(290, 126)
        Me.PListTrans.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(452, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 14)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "No. Customer"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(189, 14)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "www.macsauto-indonesia.com"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(451, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 14)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Tanggal Transaksi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(452, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 14)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "No. Invoice"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 361)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 14)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "(ADMIN)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(327, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 14)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "(CUSTOMER)"
        '
        'PCmpAdd
        '
        Me.PCmpAdd.AutoSize = True
        Me.PCmpAdd.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCmpAdd.Location = New System.Drawing.Point(13, 30)
        Me.PCmpAdd.Name = "PCmpAdd"
        Me.PCmpAdd.Size = New System.Drawing.Size(280, 42)
        Me.PCmpAdd.TabIndex = 12
        Me.PCmpAdd.Text = "HOS Cokroaminoto (Komp.SPBU Pertamina)," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Samping Ubud Village," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ciledug Raya"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(441, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "KEMBALI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(440, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "TOTAL BAYAR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(522, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(392, 14)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Copyright ©2013 MACSAUTO INDONESIA. All rights reserved"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(441, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "TOTAL HARGA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "DISKON"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(505, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "HARGA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(326, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "QUANTITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DETIL TRANSAKSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "INVOICE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MACSAUTO - INDONESIA"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(746, 406)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 13
        Me.LineShape4.X2 = 734
        Me.LineShape4.Y1 = 383
        Me.LineShape4.Y2 = 383
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 12
        Me.LineShape3.X2 = 733
        Me.LineShape3.Y1 = 301
        Me.LineShape3.Y2 = 301
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 734
        Me.LineShape2.Y1 = 157
        Me.LineShape2.Y2 = 157
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 731
        Me.LineShape1.Y1 = 134
        Me.LineShape1.Y2 = 134
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(684, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 71)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(773, 510)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Print Preview"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PCmpAdd As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PListTrans As System.Windows.Forms.ListBox
    Friend WithEvents PCustNo As System.Windows.Forms.Label
    Friend WithEvents PTransDat As System.Windows.Forms.Label
    Friend WithEvents PInvNo As System.Windows.Forms.Label
    Friend WithEvents PlistPrice As System.Windows.Forms.ListBox
    Friend WithEvents PListDisc As System.Windows.Forms.ListBox
    Friend WithEvents PListQty As System.Windows.Forms.ListBox
    Friend WithEvents PRemainingAR As System.Windows.Forms.Label
    Friend WithEvents PTotalPayment As System.Windows.Forms.Label
    Friend WithEvents PTotalPrice As System.Windows.Forms.Label

End Class
