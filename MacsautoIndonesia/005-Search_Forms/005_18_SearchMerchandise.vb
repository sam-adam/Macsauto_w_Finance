﻿Public Class _005_18_SearchMerchandise
    Public Event MerchandiseSelected As EventHandler(Of MerchandiseSelectedEventArgs)

    Private ReadOnly _merchandiseDataTable As DataTable
    Private _merchandiseDataView As DataView

    Public Sub New()
        InitializeComponent()

        _merchandiseDataTable = New DataTable()

        With MerchandiseDataGrid
            .AutoGenerateColumns = False
            .DataSource = _merchandiseDataView
        End With

        ReloadData()

        With MerchandiseDataGrid
            .Columns(MerchandiseIdCol.Index).DataPropertyName = "idmrch"
            .Columns(ProductIdCol.Index).DataPropertyName = "idpdt"
            .Columns(MerchandiseDescriptionCol.Index).DataPropertyName = "pdtds"
            .Columns(MerchandiseStockCol.Index).DataPropertyName = "slqty"
            .Columns(MerchandiseUoMCol.Index).DataPropertyName = "uodsc"
            .Columns(MerchandisePointCol.Index).DataPropertyName = "mpoin"
        End With
    End Sub

    Private Sub ReloadData()
        Const allMerchandisesQuery As String =
            "SELECT hmerchandise.idmrch," & _
            "   hmerchandise.mpoin," & _
            "   hproduct.idpdt," & _
            "   hproduct.idptp," & _
            "   hproduct.iduom," & _
            "   hproduct.pdtds," & _
            "   hproduct.glnum," & _
            "   hproduct.psamt," & _
            "   hproduct.ppamt," & _
            "   hproduct.pdqty," & _
            "   dproduct.slqty," & _
            "   producttype.ptpdc," & _
            "   uom.uodsc" & _
            " FROM hmerchandise" & _
            " LEFT JOIN hproduct ON hmerchandise.idpdt = hproduct.idpdt" & _
            " RIGHT JOIN dproduct ON (hproduct.idpdt = dproduct.idpdt AND dproduct.defsl = 'True')" & _
            " RIGHT JOIN producttype ON hproduct.idptp = producttype.idptp AND producttype.ismrch = 1" & _
            " LEFT JOIN uom ON hproduct.iduom = uom.iduom" & _
            " WHERE hproduct.is_active = 1" & _
            " GROUP BY hmerchandise.idpdt" & _
            " HAVING SUM(dproduct.slqty) > 0"

        _merchandiseDataTable.Rows.Clear()
        _merchandiseDataTable.Load(ExecQueryReader(allMerchandisesQuery))

        _merchandiseDataView = _merchandiseDataTable.AsDataView()

        MerchandiseDataGrid.DataSource = _merchandiseDataView
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub SelectBtn_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        SelectMerchandise()
    End Sub

    Private Sub SelectMerchandise()
        If MerchandiseDataGrid.SelectedCells.Count = 0 Then
            MsgBox("No merchandise selected", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        Else
            RaiseEvent MerchandiseSelected(Me, New MerchandiseSelectedEventArgs(_merchandiseDataTable.Select("idpdt = '" & MerchandiseDataGrid.CurrentRow.Cells(ProductIdCol.Index).Value & "'").FirstOrDefault()))
        End If
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        _merchandiseDataView.RowFilter = "pdtds LIKE '%" & SearchTxt.Text & "%'"
    End Sub

    Private Sub _005_18_SearchMerchandise_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SearchTxt.Focus()
    End Sub

    Private Sub _005_18_SearchMerchandise_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SearchTxt.Text = ""
    End Sub

    Private Sub _005_18_SearchMerchandise_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F5 Then
            SearchTxt.Text = ""

            ReloadData()
        End If
    End Sub

    Private Sub MerchandiseDataGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MerchandiseDataGrid.KeyPress
        If e.KeyChar.SameAsKey(Keys.Enter) Then
            SelectMerchandise()
        End If
    End Sub

    Private Sub MerchandiseDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MerchandiseDataGrid.CellDoubleClick
        SelectMerchandise()
    End Sub
End Class

Public Class MerchandiseSelectedEventArgs
    Inherits EventArgs

    Private ReadOnly _merchandiseDataRow As DataRow

    ReadOnly Property MerchandiseDataRow() As DataRow
        Get
            Return _merchandiseDataRow
        End Get
    End Property

    Public Sub New(ByVal merchandiseDataRow As DataRow)
        _merchandiseDataRow = merchandiseDataRow
    End Sub
End Class