<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _003_06_Print_Transaction
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
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.TransactionIdTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerNameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IsMemberChk = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerPhoneTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerCellphoneTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VehicleRegLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VehicleSizeTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VehicleColorTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VehicleModelTxt = New System.Windows.Forms.TextBox()
        Me.MotorRadio = New System.Windows.Forms.RadioButton()
        Me.CarRadio = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VehicleBrandTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTxt = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PrintBtn)
        Me.Panel1.Controls.Add(Me.TransactionIdTxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 50)
        Me.Panel1.TabIndex = 0
        '
        'PrintBtn
        '
        Me.PrintBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintBtn.Enabled = False
        Me.PrintBtn.Location = New System.Drawing.Point(748, 8)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(75, 30)
        Me.PrintBtn.TabIndex = 2
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
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
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.Location = New System.Drawing.Point(126, 56)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.ReadOnly = True
        Me.CustomerNameTxt.Size = New System.Drawing.Size(250, 23)
        Me.CustomerNameTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer"
        '
        'IsMemberChk
        '
        Me.IsMemberChk.AutoSize = True
        Me.IsMemberChk.Enabled = False
        Me.IsMemberChk.Location = New System.Drawing.Point(126, 143)
        Me.IsMemberChk.Name = "IsMemberChk"
        Me.IsMemberChk.Size = New System.Drawing.Size(78, 21)
        Me.IsMemberChk.TabIndex = 3
        Me.IsMemberChk.Text = "Member"
        Me.IsMemberChk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phone"
        '
        'CustomerPhoneTxt
        '
        Me.CustomerPhoneTxt.Location = New System.Drawing.Point(126, 114)
        Me.CustomerPhoneTxt.Name = "CustomerPhoneTxt"
        Me.CustomerPhoneTxt.ReadOnly = True
        Me.CustomerPhoneTxt.Size = New System.Drawing.Size(160, 23)
        Me.CustomerPhoneTxt.TabIndex = 4
        Me.CustomerPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cellphone"
        '
        'CustomerCellphoneTxt
        '
        Me.CustomerCellphoneTxt.Location = New System.Drawing.Point(369, 114)
        Me.CustomerCellphoneTxt.Name = "CustomerCellphoneTxt"
        Me.CustomerCellphoneTxt.ReadOnly = True
        Me.CustomerCellphoneTxt.Size = New System.Drawing.Size(160, 23)
        Me.CustomerCellphoneTxt.TabIndex = 6
        Me.CustomerCellphoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VehicleRegLbl)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.VehicleSizeTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.VehicleColorTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.VehicleModelTxt)
        Me.GroupBox1.Controls.Add(Me.MotorRadio)
        Me.GroupBox1.Controls.Add(Me.CarRadio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.VehicleBrandTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 153)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle Data"
        '
        'VehicleRegLbl
        '
        Me.VehicleRegLbl.AutoSize = True
        Me.VehicleRegLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.VehicleRegLbl.ForeColor = System.Drawing.Color.Black
        Me.VehicleRegLbl.Location = New System.Drawing.Point(59, 32)
        Me.VehicleRegLbl.Name = "VehicleRegLbl"
        Me.VehicleRegLbl.Size = New System.Drawing.Size(0, 24)
        Me.VehicleRegLbl.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(228, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Size"
        '
        'VehicleSizeTxt
        '
        Me.VehicleSizeTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleSizeTxt.Location = New System.Drawing.Point(269, 117)
        Me.VehicleSizeTxt.Name = "VehicleSizeTxt"
        Me.VehicleSizeTxt.ReadOnly = True
        Me.VehicleSizeTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleSizeTxt.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Color"
        '
        'VehicleColorTxt
        '
        Me.VehicleColorTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleColorTxt.Location = New System.Drawing.Point(63, 117)
        Me.VehicleColorTxt.Name = "VehicleColorTxt"
        Me.VehicleColorTxt.ReadOnly = True
        Me.VehicleColorTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleColorTxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(217, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Model"
        '
        'VehicleModelTxt
        '
        Me.VehicleModelTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleModelTxt.Location = New System.Drawing.Point(269, 88)
        Me.VehicleModelTxt.Name = "VehicleModelTxt"
        Me.VehicleModelTxt.ReadOnly = True
        Me.VehicleModelTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleModelTxt.TabIndex = 7
        '
        'MotorRadio
        '
        Me.MotorRadio.AutoSize = True
        Me.MotorRadio.Enabled = False
        Me.MotorRadio.ForeColor = System.Drawing.Color.Black
        Me.MotorRadio.Location = New System.Drawing.Point(117, 60)
        Me.MotorRadio.Name = "MotorRadio"
        Me.MotorRadio.Size = New System.Drawing.Size(94, 21)
        Me.MotorRadio.TabIndex = 6
        Me.MotorRadio.TabStop = True
        Me.MotorRadio.Text = "Motorcycle"
        Me.MotorRadio.UseVisualStyleBackColor = True
        '
        'CarRadio
        '
        Me.CarRadio.AutoSize = True
        Me.CarRadio.Enabled = False
        Me.CarRadio.ForeColor = System.Drawing.Color.Black
        Me.CarRadio.Location = New System.Drawing.Point(63, 60)
        Me.CarRadio.Name = "CarRadio"
        Me.CarRadio.Size = New System.Drawing.Size(48, 21)
        Me.CarRadio.TabIndex = 5
        Me.CarRadio.TabStop = True
        Me.CarRadio.Text = "Car"
        Me.CarRadio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Brand"
        '
        'VehicleBrandTxt
        '
        Me.VehicleBrandTxt.ForeColor = System.Drawing.Color.Black
        Me.VehicleBrandTxt.Location = New System.Drawing.Point(63, 88)
        Me.VehicleBrandTxt.Name = "VehicleBrandTxt"
        Me.VehicleBrandTxt.ReadOnly = True
        Me.VehicleBrandTxt.Size = New System.Drawing.Size(148, 23)
        Me.VehicleBrandTxt.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Date"
        '
        'DateTxt
        '
        Me.DateTxt.Location = New System.Drawing.Point(126, 85)
        Me.DateTxt.Name = "DateTxt"
        Me.DateTxt.ReadOnly = True
        Me.DateTxt.Size = New System.Drawing.Size(250, 23)
        Me.DateTxt.TabIndex = 9
        '
        '_003_06_Print_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 522)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTxt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CustomerCellphoneTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CustomerPhoneTxt)
        Me.Controls.Add(Me.IsMemberChk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CustomerNameTxt)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_003_06_Print_Transaction"
        Me.Text = "Transaction - Print"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TransactionIdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
    Friend WithEvents CustomerNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IsMemberChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustomerPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomerCellphoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MotorRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CarRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VehicleBrandTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VehicleModelTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents VehicleColorTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VehicleSizeTxt As System.Windows.Forms.TextBox
    Friend WithEvents VehicleRegLbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTxt As System.Windows.Forms.TextBox
End Class
