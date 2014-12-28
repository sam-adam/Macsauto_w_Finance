Public Class _001_09_Assign_PromotionToProdServ
    Dim flag As Boolean
    Private Sub loadItem()
        pdtsvcbo.Items.Clear()
        If ProductRbtn.Checked = True Then
            reader = ExecQueryReader("SELECT * FROM HProduct")
        Else
            reader = ExecQueryReader("SELECT * FROM HService")
        End If
        While reader.Read()
            pdtsvcbo.Items.Add(reader(0).ToString & " - " & reader(2).ToString)
        End While
    End Sub
    Private Sub clearField()
        ProductRbtn.Checked = True
        Begda.Value = Today.Date.ToString
        endda.Value = Today.Date.ToString
        pdtsvcbo.SelectedIndex = -1
        PromoCbo.SelectedIndex = -1
        Member.Checked = False
        status.Checked = False

    End Sub
    Private Sub lockField()
        ProductRbtn.Enabled = False
        ServiceRbtn.Enabled = False
        pdtsvcbo.Enabled = False
        PromoCbo.Enabled = False
        status.Enabled = False
        Member.Enabled = False
        Begda.Enabled = False
        endda.Enabled = False
    End Sub
    Private Sub unLockField()
        ProductRbtn.Enabled = True
        ServiceRbtn.Enabled = True
        status.Enabled = True
        Member.Enabled = True
        Begda.Enabled = True
        endda.Enabled = True
    End Sub
    Private Function checkItemOnPromo()
        Dim i, y As Integer
        For i = 0 To PromoGrid.Rows.Count - 1

            If PromoGrid.Rows(i).Cells(7).Value.ToString = pdtsvcbo.SelectedItem.ToString.Substring(0, 8) Then
                y = 1
                Exit For
            Else
                y = 2
            End If
        Next i
        Return y
    End Function
    Private Function getDescription(ByVal item As String)
        Dim text As String
        If item.Substring(0, 1) = "M" Then
            text = getText("SELECT pdtds FROM HProduct where idpdt ='" + item + "'", 0)
        Else
            text = getText("SELECT svcdc FROM HService where idsvc ='" + item + "'", 0)
        End If
        Return text
    End Function
    Private Sub setPromoType()
        If PromoGrid.CurrentRow.Cells(9).Value.ToString = "P" Then
            ProductRbtn.Checked = True
        Else
            ServiceRbtn.Checked = True
        End If
    End Sub
    Private Sub setStatus()
        If PromoGrid.CurrentRow.Cells(5).Value.ToString = True Then
            status.Checked = True
        Else
            status.Checked = False
        End If
    End Sub
    Private Function setMember()
        If PromoGrid.CurrentRow.Cells(6).Value.ToString = True Then
            Member.Checked = True
        Else
            Member.Checked = False
        End If
    End Function

    Private Function getPromoValue(ByVal item As String)
        reader = ExecQueryReader("Select * from promotion where idpmt like '" + item + "'")
        reader.read()
        If reader(2).ToString = "3002" Then

            Return reader(4).ToString & "%"
        Else

            Return reader(3).ToString
        End If
    End Function
    Private Sub reloadGrid()
        Dim i As Integer
        For i = 0 To PromoGrid.Rows.Count - 1
            PromoGrid.Rows(i).Cells(1).Value = getDescription(PromoGrid.Rows(i).Cells(1).Value.ToString)
            PromoGrid.Rows(i).Cells(4).Value = getPromoValue(PromoGrid.Rows(i).Cells(8).Value.ToString)
        Next i
    End Sub
    Private Sub loadPromoAssignmentGrid()
        PromoGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT b.pmdcp,iditm,begda,endda,astat,ismem,atype,a.idpmt FROM promoAssignment a, promotion b where a.idpmt = b.idpmt")
        While reader.read
            PromoGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString(), "Macsauto", reader(4).ToString, reader(5).ToString, reader(1).ToString, reader(7).ToString, reader(6).ToString)
        End While
        Marking(PromoGrid)
        reloadGrid()

    End Sub
    Private Sub loadPromoAssignmentGrid1(ByVal stat As String)
        PromoGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT b.pmdcp,iditm,begda,endda,astat,ismem,atype,a.idpmt FROM promoAssignment a, promotion b where a.idpmt = b.idpmt AND A.astat = '" + stat + "'")
        While reader.read
            PromoGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString(), "Macsauto", reader(4).ToString, reader(5).ToString, reader(1).ToString, reader(7).ToString, reader(6).ToString)
        End While
        Marking(PromoGrid)
        reloadGrid()

    End Sub
    Private Sub loadPromotion()
        PromoCbo.Items.Clear()
        reader = ExecQueryReader("SELECT * FROM Promotion")
        While reader.read
            PromoCbo.Items.Add(reader(0).ToString & " - " & reader(1).ToString())
        End While
    End Sub
    Private Function promotype()
        If ProductRbtn.Checked = True Then
            Return "P"
        Else
            Return "S"
        End If
    End Function
    Private Function PromoStatus()
        If status.Checked = True Then
            Return "True"
        Else
            Return "False"
        End If
    End Function
    Private Function MemberPromo()
        If Member.Checked = True Then
            Return "True"
        Else
            Return "False"
        End If
    End Function
    Private Sub ProductRbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductRbtn.CheckedChanged
        Label1.Text = "Product"
        loadItem()
    End Sub

    Private Sub ServiceRbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceRbtn.CheckedChanged
        Label1.Text = "Service"
        loadItem()
    End Sub

    Private Sub _001_09_Assign_PromotionToProdServ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadItem()
        loadPromotion()
        loadPromoAssignmentGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        If flag = True Then 'Add
            If pdtsvcbo.SelectedIndex = -1 Then
                MsgBox("Please select Product / Service you want to assign to promotion")
            ElseIf PromoCbo.SelectedIndex = -1 Then
                MsgBox("Please select promotion you want to assign to Product / Service")
            ElseIf Begda.Value > endda.Value Then
                MsgBox("Start date cannot be bigger than end date")
            ElseIf checkItemOnPromo() = 1 Then
                MsgBox(Label1.Text & " had already assigned to a promotion")
            Else
                If MsgBox("Assign '" + Label1.Text + "' to this promotion?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ExecQueryNonReader("INSERT INTO PromoAssignment VALUES('" + promotype() + "','" + pdtsvcbo.SelectedItem.ToString.Substring(0, 8) + "','" + PromoCbo.SelectedItem.ToString.Substring(0, 8) + "','" + Begda.Value.ToString("yyyy-MM-dd") + "','" + endda.Value.ToString("yyyy-MM-dd") + "','" + PromoStatus() + "','" + MemberPromo() + "')")
                    MsgBox("" + Label1.Text + " assigned to promotion")
                    loadPromoAssignmentGrid()

                    lockField()
                    cancelBtn.Visible = False
                    Add.Visible = True
                    SaveBtn.Visible = False
                    deleteBtn.Visible = True
                    Edit.Visible = True
                    clearField()
                End If
            End If
        Else
           
            If Begda.Value > endda.Value Then
                MsgBox("Start date cannot be bigger than end date")
         
            Else
                If MsgBox("Modify '" + Label1.Text + "' assignment to this promotion?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                    ' MsgBox("UPDATE PromoAssignment set begda = '" + Begda.Value.ToString("yyyy-MM-dd") + "', endda = '" + endda.Value.ToString("yyyy-MM-dd") + "',astat = '" + PromoStatus() + "',ismem = '" + MemberPromo() + "' where iditm'" + PromoGrid.CurrentRow.Cells(7).Value.ToString + "' and idpmt = '" + PromoGrid.CurrentRow.Cells(8).Value.ToString + "'")
                    ExecQueryNonReader("UPDATE PromoAssignment set begda = '" + Begda.Value.ToString("yyyy-MM-dd") + "', endda = '" + endda.Value.ToString("yyyy-MM-dd") + "',astat = '" + PromoStatus() + "',ismem = '" + MemberPromo() + "' where iditm = '" + PromoGrid.CurrentRow.Cells(7).Value.ToString + "' and idpmt = '" + PromoGrid.CurrentRow.Cells(8).Value.ToString + "'")
                    MsgBox("" + Label1.Text + " assigned to promotion")
                    loadPromoAssignmentGrid()
                    lockField()
                    cancelBtn.Visible = False
                    Add.Visible = True
                    SaveBtn.Visible = False
                    deleteBtn.Visible = True
                    Edit.Visible = True
                    clearField()
                End If
            End If
        End If
        '  MsgBox(checkItemOnPromo)


    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        clearField()
        cancelBtn.Visible = True
        Add.Visible = False
        SaveBtn.Visible = True
        deleteBtn.Visible = False
        Edit.Visible = False
        unLockField()
        pdtsvcbo.Enabled = True
        PromoCbo.Enabled = True
        flag = True

    End Sub

    Private Sub cancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        cancelBtn.Visible = False
        Add.Visible = True
        SaveBtn.Visible = False
        deleteBtn.Visible = True
        Edit.Visible = True
        lockField()
        clearField()
    End Sub

    Private Sub PromoGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PromoGrid.CellClick
        setPromoType()
        pdtsvcbo.Text = PromoGrid.CurrentRow.Cells(7).Value.ToString & " - " & PromoGrid.CurrentRow.Cells(1).Value.ToString
        PromoCbo.Text = PromoGrid.CurrentRow.Cells(8).Value.ToString & " - " & PromoGrid.CurrentRow.Cells(0).Value.ToString
        Begda.Value = PromoGrid.CurrentRow.Cells(2).Value.ToString
        endda.Value = PromoGrid.CurrentRow.Cells(3).Value.ToString
        setStatus()
        setMember()
    End Sub

    Private Sub deleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.Click
        If pdtsvcbo.SelectedIndex = -1 Then
            MsgBox("Please select item to be deleted")
        ElseIf PromoGrid.Rows.Count = 0 Then
            MsgBox("No Item to delete")
        Else
            If MsgBox("delete assignment '" + Label1.Text + "' to this promotion?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("Delete from PromoAssignment where iditm like '" + PromoGrid.CurrentRow.Cells(7).Value.ToString + "' and idpmt like '" + PromoGrid.CurrentRow.Cells(8).Value.ToString + "'")
                MsgBox("" + Label1.Text + " assignment deleted")
                lockField()
                loadPromoAssignmentGrid()
            End If
        End If

    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If pdtsvcbo.SelectedIndex = -1 Then
            MsgBox("Select promotion to be modify")
        Else
            flag = False
            unLockField()
            cancelBtn.Visible = True
            Add.Visible = False
            SaveBtn.Visible = True
            deleteBtn.Visible = False
            Edit.Visible = False
            'clearField()
        End If
        
    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        loadPromoAssignmentGrid1("True")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        loadPromoAssignmentGrid1("False")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            loadPromoAssignmentGrid()
        Catch ex As Exception

        End Try

    End Sub
End Class