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
    End Class
End Namespace