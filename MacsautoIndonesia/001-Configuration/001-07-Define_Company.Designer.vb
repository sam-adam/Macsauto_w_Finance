<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_07_Define_Company
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_07_Define_Company))
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompanyStreetTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CompanyWebsiteTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CompanyCodeTxt = New System.Windows.Forms.TextBox()
        Me.CompanyPhone2Txt = New System.Windows.Forms.TextBox()
        Me.CompanyNameTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CompanyAddressTxt = New System.Windows.Forms.TextBox()
        Me.CompanyPhone1Txt = New System.Windows.Forms.TextBox()
        Me.CompanyCityTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.BackgroundImage = CType(resources.GetObject("Cancel.BackgroundImage"), System.Drawing.Image)
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cancel.Location = New System.Drawing.Point(237, 296)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(83, 42)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.BackgroundImage = CType(resources.GetObject("Add.BackgroundImage"), System.Drawing.Image)
        Me.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add.Location = New System.Drawing.Point(328, 296)
        Me.Add.Margin = New System.Windows.Forms.Padding(4)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(83, 42)
        Me.Add.TabIndex = 9
        Me.Add.Text = "SAVE"
        Me.Add.UseVisualStyleBackColor = True
        Me.Add.Visible = False
        '
        'Edit
        '
        Me.Edit.BackgroundImage = CType(resources.GetObject("Edit.BackgroundImage"), System.Drawing.Image)
        Me.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Edit.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Edit.Location = New System.Drawing.Point(328, 296)
        Me.Edit.Margin = New System.Windows.Forms.Padding(4)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(83, 42)
        Me.Edit.TabIndex = 29
        Me.Edit.Text = "EDIT"
        Me.Edit.UseVisualStyleBackColor = True
        Me.Edit.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Company Code"
        '
        'CompanyStreetTxt
        '
        Me.CompanyStreetTxt.Location = New System.Drawing.Point(125, 127)
        Me.CompanyStreetTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyStreetTxt.MaxLength = 200
        Me.CompanyStreetTxt.Multiline = True
        Me.CompanyStreetTxt.Name = "CompanyStreetTxt"
        Me.CompanyStreetTxt.Size = New System.Drawing.Size(286, 46)
        Me.CompanyStreetTxt.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Company Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Street"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Address"
        '
        'CompanyWebsiteTxt
        '
        Me.CompanyWebsiteTxt.Location = New System.Drawing.Point(125, 266)
        Me.CompanyWebsiteTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyWebsiteTxt.MaxLength = 50
        Me.CompanyWebsiteTxt.Name = "CompanyWebsiteTxt"
        Me.CompanyWebsiteTxt.Size = New System.Drawing.Size(224, 23)
        Me.CompanyWebsiteTxt.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 269)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Website"
        '
        'CompanyCodeTxt
        '
        Me.CompanyCodeTxt.Location = New System.Drawing.Point(125, 12)
        Me.CompanyCodeTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyCodeTxt.MaxLength = 3
        Me.CompanyCodeTxt.Name = "CompanyCodeTxt"
        Me.CompanyCodeTxt.Size = New System.Drawing.Size(113, 23)
        Me.CompanyCodeTxt.TabIndex = 39
        '
        'CompanyPhone2Txt
        '
        Me.CompanyPhone2Txt.Location = New System.Drawing.Point(125, 237)
        Me.CompanyPhone2Txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyPhone2Txt.MaxLength = 50
        Me.CompanyPhone2Txt.Name = "CompanyPhone2Txt"
        Me.CompanyPhone2Txt.Size = New System.Drawing.Size(224, 23)
        Me.CompanyPhone2Txt.TabIndex = 47
        '
        'CompanyNameTxt
        '
        Me.CompanyNameTxt.Location = New System.Drawing.Point(125, 41)
        Me.CompanyNameTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyNameTxt.MaxLength = 50
        Me.CompanyNameTxt.Name = "CompanyNameTxt"
        Me.CompanyNameTxt.Size = New System.Drawing.Size(286, 23)
        Me.CompanyNameTxt.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 240)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Hotline"
        '
        'CompanyAddressTxt
        '
        Me.CompanyAddressTxt.Location = New System.Drawing.Point(125, 70)
        Me.CompanyAddressTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyAddressTxt.MaxLength = 200
        Me.CompanyAddressTxt.Multiline = True
        Me.CompanyAddressTxt.Name = "CompanyAddressTxt"
        Me.CompanyAddressTxt.Size = New System.Drawing.Size(286, 51)
        Me.CompanyAddressTxt.TabIndex = 43
        '
        'CompanyPhone1Txt
        '
        Me.CompanyPhone1Txt.Location = New System.Drawing.Point(125, 208)
        Me.CompanyPhone1Txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyPhone1Txt.MaxLength = 50
        Me.CompanyPhone1Txt.Name = "CompanyPhone1Txt"
        Me.CompanyPhone1Txt.Size = New System.Drawing.Size(224, 23)
        Me.CompanyPhone1Txt.TabIndex = 46
        '
        'CompanyCityTxt
        '
        Me.CompanyCityTxt.Location = New System.Drawing.Point(125, 179)
        Me.CompanyCityTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CompanyCityTxt.MaxLength = 50
        Me.CompanyCityTxt.Name = "CompanyCityTxt"
        Me.CompanyCityTxt.Size = New System.Drawing.Size(224, 23)
        Me.CompanyCityTxt.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 211)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Phone"
        '
        '_001_07_Define_Company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(424, 350)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyStreetTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CompanyWebsiteTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CompanyCodeTxt)
        Me.Controls.Add(Me.CompanyPhone2Txt)
        Me.Controls.Add(Me.CompanyNameTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CompanyAddressTxt)
        Me.Controls.Add(Me.CompanyPhone1Txt)
        Me.Controls.Add(Me.CompanyCityTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Edit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_07_Define_Company"
        Me.Text = "Company - Define"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CompanyStreetTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CompanyWebsiteTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CompanyCodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents CompanyPhone2Txt As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CompanyAddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents CompanyPhone1Txt As System.Windows.Forms.TextBox
    Friend WithEvents CompanyCityTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
