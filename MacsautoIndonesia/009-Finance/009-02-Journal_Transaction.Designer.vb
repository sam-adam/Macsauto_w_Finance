<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _009_02_Journal_Transaction
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_009_02_Journal_Transaction))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PostingDate = New System.Windows.Forms.DateTimePicker()
        Me.JournalGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoc = New System.Windows.Forms.TextBox()
        Me.rmark = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalDb = New System.Windows.Forms.TextBox()
        Me.totalCr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DocType = New System.Windows.Forms.ComboBox()
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posting Date"
        '
        'PostingDate
        '
        Me.PostingDate.Location = New System.Drawing.Point(117, 12)
        Me.PostingDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.Size = New System.Drawing.Size(233, 22)
        Me.PostingDate.TabIndex = 1
        '
        'JournalGrid
        '
        Me.JournalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.JournalGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5})
        Me.JournalGrid.Location = New System.Drawing.Point(12, 199)
        Me.JournalGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JournalGrid.Name = "JournalGrid"
        Me.JournalGrid.Size = New System.Drawing.Size(640, 199)
        Me.JournalGrid.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "GL Act."
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column3
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "GL Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Posting Key"
        Me.Column2.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        DataGridViewCellStyle3.NullValue = " "
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Notes"
        Me.Column5.MaxInputLength = 255
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 255
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ref. Doc."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Remark"
        '
        'rdoc
        '
        Me.rdoc.Location = New System.Drawing.Point(103, 80)
        Me.rdoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoc.MaxLength = 20
        Me.rdoc.Name = "rdoc"
        Me.rdoc.Size = New System.Drawing.Size(233, 22)
        Me.rdoc.TabIndex = 5
        '
        'rmark
        '
        Me.rmark.Location = New System.Drawing.Point(345, 66)
        Me.rmark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rmark.MaxLength = 1000
        Me.rmark.Multiline = True
        Me.rmark.Name = "rmark"
        Me.rmark.Size = New System.Drawing.Size(307, 125)
        Me.rmark.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "total Db Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "total Cr Amount"
        '
        'totalDb
        '
        Me.totalDb.Enabled = False
        Me.totalDb.Location = New System.Drawing.Point(166, 23)
        Me.totalDb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.totalDb.Name = "totalDb"
        Me.totalDb.Size = New System.Drawing.Size(116, 22)
        Me.totalDb.TabIndex = 9
        '
        'totalCr
        '
        Me.totalCr.Enabled = False
        Me.totalCr.Location = New System.Drawing.Point(166, 49)
        Me.totalCr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.totalCr.Name = "totalCr"
        Me.totalCr.Size = New System.Drawing.Size(116, 22)
        Me.totalCr.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(12, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Press 'F4' button to search GL Account"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.totalDb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.totalCr)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 83)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Amount"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gold
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.PostingDate)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-15, -4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 43)
        Me.Panel3.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(484, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "JOURNAL ENTRY"
        '
        'Add
        '
        Me.Add.BackgroundImage = CType(resources.GetObject("Add.BackgroundImage"), System.Drawing.Image)
        Me.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add.Location = New System.Drawing.Point(559, 405)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(93, 48)
        Me.Add.TabIndex = 19
        Me.Add.Text = "Post Journal"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Act. Doc."
        '
        'DocType
        '
        Me.DocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DocType.FormattingEnabled = True
        Me.DocType.Location = New System.Drawing.Point(103, 48)
        Me.DocType.Name = "DocType"
        Me.DocType.Size = New System.Drawing.Size(233, 24)
        Me.DocType.TabIndex = 26
        '
        '_009_02_Journal_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(664, 459)
        Me.Controls.Add(Me.DocType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.rmark)
        Me.Controls.Add(Me.rdoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JournalGrid)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "_009_02_Journal_Transaction"
        Me.Text = "Journal Entry Transaction"
        CType(Me.JournalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents JournalGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdoc As System.Windows.Forms.TextBox
    Friend WithEvents rmark As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents totalDb As System.Windows.Forms.TextBox
    Friend WithEvents totalCr As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DocType As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
