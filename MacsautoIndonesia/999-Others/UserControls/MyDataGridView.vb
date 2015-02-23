Namespace UserControls
    Public Class MyDataGridView
        Inherits DataGridView

        Property IsStripped() As Boolean = True
        Property StripBackColor() As Color = Color.FromArgb(238, 244, 255)

        Public Sub New()
            MyBase.New()

            AddHandler RowsAdded, AddressOf myDataGridView_RowsAdded
            AddHandler DataBindingComplete, AddressOf myDataGridView_DataBindingComplete

            If IsStripped Then
                GridColor = Color.FromArgb(221, 221, 221)
                DefaultCellStyle.ForeColor = Color.FromArgb(51, 51, 51)
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            End If

            ColumnHeadersDefaultCellStyle.WrapMode = False
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End Sub

        Private Sub myDataGridView_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs)
            UpdateRowColor()
        End Sub

        Private Sub myDataGridView_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs)
            If IsStripped AndAlso DataSource Is Nothing Then
                If e.RowIndex.IsOdd() Then
                    Rows(e.RowIndex).DefaultCellStyle.BackColor = StripBackColor
                Else
                    Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        End Sub

        Public Overrides Sub Refresh()
            MyBase.Refresh()
        End Sub

        Public Sub UpdateRowColor()
            For i As Integer = 1 To Rows.Count - 1
                If IsStripped Then
                    If i.IsOdd() Then
                        Rows(i - 1).DefaultCellStyle.BackColor = StripBackColor
                    Else
                        Rows(i - 1).DefaultCellStyle.BackColor = Color.White
                    End If
                End If
            Next
        End Sub
    End Class
End Namespace