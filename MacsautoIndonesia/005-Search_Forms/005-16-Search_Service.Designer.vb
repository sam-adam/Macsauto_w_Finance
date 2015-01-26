<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _005_16_Search_Service
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServiceDataGrid = New System.Windows.Forms.DataGridView()
        Me.ServiceIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTypeDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicePriceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ServiceDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Controls.Add(Me.SelectBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 346)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(842, 40)
        Me.Panel2.TabIndex = 2
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(674, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 30)
        Me.CancelBtn.TabIndex = 3
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SelectBtn
        '
        Me.SelectBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectBtn.Location = New System.Drawing.Point(755, 4)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(75, 30)
        Me.SelectBtn.TabIndex = 2
        Me.SelectBtn.Text = "Select"
        Me.SelectBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RefreshBtn)
        Me.Panel1.Controls.Add(Me.SearchTxt)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 50)
        Me.Panel1.TabIndex = 3
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(319, 9)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(75, 30)
        Me.RefreshBtn.TabIndex = 3
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(114, 13)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(199, 23)
        Me.SearchTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Name"
        '
        'ServiceDataGrid
        '
        Me.ServiceDataGrid.AllowUserToAddRows = False
        Me.ServiceDataGrid.AllowUserToDeleteRows = False
        Me.ServiceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiceDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceIdCol, Me.ServiceDescriptionCol, Me.ServiceTypeIdCol, Me.ServiceTypeDescriptionCol, Me.ServicePriceCol})
        Me.ServiceDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceDataGrid.Location = New System.Drawing.Point(0, 50)
        Me.ServiceDataGrid.Name = "ServiceDataGrid"
        Me.ServiceDataGrid.ReadOnly = True
        Me.ServiceDataGrid.RowHeadersVisible = False
        Me.ServiceDataGrid.Size = New System.Drawing.Size(842, 296)
        Me.ServiceDataGrid.TabIndex = 4
        '
        'ServiceIdCol
        '
        Me.ServiceIdCol.HeaderText = "ServiceId"
        Me.ServiceIdCol.Name = "ServiceIdCol"
        Me.ServiceIdCol.ReadOnly = True
        Me.ServiceIdCol.Visible = False
        Me.ServiceIdCol.Width = 72
        '
        'ServiceDescriptionCol
        '
        Me.ServiceDescriptionCol.HeaderText = "Service"
        Me.ServiceDescriptionCol.Name = "ServiceDescriptionCol"
        Me.ServiceDescriptionCol.ReadOnly = True
        Me.ServiceDescriptionCol.Width = 80
        '
        'ServiceTypeIdCol
        '
        Me.ServiceTypeIdCol.HeaderText = "Service Type"
        Me.ServiceTypeIdCol.Name = "ServiceTypeIdCol"
        Me.ServiceTypeIdCol.ReadOnly = True
        Me.ServiceTypeIdCol.Visible = False
        Me.ServiceTypeIdCol.Width = 116
        '
        'ServiceTypeDescriptionCol
        '
        Me.ServiceTypeDescriptionCol.HeaderText = "Type"
        Me.ServiceTypeDescriptionCol.Name = "ServiceTypeDescriptionCol"
        Me.ServiceTypeDescriptionCol.ReadOnly = True
        Me.ServiceTypeDescriptionCol.Width = 65
        '
        'ServicePriceCol
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N0"
        Me.ServicePriceCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.ServicePriceCol.HeaderText = "Price"
        Me.ServicePriceCol.Name = "ServicePriceCol"
        Me.ServicePriceCol.ReadOnly = True
        Me.ServicePriceCol.Width = 65
        '
        '_005_16_Search_Service
        '
        Me.AcceptButton = Me.SelectBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 386)
        Me.Controls.Add(Me.ServiceDataGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "_005_16_Search_Service"
        Me.Text = "Service - Search"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ServiceDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SelectBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents SearchTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ServiceDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceDescriptionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceTypeDescriptionCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicePriceCol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
