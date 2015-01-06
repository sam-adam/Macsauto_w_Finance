Public Class _006_03_Main_Form_Version2
    Private ReadOnly _loginForm As _006_02_LoginForm

    Public Sub New()
        _loginForm = New _006_02_LoginForm

        AddHandler _loginForm.LoginSucceded, AddressOf _loginForm_LoginSucceded
        AddHandler _loginForm.LoginCanceled, AddressOf _loginForm_LoginCancelled
        AddHandler _loginForm.Closed, AddressOf _loginForm_Closed

        InitializeComponent()

        If LoggedInEmployee Is Nothing Then
            _loginForm.ShowDialog()
        End If
    End Sub

    Private Sub _loginForm_Closed(ByVal sender As Object, ByVal e As EventArgs)
        If MessageBox.Show(_loginForm, "Exit application?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub _loginForm_LoginCancelled(ByVal sender As Object, ByVal e As EventArgs)
        If MessageBox.Show(_loginForm, "Exit application?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub _loginForm_LoginSucceded(ByVal sender As Object, ByVal e As EventArgs)
        _loginForm.Hide()

        Show()
        Focus()
    End Sub

    Private Sub BtnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransaction.Click
        CtxTransaction.Show(BtnTransaction, BtnTransaction.Size.Width, 0)
    End Sub

    Private Sub BtnMasterData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMasterData.Click
        CtxMasterData.Show(BtnMasterData, BtnMasterData.Width, 0)
    End Sub

    Private Sub BtnConfiguration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfiguration.Click
        CtxConfiguration.Show(BtnConfiguration, BtnConfiguration.Size.Width, 0)
    End Sub

    Private Sub BtnReporting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReporting.Click
        CtxReporting.Show(BtnReporting, BtnReporting.Size.Width, 0)
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        LoggedInEmployee = Nothing

        Hide()

        _loginForm.ShowDialog()
    End Sub

    Private Sub PointOfSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointOfSalesToolStripMenuItem.Click
        LoadForm(Of _003_01_TrList)()
    End Sub

    Private Sub ProductMovementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMovementToolStripMenuItem.Click
        LoadForm(Of _004_01_Product_Movement)()
    End Sub

    Private Sub PettyCashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PettyCashToolStripMenuItem.Click
        LoadForm(Of _007_02_Petty_Cash)()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        LoadForm(Of _002_01_Product)()
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceToolStripMenuItem.Click
        LoadForm(Of _002_02_Service)()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        LoadForm(Of _002_04_Customer)()
    End Sub

    Private Sub PromotionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromotionToolStripMenuItem.Click
        LoadForm(Of _002_03_Promotion)()
    End Sub

    Private Sub MerchandiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MerchandiseToolStripMenuItem.Click
        LoadForm(Of _002_05_Mechandise)()
    End Sub

    Private Sub DefineCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineCompanyToolStripMenuItem.Click
        LoadForm(Of _001_07_Define_Company)()
    End Sub

    Private Sub DefineStorageLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineStorageLocationToolStripMenuItem.Click
        LoadForm(Of _001_02_Define_Storage_Location)()
    End Sub

    Private Sub DefineUnitOfMeasureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineUnitOfMeasureToolStripMenuItem.Click
        LoadForm(Of _001_01_Define_UOM)()
    End Sub

    Private Sub DefineVehicleBrandAndModelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineVehicleBrandAndModelToolStripMenuItem.Click
        LoadForm(Of _001_03_01)()
    End Sub

    Private Sub DefineVehicleSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineVehicleSizeToolStripMenuItem.Click
        LoadForm(Of _001_04_Define_vehicle_size)()
    End Sub

    Private Sub DefineVehicleColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineVehicleColorToolStripMenuItem.Click
        LoadForm(Of _001_08_Define_Vehicle_Color)()
    End Sub

    Private Sub DefineProductTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineProductTypeToolStripMenuItem.Click
        LoadForm(Of _001_05_Define_Product_type)()
    End Sub

    Private Sub DefineServiceTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineServiceTypeToolStripMenuItem.Click
        LoadForm(Of _001_06_Define_Service_Type)()
    End Sub

    Private Sub AssignPromotionToServiceProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(Of _001_09_Assign_PromotionToProdServ)()
    End Sub

    Private Sub DefineBasePointForCustomerPointToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineBasePointForCustomerPointToolStripMenuItem.Click
        LoadForm(Of _001_10_Define_Base_point)()
    End Sub

    Private Sub StockTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockTransferToolStripMenuItem.Click
        LoadForm(Of _008_01_StockTransferReport)()
    End Sub

    Private Sub GoodIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodIssueToolStripMenuItem.Click
        LoadForm(Of _008_02_GoodIssueReport)()
    End Sub

    Private Sub GoodReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodReceiptToolStripMenuItem.Click
        LoadForm(Of _008_03_GoodReceiptReport)()
    End Sub

    Private Sub InitialStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitialStockToolStripMenuItem.Click
        LoadForm(Of _008_04_InitialStockReport)()
    End Sub

    Private Sub TransactionReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(Of _008_05_TransactionReport)()
    End Sub

    Private Sub PointRedemptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointRedemptionToolStripMenuItem.Click
        LoadForm(Of _003_04_TrMerchandiseRedemption)()
    End Sub

    Private Sub BrutoReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrutoReportToolStripMenuItem.Click
        LoadForm(Of _008_06_BrutoReport)()
    End Sub

    Private Sub PettyCashToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PettyCashToolStripMenuItem1.Click
        LoadForm(Of _008_07_PettyCashReport)()
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        LoadForm(Of _002_06_User)()
    End Sub

    Private Sub SetPrinterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetPrinterToolStripMenuItem.Click
        LoadForm(Of _001_11_Set_Printer)()
    End Sub

    Private Sub ProductMovementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMovementToolStripMenuItem1.Click
        LoadForm(Of _008_02_ProductMovement)()
    End Sub

    Private Sub SetMySQLDumperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetMySQLDumperToolStripMenuItem.Click
        LoadForm(Of _001_12_MySQLDumper)()
    End Sub

    Private Sub PettyCashUsageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PettyCashUsageToolStripMenuItem.Click
        LoadForm(Of _001_15_Petty_Cash_Config)()
    End Sub

    Private Sub LoadForm(Of T As Form)()
        Dim formType As Type = GetType(T)
        Dim form As Form
        Dim openForms As FormCollection = Application.OpenForms()

        For Each openForm As Form In openForms
            If openForm.GetType() = formType Then
                form = openForm
            End If
        Next

        Try
            If form Is Nothing Then
                form = Activator.CreateInstance(formType)
            End If

            form.MdiParent = Me
            form.Dock = DockStyle.None
            form.Show()
            form.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bntFin_Click(sender As Object, e As EventArgs) Handles BtnFinance.Click
        CtxFinance.Show(BtnFinance, BtnFinance.Size.Width, 0)
    End Sub

    Private Sub GeneralLedgerAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralLedgerAccountToolStripMenuItem.Click
        LoadForm(Of _009_01_GL_Account)()
    End Sub

    Private Sub JournalTransactionEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JournalTransactionEntryToolStripMenuItem.Click
        LoadForm(Of _009_02_Journal_Transaction)()
    End Sub

    Private Sub JournalTransactionListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JournalTransactionListToolStripMenuItem.Click
        LoadForm(Of _009_03_Transaction_List)()
    End Sub

    Private Sub GeneralLedgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralLedgeToolStripMenuItem.Click
        LoadForm(Of _009_05_General_Ledger_Report)()
    End Sub

    Private Sub TrialBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrialBalanceToolStripMenuItem.Click
        LoadForm(Of _009_06_Trial_Balance)()
    End Sub

    Private Sub ProfitAndLossToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfitAndLossToolStripMenuItem.Click
        LoadForm(Of _009_07_Profit_and_Lost)()
    End Sub

    Private Sub BalancedSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalancedSheetToolStripMenuItem.Click
        LoadForm(Of _009_08_Balanced_Sheet)()
    End Sub

    Private Sub ServiceAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceAccountToolStripMenuItem.Click
        LoadForm(Of _009_09_Set_Service_Account)()
    End Sub

    Private Sub _006_03_Main_Form_Version2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim mysqlDumpPath As String = My.MySettings.Default.MySQLDumpPath

        If Not String.IsNullOrEmpty(mysqlDumpPath) Then
            If MsgBox("Backup database now?", MsgBoxStyle.YesNo, "Database backup") = MsgBoxResult.Yes Then
                Dim dialog As FolderBrowserDialog = New FolderBrowserDialog()

                dialog.RootFolder = Environment.SpecialFolder.MyComputer

                If Not String.IsNullOrEmpty(My.MySettings.Default.MySQLBackupPath) Then
                    dialog.SelectedPath = My.MySettings.Default.MySQLBackupPath
                End If

                dialog.ShowDialog(Me)

                My.MySettings.Default.MySQLBackupPath = dialog.SelectedPath

                Try
                    BackupDatabase(mysqlDumpPath, My.Settings.Database, My.MySettings.Default.MySQLBackupPath, My.Settings.Username, My.Settings.Password)

                    MsgBox("Database backed-up")
                Catch ex As Exception
                    If MsgBox("Database backup failed. Quit anyway?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        e.Cancel = True
                    End If
                End Try
            End If
        End If
    End Sub
End Class