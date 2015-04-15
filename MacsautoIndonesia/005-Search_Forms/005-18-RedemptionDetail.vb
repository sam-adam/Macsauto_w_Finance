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
        CustomerCurrentPointTxt.DataBindings.Add("Text", _redemptionHeaderDataTable, "cpoin", False, DataSourceUpdateMode.Never)
        PointRequiredLbl.DataBindings.Add("Text", _redemptionHeaderDataTable, "tpoin", False, DataSourceUpdateMode.Never)
        IsMemberChk.DataBindings.Add("Checked", _redemptionHeaderDataTable, "is_member", False, DataSourceUpdateMode.Never)

        Dim dateBinding As New Binding("Text", _redemptionHeaderDataTable, "rdmpdat")
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

        RedemptionDetailDataGrid.Rows.Clear()

        If redemptionId.Length = "001/03-2014/0001/001".Length Then
            DoFindRedemption(redemptionId)
        End If

        NotifyPropertyChanged("RedemptionHeaderDataTable")
        NotifyPropertyChanged("HasResult")
    End Sub

    Private Sub DoFindRedemption(ByVal redemptionId As String)
        Dim redemptionHeaderQuery As String =
            "SELECT" & _
            "   hredemption.rdmpid," & _
            "   hredemption.rdmpdat," & _
            "   hredemption.idcus," & _
            "   hredemption.tpoin," & _
            "   hredemption.cpoin," & _
            "   hcustomer.cname," & _
            "   hcustomer.cphon," & _
            "   hcustomer.ccpon," & _
            "   IF(hcustomer.cstat = 'Member', 1, 0) AS is_member" & _
            " FROM hredemption" & _
            " LEFT JOIN hcustomer ON hredemption.idcus = hcustomer.idcus" & _
            " WHERE hredemption.rdmpid = '" & redemptionId & "'"
        Dim redemptionDetailQuery As String =
            "SELECT" & _
            "   dredemption.rdmpid," & _
            "   dredemption.idmrch," & _
            "   dredemption.point," & _
            "   dredemption.qty," & _
            "   hmerchandise.idpdt," & _
            "   uom.uodsc," & _
            "   hproduct.pdtds," & _
            "   producttype.ptpdc" & _
            " FROM dredemption" & _
            " LEFT JOIN hmerchandise ON dredemption.idmrch = hmerchandise.idmrch" & _
            " LEFT JOIN hproduct ON hmerchandise.idpdt = hproduct.idpdt" & _
            " LEFT JOIN producttype ON hproduct.idptp = producttype.idptp" & _
            " LEFT JOIN uom ON hproduct.iduom = uom.iduom" & _
            " WHERE dredemption.rdmpid = '" & redemptionId & "'"

        _redemptionHeaderDataTable.Load(ExecQueryReader(redemptionHeaderQuery))
        _redemptionDetailDataTable.Load(ExecQueryReader(redemptionDetailQuery))

        For Each detail As DataRow In _redemptionDetailDataTable.Rows
            With RedemptionDetailDataGrid
                RedemptionDetailDataGrid.Rows.Add(
                    detail("idmrch"),
                    detail("idpdt"),
                    detail("pdtds"),
                    detail("qty"),
                    detail("uodsc"),
                    detail("point"))
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

    Private Sub CalculatePointLeft()
        Dim pointRequired As Integer = 0
        Dim currentPoint As Integer = 0

        Integer.TryParse(PointRequiredLbl.Text, pointRequired)
        Integer.TryParse(CustomerCurrentPointTxt.Text, currentPoint)

        CustomerPointLeftTxt.Text = currentPoint - pointRequired
    End Sub

    Private Sub CustomerCurrentPointTxt_TextChanged(sender As Object, e As EventArgs) Handles CustomerCurrentPointTxt.TextChanged
        CalculatePointLeft()
    End Sub

    Private Sub PointRequiredLbl_TextChanged(sender As Object, e As EventArgs) Handles PointRequiredLbl.TextChanged
        CalculatePointLeft()
    End Sub
End Class