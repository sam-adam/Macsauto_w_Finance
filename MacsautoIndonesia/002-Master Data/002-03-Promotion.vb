Public Class _002_03_Promotion
    Dim flag As Boolean
    Private Sub LoadPromoTable()
        reader = ExecQueryReader("SELECT * FROM promotion")
        PromoGridView.Rows.Clear()
        While reader.Read()
            PromoGridView.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString)
        End While
        Marking(PromoGridView)
    End Sub
    Public Sub clearAll()
        PromoAmt.Clear()
        PromoDesc.Clear()
        PTypeAmt.Checked = False
        PTypePct.Checked = False
        PromoPct.Value = 0
    End Sub
    Public Sub entryClose()
        Add.Visible = False
        Edit.Visible = False
        Remove.Visible = False
        save.Visible = True
        Cancel.Visible = True
    End Sub
    Public Sub entryOpen()
        Add.Visible = True
        Edit.Visible = True
        Remove.Visible = True
        save.Visible = False
        Cancel.Visible = False
    End Sub
    Public Sub reset()
        clearAll()
        PromoID.Text = "xxxxxx"
        GroupBox1.Enabled = False
        TabControl1.SelectedIndex = 0
        LoadPromoTable()
    End Sub
 
    Public Sub setDiscType()
        If PromoGridView.CurrentRow.Cells(2).Value.ToString() = "3002" Then
            PTypePct.Checked = True
        Else
            PTypeAmt.Checked = True
        End If
    End Sub
    Public Function getDiscType()
        If PTypeAmt.Checked = True Then
            Return "3001"
        Else
            Return "3002"
        End If
    End Function

    Private Sub _002_03_Promotion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPromoTable()
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        flag = True
        PromoID.Text = CreateNewCode("SELECT * FROM promotion order by idpmt desc", "P", 4, 4)
        GroupBox1.Enabled = True
        clearAll()
        entryClose()
    End Sub

    Private Sub PromoGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromoGridView.DoubleClick
        PromoID.Text = PromoGridView.CurrentRow.Cells(0).Value.ToString
        PromoDesc.Text = PromoGridView.CurrentRow.Cells(1).Value.ToString
        setDiscType()
        PromoAmt.Text = PromoGridView.CurrentRow.Cells(3).Value.ToString
        PromoPct.Value = PromoGridView.CurrentRow.Cells(4).Value.ToString
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If PromoDesc.Text = "" Then
            MsgBox("Select Promotion to be modify")
        Else
            flag = False
            entryClose()
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove.Click
        If PromoDesc.Text = "" Then
            MsgBox("Select Promotion to be deleted")
        Else
            If MsgBox("Delete Promotion", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("DELETE FROM promotion WHERE idpmt = '" + PromoID.Text + "'")
                MsgBox("Promotion Deleted")
                reset()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        PromoID.Text = "xxxxxx"
        clearAll()
        entryOpen()
        TabControl1.SelectedIndex = 0
        GroupBox1.Enabled = False
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If flag = True Then
            If PromoDesc.Text = "" Then
                MsgBox("Please fill the Promotion Description")
            ElseIf PTypeAmt.Checked = True And PromoAmt.Text = "" Then
                MsgBox("Please fill the Promotion Amount")
            Else
                If MsgBox("Add new promotion", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    If PTypeAmt.Checked = True Then
                        ExecQueryNonReader("INSERT INTO promotion VALUES('" + PromoID.Text + "','" + PromoDesc.Text + "','" + getDiscType() + "','" + PromoAmt.Text + "','0')")
                    Else
                        ExecQueryNonReader("INSERT INTO promotion VALUES('" + PromoID.Text + "','" + PromoDesc.Text + "','" + getDiscType() + "','0','" + PromoPct.Value.ToString + "')")
                    End If
                    MsgBox("New Promotion Added")
                End If
                reset()
                entryOpen()
            End If
        Else
            If PromoDesc.Text = "" Then
                MsgBox("Please fill the Promotion Description")
            ElseIf PTypeAmt.Checked = True And PromoAmt.Text = "" Then
                MsgBox("Please fill the Promotion Amount")
            Else
                If MsgBox("modify promotion?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    If PTypeAmt.Checked = True Then
                        ExecQueryNonReader("UPDATE Promotion set pmdcp ='" + PromoDesc.Text + "', ptype = '" + getDiscType() + "',pdamt = '" + PromoAmt.Text + "', pdpct = '0' WHERE idpmt = '" + PromoID.Text + "'")
                    Else
                        ExecQueryNonReader("UPDATE Promotion set pmdcp ='" + PromoDesc.Text + "', ptype = '" + getDiscType() + "',pdamt = '0', pdpct = '" + PromoPct.Value.ToString + "' WHERE idpmt = '" + PromoID.Text + "'")
                    End If
                    MsgBox("Promotion Update")
                    reset()
                    entryOpen()

                End If
            End If
        End If
    End Sub
    Private Sub PTypePct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTypePct.CheckedChanged
        PromoPct.Enabled = True
        PromoAmt.Enabled = False
        PromoAmt.Text = "0"
    End Sub
    Private Sub PTypeAmt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTypeAmt.CheckedChanged
        PromoPct.Enabled = False
        PromoAmt.Enabled = True
    End Sub
    Private Sub PromoAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PromoAmt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        _001_09_Assign_PromotionToProdServ.ShowDialog()
    End Sub
End Class