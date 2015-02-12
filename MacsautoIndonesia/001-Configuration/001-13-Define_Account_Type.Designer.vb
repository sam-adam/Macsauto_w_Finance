<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_13_Define_Account_Type
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_13_Define_Account_Type))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ActGridView = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.AccountTypeIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountTypeDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewAccountTypeCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ActGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ActGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSave)
        Me.SplitContainer1.Size = New System.Drawing.Size(384, 391)
        Me.SplitContainer1.SplitterDistance = 331
        Me.SplitContainer1.TabIndex = 3
        '
        'ActGridView
        '
        Me.ActGridView.AllowUserToDeleteRows = False
        Me.ActGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ActGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountTypeIdCol, Me.AccountTypeDescCol, Me.NewAccountTypeCol})
        Me.ActGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActGridView.Location = New System.Drawing.Point(0, 0)
        Me.ActGridView.Name = "ActGridView"
        Me.ActGridView.Size = New System.Drawing.Size(384, 331)
        Me.ActGridView.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(195, 10)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 39)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'AccountTypeIdCol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccountTypeIdCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.AccountTypeIdCol.FillWeight = 120.0!
        Me.AccountTypeIdCol.HeaderText = "Act. Type ID"
        Me.AccountTypeIdCol.Name = "AccountTypeIdCol"
        Me.AccountTypeIdCol.Visible = False
        Me.AccountTypeIdCol.Width = 80
        '
        'AccountTypeDescCol
        '
        Me.AccountTypeDescCol.HeaderText = "Act. Typ. Desc."
        Me.AccountTypeDescCol.MaxInputLength = 30
        Me.AccountTypeDescCol.Name = "AccountTypeDescCol"
        Me.AccountTypeDescCol.Width = 160
        '
        'NewAccountTypeCol
        '
        Me.NewAccountTypeCol.HeaderText = "New Account Type"
        Me.NewAccountTypeCol.Name = "NewAccountTypeCol"
        Me.NewAccountTypeCol.ReadOnly = True
        Me.NewAccountTypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NewAccountTypeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NewAccountTypeCol.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(195, 10)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 39)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        '_001_13_Define_Account_Type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 391)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "_001_13_Define_Account_Type"
        Me.Text = "Account Type - Define"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ActGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ActGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents AccountTypeIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountTypeDescCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAccountTypeCol As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
