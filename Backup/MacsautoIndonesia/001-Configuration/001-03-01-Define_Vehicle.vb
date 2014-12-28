Public Class _001_03_01

    Private Sub loadVehicleBrand()
        If carRadio.Checked = True Then
            reader = ExecQueryReader("SELECT * FROM vehicleBrand where vtype = 'Car'")
        Else
            reader = ExecQueryReader("SELECT * FROM vehicleBrand where vtype = 'Motorcycle'")
        End If
        BrandView.Rows.Clear()
        While reader.Read()
            BrandView.Rows.Add(reader(0).ToString, reader(2).ToString, False, False)
        End While
        Marking(BrandView)
    End Sub
    
    Private Sub _001_03_Define_Vehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadVehicleBrand()
    End Sub

    Private Sub BrandView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BrandView.CellEndEdit
        BrandView(3, e.RowIndex).Value = True
    End Sub
    Private Sub carRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles carRadio.CheckedChanged
        'Try
        BrandView.Rows.Clear()
        loadVehicleBrand()
        'Catch ex As Exception

        ' End Try
    End Sub

    Private Sub BikeRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BikeRadio.CheckedChanged
        Try
            BrandView.Rows.Clear()
            loadVehicleBrand()
        Catch ex As Exception

        End Try

    End Sub
    Private Function checkData()
        reader = ExecQueryReader("SELECT COUNT(*)FROM vehicleBrand WHERE idbrn LIKE '" + BrandView.CurrentRow.Cells(0).Value.ToString + "'")
        reader.Read()
        Return reader(0).ToString
    End Function

    Private Sub saveVehicleBrand()
        Dim type As String
        Dim i As Integer

        If carRadio.Checked = True Then
            type = "Car"
        Else
            type = "Motorcycle"
        End If

        For i = 0 To BrandView.Rows.Count - 2
            If BrandView(2, i).Value = True Then
                ExecQueryNonReader("INSERT INTO vehiclebrand VALUES('" + BrandView.Rows(i).Cells(0).Value.ToString + "','" + type + "','" + BrandView.Rows(i).Cells(1).Value.ToString + "')")
            ElseIf BrandView(3, i).Value = True Then
                Dim query As String = "UPDATE vehiclebrand " &
                                      "SET brdsc = '" & BrandView(1, i).Value & "'" &
                                      "WHERE idbrn = '" & BrandView(0, i).Value & "'"
                ExecQueryNonReader(query)
            End If
        Next i
    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveBtn.Click
        If MsgBox("Save Vehicle brand Data?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            saveVehicleBrand()
            MsgBox("Vehicle Brand successfully defined")
            loadVehicleBrand()

        End If
    End Sub

    Private Sub BrandView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandView.DoubleClick
        Try
            If checkData() = 0 Then
                MsgBox("Please Save the brand data before proceeding to maintain the model")
            Else
                _001_03_02.code = Me.BrandView.CurrentRow.Cells(0).Value.ToString()
                _001_03_02.ShowDialog()

            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub BrandView_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles BrandView.DragEnter

    End Sub

    Private Sub BrandView_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles BrandView.RowsAdded
        Dim pre As String

        If carRadio.Checked = True Then
            pre = "C"
        Else
            pre = "B"
        End If

        BrandView(0, BrandView.NewRowIndex).Value = pre & String.Format("{0:00}", BrandView.Rows.Count)
        BrandView(2, BrandView.NewRowIndex).Value = True
        BrandView(3, BrandView.NewRowIndex).Value = True
    End Sub
End Class