Public Class _003_01_04_CreatePayment
    Public Event PaymentSubmitted As EventHandler(Of PaymentSubmittedEventArgs)

    Property GrandTotal() As Double
        Set(value As Double)
            GrandTotalLbl.Text = value.ToString("N0")
        End Set
        Get
            Return If(String.IsNullOrEmpty(GrandTotalLbl.Text), 0, Double.Parse(GrandTotalLbl.Text))
        End Get
    End Property

    ReadOnly Property SelectedPaymentType As String
        Get
            If CashRadio.Checked Then
                Return "Cash"
            ElseIf DebitRadio.Checked Then
                Return "Debit"
            Else
                Return "Credit"
            End If
        End Get
    End Property

    ReadOnly Property CashPayment As Double
        Get
            Return Double.Parse(CashPaymentTxt.Text)
        End Get
    End Property

    ReadOnly Property CashChange() As Double
        Get
            Return Double.Parse(ChangeLbl.Text)
        End Get
    End Property

    ReadOnly Property DebitCardNumber() As String
        Get
            Return DebitCardTxt.Text
        End Get
    End Property

    ReadOnly Property CreditCardNumber() As String
        Get
            Return CreditCardTxt.Text
        End Get
    End Property

    Public Sub New(ByVal currentGrandTotal As Double)
        InitializeComponent()

        CashPaymentTxt.ValidateIntegerInput()

        CashRadio.Checked = True

        GrandTotal = currentGrandTotal

        UpdatePanel()

        CashPaymentTxt.Focus()
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        If SelectedPaymentType = "Cash" AndAlso CashPayment < GrandTotal Then
            ErrorInput(CashPaymentTxt, "Not enough payment")
        ElseIf SelectedPaymentType = "Debit" AndAlso String.IsNullOrEmpty(DebitCardTxt.Text) Then
            ErrorInput(DebitCardTxt, "Debit card number is required")
        ElseIf SelectedPaymentType = "Credit" AndAlso String.IsNullOrEmpty(CreditCardTxt.Text) Then
            ErrorInput(CreditCardTxt, "Credit card number is required")
        ElseIf MsgBox("Finish payment?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") Then
            RaiseEvent PaymentSubmitted(Me, New PaymentSubmittedEventArgs(Me))
        End If
    End Sub

    Private Sub CashPaymentTxt_TextChanged(sender As Object, e As EventArgs) Handles CashPaymentTxt.TextChanged
        If Not String.IsNullOrEmpty(GrandTotal) Then
            ChangeLbl.Text = If(CashPayment <= GrandTotal, 0, CashPayment - GrandTotal).ToString("N0")
        End If
    End Sub

    Private Sub UpdatePanel()
        DebitPnl.Visible = DebitRadio.Checked
        CashPnl.Visible = CashRadio.Checked
        CreditPnl.Visible = CreditRadio.Checked
    End Sub

    Private Sub CashRadio_CheckedChanged(sender As Object, e As EventArgs) Handles CashRadio.CheckedChanged
        UpdatePanel()
    End Sub

    Private Sub DebitRadio_CheckedChanged(sender As Object, e As EventArgs) Handles DebitRadio.CheckedChanged
        UpdatePanel()
    End Sub

    Private Sub CreditRadio_CheckedChanged(sender As Object, e As EventArgs) Handles CreditRadio.CheckedChanged
        UpdatePanel()
    End Sub

    Private Sub CashPnl_Enter(sender As Object, e As EventArgs) Handles CashPnl.Enter
        CashPaymentTxt.Focus()
    End Sub

    Private Sub DebitPnl_Enter(sender As Object, e As EventArgs) Handles DebitPnl.Enter
        DebitCardTxt.Focus()
    End Sub

    Private Sub CreditPnl_Enter(sender As Object, e As EventArgs) Handles CreditPnl.Enter
        CreditCardTxt.Focus()
    End Sub

    Private Sub CashPnl_VisibleChanged(sender As Object, e As EventArgs) Handles CashPnl.VisibleChanged
        If CashPnl.Visible Then
            CashPaymentTxt.Focus()
        End If
    End Sub

    Private Sub DebitPnl_VisibleChanged(sender As Object, e As EventArgs) Handles DebitPnl.VisibleChanged
        If DebitPnl.Visible Then
            DebitCardTxt.Focus()
        End If
    End Sub

    Private Sub CreditPnl_VisibleChanged(sender As Object, e As EventArgs) Handles CreditPnl.VisibleChanged
        If CreditPnl.Visible Then
            CreditCardTxt.Focus()
        End If
    End Sub

    Private Sub _003_08_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CashPaymentTxt.Focus()
    End Sub

    Private Sub _003_08_Payment_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If CashPnl.Visible Then
            CashPaymentTxt.Focus()
        End If
    End Sub
End Class

Public Class PaymentSubmittedEventArgs
    Inherits EventArgs

    Private ReadOnly _createPaymentForm As _003_01_04_CreatePayment

    ReadOnly Property CreatePaymentForm() As _003_01_04_CreatePayment
        Get
            Return _createPaymentForm
        End Get
    End Property

    Public Sub New(ByVal createPaymentForm As _003_01_04_CreatePayment)
        _createPaymentForm = createPaymentForm
    End Sub
End Class

Public Enum PaymentType
    Cash
    DebitCard
    CreditCard
End Enum