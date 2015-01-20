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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.IdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalServiceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalProductCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPaymentCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalChangeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBrandCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleModelCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleSizeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleColorCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCol, Me.DateCol, Me.StatusCol, Me.RegistrationNumberCol, Me.TotalServiceCol, Me.TotalProductCol, Me.TotalCostCol, Me.TotalPaymentCol, Me.TotalChangeCol, Me.EmployeeCol, Me.VehicleTypeCol, Me.VehicleBrandCol, Me.VehicleModelCol, Me.VehicleSizeCol, Me.VehicleColorCol, Me.RemarkCol})
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 54)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.Size = New System.Drawing.Size(1370, 499)
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
        Me.PanelTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1370, 54)
        Me.PanelTop.TabIndex = 1
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExport.Location = New System.Drawing.Point(1257, 8)
        Me.BtnExport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(100, 28)
        Me.BtnExport.TabIndex = 5
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "To"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(372, 10)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(265, 23)
        Me.DateTimePicker2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(63, 10)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 23)
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
        Me.PanelBottom.Location = New System.Drawing.Point(0, 553)
        Me.PanelBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1370, 98)
        Me.PanelBottom.TabIndex = 2
        '
        'TotalPaymentLabel
        '
        Me.TotalPaymentLabel.AutoSize = True
        Me.TotalPaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPaymentLabel.Location = New System.Drawing.Point(1103, 18)
        Me.TotalPaymentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalPaymentLabel.Name = "TotalPaymentLabel"
        Me.TotalPaymentLabel.Size = New System.Drawing.Size(190, 20)
        Me.TotalPaymentLabel.TabIndex = 10
        Me.TotalPaymentLabel.Text = "Total payment: Rp0,00"
        '
        'TotalCarLabel
        '
        Me.TotalCarLabel.AutoSize = True
        Me.TotalCarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCarLabel.Location = New System.Drawing.Point(217, 18)
        Me.TotalCarLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalCarLabel.Name = "TotalCarLabel"
        Me.TotalCarLabel.Size = New System.Drawing.Size(45, 20)
        Me.TotalCarLabel.TabIndex = 9
        Me.TotalCarLabel.Text = "XXX"
        '
        'TotalMotorcycleLabel
        '
        Me.TotalMotorcycleLabel.AutoSize = True
        Me.TotalMotorcycleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMotorcycleLabel.Location = New System.Drawing.Point(217, 55)
        Me.TotalMotorcycleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalMotorcycleLabel.Name = "TotalMotorcycleLabel"
        Me.TotalMotorcycleLabel.Size = New System.Drawing.Size(45, 20)
        Me.TotalMotorcycleLabel.TabIndex = 8
        Me.TotalMotorcycleLabel.Text = "XXX"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Motorcycle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Car:"
        '
        'IdCol
        '
        Me.IdCol.HeaderText = "Id"
        Me.IdCol.Name = "IdCol"
        Me.IdCol.ReadOnly = True
        '
        'DateCol
        '
        Me.DateCol.HeaderText = "Date"
        Me.DateCol.Name = "DateCol"
        Me.DateCol.ReadOnly = True
        '
        'StatusCol
        '
        Me.StatusCol.HeaderText = "Status"
        Me.StatusCol.Name = "StatusCol"
        Me.StatusCol.ReadOnly = True
        '
        'RegistrationNumberCol
        '
        Me.RegistrationNumberCol.HeaderText = "Registration Number"
        Me.RegistrationNumberCol.Name = "RegistrationNumberCol"
        Me.RegistrationNumberCol.ReadOnly = True
        '
        'TotalServiceCol
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TotalServiceCol.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalServiceCol.HeaderText = "Total Service"
        Me.TotalServiceCol.Name = "TotalServiceCol"
        Me.TotalServiceCol.ReadOnly = True
        '
        'TotalProductCol
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N0"
        Me.TotalProductCol.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalProductCol.HeaderText = "Total Product"
        Me.TotalProductCol.Name = "TotalProductCol"
        Me.TotalProductCol.ReadOnly = True
        '
        'TotalCostCol
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "N0"
        Me.TotalCostCol.DefaultCellStyle = DataGridViewCellStyle8
        Me.TotalCostCol.HeaderText = "Total Cost"
        Me.TotalCostCol.Name = "TotalCostCol"
        Me.TotalCostCol.ReadOnly = True
        '
        'TotalPaymentCol
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "N0"
        Me.TotalPaymentCol.DefaultCellStyle = DataGridViewCellStyle9
        Me.TotalPaymentCol.HeaderText = "Total Payment"
        Me.TotalPaymentCol.Name = "TotalPaymentCol"
        Me.TotalPaymentCol.ReadOnly = True
        '
        'TotalChangeCol
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "N0"
        Me.TotalChangeCol.DefaultCellStyle = DataGridViewCellStyle10
        Me.TotalChangeCol.HeaderText = "Total Change"
        Me.TotalChangeCol.Name = "TotalChangeCol"
        Me.TotalChangeCol.ReadOnly = True
        '
        'EmployeeCol
        '
        Me.EmployeeCol.HeaderText = "Employee"
        Me.EmployeeCol.Name = "EmployeeCol"
        Me.EmployeeCol.ReadOnly = True
        '
        'VehicleTypeCol
        '
        Me.VehicleTypeCol.HeaderText = "VehicleType"
        Me.VehicleTypeCol.Name = "VehicleTypeCol"
        Me.VehicleTypeCol.ReadOnly = True
        '
        'VehicleBrandCol
        '
        Me.VehicleBrandCol.HeaderText = "Vehicle Brand"
        Me.VehicleBrandCol.Name = "VehicleBrandCol"
        Me.VehicleBrandCol.ReadOnly = True
        '
        'VehicleModelCol
        '
        Me.VehicleModelCol.HeaderText = "Vehicle Model"
        Me.VehicleModelCol.Name = "VehicleModelCol"
        Me.VehicleModelCol.ReadOnly = True
        '
        'VehicleSizeCol
        '
        Me.VehicleSizeCol.HeaderText = "Size"
        Me.VehicleSizeCol.Name = "VehicleSizeCol"
        Me.VehicleSizeCol.ReadOnly = True
        '
        'VehicleColorCol
        '
        Me.VehicleColorCol.HeaderText = "Color"
        Me.VehicleColorCol.Name = "VehicleColorCol"
        Me.VehicleColorCol.ReadOnly = True
        '
        'RemarkCol
        '
        Me.RemarkCol.HeaderText = "Remark"
        Me.RemarkCol.Name = "RemarkCol"
        Me.RemarkCol.ReadOnly = True
        '
        '_008_06_BrutoReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 651)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents IdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalServiceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalProductCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPaymentCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalChangeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleBrandCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleModelCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleSizeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleColorCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
