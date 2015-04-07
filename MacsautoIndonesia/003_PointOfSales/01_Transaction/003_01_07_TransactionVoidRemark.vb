Public Class _003_01_07_TransactionVoidRemark
    Public Event ReasonSubmitted As EventHandler

    ReadOnly Property VoidReason() As String
        Get
            Return VoidReasonTxt.Text
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub _003_09_Void_Remark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VoidReasonTxt.Focus()
    End Sub

    Private Sub VoidBtn_Click(sender As Object, e As EventArgs) Handles VoidBtn.Click
        If String.IsNullOrEmpty(VoidReasonTxt.Text) Then
            ErrorInput(VoidReasonTxt, "Void reason is required")
        Else
            RaiseEvent ReasonSubmitted(Me, New EventArgs())
        End If
    End Sub
End Class