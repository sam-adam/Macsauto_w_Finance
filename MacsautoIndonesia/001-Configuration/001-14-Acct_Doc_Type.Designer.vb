﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _001_14_Acct_Doc_Type
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_001_14_Acct_Doc_Type))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ActGridView = New System.Windows.Forms.DataGridView()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.AccountDocTypeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDocTypeDescCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewAccountDocumentCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(412, 322)
        Me.SplitContainer1.SplitterDistance = 272
        Me.SplitContainer1.TabIndex = 4
        '
        'ActGridView
        '
        Me.ActGridView.AllowUserToDeleteRows = False
        Me.ActGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ActGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountDocTypeCol, Me.AccountDocTypeDescCol, Me.NewAccountDocumentCol})
        Me.ActGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActGridView.Location = New System.Drawing.Point(0, 0)
        Me.ActGridView.Name = "ActGridView"
        Me.ActGridView.Size = New System.Drawing.Size(412, 272)
        Me.ActGridView.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(3, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 39)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'AccountDocTypeCol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AccountDocTypeCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.AccountDocTypeCol.FillWeight = 120.0!
        Me.AccountDocTypeCol.HeaderText = "Act. Doc Type"
        Me.AccountDocTypeCol.MaxInputLength = 2
        Me.AccountDocTypeCol.Name = "AccountDocTypeCol"
        Me.AccountDocTypeCol.Width = 80
        '
        'AccountDocTypeDescCol
        '
        Me.AccountDocTypeDescCol.HeaderText = "Act. Doc. Type Desc."
        Me.AccountDocTypeDescCol.MaxInputLength = 50
        Me.AccountDocTypeDescCol.Name = "AccountDocTypeDescCol"
        Me.AccountDocTypeDescCol.Width = 160
        '
        'NewAccountDocumentCol
        '
        Me.NewAccountDocumentCol.HeaderText = "New Account Document"
        Me.NewAccountDocumentCol.Name = "NewAccountDocumentCol"
        Me.NewAccountDocumentCol.ReadOnly = True
        Me.NewAccountDocumentCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NewAccountDocumentCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NewAccountDocumentCol.Visible = False
        '
        '_001_14_Acct_Doc_Type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 322)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "_001_14_Acct_Doc_Type"
        Me.Text = "Accounting Document - Define"
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
    Friend WithEvents AccountDocTypeCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountDocTypeDescCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAccountDocumentCol As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
