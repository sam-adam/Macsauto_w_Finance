Public Class _009_02_Journal_Transaction
    Private ReadOnly _accountSearchForm As _005_11_GLAccount

    Public Sub New()
        InitializeComponent()

        _accountSearchForm = New _005_11_GLAccount()

        AddHandler _accountSearchForm.AccountSelected, AddressOf _accountSearchForm_AccountSelected
    End Sub

    Private Sub _accountSearchForm_AccountSelected(ByVal sender As Object, ByVal e As SelectedAccountEventArgs)
        JournalGrid.CurrentRow.Cells(0).Value = e.AccountNumber
        JournalGrid.CurrentRow.Cells(1).Value = e.AccountDescription

        _accountSearchForm.Close()
    End Sub

    Public Sub CountTotal()
        Dim db, cr As Double
        Dim i As Integer
        Try
            db = 0
            cr = 0
            For i = 0 To JournalGrid.Rows.Count - 1
                If JournalGrid.Rows(i).Cells(2).Value = "Debit" Then
                    db = db + JournalGrid.Rows(i).Cells(3).Value
                Else
                    cr = cr + JournalGrid.Rows(i).Cells(3).Value
                End If
            Next i
            totalCr.Text = cr
            totalDb.Text = db
        Catch ex As Exception
            MsgBox("Please enter number in amount column")
        End Try

    End Sub

    Private Function getDescription(ByVal flag As String)
        Dim desc As String
        reader = ExecQueryReader("SELECT * FROM GLAccountMS WHERE glnum LIKE '" + flag + "'")
        While reader.read()
            desc = reader(1).ToString
        End While

        Return desc
    End Function
    Private Sub JournalGrid_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles JournalGrid.CellEndEdit
        If e.ColumnIndex = 3 Then
            Dim value As String = JournalGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Char.IsLetter(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    JournalGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "0"
                    Exit Sub
                End If
            Next
            CountTotal()
        ElseIf e.ColumnIndex = 2 Then
            CountTotal()
        ElseIf e.ColumnIndex = 0 Then
            '
            Try
                If getDescription(JournalGrid.CurrentRow.Cells(0).Value.ToString).Equals("") Or getDescription(JournalGrid.CurrentRow.Cells(0).Value.ToString).Equals(vbNull) Then
                    MsgBox("Account does not exist")
                    JournalGrid.Rows.RemoveAt(JournalGrid.Rows.Count - 1)
                Else
                    JournalGrid.CurrentRow.Cells(1).Value = getDescription(JournalGrid.CurrentRow.Cells(0).Value.ToString)

                End If


            Catch ex As Exception
                MsgBox("Account does not exist")
                JournalGrid.Rows.RemoveAt(JournalGrid.Rows.Count - 2)

            End Try
            'End If

        End If

    End Sub
    Public Function CreateNewCode()

        reader = ExecQueryReader("SELECT *  FROM Jourhd order by docid DESC")
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
    Private Function checkActPeriod()
        reader = ExecQueryReader("SELECT ACMON,ACYER FROM PRACT WHERE ACTIV = '1'")
        reader.read()
        Return reader(1).ToString & "-" & reader(0).ToString
    End Function
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        Dim i As Integer
        Dim code As String
        If totalCr.Text <> totalDb.Text Then
            MsgBox("Debit & Credit amount must be the same")
        ElseIf (PostingDate.Value.Year.ToString & "-" & PostingDate.Value.Month.ToString("00")) <> checkActPeriod() Then
            MsgBox("Accounting Period '" & PostingDate.Value.Year.ToString & "-" & PostingDate.Value.Month.ToString("00") & "'is not activated (Current Active Accounting Period : '" + checkActPeriod() + "')")
        ElseIf PostingDate.Value.Date > Date.Today Then
            MsgBox("You cannot perform posting in the future")
        ElseIf JournalGrid.Rows.Count = 1 Then
            MsgBox("Please enter GL Account to perform Journal Entry")
        ElseIf DocType.SelectedIndex = -1 Then
            MsgBox("Please select accounting document type")
        Else
            If MsgBox("Save Journal Transaction?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                code = CreateNewCode()
                ExecQueryNonReader("INSERT INTO JOURHD(DOCID,DOCDT,PSTDT,RFDOC,RMARK,DSTAT,UNAME,CGDAT,DTNUM) VALUES('" + code + "','" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + PostingDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + rdoc.Text + "','" + rmark.Text + "','','" + LoggedInEmployee.Id + "','0000-00-00','" + DocType.SelectedItem.ToString.Substring(0, 2) + "')")
                For i = 0 To JournalGrid.Rows.Count - 2
                    ExecQueryNonReader("INSERT INTO JOURDT(DOCID,GLNUM,PSTKY,PSAMT,NOTES) VALUES('" + code + "','" + JournalGrid.Rows(i).Cells(0).Value.ToString + "','" + getPstKey(i) + "','" + JournalGrid.Rows(i).Cells(3).Value.ToString + "','')")
                Next i
                MsgBox("Journal Posted")
                Me.Close()
            End If

        End If
    End Sub
    Public Function getPstKey(ByVal i As Integer)
        If JournalGrid.Rows(i).Cells(2).Value = "Debit" Then
            Return "10"
        Else
            Return "20"
        End If
    End Function

    Private Sub JournalGrid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JournalGrid.KeyDown
        If e.KeyCode = Keys.F4 Then
            _accountSearchForm.ShowDialog()
        End If
    End Sub
    Private Sub getActDocType()
        reader = ExecQueryReader("SELECT * FROM Actdoctype")
        While reader.read
            DocType.Items.Add(reader(0).ToString + "-" + reader(1).ToString)
        End While
    End Sub
    Private Sub _009_02_Journal_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getActDocType()
        DocType.SelectedIndex = 0
    End Sub
End Class