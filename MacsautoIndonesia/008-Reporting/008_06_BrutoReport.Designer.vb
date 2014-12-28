<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _008_06_BrutoReport
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.TotalPaymentLabel = New System.Windows.Forms.Label()
        Me.TotalCarLabel = New System.Windows.Forms.Label()
        Me.TotalMotorcycleLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRegNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotalPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotalChange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVehicleType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVehicleBrand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVehicleModel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVehicleColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelTop.SuspendLayout
        Me.PanelBottom.SuspendLayout
        Me.SuspendLayout
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = false
        Me.DataGridView.AllowUserToDeleteRows = false
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColDate, Me.ColRegNumber, Me.ColTotalCost, Me.ColTotalPayment, Me.ColTotalChange, Me.ColEmployee, Me.ColVehicleType, Me.ColVehicleBrand, Me.ColVehicleModel, Me.Size, Me.ColVehicleColor})
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 50)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = true
        Me.DataGridView.Size = New System.Drawing.Size(1193, 399)
        Me.DataGridView.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.BtnExport)
        Me.PanelTop.Controls.Add(Me.Label2)
        Me.PanelTop.Controls.Add(Me.DateTimePicker2)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Controls.Add(Me.DateTimePicker1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1193, 50)
        Me.PanelTop.TabIndex = 1
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnExport.Location = New System.Drawing.Point(1106, 15)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(75, 23)
        Me.BtnExport.TabIndex = 5
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(254, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "To"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(280, 17)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(48, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.TotalPaymentLabel)
        Me.PanelBottom.Controls.Add(Me.TotalCarLabel)
        Me.PanelBottom.Controls.Add(Me.TotalMotorcycleLabel)
        Me.PanelBottom.Controls.Add(Me.Label4)
        Me.PanelBottom.Controls.Add(Me.Label3)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 449)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1193, 80)
        Me.PanelBottom.TabIndex = 2
        '
        'TotalPaymentLabel
        '
        Me.TotalPaymentLabel.AutoSize = true
        Me.TotalPaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalPaymentLabel.Location = New System.Drawing.Point(827, 15)
        Me.TotalPaymentLabel.Name = "TotalPaymentLabel"
        Me.TotalPaymentLabel.Size = New System.Drawing.Size(190, 20)
        Me.TotalPaymentLabel.TabIndex = 10
        Me.TotalPaymentLabel.Text = "Total payment: Rp0,00"
        '
        'TotalCarLabel
        '
        Me.TotalCarLabel.AutoSize = true
        Me.TotalCarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalCarLabel.Location = New System.Drawing.Point(163, 15)
        Me.TotalCarLabel.Name = "TotalCarLabel"
        Me.TotalCarLabel.Size = New System.Drawing.Size(45, 20)
        Me.TotalCarLabel.TabIndex = 9
        Me.TotalCarLabel.Text = "XXX"
        '
        'TotalMotorcycleLabel
        '
        Me.TotalMotorcycleLabel.AutoSize = true
        Me.TotalMotorcycleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TotalMotorcycleLabel.Location = New System.Drawing.Point(163, 45)
        Me.TotalMotorcycleLabel.Name = "TotalMotorcycleLabel"
        Me.TotalMotorcycleLabel.Size = New System.Drawing.Size(45, 20)
        Me.TotalMotorcycleLabel.TabIndex = 8
        Me.TotalMotorcycleLabel.Text = "XXX"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Motorcycle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Car:"
        '
        'ColId
        '
        Me.ColId.HeaderText = "Id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = true
        '
        'ColDate
        '
        Me.ColDate.HeaderText = "Date"
        Me.ColDate.Name = "ColDate"
        Me.ColDate.ReadOnly = true
        '
        'ColRegNumber
        '
        Me.ColRegNumber.HeaderText = "Registration Number"
        Me.ColRegNumber.Name = "ColRegNumber"
        Me.ColRegNumber.ReadOnly = true
        '
        'ColTotalCost
        '
        Me.ColTotalCost.HeaderText = "Total Cost"
        Me.ColTotalCost.Name = "ColTotalCost"
        Me.ColTotalCost.ReadOnly = true
        '
        'ColTotalPayment
        '
        Me.ColTotalPayment.HeaderText = "Total Payment"
        Me.ColTotalPayment.Name = "ColTotalPayment"
        Me.ColTotalPayment.ReadOnly = true
        '
        'ColTotalChange
        '
        Me.ColTotalChange.HeaderText = "Total Change"
        Me.ColTotalChange.Name = "ColTotalChange"
        Me.ColTotalChange.ReadOnly = true
        '
        'ColEmployee
        '
        Me.ColEmployee.HeaderText = "Employee"
        Me.ColEmployee.Name = "ColEmployee"
        Me.ColEmployee.ReadOnly = true
        '
        'ColVehicleType
        '
        Me.ColVehicleType.HeaderText = "VehicleType"
        Me.ColVehicleType.Name = "ColVehicleType"
        Me.ColVehicleType.ReadOnly = true
        '
        'ColVehicleBrand
        '
        Me.ColVehicleBrand.HeaderText = "Vehicle Brand"
        Me.ColVehicleBrand.Name = "ColVehicleBrand"
        Me.ColVehicleBrand.ReadOnly = true
        '
        'ColVehicleModel
        '
        Me.ColVehicleModel.HeaderText = "Vehicle Model"
        Me.ColVehicleModel.Name = "ColVehicleModel"
        Me.ColVehicleModel.ReadOnly = true
        '
        'Size
        '
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = true
        '
        'ColVehicleColor
        '
        Me.ColVehicleColor.HeaderText = "Color"
        Me.ColVehicleColor.Name = "ColVehicleColor"
        Me.ColVehicleColor.ReadOnly = true
        '
        '_008_06_BrutoReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 529)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "_008_06_BrutoReport"
        Me.Text = "Report - Bruto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelTop.ResumeLayout(false)
        Me.PanelTop.PerformLayout
        Me.PanelBottom.ResumeLayout(false)
        Me.PanelBottom.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalCarLabel As System.Windows.Forms.Label
    Friend WithEvents TotalMotorcycleLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalPaymentLabel As System.Windows.Forms.Label
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRegNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTotalPayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTotalChange As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColEmployee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColVehicleType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColVehicleBrand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColVehicleModel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Size As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColVehicleColor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
