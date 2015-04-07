Imports System.Windows.Forms

Public Class _006_01_Main_Form
    Private _isManager As Boolean

    Public Sub New(ByVal isManager As Boolean)
        _isManager = isManager

        InitializeComponent()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        Dim form = New _002_01_Product
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.show()
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceToolStripMenuItem.Click
        Dim form = New _002_02_Service
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim form = New _002_04_Customer
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub PromotionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromotionToolStripMenuItem.Click
        Dim form = New _002_03_Promotion
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineUnitOfMeasureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineUnitOfMeasureToolStripMenuItem.Click
        Dim form = New _001_01_Define_UOM
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineStorageLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineStorageLocationToolStripMenuItem.Click
        Dim form = New _001_02_Define_Storage_Location
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineVehicleBrandModelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineVehicleBrandModelToolStripMenuItem.Click
        Dim form = New _001_03_01
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineVehicleSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineVehicleSizeToolStripMenuItem.Click
        Dim form = New _001_04_Define_vehicle_size
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineProductTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineProductTypeToolStripMenuItem.Click
        Dim form = New _001_05_Define_Product_type
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineServiceTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineServiceTypeToolStripMenuItem.Click
        Dim form = New _001_06_Define_Service_Type
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineCompanyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineCompanyToolStripMenuItem.Click
        Dim form = New _001_07_Define_Company
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        _006_02_LoginForm.Show()
    End Sub

    Private Sub ProductMovementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMovementToolStripMenuItem.Click
        Dim form = New _004_01_Product_Movement
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub PointOfSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointOfSalesToolStripMenuItem.Click
        Dim form = New TransactionList
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineVehicleColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineVehicleColorToolStripMenuItem.Click
        Dim form = New _001_08_Define_Vehicle_Color
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub _006_01_Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' MasterDataToolStripMenuItem.Visible = False

    End Sub

    Private Sub PettyCashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PettyCashToolStripMenuItem.Click
        Dim form = New _007_02_Petty_Cash
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub _006_01_Main_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        _006_02_LoginForm.Show()
    End Sub

    Private Sub StockTransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockTransferToolStripMenuItem.Click
        Dim form = New _008_01_StockTransferReport
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub GoodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodToolStripMenuItem.Click
        Dim form = New _008_02_GoodIssueReport
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub GoodReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoodReceiptToolStripMenuItem.Click
        Dim form = New _008_03_GoodReceiptReport
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub InitialStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitialStockToolStripMenuItem.Click
        Dim form = New _008_04_InitialStockReport
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub TransactionReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionReceiptToolStripMenuItem.Click
        Dim form = New _008_05_TransactionReport
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub AssignPromotionToServiceProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignPromotionToServiceProductToolStripMenuItem.Click
        Dim form = New _001_09_Assign_PromotionToProdServ
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub MerchandiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MerchandiseToolStripMenuItem.Click
        Dim form = New _002_05_Mechandise
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineBasePointForCustomerPointToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineBasePointForCustomerPointToolStripMenuItem.Click
        Dim form = New _001_10_Define_Base_point
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub


    Private Sub GLAccountMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLAccountMasterToolStripMenuItem.Click
        Dim form = New _009_01_GL_Account
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineToolStripMenuItem.Click
        Dim form = New _001_13_Define_Account_Type
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefineAccountingDocumentTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineAccountingDocumentTypeToolStripMenuItem.Click
        Dim form = New _001_14_Acct_Doc_Type
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub DefinePettyCashAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefinePettyCashAccountToolStripMenuItem.Click
        Dim form = New _001_15_Petty_Cash_Config
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub JournalEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalEntryToolStripMenuItem.Click
        Dim form = New _009_02_Journal_Transaction
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub JournalTransactionListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalTransactionListToolStripMenuItem.Click
        Dim form = New _009_03_Transaction_List
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub GeneralLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralLedgerToolStripMenuItem.Click
        Dim form = New _009_05_General_Ledger_Report
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub TrialBalanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrialBalanceToolStripMenuItem.Click
        Dim form = New _009_06_Trial_Balance
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub ProfitAndLostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfitAndLostToolStripMenuItem.Click
        Dim form = New _009_07_Profit_and_Lost
        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub

    Private Sub BalanceSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceSheetToolStripMenuItem.Click
        Dim form = New _009_08_Balanced_Sheet

        form.MdiParent = Me
        form.Dock = DockStyle.None
        form.Show()
    End Sub
End Class
