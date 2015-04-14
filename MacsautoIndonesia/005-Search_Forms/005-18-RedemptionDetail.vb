Imports System.Globalization
Imports System.ComponentModel

Public Class _005_18_RedemptionDetail
    Implements INotifyPropertyChanged

    Private ReadOnly _transactionHeaderDataTable As DataTable
    Private ReadOnly _transactionDetailDataTable As DataTable

    ReadOnly Property TransactionHeaderDataTable() As DataTable
        Get
            Return _transactionHeaderDataTable
        End Get
    End Property

    ReadOnly Property HasResult As Boolean
        Get
            Return _transactionHeaderDataTable.Rows.Count > 0
        End Get
    End Property

    ReadOnly Property DateTimeFormatUsed As String
        Get
            Return LongFriendlyDateTimeFormat
        End Get
    End Property

    ReadOnly Property TransactionDetailDataTable() As DataTable
        Get
            Return _transactionDetailDataTable
        End Get
    End Property
    
    Public Sub New()
        InitializeComponent()

        _transactionHeaderDataTable = New DataTable()
        _transactionDetailDataTable = New DataTable()
    End Sub

    Public Sub PerformBinding()
        DoFindTransaction("", "")

        CustomerNameTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "cname", False, DataSourceUpdateMode.Never)
        CustomerPhoneTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "cphon", False, DataSourceUpdateMode.Never)
        CustomerCellphoneTxt.DataBindings.Add("Text", _transactionHeaderDataTable, "ccpon", False, DataSourceUpdateMode.Never)
        IsMemberChk.DataBindings.Add("Checked", _transactionHeaderDataTable, "is_member", False, DataSourceUpdateMode.Never)
        
        Dim dateBinding As New Binding("Text", _transactionHeaderDataTable, "trdat")
        AddHandler dateBinding.Format,
            Sub(s As Object, evt As ConvertEventArgs)
                If evt.DesiredType Is GetType(String) Then
                    evt.Value = Date.ParseExact(evt.Value.ToString(), CurrentDateTimeFormat, CultureInfo.InvariantCulture).ToString(DateTimeFormatUsed)
                End If
            End Sub
        DateTxt.DataBindings.Add(dateBinding)

        DataBindings.Add("VehicleType", _transactionHeaderDataTable, "vtype")
        DataBindings.Add("PaymentType", _transactionHeaderDataTable, "pterm")
    End Sub

    Public Sub FindTransaction(ByVal transactionId As String, Optional ByVal transactionStatus As String = "")
        _transactionHeaderDataTable.Clear()
        _transactionDetailDataTable.Clear()

        TransactionDetailDataGrid.Rows.Clear()

        If transactionId.Length = "001/03-2014/0001/001".Length Then
            DoFindTransaction(transactionId, transactionStatus)
        End If

        NotifyPropertyChanged("TransactionHeaderDataTable")
        NotifyPropertyChanged("HasResult")
    End Sub

    Private Sub DoFindTransaction(ByVal transactionId As String, ByVal transactionStatus As String)
        Dim transactionHeaderQuery As String =
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
                " WHERE htransaction.trsid = '" & transactionId & "'"
        Dim transactionDetailQuery As String =
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
            " WHERE dtransaction.trsid = '" & transactionId & "'"

        If Not String.IsNullOrEmpty(transactionStatus) Then
            If transactionStatus.IndexOf("NOT", StringComparison.Ordinal) = 0 Then
                transactionStatus = transactionStatus.Replace("NOT ", "")

                transactionHeaderQuery &= " AND htransaction.trstat <> '" & transactionStatus.ToUpper() & "'"
                transactionDetailQuery &= " AND htransaction.trstat <> '" & transactionStatus.ToUpper() & "'"
            Else
                transactionHeaderQuery &= " AND htransaction.trstat = '" & transactionStatus.ToUpper() & "'"
                transactionDetailQuery &= " AND htransaction.trstat = '" & transactionStatus.ToUpper() & "'"
            End If
        End If

        _transactionHeaderDataTable.Load(ExecQueryReader(transactionHeaderQuery))
        _transactionDetailDataTable.Load(ExecQueryReader(transactionDetailQuery))

        For Each detail As DataRow In _transactionDetailDataTable.Rows
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