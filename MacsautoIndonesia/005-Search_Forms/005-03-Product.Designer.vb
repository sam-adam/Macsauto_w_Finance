<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_03_Product
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
        Me.productGrid = New System.Windows.Forms.DataGridView()
        CType(Me.productGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productGrid
        '
        Me.productGrid.AllowUserToAddRows = False
        Me.productGrid.AllowUserToDeleteRows = False
        Me.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productGrid.Location = New System.Drawing.Point(0, 0)
        Me.productGrid.Name = "productGrid"
        Me.productGrid.ReadOnly = True
        Me.productGrid.Size = New System.Drawing.Size(437, 349)
        Me.productGrid.TabIndex = 1
        '
        '_005_03_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 349)
        Me.Controls.Add(Me.productGrid)
        Me.Name = "_005_03_Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Product"
        CType(Me.productGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents productGrid As System.Windows.Forms.DataGridView
End Class
