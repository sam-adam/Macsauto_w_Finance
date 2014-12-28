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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TransactionIdTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResultCountLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TrItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrItemQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrItemDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrItemSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CustomerNameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AdminTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VehicleTypeTxt = New System.Windows.Forms.TextBox()
        Me.CreatedTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LicenseTxt = New System.Windows.Forms.TextBox()
        Me.VehicleColorTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VehicleBrandTxt = New System.Windows.Forms.TextBox()
        Me.VehicleModelTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.RemarkTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransactionIdTxt
        '
        Me.TransactionIdTxt.Location = New System.Drawing.Point(191, 7)
        Me.TransactionIdTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionIdTxt.Name = "TransactionIdTxt"
        Me.TransactionIdTxt.Size = New System.Drawing.Size(225, 23)
        Me.TransactionIdTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Transaction Number"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 41)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ResultCountLabel)
        Me.Panel2.Controls.Add(Me.SearchButton)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TransactionIdTxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 34)
        Me.Panel2.TabIndex = 0
        '
        'ResultCountLabel
        '
        Me.ResultCountLabel.AutoSize = True
        Me.ResultCountLabel.Location = New System.Drawing.Point(516, 10)
        Me.ResultCountLabel.Name = "ResultCountLabel"
        Me.ResultCountLabel.Size = New System.Drawing.Size(147, 17)
        Me.ResultCountLabel.TabIndex = 3
        Me.ResultCountLabel.Text = "0 transaction(s) found"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(422, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(88, 27)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(707, 248)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(88, 27)
        Me.SubmitButton.TabIndex = 4
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(801, 248)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(88, 27)
        Me.CancelButton.TabIndex = 5
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.RemarkTxt)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(901, 547)
        Me.Panel3.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 178)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(899, 100)
        Me.Panel5.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrItem, Me.TrItemPrice, Me.TrItemQty, Me.TrItemDiscount, Me.TrItemSubtotal})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(899, 100)
        Me.DataGridView1.TabIndex = 17
        '
        'TrItem
        '
        Me.TrItem.HeaderText = "Transaction Item"
        Me.TrItem.Name = "TrItem"
        Me.TrItem.ReadOnly = True
        '
        'TrItemPrice
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.TrItemPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.TrItemPrice.HeaderText = "Item Price"
        Me.TrItemPrice.Name = "TrItemPrice"
        Me.TrItemPrice.ReadOnly = True
        '
        'TrItemQty
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.TrItemQty.DefaultCellStyle = DataGridViewCellStyle2
        Me.TrItemQty.HeaderText = "Item Quantity"
        Me.TrItemQty.Name = "TrItemQty"
        Me.TrItemQty.ReadOnly = True
        '
        'TrItemDiscount
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.TrItemDiscount.DefaultCellStyle = DataGridViewCellStyle3
        Me.TrItemDiscount.HeaderText = "Item Discount (%)"
        Me.TrItemDiscount.Name = "TrItemDiscount"
        Me.TrItemDiscount.ReadOnly = True
        '
        'TrItemSubtotal
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.TrItemSubtotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.TrItemSubtotal.HeaderText = "Item Subtotal"
        Me.TrItemSubtotal.Name = "TrItemSubtotal"
        Me.TrItemSubtotal.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.CustomerNameTxt)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.AdminTxt)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.VehicleTypeTxt)
        Me.Panel6.Controls.Add(Me.CreatedTxt)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.LicenseTxt)
        Me.Panel6.Controls.Add(Me.VehicleColorTxt)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.VehicleBrandTxt)
        Me.Panel6.Controls.Add(Me.VehicleModelTxt)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(899, 178)
        Me.Panel6.TabIndex = 19
        '
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.Enabled = False
        Me.CustomerNameTxt.Location = New System.Drawing.Point(117, 14)
        Me.CustomerNameTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.Size = New System.Drawing.Size(225, 23)
        Me.CustomerNameTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer"
        '
        'AdminTxt
        '
        Me.AdminTxt.Enabled = False
        Me.AdminTxt.Location = New System.Drawing.Point(117, 138)
        Me.AdminTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.AdminTxt.Name = "AdminTxt"
        Me.AdminTxt.Size = New System.Drawing.Size(225, 23)
        Me.AdminTxt.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vehicle Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Admin"
        '
        'VehicleTypeTxt
        '
        Me.VehicleTypeTxt.Enabled = False
        Me.VehicleTypeTxt.Location = New System.Drawing.Point(117, 45)
        Me.VehicleTypeTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.VehicleTypeTxt.Name = "VehicleTypeTxt"
        Me.VehicleTypeTxt.Size = New System.Drawing.Size(225, 23)
        Me.VehicleTypeTxt.TabIndex = 3
        '
        'CreatedTxt
        '
        Me.CreatedTxt.Enabled = False
        Me.CreatedTxt.Location = New System.Drawing.Point(117, 107)
        Me.CreatedTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CreatedTxt.Name = "CreatedTxt"
        Me.CreatedTxt.Size = New System.Drawing.Size(225, 23)
        Me.CreatedTxt.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "License"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Date"
        '
        'LicenseTxt
        '
        Me.LicenseTxt.Enabled = False
        Me.LicenseTxt.Location = New System.Drawing.Point(117, 76)
        Me.LicenseTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.LicenseTxt.Name = "LicenseTxt"
        Me.LicenseTxt.Size = New System.Drawing.Size(225, 23)
        Me.LicenseTxt.TabIndex = 5
        '
        'VehicleColorTxt
        '
        Me.VehicleColorTxt.Enabled = False
        Me.VehicleColorTxt.Location = New System.Drawing.Point(483, 76)
        Me.VehicleColorTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.VehicleColorTxt.Name = "VehicleColorTxt"
        Me.VehicleColorTxt.Size = New System.Drawing.Size(225, 23)
        Me.VehicleColorTxt.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Brand"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(430, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Color"
        '
        'VehicleBrandTxt
        '
        Me.VehicleBrandTxt.Enabled = False
        Me.VehicleBrandTxt.Location = New System.Drawing.Point(483, 14)
        Me.VehicleBrandTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.VehicleBrandTxt.Name = "VehicleBrandTxt"
        Me.VehicleBrandTxt.Size = New System.Drawing.Size(225, 23)
        Me.VehicleBrandTxt.TabIndex = 8
        '
        'VehicleModelTxt
        '
        Me.VehicleModelTxt.Enabled = False
        Me.VehicleModelTxt.Location = New System.Drawing.Point(483, 45)
        Me.VehicleModelTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.VehicleModelTxt.Name = "VehicleModelTxt"
        Me.VehicleModelTxt.Size = New System.Drawing.Size(225, 23)
        Me.VehicleModelTxt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(430, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Model"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CancelBtn)
        Me.Panel4.Controls.Add(Me.SubmitBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 499)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(899, 46)
        Me.Panel4.TabIndex = 6
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(706, 8)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(88, 27)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "Close"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Enabled = False
        Me.SubmitBtn.Location = New System.Drawing.Point(800, 8)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(88, 27)
        Me.SubmitBtn.TabIndex = 3
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'RemarkTxt
        '
        Me.RemarkTxt.Location = New System.Drawing.Point(23, 317)
        Me.RemarkTxt.Multiline = True
        Me.RemarkTxt.Name = "RemarkTxt"
        Me.RemarkTxt.Size = New System.Drawing.Size(319, 105)
        Me.RemarkTxt.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cancellation Remark"
        '
        '_003_05_Cancel_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 588)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_003_05_Cancel_Transaction"
        Me.Text = "Cancel Paid Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TransactionIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ResultCountLabel As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CustomerNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VehicleTypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LicenseTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents VehicleModelTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VehicleBrandTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VehicleColorTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CreatedTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AdminTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TrItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrItemPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrItemQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrItemDiscount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrItemSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RemarkTxt As System.Windows.Forms.TextBox
End Class
