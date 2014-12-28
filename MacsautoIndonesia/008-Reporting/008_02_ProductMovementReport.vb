Imports MySql.Data.MySqlClient

Public Class _008_02_ProductMovement
    Private products As List(Of KeyValuePair(Of String, String))

    Public Sub New()
        Dim query As String
        Dim reader As MySqlDataReader

        query = "SELECT idpdt, pdtds" & _
                " FROM hproduct"
        reader = ExecQueryReader(query)
        products = New List(Of KeyValuePair(Of String, String))()

        While reader.Read()
            products.Add(New KeyValuePair(Of String, String)(reader(0).ToString(), reader(1).ToString()))
        End While

        InitializeComponent()

        For Each keyValuePair As KeyValuePair(Of String,String) In products
            ComboBox1.Items.Add(keyValuePair)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadReport(GetSelectedProduct().Key, DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReport(GetSelectedProduct().Key, DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport(GetSelectedProduct().Key, DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Function GetSelectedProduct() As KeyValuePair(Of String, String)
        Dim selectedProduct As KeyValuePair(Of String, String) = Nothing

        For Each product As KeyValuePair(Of String, String) In products
            If product.Key = CType(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key Then
                selectedProduct = product
            End If
        Next

        Return selectedProduct
    End Function

    Private Sub LoadReport(ByVal product As String, ByVal from As DateTime, ByVal until As DateTime)
        Dim query As String
        Dim reader As MySqlDataReader

        query = "SELECT (incomingMovement.total - outgoingMovement.total - transaction.total) AS totalMovement" & _
                " FROM (SELECT IFNULL(SUM(qty), 0) AS total" & _
                " FROM (" & GetProductMovements(product, from.AddDays(-1)) & ") movementIn" & _
                " WHERE type = 'Initial Stock Balance' OR type = 'Goods Receipt') incomingMovement" & _
                " , (SELECT IFNULL(SUM(qty), 0) AS total" & _
                " FROM (" & GetProductMovements(product, from.AddDays(-1)) & ") movementOut" & _
                " WHERE type = 'Goods Issue') outgoingMovement" & _
                " , (SELECT IFNULL(SUM(qty), 0) AS total" & _
                " FROM (" & GetProductTransactions(product, from.AddDays(-1)) & ") transaction) transaction"
        reader = ExecQueryReader(query)

        While reader.Read()
            LblOpeningBalance.Text = "Opening balance: " & reader(0)
        End While

        query = "SELECT allMovements.type, allMovements.id, SUM(allMovements.qty) AS qty, allMovements.date, allMovements.remark FROM" & _
                " ((SELECT movement.type AS type, movement.id, movement.qty, movement.date, movement.remark" & _
                " FROM (" & GetProductMovements(product, until, from) & ") movement)" & _
                " UNION" & _
                " (SELECT 'Transaction' AS type, transaction.id, transaction.qty, transaction.date, transaction.remark" & _
                " FROM (" & GetProductTransactions(product, until, from) & ") transaction)) AS allMovements" & _
                " GROUP BY allMovements.id" & _
                " ORDER BY allMovements.date ASC"
        reader = ExecQueryReader(query)

        DataGridView.Rows.Clear()

        While reader.Read()
            DataGridView.Rows.Add(reader("type").ToString(), reader("id").ToString(), reader("qty"), Convert.ToDateTime(reader("date").ToString()).ToString("dd/MM/yyyy"), reader("remark").ToString())
        End While
    End Sub

    Private Function GetProductMovements(ByVal product As String, ByVal before As DateTime, Optional ByVal after As DateTime = Nothing) As String
        Return "SELECT hmove.pmvid as id, dmove.mvqty AS qty, hmove.mtype AS type, hmove.mdate AS date, IFNULL(hmove.reamv, '') AS remark" & _
                " FROM hpmovement hmove" & _
                " JOIN dpmovement dmove ON hmove.pmvid = dmove.pmvid" & _
                " WHERE hmove.mdate <= '" & before.ToString("yyyy-MM-dd") & "'" & _
                IIf(after <> Nothing, " AND hmove.mdate >= '" & after.ToString("yyyy-MM-dd") & "'", "") & _
                " AND dmove.idpdt = '" & product & "'"
    End Function

    Private Function GetProductTransactions(ByVal product As String, ByVal before As DateTime, Optional ByVal after As DateTime = Nothing) As String
        Return "SELECT htrans.trsid as id, dtrans.trqty as qty, htrans.trdat as date, IFNULL(dtrans.rmark, '') AS remark" & _
               " FROM htransaction htrans" & _
               " JOIN dtransaction dtrans ON htrans.trsid = dtrans.trsid" & _
               " WHERE htrans.trdat <= '" & before.ToString("yyyy-MM-dd") & "'" & _
               IIf(after <> Nothing, " AND htrans.trdat >= '" & after.ToString("yyyy-MM-dd") & "'", "") & _
               " AND dtrans.idpdt = '" & product & "'"
    End Function

    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click
        excelExport(DataGridView, "ProductMovementReport (" & DateTimePicker1.Value.ToString("ddMMyyyy") & " - " & DateTimePicker2.Value.ToString("ddMMyyyy") & ")")
    End Sub
End Class