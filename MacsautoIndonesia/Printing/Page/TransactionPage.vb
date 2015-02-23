Imports MacsautoIndonesia.Printing.Page.Content
Imports MacsautoIndonesia.Printing.Renderer
Imports System.Collections.ObjectModel
Imports MacsautoIndonesia.Services

Namespace Printing.Page
    Public Class TransactionPage
        Inherits RollPage

        Private ReadOnly _defaultFont As Font
        Private _transactionDetails As Collection(Of TransactionDetail)
        Private _headerCompanyInfo As Line
        Private _headerTransactionInfo As Line
        Private _content As Line
        Private _separator As Line
        Private _footerPayment As Line
        Private _footerInfo As Line

        Public Sub New(ByVal width As Integer)
            MyBase.New(width, New PanelRenderer())

            _defaultFont = New Font(SystemFonts.DialogFont.FontFamily, 10)
            
            InitializeLines()
            InitializeSeparator()
            InitializeDefaults()
        End Sub

        Public Sub New(ByVal width As Integer, ByVal font As Font)
            MyBase.New(width, New PanelRenderer())

            _defaultFont = font

            InitializeLines()
            InitializeSeparator()
            InitializeDefaults()
        End Sub

        Private Sub InitializeLines()
            _transactionDetails = New Collection(Of TransactionDetail)()
            _headerCompanyInfo = New Line("TRANSACTION COMPANY INFO CONTAINER", _defaultFont)
            _headerTransactionInfo = New Line("TRANSACTION HEADER CONTAINER", _defaultFont)
            _content = New Line("TRANSACTION DETAIL CONTAINER", _defaultFont)
            _footerPayment = New Line("TRANSACTION FOOTER PAYMENT CONTAINER", _defaultFont)
            _footerInfo = New Line("TRANSACTION FOOTER INFO CONTAINER", _defaultFont)

            SetPayment(0, "CASH")
            SetTransactionInformation("-", "-", "-", "-", DateTime.Now, DateTime.Now.ToShortTimeString(), "-")
        End Sub

        Private Sub InitializeSeparator()
            Dim idx As Integer = Width * 2.5
            Dim lineItemWidth As Integer = TextRenderer.MeasureText("-", _defaultFont, New Size(Width, 30)).Width
            Dim line As String = ""

            While idx > 0
                line &= "-"

                idx = idx - lineItemWidth
            End While

            _separator = (New Line("HEADER LINE", _defaultFont).AddText(line, ContentAlignment.MiddleCenter))
        End Sub

        Private Sub InitializeDefaults()
            Dim currentCompany As Company = CompanyService.GetCurrentCompany()

            If Not currentCompany Is Nothing Then
                AppendTitle(currentCompany.Name)
                AppendTitle(currentCompany.Address)

                If Not String.IsNullOrEmpty(currentCompany.Street) Then
                    AppendTitle(currentCompany.Street)
                End If

                AppendTitle("Phone: " & currentCompany.Phone1)

                If Not String.IsNullOrEmpty(currentCompany.Phone2) Then
                    AppendTitle("Hotline: " & currentCompany.Phone2)
                End If

                If Not String.IsNullOrEmpty(currentCompany.Website) Then
                    AppendTitle(currentCompany.Website)
                End If
            End If
        End Sub

        Public Sub AppendTitle(ByVal titleToAppend As String, ByVal fontStyle As FontStyle, ByVal fontSize As Integer)
            _headerCompanyInfo.AddSubLine(New Line("TRANSACTION HEADER LINE", New Font(_defaultFont.FontFamily, fontSize, fontStyle)).AddText(titleToAppend.ToUpperInvariant(), ContentAlignment.MiddleCenter))

            ReloadContent()
        End Sub

        Public Sub AppendTitle(ByVal titleToAppend)
            AppendTitle(titleToAppend, FontStyle.Regular, _defaultFont.Size)
        End Sub

        Public Sub AppendItem(ByVal name As String, ByVal price As Long, ByVal quantity As Integer, Optional ByVal discount As Integer = 0)
            Dim transactionDetail As New TransactionDetail(name, price, quantity, discount)
            _transactionDetails.Add(transactionDetail)

            Dim transactionContainer = New Line("TRANSACTION DETAIL CONTAINER", _defaultFont)
            Dim transactionSubContainer As Line = New Line("TRANSACTION DETAIL SUBCONTAINER", _defaultFont)
            Dim transactionName As Line = New Line("TRANSACTION NAME", _defaultFont).AddText(transactionDetail.Name, ContentAlignment.MiddleLeft)
            Dim transactionQuantityContainer As Line = New Line("TRANSACTION QUANTITY CONTAINER", _defaultFont)
            Dim transactionQuantityAndPrice As Line = New Line("TRANSACTION QUANTITY AND PRICE", _defaultFont, DockStyle.Fill).AddText(transactionDetail.Quantity & " x " & transactionDetail.Price.ToString("N"), ContentAlignment.MiddleLeft, 1)
            Dim transactionDiscount As Line = New Line("TRANSACTION DISCOUNT", _defaultFont, DockStyle.Right).AddText(IIf(transactionDetail.Discount > 0, transactionDetail.Discount & "%", ""), ContentAlignment.MiddleRight)
            Dim transactionSubTotalContainer As Line = New Line("TRANSACTION SUBTOTAL CONTAINER", _defaultFont, DockStyle.Right)
            Dim transactionSubTotal As Line = New Line("TRANSACTION SUBTOTAL", _defaultFont, DockStyle.Fill).AddText(transactionDetail.SubTotal.ToString("N"), ContentAlignment.MiddleRight)
            Dim transactionEqSign As Line = New Line("TRANSACTION EQ LABEL", _defaultFont, DockStyle.Left).AddText("=", ContentAlignment.MiddleLeft)

            transactionSubTotal.Group = "subTotalGroup"

            transactionSubTotalContainer.AddSubLine(transactionSubTotal)
            transactionSubTotalContainer.AddSubLine(transactionEqSign)

            transactionQuantityContainer.AddSubLine(transactionQuantityAndPrice)
            transactionQuantityContainer.AddSubLine(transactionSubTotalContainer)

            If transactionDetail.Discount <> 0 Then
                transactionQuantityContainer.AddSubLine(transactionDiscount)
            End If

            transactionSubContainer.AddSubLine(transactionName)
            transactionSubContainer.AddSubLine(transactionQuantityContainer)

            transactionContainer.AddSubLine(transactionSubContainer)

            _content.AddSubLine(transactionContainer)

            SetPayment(0, "CASH")

            ReloadContent()
        End Sub

        Public Sub AppendFooter(ByVal footerToAppend As String)
            _footerInfo.AddSubLine(New Line(_defaultFont).AddText(footerToAppend.ToUpperInvariant(), ContentAlignment.MiddleCenter))

            ReloadContent()
        End Sub

        Public Sub SetPayment(ByVal paymentAmount As Long, ByVal paymentType As String)
            _footerPayment = New Line("TRANSACTION FOOTER PAYMENT CONTAINER", _defaultFont)
            _footerPayment.Margin = New Padding(0, 15, 0, 5)

            Dim transactionGrandTotalAmount As Long = _transactionDetails.Sum(Function(transactionDetail) transactionDetail.SubTotal)
            Dim transactionGrandTotalSeparator As Line = New Line("TRANSACTION GRANDTOTAL SEPARATOR", _defaultFont).AddText("-----------------", ContentAlignment.MiddleRight)
            Dim transactionGrandTotal As Line = New Line("TRANSACTION GRAND TOTAL", _defaultFont).AddText(transactionGrandTotalAmount.ToString("N"), ContentAlignment.MiddleRight)
            Dim transactionPaymentAmount As Line = New Line("TRANSACTION PAYMENT CONTAINER", _defaultFont).AddSubLine(
                New Line("TRANSACTION PAYMENT LABEL", _defaultFont, DockStyle.Left).AddText(paymentType.ToUpperInvariant(), ContentAlignment.MiddleLeft)).AddSubLine(
                New Line("TRANSACTION PAYMENT AMOUNT", _defaultFont, DockStyle.Fill).AddText(paymentAmount.ToString("N"), ContentAlignment.MiddleRight))
            Dim transactionChangeAmount As Line = New Line("TRANSACTION CHANGE CONTAINER", _defaultFont).AddSubLine(
                New Line("TRANSACTION CHANGE LABEL", _defaultFont, DockStyle.Left).AddText("CHANGE", ContentAlignment.MiddleLeft)).AddSubLine(
                New Line("TRANSACTOIN CHANGE AMOUNT", _defaultFont, DockStyle.Fill).AddText((paymentAmount - transactionGrandTotalAmount).ToString("N"), ContentAlignment.MiddleRight))

            _footerPayment.AddSubLine(transactionGrandTotalSeparator)
            _footerPayment.AddSubLine(transactionGrandTotal)
            _footerPayment.AddSubLine(transactionPaymentAmount)
            _footerPayment.AddSubLine(transactionChangeAmount)
        End Sub

        Public Sub SetPayment(ByVal paymentAmount As Long, ByVal paymentType As String, ByVal pointsEarned As String, ByVal totalPoints As String, ByVal expired As String)
            SetPayment(paymentAmount, paymentType)

            Dim pointsEarnedContainer As Line = New Line("POINTS EARNED CONTAINER", _defaultFont).AddSubLine(
                New Line("POINTS EARNED LABEL", _defaultFont, DockStyle.Left).AddText("POINTS EARNED", ContentAlignment.MiddleLeft)).AddSubLine(
                New Line("POINTS EARNED AMOUNT", _defaultFont, DockStyle.Fill).AddText(pointsEarned, ContentAlignment.MiddleRight))
            Dim totalPointsContainer As Line = New Line("TOTAL POINTS CONTAINER", _defaultFont).AddSubLine(
                New Line("TOTAL POINTS LABEL", _defaultFont, DockStyle.Left).AddText("TOTAL POINTS", ContentAlignment.MiddleLeft)).AddSubLine(
                New Line("TOTAL POINTS AMOUNT", _defaultFont, DockStyle.Fill).AddText(totalPoints, ContentAlignment.MiddleRight))
            Dim expiredContainer As Line = New Line("EXPIRED CONTAINER", _defaultFont).AddSubLine(
                New Line("EXPIRED LABEL", _defaultFont, DockStyle.Left).AddText("POINTS EXPIRED ON", ContentAlignment.MiddleLeft)).AddSubLine(
                New Line("EXPIRED DATE", _defaultFont, DockStyle.Fill).AddText(expired, ContentAlignment.MiddleRight))

            _footerPayment.AddSubLine(_separator)
            _footerPayment.AddSubLine(pointsEarnedContainer)
            _footerPayment.AddSubLine(totalPointsContainer)
            _footerPayment.AddSubLine(expiredContainer)
        End Sub

        Public Sub SetTransactionInformation(ByVal transactionId As String, ByVal vehicleRegistration As String, ByVal vehicleBrand As String, ByVal vehicleModel As String, ByVal transactionDate As String, ByVal transactionTime As String, Optional ByVal cashier As String = Nothing)
            _headerTransactionInfo = New Line("TRANSACTION HEADER INFORMATION", _defaultFont)

            If cashier Is Nothing Then
                cashier = LoggedInEmployee.Name.ToUpperInvariant()

                If cashier.Length > 8 Then
                    cashier = cashier.Substring(0, 8)
                End If
            End If

            Dim transactionInfoTopContainer As Line = New Line("TRANSACTION NUMBER AND DATE CONTAINER", _defaultFont)
            Dim transactionNumber As Line = New Line("TRANSACTION NUMBER", _defaultFont, DockStyle.Top).AddText(transactionId, ContentAlignment.MiddleLeft)
            Dim transactionCashier As Line = New Line("TRANSACTION CASHIER", _defaultFont, DockStyle.Top).AddText("CASHIER : " & cashier, ContentAlignment.MiddleLeft)

            transactionInfoTopContainer.AddSubLine(transactionNumber)
            transactionInfoTopContainer.AddSubLine(transactionCashier)

            Dim transactionDateTimeContainer As Line = New Line("TRANSACTION DATETIME CONTAINER", _defaultFont)
            Dim transactionDateLine As Line = New Line("TRANSACTION DATE", _defaultFont, DockStyle.Fill).AddText("DATE : " & transactionDate, ContentAlignment.MiddleLeft)
            Dim transactionTimeLine As Line = New Line("TRANSACTION TIME", _defaultFont, DockStyle.Right).AddText("TIME : " & transactionTime, ContentAlignment.MiddleRight)

            transactionDateTimeContainer.AddSubLine(transactionDateLine)
            transactionDateTimeContainer.AddSubLine(transactionTimeLine)

            Dim vehicleBrandAndModelText As String = "MODEL : " & vehicleModel & ", " & vehicleBrand

            If vehicleBrandAndModelText.Length > 35 Then
                vehicleBrandAndModelText = vehicleBrandAndModelText.Substring(0, 30)
            End If

            Dim vehicleDataContainer As Line = New Line("VEHICLE DATA CONTAINER", _defaultFont)
            Dim vehicleRegistrationLine As Line = New Line("VEHICLE REGISTRATION", _defaultFont, DockStyle.Right).AddText("REG NUM : " & vehicleRegistration, ContentAlignment.MiddleRight)
            Dim vehicleBrandAndModel As Line = New Line("VEHICLE BRAND AND MODEL", _defaultFont, DockStyle.Fill).AddText(vehicleBrandAndModelText, ContentAlignment.MiddleLeft)

            vehicleDataContainer.AddSubLine(vehicleBrandAndModel)
            vehicleDataContainer.AddSubLine(vehicleRegistrationLine)

            _headerTransactionInfo.AddSubLine(transactionInfoTopContainer)
            _headerTransactionInfo.AddSubLine(transactionDateTimeContainer)
            _headerTransactionInfo.AddSubLine(vehicleDataContainer)
        End Sub

        Private Sub ReloadContent()
            Content = New Line("MAIN CONTAINER", _defaultFont) _
                        .AddSubLine(_headerCompanyInfo) _
                        .AddSubLine(_separator) _
                        .AddSubLine(_headerTransactionInfo) _
                        .AddSubLine(_separator) _
                        .AddSubLine(_content) _
                        .AddSubLine(_footerPayment) _
                        .AddSubLine(_footerInfo)
        End Sub
    End Class

    Class TransactionDetail
        Private ReadOnly _name As String
        Private ReadOnly _price As Long
        Private ReadOnly _quantity As Integer
        Private ReadOnly _discount As Integer

        Sub New(ByVal name As String, ByVal price As Long, ByVal quantity As Integer, ByVal discount As Integer)
            _name = name.ToUpperInvariant()
            _price = price
            _quantity = quantity
            _discount = discount
        End Sub

        ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property

        ReadOnly Property Price() As Long
            Get
                Return _price
            End Get
        End Property

        ReadOnly Property Quantity() As Integer
            Get
                Return _quantity
            End Get
        End Property

        ReadOnly Property Discount() As Integer
            Get
                Return _discount
            End Get
        End Property

        ReadOnly Property SubTotal() As Long
            Get
                Return (_price * _quantity) * ((100 - _discount) / 100)
            End Get
        End Property
    End Class
End Namespace