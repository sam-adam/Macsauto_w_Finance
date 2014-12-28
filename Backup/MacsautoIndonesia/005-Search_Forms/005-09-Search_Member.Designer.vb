<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_09_Search_Member
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
        Me.cName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerGrid = New System.Windows.Forms.DataGridView()
        CType(Me.CustomerGrid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cName
        '
        Me.cName.Location = New System.Drawing.Point(117, 11)
        Me.cName.Name = "cName"
        Me.cName.Size = New System.Drawing.Size(297, 22)
        Me.cName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer Name"
        '
        'CustomerGrid
        '
        Me.CustomerGrid.AllowUserToAddRows = false
        Me.CustomerGrid.AllowUserToDeleteRows = false
        Me.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerGrid.Location = New System.Drawing.Point(14, 40)
        Me.CustomerGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerGrid.Name = "CustomerGrid"
        Me.CustomerGrid.ReadOnly = true
        Me.CustomerGrid.Size = New System.Drawing.Size(528, 347)
        Me.CustomerGrid.TabIndex = 3
        '
        '_005_09_Search_Member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 398)
        Me.Controls.Add(Me.cName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerGrid)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_005_09_Search_Member"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Member"
        CType(Me.CustomerGrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerGrid As System.Windows.Forms.DataGridView
End Class
