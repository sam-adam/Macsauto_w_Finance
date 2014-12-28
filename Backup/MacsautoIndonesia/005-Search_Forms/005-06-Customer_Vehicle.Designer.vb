<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_06_Customer_Vehicle
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
        Me.CustomerVehicle = New System.Windows.Forms.DataGridView()
        CType(Me.CustomerVehicle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerVehicle
        '
        Me.CustomerVehicle.AllowUserToAddRows = False
        Me.CustomerVehicle.AllowUserToDeleteRows = False
        Me.CustomerVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerVehicle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerVehicle.Location = New System.Drawing.Point(0, 0)
        Me.CustomerVehicle.Name = "CustomerVehicle"
        Me.CustomerVehicle.ReadOnly = True
        Me.CustomerVehicle.Size = New System.Drawing.Size(667, 299)
        Me.CustomerVehicle.TabIndex = 0
        '
        '_005_06_Customer_Vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 299)
        Me.Controls.Add(Me.CustomerVehicle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "_005_06_Customer_Vehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Vehicle"
        CType(Me.CustomerVehicle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomerVehicle As System.Windows.Forms.DataGridView
End Class
