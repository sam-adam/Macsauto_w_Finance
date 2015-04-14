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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.DateTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerCellphoneTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerPhoneTxt = New System.Windows.Forms.TextBox()
        Me.IsMemberChk = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerNameTxt = New System.Windows.Forms.TextBox()
        Me.TransactionDetailDataGrid = New System.Windows.Forms.DataGridView()
        Me.ItemTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemUoMCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDiscountCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemSubTotalCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRemarkcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
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
        Me.TransactionDetailDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemTypeCol, Me.ItemNameCol, Me.ItemUoMCol, Me.ItemPriceCol, Me.ItemQuantityCol, Me.ItemDiscountCol, Me.ItemSubTotalCol, Me.ItemRemarkcol})
        Me.TransactionDetailDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionDetailDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.TransactionDetailDataGrid.Name = "TransactionDetailDataGrid"
        Me.TransactionDetailDataGrid.ReadOnly = True
        Me.TransactionDetailDataGrid.RowHeadersVisible = False
        Me.TransactionDetailDataGrid.Size = New System.Drawing.Size(863, 227)
        Me.TransactionDetailDataGrid.TabIndex = 1
        '
        'ItemTypeCol
        '
        Me.ItemTypeCol.HeaderText = "Item Type"
        Me.ItemTypeCol.Name = "ItemTypeCol"
        Me.ItemTypeCol.ReadOnly = True
        Me.ItemTypeCol.Width = 95
        '
        'ItemNameCol
        '
        Me.ItemNameCol.HeaderText = "Name"
        Me.ItemNameCol.Name = "ItemNameCol"
        Me.ItemNameCol.ReadOnly = True
        Me.ItemNameCol.Width = 70
        '
        'ItemUoMCol
        '
        Me.ItemUoMCol.HeaderText = "Measurement"
        Me.ItemUoMCol.Name = "ItemUoMCol"
        Me.ItemUoMCol.ReadOnly = True
        Me.ItemUoMCol.Width = 119
        '
        'ItemPriceCol
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ItemPriceCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.ItemPriceCol.HeaderText = "Price"
        Me.ItemPriceCol.Name = "ItemPriceCol"
        Me.ItemPriceCol.ReadOnly = True
        Me.ItemPriceCol.Width = 65
        '
        'ItemQuantityCol
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ItemQuantityCol.DefaultCellStyle = DataGridViewCellStyle6
        Me.ItemQuantityCol.HeaderText = "Quantity"
        Me.ItemQuantityCol.Name = "ItemQuantityCol"
        Me.ItemQuantityCol.ReadOnly = True
        Me.ItemQuantityCol.Width = 86
        '
        'ItemDiscountCol
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        Me.ItemDiscountCol.DefaultCellStyle = DataGridViewCellStyle7
        Me.ItemDiscountCol.HeaderText = "Discount"
        Me.ItemDiscountCol.Name = "ItemDiscountCol"
        Me.ItemDiscountCol.ReadOnly = True
        Me.ItemDiscountCol.Width = 88
        '
        'ItemSubTotalCol
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ItemSubTotalCol.DefaultCellStyle = DataGridViewCellStyle8
        Me.ItemSubTotalCol.HeaderText = "SubTotal"
        Me.ItemSubTotalCol.Name = "ItemSubTotalCol"
        Me.ItemSubTotalCol.ReadOnly = True
        Me.ItemSubTotalCol.Width = 90
        '
        'ItemRemarkcol
        '
        Me.ItemRemarkcol.HeaderText = "Remark"
        Me.ItemRemarkcol.Name = "ItemRemarkcol"
        Me.ItemRemarkcol.ReadOnly = True
        Me.ItemRemarkcol.Width = 82
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
    Friend WithEvents ItemTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemUoMCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemPriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantityCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDiscountCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemSubTotalCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemRemarkcol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
