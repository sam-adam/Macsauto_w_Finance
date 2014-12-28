<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_08_POS_Service
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
        Me.servSearchGrid = New System.Windows.Forms.DataGridView()
        CType(Me.servSearchGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'servSearchGrid
        '
        Me.servSearchGrid.AllowUserToAddRows = False
        Me.servSearchGrid.AllowUserToDeleteRows = False
        Me.servSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.servSearchGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.servSearchGrid.Location = New System.Drawing.Point(0, 0)
        Me.servSearchGrid.Name = "servSearchGrid"
        Me.servSearchGrid.ReadOnly = True
        Me.servSearchGrid.Size = New System.Drawing.Size(632, 397)
        Me.servSearchGrid.TabIndex = 0
        '
        '_005_08_POS_Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 397)
        Me.Controls.Add(Me.servSearchGrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "_005_08_POS_Service"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service List"
        CType(Me.servSearchGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents servSearchGrid As System.Windows.Forms.DataGridView
End Class
