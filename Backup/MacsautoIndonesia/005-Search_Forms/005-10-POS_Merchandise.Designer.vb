<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_10_POS_Merchandise
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
        Me.SProductGrid = New System.Windows.Forms.DataGridView()
        CType(Me.SProductGrid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SProductGrid
        '
        Me.SProductGrid.AllowUserToAddRows = false
        Me.SProductGrid.AllowUserToDeleteRows = false
        Me.SProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SProductGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SProductGrid.Location = New System.Drawing.Point(0, 0)
        Me.SProductGrid.Name = "SProductGrid"
        Me.SProductGrid.ReadOnly = true
        Me.SProductGrid.Size = New System.Drawing.Size(507, 389)
        Me.SProductGrid.TabIndex = 2
        '
        '_005_10_POS_Merchandise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 389)
        Me.Controls.Add(Me.SProductGrid)
        Me.Name = "_005_10_POS_Merchandise"
        Me.Text = "_005_10_POS_Merchandise"
        CType(Me.SProductGrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SProductGrid As System.Windows.Forms.DataGridView
End Class
