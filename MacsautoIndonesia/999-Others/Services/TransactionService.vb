Imports MySql.Data.MySqlClient

Namespace Services
    Public Class TransactionService
        Const TransactionIdFormat As String = "{0:000}/{1:00}-{2:0000}/{3:0000}/{4:000}"
        Const PaymentIdFormat As String = "P{0:00}{1:000}.{2:00000}"

        Public Shared Function GetNewTransactionId(Optional ByRef command As MySqlCommand = Nothing) As String
            If command Is Nothing Then
                command = New MySqlCommand()
                command.Connection = GetConnection()
            End If

            Dim totalDailyTransactions As Integer = 0
            Dim totalMonthlyTransactions As Integer = 0

            command.CommandText = "SELECT COUNT(trsid) AS total_daily_transaction FROM htransaction WHERE DATE(trdat) = DATE(NOW())"
            totalDailyTransactions = Integer.Parse(command.ExecuteScalar())

            command.CommandText = "SELECT COUNT(trsid) AS total_monthly_transaction FROM htransaction WHERE MONTH(trdat) = MONTH(NOW())"
            totalMonthlyTransactions = Integer.Parse(command.ExecuteScalar())

            Return String.Format(TransactionIdFormat, LoggedInEmployee.Company.Id, DateTime.Now.Month, DateTime.Now.Year, (totalMonthlyTransactions + 1), (totalDailyTransactions + 1))
        End Function

        Public Shared Function GetNewPaymentId(Optional ByRef command As MySqlCommand = Nothing) As String
            If command Is Nothing Then
                command = New MySqlCommand()
                command.Connection = GetConnection()
            End If

            Dim totalAnnualPayment = 0

            command.CommandText = "SELECT COUNT(payid) AS total_annual_payment FROM payment WHERE YEAR(pydat) = YEAR(NOW())"
            totalAnnualPayment = Integer.Parse(command.ExecuteScalar())

            Return String.Format(PaymentIdFormat, DateTime.Now.ToString("yy"), LoggedInEmployee.Company.Id, (totalAnnualPayment + 1))
        End Function

        Public Shared Function CheckPointExpiry(ByRef command As MySqlCommand, ByVal customerId As String) As Boolean
            Dim pointsSetExpired As Boolean = False

            command.CommandText = "SELECT cpoin FROM hcustomer WHERE idcus = @customerId"
            command.CreateParameter()

            command.Parameters.AddWithValue("customerId", customerId)

            Dim currentPoint As Integer = command.ExecuteScalar()

            If currentPoint > 0 Then
                command.CommandText = "SELECT DATEDIFF(NOW(), htransaction.trdat) AS last_transaction FROM htransaction WHERE htransaction.idcus = @customerId ORDER BY htransaction.trdat DESC LIMIT 1"
                Dim lastTransaction As Integer = command.ExecuteScalar()

                command.CommandText = "SELECT DATEDIFF(NOW(), hredemption.rdmpdat) AS last_redemption FROM hredemption WHERE hredemption.idcus = @customerId ORDER BY hredemption.rdmpdat DESC LIMIT 1"
                Dim lastRedemption As Integer = command.ExecuteScalar()

                If lastTransaction > 365 Or lastRedemption > 365 Then
                    MsgBox("Last transaction is more than 1 year. Points will be set expired.", MsgBoxStyle.OkOnly, "Warning")

                    command.CommandText = "INSERT INTO pointtrans(idcus, trpon, trtype) VALUES(@customerId, @points, @type)"
                    command.Parameters.AddWithValue("customerId", customerId)
                    command.Parameters.AddWithValue("points", currentPoint)
                    command.Parameters.AddWithValue("type", "SUB")
                    command.ExecuteNonQuery()

                    command.CommandText = "UPDATE cpoin FROM hcustomer WHERE idcus = @customerId"
                    command.ExecuteNonQuery()

                    pointsSetExpired = True

                    MsgBox(currentPoint & " is set expired successfully.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Success")
                End If
            End If

            Return pointsSetExpired
        End Function

        Public Shared Function CalculatePointsEarned(ByVal grandTotal As Double, Optional ByRef command As MySqlCommand = Nothing) As Integer
            If command Is Nothing Then
                command = New MySqlCommand()
                command.Connection = GetConnection()
            End If

            command.CommandText = "SELECT pbase FROM basepoint"

            Dim basePoint As Double = Double.Parse(command.ExecuteScalar())

            Return Math.Abs(Math.Floor(grandTotal / basePoint))
        End Function

        Public Shared Function CalculatePromotion(ByVal price As Double, ByVal promotion As DataRow) As Double
            If promotion("ptype") = "3001" Then
                Dim newPrice As Double = (price - promotion("pdamt"))

                Return If(newPrice < 0, 0, newPrice)
            Else
                Return (price * ((100 - promotion("pdpct")) / 100))
            End If
        End Function

        Public Shared Function FindBestPromotion(ByVal nonMemberOnly As Boolean, ByVal itemId As String, ByVal itemType As String, ByVal itemPrice As Double, Optional ByRef command As MySqlCommand = Nothing) As DataRow
            If command Is Nothing Then
                command = New MySqlCommand()
                command.Connection = GetConnection()
            End If

            Dim promotionDataTable As DataTable = New DataTable()
            Dim bestPromotionDataRow As DataRow = Nothing

            command.CommandText =
                "SELECT promotion.idpmt," & _
                "   promotion.pmdcp," & _
                "   promotion.ptype," & _
                "   promotion.pdamt," & _
                "   promotion.pdpct," & _
                "   promoassignment.atype," & _
                "   promoassignment.iditm," & _
                "   promoassignment.idpmt," & _
                "   promoassignment.begda," & _
                "   promoassignment.endda," & _
                "   promoassignment.astat," & _
                "   promoassignment.ismem" & _
                " FROM promoassignment" & _
                " LEFT JOIN promotion ON promoassignment.idpmt = promotion.idpmt" & _
                " WHERE DATE(NOW()) BETWEEN promoassignment.begda AND promoassignment.endda" & _
                " AND promoassignment.astat = 'True'" & _
                " AND promoassignment.atype = @itemType" & _
                " AND promoassignment.iditm = @itemId" & _
                " AND promoassignment.ismem = @isMember"
            command.CreateParameter()

            command.Parameters.Clear()
            command.Parameters.AddWithValue("itemType", itemType)
            command.Parameters.AddWithValue("itemId", itemId)
            command.Parameters.AddWithValue("isMember", nonMemberOnly)

            promotionDataTable.Load(command.ExecuteReader())

            For Each promotion As DataRow In promotionDataTable.Rows
                If bestPromotionDataRow Is Nothing Then
                    bestPromotionDataRow = promotion
                ElseIf CalculatePromotion(itemPrice, bestPromotionDataRow) < CalculatePromotion(itemPrice, promotion) Then
                    bestPromotionDataRow = promotion
                End If
            Next

            Return bestPromotionDataRow
        End Function

        Public Shared Function IsAutopostReady() As Boolean
            Return AccountingService.IsConfigurationValid("transaction_cash") And
                AccountingService.IsConfigurationValid("transaction_card") And
                AccountingService.IsConfigurationValid("transaction_cogs") And
                AccountingService.IsConfigurationValid("transaction_product_revenue")
        End Function
    End Class
End Namespace