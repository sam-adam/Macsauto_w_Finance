Imports MySql.Data.MySqlClient

Public Class _005_11_GLAccount
    Private ReadOnly _dataTable As DataTable

    Public Event AccountSelected As EventHandler(Of SelectedAccountEventArgs)

    Public Sub New()
        InitializeComponent()

        _dataTable = New DataTable()
        _dataTable.Load(ExecQueryReader("SELECT glnum, gldes, actid, ispnl, glsta FROM glaccountms WHERE glsta = 'Active'"))

        Dim reader As MySqlDataReader = ExecQueryReader("SELECT actid, actds FROM accounttype")

        TreeView1.Nodes.Clear()

        While reader.Read()
            Dim newNode As TreeNode = TreeView1.Nodes.Add(reader("actid").ToString(), reader("actid").ToString() & " - " & reader("actds").ToString())

            For Each row As DataRow In _dataTable.Select("actid = " & reader("actid").ToString())
                newNode.Nodes.Add(row("glnum"), row("glnum") & " - " & row("gldes"))
            Next
        End While
    End Sub

    Private Sub TreeView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDoubleClick
        If TreeView1.SelectedNode.Level > 0 Then
            TrySetSelectedAccount()
        End If
    End Sub

    Private Sub TreeView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TreeView1.KeyPress
        If TreeView1.SelectedNode.Level > 0 Then
            TrySetSelectedAccount()
        End If
    End Sub

    Private Sub TrySetSelectedAccount()
        Dim selectedNode As TreeNode = TreeView1.SelectedNode

        If selectedNode.Level = 0 Then
            MsgBox("You cannot select Account Type, please select a GL Account")
        Else
            Dim selectedAccount As DataRow = _dataTable.Select("glnum = '" & selectedNode.Name & "'").First()

            RaiseEvent AccountSelected(Me, New SelectedAccountEventArgs(selectedAccount("glnum").ToString(), selectedAccount("gldes").ToString(), selectedAccount("ispnl").ToString() = "X"))
        End If
    End Sub

    Private Sub _005_11_GLAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class SelectedAccountEventArgs
    Inherits EventArgs

    Public Sub New(ByVal accountNumber As String, ByVal accountDescription As String, ByVal isProfitAndLoss As Boolean)
        Me.AccountNumber = accountNumber
        Me.AccountDescription = accountDescription
        Me.IsProfitAndLoss = isProfitAndLoss
    End Sub

    Property AccountNumber() As String
    Property AccountDescription() As String
    Property IsProfitAndLoss() As Boolean
End Class