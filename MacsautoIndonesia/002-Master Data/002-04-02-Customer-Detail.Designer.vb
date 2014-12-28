<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _002_04_01_Customer_Detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_002_04_01_Customer_Detail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.vBrand = New System.Windows.Forms.ComboBox()
        Me.vType = New System.Windows.Forms.ComboBox()
        Me.LicensePlate = New System.Windows.Forms.TextBox()
        Me.Expdate = New System.Windows.Forms.DateTimePicker()
        Me.vYear = New System.Windows.Forms.TextBox()
        Me.vKilo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.vColor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblVehicleSize = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vehicle Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "License Plate Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "License Expired"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Vehicle Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "KM. Reached"
        '
        'vBrand
        '
        Me.vBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vBrand.FormattingEnabled = True
        Me.vBrand.Location = New System.Drawing.Point(157, 67)
        Me.vBrand.Name = "vBrand"
        Me.vBrand.Size = New System.Drawing.Size(230, 24)
        Me.vBrand.TabIndex = 6
        '
        'vType
        '
        Me.vType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vType.FormattingEnabled = True
        Me.vType.Location = New System.Drawing.Point(157, 97)
        Me.vType.Name = "vType"
        Me.vType.Size = New System.Drawing.Size(230, 24)
        Me.vType.TabIndex = 7
        '
        'LicensePlate
        '
        Me.LicensePlate.Location = New System.Drawing.Point(157, 155)
        Me.LicensePlate.MaxLength = 15
        Me.LicensePlate.Name = "LicensePlate"
        Me.LicensePlate.Size = New System.Drawing.Size(151, 22)
        Me.LicensePlate.TabIndex = 9
        '
        'Expdate
        '
        Me.Expdate.Location = New System.Drawing.Point(157, 184)
        Me.Expdate.Name = "Expdate"
        Me.Expdate.Size = New System.Drawing.Size(200, 22)
        Me.Expdate.TabIndex = 10
        '
        'vYear
        '
        Me.vYear.Location = New System.Drawing.Point(157, 213)
        Me.vYear.MaxLength = 4
        Me.vYear.Name = "vYear"
        Me.vYear.Size = New System.Drawing.Size(100, 22)
        Me.vYear.TabIndex = 11
        Me.vYear.Text = "0"
        '
        'vKilo
        '
        Me.vKilo.Location = New System.Drawing.Point(157, 242)
        Me.vKilo.MaxLength = 9
        Me.vKilo.Name = "vKilo"
        Me.vKilo.Size = New System.Drawing.Size(100, 22)
        Me.vKilo.TabIndex = 12
        Me.vKilo.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Kilometers"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(302, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 44)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(395, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 44)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(22, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 20)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CAR"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(105, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(103, 20)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "MOTORCYCLE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'vColor
        '
        Me.vColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vColor.FormattingEnabled = True
        Me.vColor.Location = New System.Drawing.Point(157, 127)
        Me.vColor.Name = "vColor"
        Me.vColor.Size = New System.Drawing.Size(230, 24)
        Me.vColor.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Vehicle Color"
        '
        'LblVehicleSize
        '
        Me.LblVehicleSize.AutoSize = True
        Me.LblVehicleSize.Location = New System.Drawing.Point(393, 100)
        Me.LblVehicleSize.Name = "LblVehicleSize"
        Me.LblVehicleSize.Size = New System.Drawing.Size(80, 16)
        Me.LblVehicleSize.TabIndex = 18
        Me.LblVehicleSize.Text = "[Vehicle Size]"
        '
        '_002_04_01_Customer_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(485, 272)
        Me.Controls.Add(Me.LblVehicleSize)
        Me.Controls.Add(Me.vColor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.vKilo)
        Me.Controls.Add(Me.vYear)
        Me.Controls.Add(Me.Expdate)
        Me.Controls.Add(Me.LicensePlate)
        Me.Controls.Add(Me.vType)
        Me.Controls.Add(Me.vBrand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_002_04_01_Customer_Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Customer Vehicle Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents vBrand As System.Windows.Forms.ComboBox
    Friend WithEvents vType As System.Windows.Forms.ComboBox
    Friend WithEvents LicensePlate As System.Windows.Forms.TextBox
    Friend WithEvents Expdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents vYear As System.Windows.Forms.TextBox
    Friend WithEvents vKilo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents vColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblVehicleSize As System.Windows.Forms.Label
End Class
