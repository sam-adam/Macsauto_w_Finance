<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_09_Assign_PromotionToProdServ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_09_Assign_PromotionToProdServ))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProductRbtn = New System.Windows.Forms.RadioButton()
        Me.ServiceRbtn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pdtsvcbo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PromoCbo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Begda = New System.Windows.Forms.DateTimePicker()
        Me.endda = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.CheckBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Member = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PromoGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Edit = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        CType(Me.PromoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductRbtn
        '
        Me.ProductRbtn.AutoSize = True
        Me.ProductRbtn.Checked = True
        Me.ProductRbtn.Enabled = False
        Me.ProductRbtn.Location = New System.Drawing.Point(9, 9)
        Me.ProductRbtn.Name = "ProductRbtn"
        Me.ProductRbtn.Size = New System.Drawing.Size(74, 21)
        Me.ProductRbtn.TabIndex = 0
        Me.ProductRbtn.TabStop = True
        Me.ProductRbtn.Text = "Product"
        Me.ProductRbtn.UseVisualStyleBackColor = True
        '
        'ServiceRbtn
        '
        Me.ServiceRbtn.AutoSize = True
        Me.ServiceRbtn.Enabled = False
        Me.ServiceRbtn.Location = New System.Drawing.Point(106, 9)
        Me.ServiceRbtn.Name = "ServiceRbtn"
        Me.ServiceRbtn.Size = New System.Drawing.Size(69, 21)
        Me.ServiceRbtn.TabIndex = 1
        Me.ServiceRbtn.Text = "Service"
        Me.ServiceRbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product"
        '
        'pdtsvcbo
        '
        Me.pdtsvcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pdtsvcbo.Enabled = False
        Me.pdtsvcbo.FormattingEnabled = True
        Me.pdtsvcbo.Location = New System.Drawing.Point(144, 42)
        Me.pdtsvcbo.Name = "pdtsvcbo"
        Me.pdtsvcbo.Size = New System.Drawing.Size(255, 25)
        Me.pdtsvcbo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Promotion"
        '
        'PromoCbo
        '
        Me.PromoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PromoCbo.Enabled = False
        Me.PromoCbo.FormattingEnabled = True
        Me.PromoCbo.Location = New System.Drawing.Point(144, 77)
        Me.PromoCbo.Name = "PromoCbo"
        Me.PromoCbo.Size = New System.Drawing.Size(255, 25)
        Me.PromoCbo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Start date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "End date"
        '
        'Begda
        '
        Me.Begda.Enabled = False
        Me.Begda.Location = New System.Drawing.Point(144, 113)
        Me.Begda.Name = "Begda"
        Me.Begda.Size = New System.Drawing.Size(255, 23)
        Me.Begda.TabIndex = 8
        '
        'endda
        '
        Me.endda.Enabled = False
        Me.endda.Location = New System.Drawing.Point(144, 145)
        Me.endda.Name = "endda"
        Me.endda.Size = New System.Drawing.Size(255, 23)
        Me.endda.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(421, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Promotion Status"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Enabled = False
        Me.status.Location = New System.Drawing.Point(563, 44)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(65, 21)
        Me.status.TabIndex = 11
        Me.status.Text = "Active"
        Me.status.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.BackgroundImage = CType(resources.GetObject("Add.BackgroundImage"), System.Drawing.Image)
        Me.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add.Location = New System.Drawing.Point(457, 128)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(80, 40)
        Me.Add.TabIndex = 19
        Me.Add.Text = "ADD"
        Me.Add.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.BackgroundImage = CType(resources.GetObject("SaveBtn.BackgroundImage"), System.Drawing.Image)
        Me.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBtn.Location = New System.Drawing.Point(501, 128)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(80, 40)
        Me.SaveBtn.TabIndex = 22
        Me.SaveBtn.Text = "SAVE"
        Me.SaveBtn.UseVisualStyleBackColor = True
        Me.SaveBtn.Visible = False
        '
        'Member
        '
        Me.Member.AutoSize = True
        Me.Member.Enabled = False
        Me.Member.Location = New System.Drawing.Point(563, 76)
        Me.Member.Name = "Member"
        Me.Member.Size = New System.Drawing.Size(48, 21)
        Me.Member.TabIndex = 21
        Me.Member.Text = "Yes"
        Me.Member.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(421, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Applied for Member"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(61, 6)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 21)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Active"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 6)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 21)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "All"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PromoGrid
        '
        Me.PromoGrid.AllowUserToAddRows = False
        Me.PromoGrid.AllowUserToDeleteRows = False
        Me.PromoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PromoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.PromoGrid.Location = New System.Drawing.Point(13, 28)
        Me.PromoGrid.Name = "PromoGrid"
        Me.PromoGrid.ReadOnly = True
        Me.PromoGrid.Size = New System.Drawing.Size(901, 331)
        Me.PromoGrid.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Promotion Description"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Applied To"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Start Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "End date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Discount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Active"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "Applied to Member"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column8
        '
        Me.Column8.HeaderText = "iditm"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "idpmt"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "ptype"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.PromoGrid)
        Me.Panel1.Location = New System.Drawing.Point(12, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 376)
        Me.Panel1.TabIndex = 21
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(131, 6)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(81, 21)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "In-Active"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Edit)
        Me.Panel2.Controls.Add(Me.cancelBtn)
        Me.Panel2.Controls.Add(Me.deleteBtn)
        Me.Panel2.Controls.Add(Me.SaveBtn)
        Me.Panel2.Controls.Add(Me.ProductRbtn)
        Me.Panel2.Controls.Add(Me.Member)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.pdtsvcbo)
        Me.Panel2.Controls.Add(Me.PromoCbo)
        Me.Panel2.Controls.Add(Me.Add)
        Me.Panel2.Controls.Add(Me.Begda)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.status)
        Me.Panel2.Controls.Add(Me.endda)
        Me.Panel2.Controls.Add(Me.ServiceRbtn)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 196)
        Me.Panel2.TabIndex = 22
        '
        'Edit
        '
        Me.Edit.BackgroundImage = CType(resources.GetObject("Edit.BackgroundImage"), System.Drawing.Image)
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Edit.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Edit.Location = New System.Drawing.Point(548, 128)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(80, 40)
        Me.Edit.TabIndex = 25
        Me.Edit.Text = "MODIFY"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.BackgroundImage = CType(resources.GetObject("cancelBtn.BackgroundImage"), System.Drawing.Image)
        Me.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelBtn.Location = New System.Drawing.Point(587, 128)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(80, 40)
        Me.cancelBtn.TabIndex = 24
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = True
        Me.cancelBtn.Visible = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackgroundImage = CType(resources.GetObject("deleteBtn.BackgroundImage"), System.Drawing.Image)
        Me.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBtn.Location = New System.Drawing.Point(640, 128)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(80, 40)
        Me.deleteBtn.TabIndex = 23
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        '_001_09_Assign_PromotionToProdServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(945, 598)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_001_09_Assign_PromotionToProdServ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Promotion to Service or Product"
        CType(Me.PromoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProductRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents ServiceRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pdtsvcbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PromoCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Begda As System.Windows.Forms.DateTimePicker
    Friend WithEvents endda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.CheckBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PromoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Member As System.Windows.Forms.CheckBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
End Class
