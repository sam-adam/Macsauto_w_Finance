﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_05_Define_Product_type
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_05_Define_Product_type))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PTypeGridView = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ProductTypeIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTypeDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTypeIsMerchandiseCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductTypeIsConsumablesCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NewProductTypeCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PTypeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.PTypeGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSave)
        Me.SplitContainer1.Size = New System.Drawing.Size(518, 420)
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.TabIndex = 3
        '
        'PTypeGridView
        '
        Me.PTypeGridView.AllowUserToDeleteRows = False
        Me.PTypeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PTypeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PTypeGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PTypeGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductTypeIdCol, Me.ProductTypeDescriptionCol, Me.ProductTypeIsMerchandiseCol, Me.ProductTypeIsConsumablesCol, Me.NewProductTypeCol})
        Me.PTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PTypeGridView.Location = New System.Drawing.Point(0, 0)
        Me.PTypeGridView.Name = "PTypeGridView"
        Me.PTypeGridView.Size = New System.Drawing.Size(518, 364)
        Me.PTypeGridView.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(326, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 50)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ProductTypeIdCol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductTypeIdCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.ProductTypeIdCol.HeaderText = "Product Type #"
        Me.ProductTypeIdCol.Name = "ProductTypeIdCol"
        Me.ProductTypeIdCol.ReadOnly = True
        Me.ProductTypeIdCol.Visible = False
        Me.ProductTypeIdCol.Width = 120
        '
        'ProductTypeDescriptionCol
        '
        Me.ProductTypeDescriptionCol.HeaderText = "Product Type Description"
        Me.ProductTypeDescriptionCol.MaxInputLength = 50
        Me.ProductTypeDescriptionCol.Name = "ProductTypeDescriptionCol"
        Me.ProductTypeDescriptionCol.Width = 172
        '
        'ProductTypeIsMerchandiseCol
        '
        Me.ProductTypeIsMerchandiseCol.HeaderText = "Is Merchandise?"
        Me.ProductTypeIsMerchandiseCol.Name = "ProductTypeIsMerchandiseCol"
        '
        'ProductTypeIsConsumablesCol
        '
        Me.ProductTypeIsConsumablesCol.HeaderText = "Is Consumables?"
        Me.ProductTypeIsConsumablesCol.Name = "ProductTypeIsConsumablesCol"
        Me.ProductTypeIsConsumablesCol.Width = 102
        '
        'NewProductTypeCol
        '
        Me.NewProductTypeCol.HeaderText = "NewProductType"
        Me.NewProductTypeCol.Name = "NewProductTypeCol"
        Me.NewProductTypeCol.ReadOnly = True
        Me.NewProductTypeCol.Visible = False
        '
        '_001_05_Define_Product_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(518, 420)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_001_05_Define_Product_type"
        Me.Text = "Define Product Type"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PTypeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PTypeGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ProductTypeIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductTypeDescriptionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductTypeIsMerchandiseCol As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProductTypeIsConsumablesCol As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NewProductTypeCol As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
