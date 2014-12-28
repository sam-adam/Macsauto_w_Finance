Imports System.Printing

Public Class _001_11_Set_Printer
    Public Sub New()
        Dim printServer = New PrintServer

        InitializeComponent()

        For Each printQueue As PrintQueue In printServer.GetPrintQueues()
            ListBoxPrinter.Items.Add(printQueue.FullName)
        Next

        ChkPrintPreview.Checked = My.Settings.ShowPrintPreview
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        My.Settings.DefaultPrinter = ListBoxPrinter.SelectedItem.ToString()
        My.Settings.ShowPrintPreview = ChkPrintPreview.Checked

        MessageBox.Show(Me, "Printer settings saved", "Success")

        Close()
    End Sub
End Class