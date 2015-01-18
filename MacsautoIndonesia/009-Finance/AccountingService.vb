Public Class AccountingService
    Public Shared Function GetAllPeriods() As DataTable
        Dim allPeriodQuery As String = "SELECT acpid, acyer, acmon, activ FROM pract"
        Dim allPeriodDataTable As DataTable = New DataTable()

        allPeriodDataTable.Load(ExecQueryReader(allPeriodQuery))

        Return allPeriodDataTable
    End Function

    Public Shared Function GetActivePeriod()
        For Each period As DataRow In GetAllPeriods().Rows
            If period("activ") Then
                Return period
            End If
        Next

        Return Nothing
    End Function
End Class