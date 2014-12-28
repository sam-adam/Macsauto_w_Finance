Imports Microsoft.Office.Interop.Excel
Public Class _009_05_General_Ledger_Report
    Public Sub loadMonth()
        reader = ExecQueryReader("SELECT ACYER, ACMON FROM PRACT ORDER BY ACPID DESC")
        While reader.read()
            ComboBox1.Items.Add(reader(0).ToString & "-" & reader(1).ToString)
        End While

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
        'wSheet.Protect("solutionforsatisfaction")

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
    Private Sub _009_05_General_Ledger_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadMonth()

    End Sub
    Public Sub getAllGL()

        reader = ExecQueryReader("SELECT PSTDT,a.docid,b.GLNUM,GLDES,SUM(CASE WHEN PSTKY = '10' THEN PSAMT ELSE '0' END)'DEBIT', SUM(CASE WHEN PSTKY = '20' THEN PSAMT ELSE '0' END)'CREDIT',rfdoc,rmark FROM JOURHD A, JOURDT B,GLACCOUNTMS C  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM  and DSTAT <> 'X' AND PSTDT LIKE '" + ComboBox1.SelectedItem.ToString + "%' GROUP BY  B.GLNUM,PSTDT")
        'reader = ExecQueryReader("SELECT PSTDT,a.docid,b.GLNUM,SUM(CASE WHEN PSTKY = '10' THEN PSAMT END)'DEBIT', SUM(CASE WHEN PSTKY = '20' THEN PSAMT END)'CREDIT',rfdoc,rmark FROM JOURHD A, JOURDT B,GLACCOUNTMS C  WHERE A.DOCID = B.DOCID AND C.GLNUM =B.GLNUM  and DSTAT <> 'X' AND PSTDT LIKE '2014-11%' GROUP BY  B.GLNUM,PSTDT")
        While reader.read
            GLReport.Rows.Add(reader(0).ToString, reader(1).ToString, reader(2), reader(3).ToString, reader(4), reader(5), reader(6).ToString, reader(7).ToString)

        End While

    End Sub
   

    Public Sub countSubtotal()
        Dim amount As Double
        Dim i As Integer
        For i = 0 To GLReport.Rows.Count - 1
            ' MsgBox(GLReport.Rows(i).Cells(4).Value + "-" + GLReport.Rows(i).Cells(5).Value)
            ' amount = amount + GLReport.Rows(i).Cells(4).Value - GLReport.Rows(i).Cells(5).Value
            If i > 0 Then
                If GLReport.Rows(i).Cells(2).Value <> GLReport.Rows(i - 1).Cells(2).Value Then
                    amount = 0
                    GLReport.Rows(i - 1).Cells(8).Style.BackColor = Color.Yellow
                    amount = amount + GLReport.Rows(i).Cells(4).Value - GLReport.Rows(i).Cells(5).Value
                    GLReport.Rows(i).Cells(8).Value = amount

                Else
                    amount = amount + GLReport.Rows(i).Cells(4).Value - GLReport.Rows(i).Cells(5).Value
                    GLReport.Rows(i).Cells(8).Value = amount
                End If
            Else
                amount = amount + GLReport.Rows(i).Cells(4).Value - GLReport.Rows(i).Cells(5).Value
                GLReport.Rows(i).Cells(8).Value = amount
            End If
            'Else
            ' GLReport.Rows(i).Cells(8).Value = amount
        Next i
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If GLReport.Rows.Count <> 0 Then
            If MsgBox("Export General Ledger?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                'exportToExcel(TrlistGrid, "List")
                excelExport(GLReport)
            End If
        Else
            MsgBox("No Data to be exported")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select Accounting period")

        Else
            getAllGL()
            countSubtotal()
        End If

       
    End Sub
End Class