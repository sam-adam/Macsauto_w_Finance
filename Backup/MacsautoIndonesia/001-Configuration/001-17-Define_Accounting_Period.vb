Public Class _001_17_Define_Accounting_Period
    Private Function checkActPeriod()
        reader = ExecQueryReader("SELECT COUNT(*)from pract")
        reader.read()
        If reader(0).ToString = "0" Then
            Return "0"
        Else
            Return "1"
        End If
    End Function
    Public Function getLastCode()
        reader = ExecQueryReader("SELECT *  FROM pract order by acpid desc")
        reader.read()
        Return reader(0).ToString
    End Function
    Public Function CreateNewCode()

        reader = ExecQueryReader("SELECT *  FROM pract order by acpid desc")
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        '  MsgBox(reader(0).ToString.Substring(4, 2))
        If reader.HasRows Then
            lastCode = reader(0).ToString
            newcode = lastCode + 1
        Else
            newcode = "1"
        End If
        Return newcode
    End Function
    Private Sub getAccountingPeriod()
        reader = ExecQueryReader("SELECT * FROM PRACT WHERE ACTIV = '1'")
        reader.read()
        Month.Text = reader(1).ToString
        Year.Text = reader(2).ToString
    End Sub

    Private Sub _001_17_Define_Accounting_Period_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If checkActPeriod() <> 0 Then
            getAccountingPeriod()
            Month.Enabled = False
            Year.Enabled = False
        End If
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim code As String
        code = CreateNewCode()
        If checkActPeriod() = 0 Then
            If MsgBox("Enter Initial accounting period?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("INSERT INTO pract VALUES('" + code + "','" + Month.SelectedItem.ToString + "','" + Year.Text + "','1')")
                MsgBox("Accounting Period Defined")
            End If
        Else
            If MsgBox("Are you sure to close this accounting Period?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("UPDATE pract SET activ = 0 WHERE acpid = '" + getLastCode() + "'")
                Dim nmonth, nyear As String
                nmonth = (Integer.Parse(Month.SelectedItem.ToString) + 1).ToString("00")
                nyear = Year.Text
                If (Integer.Parse(Month.SelectedItem.ToString) + 1) > 12 Then
                    nmonth = "01"
                    nyear = (Integer.Parse(Year.Text) + 1).ToString
                End If
                ExecQueryNonReader("INSERT INTO pract VALUES('" + code + "','" + nmonth + "','" + nyear + "','1')")
                MsgBox("Accounting Period Close")

            End If
        End If
        getAccountingPeriod()
    End Sub
End Class