<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _003_04_TrMerchandiseRedemption
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_003_04_TrMerchandiseRedemption))
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CustomerPanel = New System.Windows.Forms.Panel()
        Me.cPoin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cCell = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cPhone = New System.Windows.Forms.TextBox()
        Me.cAddress = New System.Windows.Forms.TextBox()
        Me.cNAme = New System.Windows.Forms.TextBox()
        Me.cNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ServicePanel = New System.Windows.Forms.Panel()
        Me.MerchandiseGrid = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Point = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.RemoveServBtn = New System.Windows.Forms.Button()
        Me.AddServiceBtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TotalPointRequired = New System.Windows.Forms.TextBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8.SuspendLayout()
        Me.CustomerPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ServicePanel.SuspendLayout()
        CType(Me.MerchandiseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gold
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.TextBox4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(924, 35)
        Me.Panel8.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(194, 19)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "TRANSACTION NUMBER"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(209, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 24)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.Text = "Auto-Generated"
        '
        'CustomerPanel
        '
        Me.CustomerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerPanel.Controls.Add(Me.cPoin)
        Me.CustomerPanel.Controls.Add(Me.Label5)
        Me.CustomerPanel.Controls.Add(Me.Panel1)
        Me.CustomerPanel.Controls.Add(Me.cCell)
        Me.CustomerPanel.Controls.Add(Me.Label12)
        Me.CustomerPanel.Controls.Add(Me.Button1)
        Me.CustomerPanel.Controls.Add(Me.cPhone)
        Me.CustomerPanel.Controls.Add(Me.cAddress)
        Me.CustomerPanel.Controls.Add(Me.cNAme)
        Me.CustomerPanel.Controls.Add(Me.cNumber)
        Me.CustomerPanel.Controls.Add(Me.Label2)
        Me.CustomerPanel.Controls.Add(Me.Label4)
        Me.CustomerPanel.Controls.Add(Me.Label1)
        Me.CustomerPanel.Controls.Add(Me.Label3)
        Me.CustomerPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerPanel.Location = New System.Drawing.Point(3, 3)
        Me.CustomerPanel.Name = "CustomerPanel"
        Me.CustomerPanel.Size = New System.Drawing.Size(304, 236)
        Me.CustomerPanel.TabIndex = 31
        '
        'cPoin
        '
        Me.cPoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cPoin.Enabled = False
        Me.cPoin.Location = New System.Drawing.Point(116, 170)
        Me.cPoin.Name = "cPoin"
        Me.cPoin.Size = New System.Drawing.Size(75, 20)
        Me.cPoin.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Points"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Location = New System.Drawing.Point(-11, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 25)
        Me.Panel1.TabIndex = 12
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(32, 2)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 14)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Customer Data"
        '
        'cCell
        '
        Me.cCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cCell.Enabled = False
        Me.cCell.Location = New System.Drawing.Point(116, 144)
        Me.cCell.Name = "cCell"
        Me.cCell.Size = New System.Drawing.Size(170, 20)
        Me.cCell.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Cell phone "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cPhone
        '
        Me.cPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cPhone.Enabled = False
        Me.cPhone.Location = New System.Drawing.Point(116, 118)
        Me.cPhone.Name = "cPhone"
        Me.cPhone.Size = New System.Drawing.Size(170, 20)
        Me.cPhone.TabIndex = 7
        '
        'cAddress
        '
        Me.cAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cAddress.Enabled = False
        Me.cAddress.Location = New System.Drawing.Point(116, 56)
        Me.cAddress.Multiline = True
        Me.cAddress.Name = "cAddress"
        Me.cAddress.Size = New System.Drawing.Size(170, 58)
        Me.cAddress.TabIndex = 6
        '
        'cNAme
        '
        Me.cNAme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cNAme.Enabled = False
        Me.cNAme.Location = New System.Drawing.Point(116, 31)
        Me.cNAme.Name = "cNAme"
        Me.cNAme.Size = New System.Drawing.Size(170, 20)
        Me.cNAme.TabIndex = 5
        '
        'cNumber
        '
        Me.cNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cNumber.Location = New System.Drawing.Point(116, 8)
        Me.cNumber.MaxLength = 11
        Me.cNumber.Name = "cNumber"
        Me.cNumber.Size = New System.Drawing.Size(127, 20)
        Me.cNumber.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer Phone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Address"
        '
        'TrDATE
        '
        Me.TrDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrDATE.Location = New System.Drawing.Point(454, 0)
        Me.TrDATE.Name = "TrDATE"
        Me.TrDATE.Size = New System.Drawing.Size(217, 20)
        Me.TrDATE.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(313, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 17)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "TRANSACTION DATE"
        '
        'ServicePanel
        '
        Me.ServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServicePanel.Controls.Add(Me.MerchandiseGrid)
        Me.ServicePanel.Controls.Add(Me.Panel5)
        Me.ServicePanel.Controls.Add(Me.RemoveServBtn)
        Me.ServicePanel.Controls.Add(Me.AddServiceBtn)
        Me.ServicePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicePanel.Location = New System.Drawing.Point(313, 26)
        Me.ServicePanel.Name = "ServicePanel"
        Me.ServicePanel.Size = New System.Drawing.Size(596, 206)
        Me.ServicePanel.TabIndex = 34
        '
        'MerchandiseGrid
        '
        Me.MerchandiseGrid.AllowUserToAddRows = False
        Me.MerchandiseGrid.AllowUserToDeleteRows = False
        Me.MerchandiseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MerchandiseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column8, Me.Point})
        Me.MerchandiseGrid.Location = New System.Drawing.Point(3, 3)
        Me.MerchandiseGrid.Name = "MerchandiseGrid"
        Me.MerchandiseGrid.Size = New System.Drawing.Size(587, 162)
        Me.MerchandiseGrid.TabIndex = 16
        '
        'Column7
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column7.HeaderText = "Seq"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn1.HeaderText = "Merchandise ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle19.Format = "N0"
        DataGridViewCellStyle19.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn3.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'Column8
        '
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column8.HeaderText = "UoM"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 60
        '
        'Point
        '
        Me.Point.HeaderText = "Point"
        Me.Point.Name = "Point"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gold
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Location = New System.Drawing.Point(-3, 186)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(151, 22)
        Me.Panel5.TabIndex = 15
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(15, 1)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(126, 14)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Redemption Item Detail"
        '
        'RemoveServBtn
        '
        Me.RemoveServBtn.BackgroundImage = CType(resources.GetObject("RemoveServBtn.BackgroundImage"), System.Drawing.Image)
        Me.RemoveServBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RemoveServBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RemoveServBtn.Location = New System.Drawing.Point(402, 171)
        Me.RemoveServBtn.Name = "RemoveServBtn"
        Me.RemoveServBtn.Size = New System.Drawing.Size(188, 29)
        Me.RemoveServBtn.TabIndex = 2
        Me.RemoveServBtn.Text = "REMOVE MERCHANDISE"
        Me.RemoveServBtn.UseVisualStyleBackColor = True
        '
        'AddServiceBtn
        '
        Me.AddServiceBtn.BackgroundImage = CType(resources.GetObject("AddServiceBtn.BackgroundImage"), System.Drawing.Image)
        Me.AddServiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddServiceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddServiceBtn.Location = New System.Drawing.Point(245, 171)
        Me.AddServiceBtn.Name = "AddServiceBtn"
        Me.AddServiceBtn.Size = New System.Drawing.Size(151, 29)
        Me.AddServiceBtn.TabIndex = 1
        Me.AddServiceBtn.Text = "ADD MERCHANDISE"
        Me.AddServiceBtn.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 26)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Total Point Required"
        '
        'TotalPointRequired
        '
        Me.TotalPointRequired.Enabled = False
        Me.TotalPointRequired.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPointRequired.Location = New System.Drawing.Point(219, 18)
        Me.TotalPointRequired.Name = "TotalPointRequired"
        Me.TotalPointRequired.Size = New System.Drawing.Size(256, 33)
        Me.TotalPointRequired.TabIndex = 18
        Me.TotalPointRequired.Text = "0"
        Me.TotalPointRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.BackgroundImage = CType(resources.GetObject("CancelBtn.BackgroundImage"), System.Drawing.Image)
        Me.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelBtn.Location = New System.Drawing.Point(811, 8)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(101, 53)
        Me.CancelBtn.TabIndex = 36
        Me.CancelBtn.Text = "CANCEL"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBtn.BackgroundImage = CType(resources.GetObject("SaveBtn.BackgroundImage"), System.Drawing.Image)
        Me.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaveBtn.Location = New System.Drawing.Point(704, 8)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(101, 53)
        Me.SaveBtn.TabIndex = 35
        Me.SaveBtn.Text = "SAVE"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gold
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label32)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 350)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(924, 24)
        Me.Panel7.TabIndex = 37
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(1008, 5)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(209, 14)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Copyrights © 2013 – Macsauto Indonesia"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.CustomerPanel)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.TrDATE)
        Me.Panel2.Controls.Add(Me.ServicePanel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 315)
        Me.Panel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TotalPointRequired)
        Me.Panel3.Controls.Add(Me.SaveBtn)
        Me.Panel3.Controls.Add(Me.CancelBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 248)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(924, 67)
        Me.Panel3.TabIndex = 37
        '
        '_003_04_TrMerchandiseRedemption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(924, 374)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "_003_04_TrMerchandiseRedemption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merchandise Redemption"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.CustomerPanel.ResumeLayout(False)
        Me.CustomerPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ServicePanel.ResumeLayout(False)
        CType(Me.MerchandiseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CustomerPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cCell As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cPhone As System.Windows.Forms.TextBox
    Friend WithEvents cAddress As System.Windows.Forms.TextBox
    Friend WithEvents cNAme As System.Windows.Forms.TextBox
    Friend WithEvents cNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cPoin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TrDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ServicePanel As System.Windows.Forms.Panel
    Friend WithEvents RemoveServBtn As System.Windows.Forms.Button
    Friend WithEvents AddServiceBtn As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents MerchandiseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Point As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TotalPointRequired As System.Windows.Forms.TextBox
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
