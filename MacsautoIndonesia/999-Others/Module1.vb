Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Globalization
Imports Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.SmartCard
Imports MacsautoIndonesia.SmartCard.Reader

Module Module1
    Public reader, reader1
    Public findserviceFlag

    Dim connectionString As String = "Server=" & My.Settings.Host & ";Uid=" & My.Settings.Username & ";Pwd=" & My.Settings.Password & ";Database=" & My.Settings.Database & ";Convert Zero Datetime=True"
    Dim con As New MySqlConnection(connectionString)
    Dim cmd As New MySqlCommand
    Dim cardReaders As List(Of SmartCardReader)

    Public Sub InitCardReader()
        SmartCardManager.Initialize()
        cardReaders = SmartCardManager.CardReaders
    End Sub
    Public Function getCardReader() As SmartCardReader
        Return cardReaders.FirstOrDefault
    End Function
    Public Function getText(ByVal query As String, ByVal readerIndx As Integer)
        reader = ExecQueryReader(query)
        reader.read()
        Return reader(readerIndx).ToString
    End Function

    Public Sub ExecQueryNonReader(ByVal query)
        con.Close()
        con.Open()
        Dim dataTable As New System.Data.DataTable
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(dataTable)
        con.Close()
    End Sub

    Public Sub loadTable(ByVal query As String, ByVal DataGridView As DataGridView)
        con.Close()
        con.Open()
        Dim table As New System.Data.DataTable
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, con)
        Dim cb As New MySql.Data.MySqlClient.MySqlCommandBuilder(adapter)
        adapter.Fill(table)
        DataGridView.DataSource = table
        con.Close()

    End Sub
    Public Function ExecQueryReader(ByVal query)
        con.Close()
        con.Open()
        Dim adapter As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = adapter.ExecuteReader
        Return reader
        con.Close()

    End Function
    Function toCurrencyFormat(ByVal number As String)
        Return FormatNumber(number, TriState.True, TriState.True, TriState.True).ToString()
    End Function

    Public Function CreateNewCode(ByVal query As String, ByVal prefix As String, ByVal sfrom As Integer, ByVal sto As Integer)
        reader = ExecQueryReader(query)
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        If reader.HasRows Then
            If Date.Today.Year.ToString.Substring(2, 2) = reader(0).ToString().Substring(1, 2) Then
                lastCode = reader(0).ToString().Substring(sfrom, sto)
                If lastCode < 9 Then
                    newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "/" & "000" & (lastCode + 1)
                ElseIf lastCode < 100 Then
                    newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "/" & "00" & (lastCode + 1)
                ElseIf lastCode < 1000 Then
                    newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0" & (lastCode + 1)
                Else
                    newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "/" & (lastCode + 1)
                End If
            Else
                newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
            End If
        Else
            newcode = prefix & Date.Today.Year.ToString.Substring(2, 2) & "/" & "0001"
        End If
        Return newcode
    End Function


    ' Make and return a PrintDocument object that's ready
    ' to print the paragraphs.
    Public Function PreparePrintDocument() As PrintDocument
        ' Make the PrintDocument object.
        Dim print_document As New PrintDocument

        ' Install the PrintPage event handler.
        AddHandler print_document.PrintPage, AddressOf _
            Print_PrintPage

        ' Return the object.
        Return print_document
    End Function

    ' Print the next page.
    Private Sub Print_PrintPage(ByVal sender As Object, ByVal e _
        As System.Drawing.Printing.PrintPageEventArgs)
        ' Draw a rectangle at the margins.
        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)

        ' Draw a thick, dashed ellipse.
        Dim dotted_pen As New Pen(Color.Black, 5)
        dotted_pen.DashStyle = Drawing2D.DashStyle.Dash
        e.Graphics.DrawEllipse(dotted_pen, e.MarginBounds)
        dotted_pen.Dispose()

        ' Draw a thick diamond.
        Dim x0 As Integer = e.MarginBounds.X
        Dim y0 As Integer = e.MarginBounds.Y
        Dim wid As Integer = e.MarginBounds.Width
        Dim hgt As Integer = e.MarginBounds.Height
        Dim pts() As System.Drawing.Point = { _
            New System.Drawing.Point(x0, y0 + hgt \ 2), _
            New System.Drawing.Point(x0 + wid \ 2, y0), _
            New System.Drawing.Point(x0 + wid, y0 + hgt \ 2), _
            New System.Drawing.Point(x0 + wid \ 2, y0 + hgt) _
        }
        e.Graphics.DrawPolygon(New Pen(Color.Black, 5), pts)

        ' There are no more pages.
        e.HasMorePages = False
    End Sub

    Public Sub Marking(ByVal DataGridView)
        For i As Integer = 0 To DataGridView.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            Else
                DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.White
            End If
        Next i
    End Sub

    Public Sub excelExport(ByVal dg As DataGridView, Optional ByVal filename As String = "report")
        Dim abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        'verfying the datagridview having data or not
        If ((dg.Columns.Count = 0) Or (dg.Rows.Count = 0)) Then
            Exit Sub
        End If

        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i As Integer = 0 To dg.ColumnCount - 1
            dset.Tables(0).Columns.Add(dg.Columns(i).HeaderText)
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i As Integer = 0 To dg.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j As Integer = 0 To dg.Columns.Count - 1
                dr1(j) = dg.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next
        Dim excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application

        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            wSheet.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next

        wSheet.Columns.AutoFit()
        wSheet.Protect("solutionforsatisfaction")

        Dim dialog As New SaveFileDialog

        dialog.Filter = "Excel files (*.xls)|*.xls"
        dialog.DefaultExt = "xls"
        dialog.FileName = filename

        Dim dialogResult = dialog.ShowDialog

        If dialogResult = dialogResult.OK Or dialogResult = dialogResult.Yes Then
            Try
                Dim strFileName As String = dialog.FileName
                Dim blnFileOpen As Boolean = False
                Try
                    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                    fileTemp.Close()
                Catch ex As Exception
                    blnFileOpen = False
                End Try

                If System.IO.File.Exists(strFileName) Then
                    System.IO.File.Delete(strFileName)
                End If

                wBook.SaveAs(strFileName, XlFileFormat.xlExcel8)
                'excel.Workbooks.Open(strFileName)
                excel.Visible = True
                MsgBox("Export to excel Completed")
            Catch exerr As Exception
            End Try
        End If
    End Sub

    Public Function ToDate(ByVal mySqlDate As String) As String
        Dim formattedDate As String
        Dim datePart = mySqlDate.Split(" ")(0)
        Dim dateParts = datePart.Split("/")

        formattedDate = dateParts(2).ToString & "-" & String.Format("{0:00}", CInt(dateParts(1).ToString())) & "-" & String.Format("{0:00}", CInt(dateParts(0).ToString()))

        Return formattedDate
    End Function

    Public Sub CheckPointExpiry(ByVal CNumber As String)
        Dim query As String
        Dim myReader As MySqlDataReader
        Dim setExpired As Boolean = False

        query = "SELECT trdat" & _
                " FROM htransaction" & _
                " WHERE idcus = '" & CNumber & "'" & _
                " ORDER BY trdat DESC" & _
                " LIMIT 0, 1"
        myReader = ExecQueryReader(query)

        While myReader.Read()
            If DateDiff("d", DateTime.Now, DateTime.Parse(ToDate(myReader(0).ToString()))) > 365 Then
                MsgBox("Last transaction is more than 1 year. Points will be set expired.", MsgBoxStyle.OkOnly, "Warning")

                setExpired = True
            End If
        End While

        If setExpired = False Then
            query = "SELECT rdmpdat" & _
                    " FROM hredemption" & _
                    " WHERE idcus = '" & CNumber & "'" & _
                    " ORDER BY rdmpdat DESC" & _
                    " LIMIT 0, 1"
            myReader = ExecQueryReader(query)

            While myReader.Read()
                Dim lastDate As DateTime = DateTime.ParseExact(ToDate(myReader(0).ToString()), "yyyy-dd-MM", DateTimeFormatInfo.InvariantInfo)

                If DateDiff("d", DateTime.Now, lastDate) > 365 Then
                    MsgBox("Last transaction is more than 1 year. Points will be set expired.", MsgBoxStyle.OkOnly, "Warning")

                    setExpired = True
                End If
            End While
        End If

        If setExpired Then
            Dim totalPoint As String = "0"

            query = "SELECT cpoin" & _
                    " FROM hcustomer" & _
                    " WHERE idcus = '" & CNumber & "'"
            myReader = ExecQueryReader(query)

            While myReader.Read()
                totalPoint = myReader(0).ToString()
            End While

            ExecQueryNonReader("UPDATE hcustomer SET cpoin = 0 WHERE idcus = '" & CNumber & "'")
            ExecQueryNonReader("INSERT INTO pointTrans(IDPOR,IDCUS,PTDAT,TRPON, TRTYPE) VALUES('" + CreatePointNewCode() + "','" + CNumber + "',NOW(),'" + totalPoint + "', 'SUB')")

            MsgBox(totalPoint & " is set expired successfully.")
        End If
    End Sub

    Public Function CreatePointNewCode()
        Dim Curdate, company As String
        Curdate = Date.Today.Month & "-" & Date.Today.Year
        company = getText("select * from pointTrans", 0)
        reader = ExecQueryReader("SELECT *  FROM pointTrans  order by idpor DESC")
        reader.read()
        Dim lastCode As Integer
        Dim newcode As String
        If reader.HasRows Then
            lastCode = reader(0).ToString()
            newcode = lastCode + 1
        Else
            newcode = 1
        End If

        Return newcode
    End Function
    Public Function NewJournalCode()
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

    Public Sub DoInTransaction(ByRef func As Func(Of MySqlCommand, Boolean))
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        Else
            con.Open()
        End If

        Dim command As MySqlCommand = New MySqlCommand()
        Dim transaction As MySqlTransaction = con.BeginTransaction(IsolationLevel.ReadCommitted)

        command.Connection = con

        Try
            func.Invoke(command)

            GetConnection()

            transaction.Commit()
        Catch ex As MySqlException
            transaction.Rollback()

            Throw
        Catch ex As Exception
            transaction.Rollback()

            Throw
        End Try
    End Sub

    Public Sub ExecQuery(ByVal query As String)
        Dim command As MySqlCommand

        command = New MySqlCommand(query, GetConnection())
        command.ExecuteReader().Close()
    End Sub

    Public Function HasResult(ByVal query As String)
        Dim dataReader As MySqlDataReader = ExecQueryReader(query)

        Return dataReader.HasRows
    End Function

    Public Function GetConnection() As MySqlConnection
        Try
            If (con.State = ConnectionState.Open) Then
                Dim newConnection As MySqlConnection = New MySqlConnection(connectionString)

                newConnection.Open()

                Return newConnection
            ElseIf con.State = ConnectionState.Closed Then
                con.Open()

                Return con
            End If

            Return con
        Catch ex As MySqlException
            Throw
        End Try
    End Function
End Module
