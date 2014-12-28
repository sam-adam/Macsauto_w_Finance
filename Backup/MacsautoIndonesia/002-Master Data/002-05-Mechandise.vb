Public Class _002_05_Mechandise

    Private Sub LoadMerchandises()
        Dim query As String

        query = "SELECT hm.idpdt, hm.idmrch, hp.pdtds, hp.ppamt, hm.mpoin, sum(slqty), uom.uodsc FROM hmerchandise hm JOIN hproduct hp ON hm.idpdt = hp.idpdt JOIN dproduct dp ON hp.idpdt = dp.idpdt INNER JOIN uom uom ON hp.iduom = uom.iduom"

        reader = ExecQueryReader(query)

        ProductGridView.Rows.Clear()

        While reader.Read()
            ProductGridView.Rows.Add(reader(0).ToString(), reader(1).ToString(), reader(2).ToString(), reader(3).ToString(), reader(4).ToString(), reader(5).ToString(), reader(6).ToString())
        End While

        Marking(ProductGridView)
    End Sub

    Private Sub _002_05_Mechandise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadMerchandises()
    End Sub

    Private Sub ProductGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Edit_Click( sender As System.Object,  e As System.EventArgs) Handles Edit.Click
        If ProductIDLbl.Text = "" Or ProductIDLbl.Text = "xxxxxx" Then
            MsgBox("Please select the merchandise")
        Else
            MerchandisePointTxt.Enabled = True
            ProductGridView.Enabled = False
            save.Visible = True
            Cancel.Visible = True
            Edit.Visible = False
        End If
    
    End Sub

    Private Sub save_Click( sender As System.Object,  e As System.EventArgs) Handles save.Click
        If MerchandisePointTxt.Text = "" Or Integer.Parse(MerchandisePointTxt.Text) < 0 Then
            MessageBox.Show("Merchandise point is required")
        Else If MessageBox.Show("Edit merchandise point?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes
            ExecQueryNonReader("UPDATE hmerchandise SET mpoin = " & MerchandisePointTxt.Text)

            MessageBox.Show("Merchandise updated", "Success")

            MerchandisePointTxt.Enabled = False
            ProductGridView.Enabled = True
            save.Visible = False
            Cancel.Visible = False
            Edit.Visible = True

            LoadMerchandises()

            FillData()
        End If
    End Sub

    Private Sub Cancel_Click( sender As System.Object,  e As System.EventArgs) Handles Cancel.Click
        MerchandisePointTxt.Enabled = False
        ProductGridView.Enabled = True
        save.Visible = False
        Cancel.Visible = False
        Edit.Visible = True

        FillData()
    End Sub

    Private Sub ProductGridView_CellEnter( sender As System.Object,  e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductGridView.CellEnter
        FillData()
    End Sub

    Private Sub FillData
        If ProductGridView.Rows.Count > 0 And ProductGridView.SelectedCells.Count > 0 Then
            ProductIDLbl.Text = ProductGridView(0, ProductGridView.SelectedCells(0).RowIndex).Value.ToString()
            MerchandiseIDLbl.Text = ProductGridView(1, ProductGridView.SelectedCells(0).RowIndex).Value.ToString()
            MerchandisePointTxt.Text = ProductGridView(4, ProductGridView.SelectedCells(0).RowIndex).Value.ToString()
        End If
    End Sub
End Class