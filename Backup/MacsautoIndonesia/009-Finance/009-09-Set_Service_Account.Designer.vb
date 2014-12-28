<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _009_09_Set_Service_Account
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SetByAccountTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ServiceItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ServiceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SetByAccountTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ServiceItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SetByAccountTab)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 404)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SaveBtn)
        Me.Panel2.Controls.Add(Me.CancelBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 404)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 44)
        Me.Panel2.TabIndex = 1
        '
        'SetByAccountTab
        '
        Me.SetByAccountTab.Controls.Add(Me.TabPage1)
        Me.SetByAccountTab.Controls.Add(Me.TabPage2)
        Me.SetByAccountTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetByAccountTab.Location = New System.Drawing.Point(0, 0)
        Me.SetByAccountTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SetByAccountTab.Name = "SetByAccountTab"
        Me.SetByAccountTab.SelectedIndex = 0
        Me.SetByAccountTab.Size = New System.Drawing.Size(475, 404)
        Me.SetByAccountTab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ServiceItemsDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(467, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Set By Service Item"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(467, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Set By Service Type"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(315, 9)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 27)
        Me.CancelBtn.TabIndex = 0
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(396, 9)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 27)
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ServiceItemsDataGridView
        '
        Me.ServiceItemsDataGridView.AllowUserToAddRows = False
        Me.ServiceItemsDataGridView.AllowUserToDeleteRows = False
        Me.ServiceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServiceItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceId, Me.ServiceName, Me.ServiceType, Me.ServiceDesc})
        Me.ServiceItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.ServiceItemsDataGridView.Location = New System.Drawing.Point(4, 4)
        Me.ServiceItemsDataGridView.Name = "ServiceItemsDataGridView"
        Me.ServiceItemsDataGridView.ReadOnly = True
        Me.ServiceItemsDataGridView.RowHeadersVisible = False
        Me.ServiceItemsDataGridView.Size = New System.Drawing.Size(459, 150)
        Me.ServiceItemsDataGridView.TabIndex = 0
        '
        'ServiceId
        '
        Me.ServiceId.HeaderText = "Id"
        Me.ServiceId.Name = "ServiceId"
        Me.ServiceId.ReadOnly = True
        '
        'ServiceName
        '
        Me.ServiceName.HeaderText = "Name"
        Me.ServiceName.Name = "ServiceName"
        Me.ServiceName.ReadOnly = True
        '
        'ServiceType
        '
        Me.ServiceType.HeaderText = "Type"
        Me.ServiceType.Name = "ServiceType"
        Me.ServiceType.ReadOnly = True
        '
        'ServiceDesc
        '
        Me.ServiceDesc.HeaderText = "Description"
        Me.ServiceDesc.Name = "ServiceDesc"
        Me.ServiceDesc.ReadOnly = True
        '
        '_009_09_Set_Service_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "_009_09_Set_Service_Account"
        Me.Text = "Set Service Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SetByAccountTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ServiceItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SetByAccountTab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents ServiceItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceDesc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
