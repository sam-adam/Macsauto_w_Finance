Public Class _008_08_TransactionList
    Public Sub loadTransactionList(ByVal status As String)
        TrlistGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM HTRANSACTION WHERE trstat LIKE '" + status + "' order by trdat,trsid desc")
        While reader.read
            TrlistGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9).ToString, reader(10).ToString, reader(11).ToString, reader(12).ToString, reader(13).ToString, reader(14).ToString, reader(15).ToString, reader(16).ToString, reader(17).ToString, reader(18).ToString)
        End While
        Marking(TrlistGrid)
    End Sub
    Private Sub _008_08_TransactionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TrlistGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM HTRANSACTION order by trdat,trsid desc")
        While reader.read
            TrlistGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9).ToString, reader(10).ToString, reader(11).ToString, reader(12).ToString, reader(13).ToString, reader(14).ToString, reader(15).ToString, reader(16).ToString, reader(17).ToString, reader(18).ToString)
        End While
        Marking(TrlistGrid)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        loadTransactionList("Paid")

    End Sub

    
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        loadTransactionList("Void")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TrlistGrid.Rows.Clear()
        reader = ExecQueryReader("SELECT * FROM HTRANSACTION   order by trdat,trsid desc")
        While reader.read
            TrlistGrid.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4).ToString, reader(5).ToString, reader(6).ToString, reader(7).ToString, reader(8).ToString, reader(9).ToString, reader(10).ToString, reader(11).ToString, reader(12).ToString, reader(13).ToString, reader(14).ToString, reader(15).ToString, reader(16).ToString, reader(17).ToString, reader(18).ToString)
        End While
        Marking(TrlistGrid)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        loadTransactionList("Open")

    End Sub
End Class