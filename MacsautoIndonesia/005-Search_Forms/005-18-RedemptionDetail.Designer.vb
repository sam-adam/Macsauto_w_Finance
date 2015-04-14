<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_18_RedemptionDetail
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomerPointLeftTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerCurrentPointTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PointRequiredLbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerCellphoneTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerPhoneTxt = New System.Windows.Forms.TextBox()
        Me.IsMemberChk = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerNameTxt = New System.Windows.Forms.TextBox()
        Me.TransactionDetailDataGrid = New System.Windows.Forms.DataGridView()
        Me.MerchandiseIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseQuantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandiseUoMCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerchandisePointCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TransactionDetailDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer
        '
        Me.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer.Panel1.Controls.Add(Me.DateTxt)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer.Panel1.Controls.Add(Me.CustomerCellphoneTxt)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer.Panel1.Controls.Add(Me.CustomerPhoneTxt)
        Me.SplitContainer.Panel1.Controls.Add(Me.IsMemberChk)
        Me.SplitContainer.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer.Panel1.Controls.Add(Me.CustomerNameTxt)
        Me.SplitContainer.Panel1MinSize = 100
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.TransactionDetailDataGrid)
        Me.SplitContainer.Size = New System.Drawing.Size(867, 385)
        Me.SplitContainer.SplitterDistance = 150
        Me.SplitContainer.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CustomerPointLeftTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CustomerCurrentPointTxt)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.PointRequiredLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(424, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 125)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Point Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Point Left"
        '
        'CustomerPointLeftTxt
        '
        Me.CustomerPointLeftTxt.Location = New System.Drawing.Point(103, 87)
        Me.CustomerPointLeftTxt.Name = "CustomerPointLeftTxt"
        Me.CustomerPointLeftTxt.ReadOnly = True
        Me.CustomerPointLeftTxt.Size = New System.Drawing.Size(116, 23)
        Me.CustomerPointLeftTxt.TabIndex = 21
        Me.CustomerPointLeftTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Current Point"
        '
        'CustomerCurrentPointTxt
        '
        Me.CustomerCurrentPointTxt.Location = New System.Drawing.Point(103, 58)
        Me.CustomerCurrentPointTxt.Name = "CustomerCurrentPointTxt"
        Me.CustomerCurrentPointTxt.ReadOnly = True
        Me.CustomerCurrentPointTxt.Size = New System.Drawing.Size(116, 23)
        Me.CustomerCurrentPointTxt.TabIndex = 19
        Me.CustomerCurrentPointTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Point Required:"
        '
        'PointRequiredLbl
        '
        Me.PointRequiredLbl.AutoSize = True
        Me.PointRequiredLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.PointRequiredLbl.ForeColor = System.Drawing.Color.Black
        Me.PointRequiredLbl.Location = New System.Drawing.Point(162, 26)
        Me.PointRequiredLbl.Name = "PointRequiredLbl"
        Me.PointRequiredLbl.Size = New System.Drawing.Size(0, 24)
        Me.PointRequiredLbl.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Date"
        '
        'DateTxt
        '
        Me.DateTxt.Location = New System.Drawing.Point(126, 34)
        Me.DateTxt.Name = "DateTxt"
        Me.DateTxt.ReadOnly = True
        Me.DateTxt.Size = New System.Drawing.Size(250, 23)
        Me.DateTxt.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cellphone"
        '
        'CustomerCellphoneTxt
        '
        Me.CustomerCellphoneTxt.Location = New System.Drawing.Point(126, 92)
        Me.CustomerCellphoneTxt.Name = "CustomerCellphoneTxt"
        Me.CustomerCellphoneTxt.ReadOnly = True
        Me.CustomerCellphoneTxt.Size = New System.Drawing.Size(160, 23)
        Me.CustomerCellphoneTxt.TabIndex = 17
        Me.CustomerCellphoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Phone"
        '
        'CustomerPhoneTxt
        '
        Me.CustomerPhoneTxt.Location = New System.Drawing.Point(126, 63)
        Me.CustomerPhoneTxt.Name = "CustomerPhoneTxt"
        Me.CustomerPhoneTxt.ReadOnly = True
        Me.CustomerPhoneTxt.Size = New System.Drawing.Size(160, 23)
        Me.CustomerPhoneTxt.TabIndex = 15
        Me.CustomerPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IsMemberChk
        '
        Me.IsMemberChk.AutoSize = True
        Me.IsMemberChk.Enabled = False
        Me.IsMemberChk.Location = New System.Drawing.Point(292, 65)
        Me.IsMemberChk.Name = "IsMemberChk"
        Me.IsMemberChk.Size = New System.Drawing.Size(78, 21)
        Me.IsMemberChk.TabIndex = 14
        Me.IsMemberChk.Text = "Member"
        Me.IsMemberChk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer"
        '
        'CustomerNameTxt
        '
        Me.CustomerNameTxt.Location = New System.Drawing.Point(126, 5)
        Me.CustomerNameTxt.Name = "CustomerNameTxt"
        Me.CustomerNameTxt.ReadOnly = True
        Me.CustomerNameTxt.Size = New System.Drawing.Size(250, 23)
        Me.CustomerNameTxt.TabIndex = 12
        '
        'TransactionDetailDataGrid
        '
        Me.TransactionDetailDataGrid.AllowUserToAddRows = False
        Me.TransactionDetailDataGrid.AllowUserToDeleteRows = False
        Me.TransactionDetailDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TransactionDetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDetailDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MerchandiseIdCol, Me.MerchandiseNameCol, Me.MerchandiseQuantityCol, Me.MerchandiseUoMCol, Me.MerchandisePointCol})
        Me.TransactionDetailDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDetailDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.TransactionDetailDataGrid.Name = "TransactionDetailDataGrid"
        Me.TransactionDetailDataGrid.ReadOnly = True
        Me.TransactionDetailDataGrid.RowHeadersVisible = False
        Me.TransactionDetailDataGrid.Size = New System.Drawing.Size(863, 227)
        Me.TransactionDetailDataGrid.TabIndex = 1
        '
        'MerchandiseIdCol
        '
        Me.MerchandiseIdCol.HeaderText = "MerchandiseId"
        Me.MerchandiseIdCol.Name = "MerchandiseIdCol"
        Me.MerchandiseIdCol.ReadOnly = True
        Me.MerchandiseIdCol.Visible = False
        Me.MerchandiseIdCol.Width = 106
        '
        'MerchandiseNameCol
        '
        Me.MerchandiseNameCol.HeaderText = "Merchandise"
        Me.MerchandiseNameCol.Name = "MerchandiseNameCol"
        Me.MerchandiseNameCol.ReadOnly = True
        Me.MerchandiseNameCol.Width = 114
        '
        'MerchandiseQuantityCol
        '
        Me.MerchandiseQuantityCol.HeaderText = "Quantity"
        Me.MerchandiseQuantityCol.Name = "MerchandiseQuantityCol"
        Me.MerchandiseQuantityCol.ReadOnly = True
        Me.MerchandiseQuantityCol.Width = 86
        '
        'MerchandiseUoMCol
        '
        Me.MerchandiseUoMCol.HeaderText = "Measurement"
        Me.MerchandiseUoMCol.Name = "MerchandiseUoMCol"
        Me.MerchandiseUoMCol.ReadOnly = True
        Me.MerchandiseUoMCol.Width = 119
        '
        'MerchandisePointCol
        '
        Me.MerchandisePointCol.HeaderText = "Point"
        Me.MerchandisePointCol.Name = "MerchandisePointCol"
        Me.MerchandisePointCol.ReadOnly = True
        Me.MerchandisePointCol.Width = 65
        '
        '_005_18_RedemptionDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(867, 0)
        Me.Name = "_005_18_RedemptionDetail"
        Me.Size = New System.Drawing.Size(867, 385)
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel1.PerformLayout()
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TransactionDetailDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents DateTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomerCellphoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustomerPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents IsMemberChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomerNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents TransactionDetailDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PointRequiredLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CustomerPointLeftTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerCurrentPointTxt As System.Windows.Forms.TextBox
    Friend WithEvents MerchandiseIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseQuantityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandiseUoMCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerchandisePointCol As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
