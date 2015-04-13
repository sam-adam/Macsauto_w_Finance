Imports MacsautoIndonesia.Printing.Page.Content
Imports MacsautoIndonesia.Printing.Renderer
Imports MacsautoIndonesia.Services

Namespace Printing.Page
    Public Class RedemptionPage
        Inherits RollPage

        Private ReadOnly _defaultFont As Font

        Private _customerId As Line
        Private _customerName As Line
        Private _pointsEarned As Line
        Private _totalPoints As Line
        Private _pointsExpire As Line
        Private _headerCompanyInfo As Line
        Private _headerTransactionInfo As Line
        Private _separator As Line
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
            _customerId = New Line("CUSTOMER ID CONTAINER", _defaultFont)
            _customerName = New Line("CUSTOMER NAME CONTAINER", _defaultFont)
            _pointsEarned = New Line("POINTS EARNED CONTAINER", _defaultFont)
            _totalPoints = New Line("TOTAL POINTS CONTAINER", _defaultFont)
            _pointsExpire = New Line("POINTS EXPIRE CONTAINER", _defaultFont)

            _headerCompanyInfo = New Line("TRANSACTION COMPANY INFO CONTAINER", _defaultFont)
            _headerTransactionInfo = New Line("TRANSACTION HEADER CONTAINER", _defaultFont)
            _footerInfo = New Line("TRANSACTION FOOTER CONTAINER", _defaultFont)
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

        Public Sub SetData(ByVal customerId As String, ByVal customerName As String, ByVal pointsUsed As String, ByVal totalPoints As String, ByVal pointsExpire As String)
            _customerName.AddSubLine(New Line("CUSTOMER NAME", _defaultFont, DockStyle.Left).AddText("CUSTOMER :", ContentAlignment.MiddleLeft)) _
                .AddSubLine(New Line("CUSTOMER NAME VALUE", _defaultFont, DockStyle.Fill).AddText(customerId.ToUpperInvariant() & " - " & customerName.ToUpperInvariant(), ContentAlignment.MiddleRight))
            _pointsEarned.AddSubLine(New Line("POINTS EARNED", _defaultFont, DockStyle.Left).AddText("POINTS USED: ", ContentAlignment.MiddleLeft)) _
                .AddSubLine(New Line("POINTS EARNED VALUE", _defaultFont, DockStyle.Fill).AddText(pointsUsed, ContentAlignment.MiddleRight))
            _totalPoints.AddSubLine(New Line("TOTAL POINTS", _defaultFont, DockStyle.Left).AddText("TOTAL POINTS: ", ContentAlignment.MiddleLeft)) _
                .AddSubLine(New Line("TOTAL POINTS VALUE", _defaultFont, DockStyle.Fill).AddText(totalPoints, ContentAlignment.MiddleRight))
            _pointsExpire.AddSubLine(New Line("POINTS EXPIRE", _defaultFont, DockStyle.Left).AddText("POINTS EXPIRED ON: ", ContentAlignment.MiddleLeft)) _
                .AddSubLine(New Line("POINTS EXPIRE VALUE", _defaultFont, DockStyle.Fill).AddText(pointsExpire, ContentAlignment.MiddleRight))

            ReloadContent()
        End Sub

        Public Sub AppendFooter(ByVal footerToAppend As String)
            _footerInfo.AddSubLine(New Line(_defaultFont).AddText(footerToAppend.ToUpperInvariant(), ContentAlignment.MiddleCenter))

            ReloadContent()
        End Sub

        Public Sub SetTransactionInformation(ByVal transactionId As String, ByVal transactionDate As String, ByVal transactionTime As String, Optional ByVal cashier As String = Nothing)
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

            _headerTransactionInfo.AddSubLine(transactionInfoTopContainer)
            _headerTransactionInfo.AddSubLine(transactionDateTimeContainer)
        End Sub

        Private Sub ReloadContent()
            Content = New Line("MAIN CONTAINER", _defaultFont) _
                        .AddSubLine(_headerCompanyInfo) _
                        .AddSubLine(_separator) _
                        .AddSubLine(_headerTransactionInfo) _
                        .AddSubLine(_separator) _
                        .AddSubLine(
                            New Line("CONTENT CONTAINER", _defaultFont) _
                                .AddSubLine(_customerId) _
                                .AddSubLine(_customerName) _
                                .AddSubLine(_pointsEarned) _
                                .AddSubLine(_totalPoints) _
                                .AddSubLine(_pointsExpire)
                        ) _
                        .AddSubLine(_separator) _
                        .AddSubLine(_footerInfo) _
                        .AddSubLine(New Line(_defaultFont).AddText(" ", ContentAlignment.MiddleCenter)) _
                        .AddSubLine(New Line(_defaultFont).AddText(" ", ContentAlignment.MiddleCenter))
        End Sub
    End Class
End Namespace