<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _009_04_Display_Journal_Tr
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Type = New System.Windows.Forms.TextBox()
        Me.docdate = New System.Windows.Forms.TextBox()
        Me.pstdt = New System.Windows.Forms.TextBox()
        Me.refdoc = New System.Windows.Forms.TextBox()
        Me.remark = New System.Windows.Forms.TextBox()
        Me.detJour = New System.Windows.Forms.DataGridView()
        Me.Reversal = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CANREA = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.detJour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction ID "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Document Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Posting Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Reference Document "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Remark "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Document status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Document Type"
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(155, 12)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(177, 23)
        Me.ID.TabIndex = 7
        '
        'Type
        '
        Me.Type.Enabled = False
        Me.Type.Location = New System.Drawing.Point(154, 40)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(177, 23)
        Me.Type.TabIndex = 8
        '
        'docdate
        '
        Me.docdate.Enabled = False
        Me.docdate.Location = New System.Drawing.Point(154, 69)
        Me.docdate.Name = "docdate"
        Me.docdate.Size = New System.Drawing.Size(177, 23)
        Me.docdate.TabIndex = 9
        '
        'pstdt
        '
        Me.pstdt.Enabled = False
        Me.pstdt.Location = New System.Drawing.Point(154, 98)
        Me.pstdt.Name = "pstdt"
        Me.pstdt.Size = New System.Drawing.Size(177, 23)
        Me.pstdt.TabIndex = 10
        '
        'refdoc
        '
        Me.refdoc.Enabled = False
        Me.refdoc.Location = New System.Drawing.Point(154, 127)
        Me.refdoc.Name = "refdoc"
        Me.refdoc.Size = New System.Drawing.Size(177, 23)
        Me.refdoc.TabIndex = 11
        '
        'remark
        '
        Me.remark.Enabled = False
        Me.remark.Location = New System.Drawing.Point(154, 155)
        Me.remark.Multiline = True
        Me.remark.Name = "remark"
        Me.remark.Size = New System.Drawing.Size(177, 69)
        Me.remark.TabIndex = 12
        '
        'detJour
        '
        Me.detJour.AllowUserToAddRows = False
        Me.detJour.AllowUserToDeleteRows = False
        Me.detJour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detJour.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.detJour.Location = New System.Drawing.Point(355, 12)
        Me.detJour.Name = "detJour"
        Me.detJour.ReadOnly = True
        Me.detJour.Size = New System.Drawing.Size(552, 166)
        Me.detJour.TabIndex = 14
        '
        'Reversal
        '
        Me.Reversal.AutoSize = True
        Me.Reversal.Enabled = False
        Me.Reversal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reversal.Location = New System.Drawing.Point(155, 242)
        Me.Reversal.Name = "Reversal"
        Me.Reversal.Size = New System.Drawing.Size(75, 20)
        Me.Reversal.TabIndex = 16
        Me.Reversal.Text = "Reversal "
        Me.Reversal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(821, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 55)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Reverse Document"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(352, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cancellation Reason"
        '
        'CANREA
        '
        Me.CANREA.Location = New System.Drawing.Point(355, 209)
        Me.CANREA.Multiline = True
        Me.CANREA.Name = "CANREA"
        Me.CANREA.Size = New System.Drawing.Size(445, 69)
        Me.CANREA.TabIndex = 19
        '
        'Column1
        '
        Me.Column1.HeaderText = "GL Account"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle1.Format = "C2"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Db"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle2.Format = "C2"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Cr"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Notes"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        '_009_04_Display_Journal_Tr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 298)
        Me.Controls.Add(Me.CANREA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Reversal)
        Me.Controls.Add(Me.detJour)
        Me.Controls.Add(Me.remark)
        Me.Controls.Add(Me.refdoc)
        Me.Controls.Add(Me.pstdt)
        Me.Controls.Add(Me.docdate)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_009_04_Display_Journal_Tr"
        Me.Text = "Journal Detail"
        CType(Me.detJour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Type As System.Windows.Forms.TextBox
    Friend WithEvents docdate As System.Windows.Forms.TextBox
    Friend WithEvents pstdt As System.Windows.Forms.TextBox
    Friend WithEvents refdoc As System.Windows.Forms.TextBox
    Friend WithEvents remark As System.Windows.Forms.TextBox
    Friend WithEvents detJour As System.Windows.Forms.DataGridView
    Friend WithEvents Reversal As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CANREA As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
