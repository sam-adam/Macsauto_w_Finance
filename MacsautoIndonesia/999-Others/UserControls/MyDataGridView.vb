Namespace UserControls
    Public Class MyDataGridView
        Inherits DataGridView

        Property IsStripped() As Boolean = True
        Property StripBackColor() As Color = Color.FromArgb(238, 244, 255)
        Property RowBackgroundColorAssesment As Func(Of DataGridViewRow, Color?) = Nothing

        Private ReadOnly _rightClickContextMenu As ContextMenuStrip

        Public Sub New()
            MyBase.New()

            AddHandler CellMouseClick, AddressOf myDataGridView_CellMouseClick
            AddHandler RowsAdded, AddressOf myDataGridView_RowsAdded
            AddHandler DataBindingComplete, AddressOf myDataGridView_DataBindingComplete

            If IsStripped Then
                GridColor = Color.FromArgb(221, 221, 221)
                DefaultCellStyle.ForeColor = Color.FromArgb(51, 51, 51)
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            End If

            ColumnHeadersDefaultCellStyle.WrapMode = False
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            _rightClickContextMenu = New ContextMenuStrip()

            With _rightClickContextMenu
                Dim copyValueMenu As ToolStripMenuItem = New ToolStripMenuItem("Copy value")
                Dim copyTextMenu As ToolStripMenuItem = New ToolStripMenuItem("Copy text")

                AddHandler copyValueMenu.Click,
                    Sub(s As Object, e As EventArgs)
                        Clipboard.SetText(CurrentCell.Value)
                    End Sub
                AddHandler copyTextMenu.Click,
                    Sub(s As Object, e As EventArgs)
                        Clipboard.SetText(CurrentCell.FormattedValue)
                    End Sub

                .Items.Add(copyTextMenu)
                .Items.Add(copyValueMenu)
            End With
        End Sub

        Public Sub AddContextMenuItem(ByVal toolStripCollection As ToolStripItem())
            If toolStripCollection.Count > 0 Then
                Dim temp(_rightClickContextMenu.Items.Count - 1) As ToolStripItem

                _rightClickContextMenu.Items.CopyTo(temp, 0)

                _rightClickContextMenu.Items.Clear()
                _rightClickContextMenu.Items.AddRange(toolStripCollection)
                _rightClickContextMenu.Items.Add(New ToolStripSeparator())
                _rightClickContextMenu.Items.AddRange(temp)
            End If
        End Sub

        Private Sub myDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
            If e.Button = MouseButtons.Right Then
                For Each cell As DataGridViewCell In SelectedCells
                    cell.Selected = False
                Next

                Item(e.ColumnIndex, e.RowIndex).Selected = True

                _rightClickContextMenu.Show(Cursor.Position)
            End If
        End Sub

        Private Sub myDataGridView_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs)
            UpdateRowColor()
        End Sub

        Private Sub myDataGridView_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs)
            If IsStripped AndAlso DataSource Is Nothing Then
                UpdateCellColor(e.RowIndex)
            End If
        End Sub

        Public Overrides Sub Refresh()
            MyBase.Refresh()
        End Sub

        Public Sub UpdateRowColor()
            For i As Integer = 1 To Rows.Count - 1
                If IsStripped Then
                    UpdateCellColor(i - 1)
                End If
            Next
        End Sub

        Private Sub UpdateCellColor(ByVal rowIndex As Integer)
            Dim changed As Boolean = False

            If Not RowBackgroundColorAssesment Is Nothing Then
                Dim color As Color? = RowBackgroundColorAssesment(Rows(rowIndex))

                If Not color Is Nothing Then
                    Rows(rowIndex).DefaultCellStyle.BackColor = color

                    changed = True
                End If
            End If

            If Not changed Then
                If rowIndex.IsOdd() Then
                    Rows(rowIndex).DefaultCellStyle.BackColor = StripBackColor
                Else
                    Rows(rowIndex).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        End Sub
    End Class
End Namespace