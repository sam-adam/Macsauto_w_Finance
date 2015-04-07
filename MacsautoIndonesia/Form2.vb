Public Class Form2
    Public Sub AddServiceItem(ByVal serviceName As String)
        Dim newServiceItem = New Label
        Dim height As Integer
        Dim totalPanelItemsHeight As Integer = 0

        For Each Control As Control In Panel2.Controls
            totalPanelItemsHeight += Control.Height
        Next

        newServiceItem.Text = serviceName
        newServiceItem.AutoSize = False
        newServiceItem.BackColor = Color.AliceBlue
        height = newServiceItem.Height
        newServiceItem.Width = newServiceItem.CreateGraphics().MeasureString(serviceName, newServiceItem.Font).Width

        While newServiceItem.Width > Panel2.Width
            newServiceItem.Height += height
            newServiceItem.Width -= Panel2.Width
        End While



        newServiceItem.Location = New Point(0, totalPanelItemsHeight + newServiceItem.Height)

        Panel2.Controls.Add(newServiceItem)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _009_02_Journal_Transaction.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        _009_03_Transaction_List.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        _009_05_General_Ledger_Report.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        _009_06_Trial_Balance.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        _009_07_Profit_and_Lost.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        _009_08_Balanced_Sheet.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        _007_02_Petty_Cash.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        _001_15_Petty_Cash_Config.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        _009_01_GL_Account.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        _002_01_Product.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        _004_01_Product_Movement.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        _001_16_Material_Account.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        _001_13_Define_Account_Type.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        _003_01_05_TransactionCancel.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        _001_05_Define_Product_type.Show()

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        _001_17_Define_Accounting_Period.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim form As _009_09_Set_Service_Account = New _009_09_Set_Service_Account()

        form.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim form As _001_14_Acct_Doc_Type = New _001_14_Acct_Doc_Type

        form.Show()
    End Sub
End Class