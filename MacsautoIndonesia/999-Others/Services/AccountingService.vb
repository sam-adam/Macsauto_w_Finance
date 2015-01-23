﻿Imports MySql.Data.MySqlClient

Namespace Services

    Public Class AccountingService
        Public Const JournalStatusAll = 0
        Public Const JournalStatusCancelled = 1
        Public Const JournalStatusNotCancelled = 2

        Private Shared ReadOnly _findJournalQuery As String =
            "SELECT jourhd.docid," & _
            "   jourhd.docdt," & _
            "   jourhd.pstdt," & _
            "   jourhd.rfdoc," & _
            "   jourhd.rmark," & _
            "   jourhd.dstat," & _
            "   jourhd.uname," & _
            "   jourhd.cgdat," & _
            "   jourhd.dtnum," & _
            "   jourhd.cancl," & _
            "   jourdt.glnum," & _
            "   jourdt.pstky," & _
            "   jourdt.psamt," & _
            "   jourdt.notes" & _
            " FROM jourhd" & _
            " LEFT JOIN jourdt ON jourhd.docid = jourdt.docid"

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

        Public Shared Sub ReverseAJournal(ByRef command As MySqlCommand, ByVal journalId As String, ByVal userId As String)
            Dim journalDataTable As DataTable = New DataTable()

            command.CommandText = (_findJournalQuery & " WHERE jourhd.docid = @docid ORDER BY jourhd.docid")
            command.CreateParameter()

            command.Parameters.Clear()
            command.Parameters.AddWithValue("docid", journalId)

            journalDataTable.Load(command.ExecuteReader())

            If journalDataTable.Rows.Count > 0 Then
                Dim journal As DataRow = journalDataTable.Rows(0)

                command.CommandText = "INSERT INTO jourhd(docdt, pstdt, rfdoc, rmark, dstat, uname, cgdat, dtnum, cancl) VALUES(NOW(), NOW(), @referenceDoc, @remark, '', @userId, NOW(), 'AD', 'X')"

                command.Parameters.Clear()
                command.Parameters.AddWithValue("referenceDoc", journal("rfdoc"))
                command.Parameters.AddWithValue("remark", ("REVERSAL OF JOURNAL #" & journal("docid")))
                command.Parameters.AddWithValue("userId", userId)

                command.ExecuteNonQuery()

                command.CommandText = "SELECT docid FROM jourhd ORDER BY docid DESC LIMIT 1"

                Dim newJournalId As String = command.ExecuteScalar().ToString()

                For Each journalDetail As DataRow In journalDataTable.Rows
                    command.CommandText = "INSERT INTO jourdt VALUES(@journalId, @accountId, @postingKey, @postingAmount, '')"

                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("journalId", newJournalId)
                    command.Parameters.AddWithValue("accountId", journalDetail("glnum"))
                    command.Parameters.AddWithValue("postingKey", If(journalDetail("pstky") = "10", "20", "10"))
                    command.Parameters.AddWithValue("postingAmount", journalDetail("psamt"))

                    command.ExecuteNonQuery()
                Next
            End If
        End Sub

        Public Shared Function FindTransactionJournal(ByVal transactionId As String, ByVal journalStatus As Integer) As DataTable
            Dim journalDataTable As DataTable = New DataTable()
            Dim transactionJournalQuery As String = _findJournalQuery

            transactionJournalQuery &= " WHERE rfdoc = '" & transactionId & "'"

            Select Case journalStatus
                Case JournalStatusCancelled
                    transactionJournalQuery &= " AND (jourhd.cancl <> '' OR jourhd.cancl IS NOT NULL)"
                Case JournalStatusNotCancelled
                    transactionJournalQuery &= " AND (jourhd.cancl = '' OR jourhd.cancl IS NULL)"
            End Select

            journalDataTable.Load(ExecQueryReader(transactionJournalQuery))

            Return journalDataTable
        End Function
    End Class
End Namespace