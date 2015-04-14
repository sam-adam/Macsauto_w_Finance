Imports System.Globalization
Imports System.ComponentModel

Public Class _005_18_RedemptionDetail
    Implements INotifyPropertyChanged

    Private ReadOnly _redemptionHeaderDataTable As DataTable
    Private ReadOnly _redemptionDetailDataTable As DataTable

    ReadOnly Property RedemptionHeaderDataTable() As DataTable
        Get
            Return _redemptionHeaderDataTable
        End Get
    End Property

    ReadOnly Property HasResult As Boolean
        Get
            Return _redemptionHeaderDataTable.Rows.Count > 0
        End Get
    End Property

    ReadOnly Property DateTimeFormatUsed As String
        Get
            Return LongFriendlyDateTimeFormat
        End Get
    End Property

    ReadOnly Property RedemptionDetailDataTable() As DataTable
        Get
            Return _redemptionDetailDataTable
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        _redemptionHeaderDataTable = New DataTable()
        _redemptionDetailDataTable = New DataTable()
    End Sub

    Public Sub PerformBinding()
        DoFindRedemption("")

        CustomerNameTxt.DataBindings.Add("Text", _redemptionHeaderDataTable, "cname", False, DataSourceUpdateMode.Never)
        CustomerPhoneTxt.DataBindings.Add("Text", _redemptionHeaderDataTable, "cphon", False, DataSourceUpdateMode.Never)
        CustomerCellphoneTxt.DataBindings.Add("Text", _redemptionHeaderDataTable, "ccpon", False, DataSourceUpdateMode.Never)
        IsMemberChk.DataBindings.Add("Checked", _redemptionHeaderDataTable, "is_member", False, DataSourceUpdateMode.Never)

        Dim dateBinding As New Binding("Text", _redemptionHeaderDataTable, "trdat")
        AddHandler dateBinding.Format,
            Sub(s As Object, evt As ConvertEventArgs)
                If evt.DesiredType Is GetType(String) Then
                    evt.Value = Date.ParseExact(evt.Value.ToString(), CurrentDateTimeFormat, CultureInfo.InvariantCulture).ToString(DateTimeFormatUsed)
                End If
            End Sub
        DateTxt.DataBindings.Add(dateBinding)
    End Sub

    Public Sub FindRedemption(ByVal redemptionId As String)
        _redemptionHeaderDataTable.Clear()
        _redemptionDetailDataTable.Clear()

        TransactionDetailDataGrid.Rows.Clear()

        If redemptionId.Length = "001/03-2014/0001/001".Length Then
            DoFindRedemption(redemptionId)
        End If

        NotifyPropertyChanged("RedemptionHeaderDataTable")
        NotifyPropertyChanged("HasResult")
    End Sub

    Private Sub DoFindRedemption(ByVal redemptionId As String)
        Dim redemptionHeaderQuery As String =
                "SELECT" & _
                "   htransaction.trsid," & _
                "   htransaction.trdat," & _
                "   htransaction.idcus," & _
                "   htransaction.linum," & _
                "   htransaction.vtype," & _
                "   htransaction.vbrnd," & _
                "   htransaction.vmodl," & _
                "   htransaction.vsize," & _
                "   htransaction.vcolr," & _
                "   htransaction.trdat," & _
                "   htransaction.pterm," & _
                "   htransaction.toamt," & _
                "   htransaction.topay," & _
                "   htransaction.chnce," & _
                "   htransaction.cpoin," & _
                "   htransaction.tpoin," & _
                "   hcustomer.cname," & _
                "   hcustomer.cphon," & _
                "   hcustomer.ccpon," & _
                "   IF(hcustomer.cstat = 'Member', 1, 0) AS is_member" & _
                " FROM htransaction" & _
                " LEFT JOIN hcustomer ON htransaction.idcus = hcustomer.idcus" & _
                " WHERE htransaction.trsid = '" & redemptionId & "'"
        Dim redemptionDetailQuery As String =
            "SELECT" & _
            "   dtransaction.trsid," & _
            "   dtransaction.ttype," & _
            "   dtransaction.idsvc," & _
            "   dtransaction.idpdt," & _
            "   dtransaction.trqty," & _
            "   dtransaction.uomdc," & _
            "   dtransaction.price," & _
            "   dtransaction.idisc," & _
            "   dtransaction.rmark," & _
            "   hproduct.pdtds," & _
            "   producttype.ptpdc," & _
            "   hservice.svcdc," & _
            "   servicetype.svtdc" & _
            " FROM dtransaction" & _
            " LEFT JOIN hproduct ON dtransaction.idpdt = hproduct.idpdt" & _
            " LEFT JOIN producttype ON hproduct.idptp = producttype.idptp" & _
            " LEFT JOIN hservice ON dtransaction.idsvc = hservice.idsvc" & _
            " LEFT JOIN servicetype ON hservice.idsvt = servicetype.idsvt" & _
            " LEFT JOIN htransaction ON dtransaction.trsid = htransaction.trsid" & _
            " WHERE dtransaction.trsid = '" & redemptionId & "'"

        _redemptionHeaderDataTable.Load(ExecQueryReader(redemptionHeaderQuery))
        _redemptionDetailDataTable.Load(ExecQueryReader(redemptionDetailQuery))

        For Each detail As DataRow In _redemptionDetailDataTable.Rows
            With TransactionDetailDataGrid
                Dim hasDiscount As Boolean = (Not String.IsNullOrEmpty(detail("idisc")) AndAlso detail("idisc") > 0)

                If detail("ttype") = "P" Then
                    TransactionDetailDataGrid.Rows.Add(
                        "Product",
                         detail("pdtds"),
                         detail("uomdc"),
                         detail("price"),
                         detail("trqty"),
                         detail("idisc"),
                         If(hasDiscount, (detail("price") * (100 - detail("idisc")) / 100), detail("price")),
                         detail("rmark"))
                Else
                    TransactionDetailDataGrid.Rows.Add(
                        "Service",
                         detail("svcdc"),
                         detail("uomdc"),
                         detail("price"),
                         detail("trqty"),
                         detail("idisc"),
                         If(hasDiscount, (detail("price") * (100 - detail("idisc")) / 100), detail("price")),
                         detail("rmark"))
                End If
            End With
        Next
    End Sub

    Private Sub _003_06_Print_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer.SplitterDistance = SplitContainer.Panel1MinSize
    End Sub

    Private Sub _003_06_Print_Transaction_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        SplitContainer.SplitterDistance = SplitContainer.Panel1MinSize
    End Sub

    Private Sub _003_06_Print_Transaction_ParentChanged(sender As Object, e As EventArgs) Handles MyBase.ParentChanged
        SplitContainer.SplitterDistance = SplitContainer.Panel1MinSize
    End Sub

    Private Sub _003_06_Print_Transaction_DockChanged(sender As Object, e As EventArgs) Handles MyBase.DockChanged
        SplitContainer.SplitterDistance = SplitContainer.Panel1MinSize
    End Sub

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub
End Class