Imports System.Windows.Input
Imports System.Web.Services.Description
Imports MySql.Data.MySqlClient
Imports MacsautoIndonesia.EventsModule
Imports MacsautoIndonesia.EventsModule.Events.Service

Public Class _002_07_Service_Add
    Private ReadOnly _serviceTypesDataTable As DataTable
    Private ReadOnly _vehicleSizesDataTable As DataTable
    Private ReadOnly _revenueAccountsDataTable As DataTable

    Public Sub New()
        InitializeComponent()

        Const allServiceTypeQuery As String =
            "SELECT servicetype.idsvt," & _
            "   servicetype.svtdc" & _
            " FROM servicetype"
        Const allVehicleSizeQuery As String =
            "SELECT vehiclesize.idsiz," & _
            "   vehiclesize.sizdc" & _
            " FROM vehiclesize"
        Const allRevenueAccountsQuery As String =
            "SELECT glaccountms.glnum," & _
            "   glaccountms.gldes," & _
            "   glaccountms.actid," & _
            "   IF(glaccountms.ispnl = 'X', 1, 0) AS ispnl," & _
            "   accounttype.actds" & _
            " FROM glaccountms" & _
            " LEFT JOIN accounttype ON glaccountms.actid = accounttype.actid" & _
            " WHERE glaccountms.glsta = 'Active'" & _
            " AND accounttype.actds = 'REVENUE'"

        _serviceTypesDataTable = New DataTable()
        _serviceTypesDataTable.Load(ExecQueryReader(allServiceTypeQuery))

        For Each row As DataRow In _serviceTypesDataTable.Rows
            ServiceTypeCbo.Items.Add(New KeyValuePair(Of String, String)(row("idsvt").ToString(), row("svtdc").ToString()))
        Next

        _vehicleSizesDataTable = New DataTable()
        _vehicleSizesDataTable.Load(ExecQueryReader(allVehicleSizeQuery))

        With ServicePriceGridView
            .AutoGenerateColumns = False
            .Columns("VehicleSizeIdCol").DataPropertyName = "idsiz"
            .Columns("VehicleSizeDescCol").DataPropertyName = "sizdc"
            .DataSource = _vehicleSizesDataTable
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With

        _revenueAccountsDataTable = New DataTable()
        _revenueAccountsDataTable.Load(ExecQueryReader(allRevenueAccountsQuery))

        For Each row As DataRow In _revenueAccountsDataTable.Rows
            AccountCbo.Items.Add(New KeyValuePair(Of String, String)(row("glnum").ToString(), row("gldes").ToString()))
        Next

        ServicePriceGridView.ValidateIntegerInput(ServicePriceCol.Index)
    End Sub

    Private Sub AddServiceTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AddServiceTabControl.SelectedIndexChanged
        Select Case AddServiceTabControl.SelectedIndex
            Case GeneralTabPage.TabIndex
                AcceptButton = ToPricingBtn
            Case PricingTabPage.TabIndex
                AcceptButton = ToAccountingBtn
            Case AccountTabPage.TabIndex
                AcceptButton = SubmitBtn
        End Select
    End Sub

    Private Sub ToPricingBtn_Click(sender As Object, e As EventArgs) Handles ToPricingBtn.Click
        AddServiceTabControl.SelectedIndex = PricingTabPage.TabIndex
    End Sub

    Private Function ValidateGeneralTab() As Boolean
        Dim result As Boolean = False

        If String.IsNullOrEmpty(ServiceNameTxt.Text) Then
            ErrorInput(ServiceNameTxt, "Service name is required")
        ElseIf ServiceTypeCbo.SelectedIndex = -1 Then
            ErrorInput(ServiceTypeCbo, "Service type is required")
        Else
            Dim serviceNameIsUniqueQuery =
                "SELECT hservice.idsvc" & _
                "   FROM hservice" & _
                "   WHERE hservice.svcdc = '" & ServiceNameTxt.Text & "'"

            If HasResult(serviceNameIsUniqueQuery) Then
                ErrorInput(ServiceNameTxt, "Service with same name already exists")
            Else
                result = True
            End If
        End If

        Return result
    End Function

    Private Sub ToGeneralBtn_Click(sender As Object, e As EventArgs) Handles ToGeneralBtn.Click
        AddServiceTabControl.SelectedIndex = GeneralTabPage.TabIndex
    End Sub

    Private Sub ToAccountingBtn_Click(sender As Object, e As EventArgs) Handles ToAccountingBtn.Click
        AddServiceTabControl.SelectedIndex = AccountTabPage.TabIndex
    End Sub

    Private Function ValidatePricingTab() As Boolean
        Dim result As Boolean = False

        For Each row As DataGridViewRow In ServicePriceGridView.Rows
            Dim servicePrice As Integer = row.Cells(ServicePriceCol.Index).Value

            If Not String.IsNullOrEmpty(servicePrice) And servicePrice > 0 Then
                result = True
            End If
        Next

        Return If(result, result, MsgBox("You have not input any price. Continue?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes)
    End Function

    Private Sub ServicePriceGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ServicePriceGridView.CellEndEdit
        If e.ColumnIndex = ServicePriceCol.Index AndAlso Not String.IsNullOrEmpty(ServicePriceGridView(e.ColumnIndex, e.RowIndex).Value) Then
            ServicePriceGridView(e.ColumnIndex, e.RowIndex).Value = String.Format("{0:n0}", Double.Parse(ServicePriceGridView(e.ColumnIndex, e.RowIndex).Value))
        End If
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Try
            If AccountCbo.SelectedIndex = -1 Then
                ErrorInput(AccountCbo, "Account is required")
            ElseIf MsgBox("Create new service?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                Dim newServiceId As String = ""

                DoInTransaction(
                    Function(command As MySqlCommand) As Boolean
                        Dim saveHeaderQuery As String =
                            String.Format("INSERT INTO hservice (" & _
                                "SELECT CONCAT('S{3}/', LPAD((COUNT(idsvc) + 1), 4, '0')) AS idsvc," & _
                                "   '{0}' AS idsvt," & _
                                "   '{1}' AS svcdc," & _
                                "   '' AS vcpmt," & _
                                "   '{2}' AS glnum," & _
                                "   1 AS is_active" & _
                                " FROM hservice" & _
                                " WHERE idsvc LIKE 'S{3}/%')" & _
                                " ORDER BY idsvc DESC",
                                CType(ServiceTypeCbo.SelectedItem, KeyValuePair(Of String, String)).Key,
                                ServiceNameTxt.Text,
                                CType(AccountCbo.SelectedItem, KeyValuePair(Of String, String)).Key,
                                DateTime.Now.ToString("yy"))

                        command.CommandText = saveHeaderQuery
                        command.ExecuteNonQuery()

                        command.CommandText = String.Format("SELECT idsvc FROM hservice WHERE idsvc LIKE 'S{0}/%' ORDER BY idsvc DESC LIMIT 1", DateTime.Now.ToString("yy"))

                        Dim dataReader As MySqlDataReader = command.ExecuteReader(CommandBehavior.SingleResult)

                        If (dataReader.Read()) Then
                            newServiceId = dataReader(0)

                            dataReader.Close()

                            For Each row As DataGridViewRow In ServicePriceGridView.Rows
                                Dim price As Double = 0

                                Double.TryParse(row.Cells(ServicePriceCol.Index).Value, price)

                                command.CommandText = "INSERT INTO dservice VALUES(@idsvc, @idsiz, @price)"

                                command.Prepare()
                                command.Parameters.Clear()
                                command.Parameters.AddWithValue("@idsvc", newServiceId)
                                command.Parameters.AddWithValue("@idsiz", row.Cells(VehicleSizeIdCol.Index).Value)
                                command.Parameters.AddWithValue("@price", price)

                                command.ExecuteNonQuery()
                            Next
                        End If

                        Return True
                    End Function)

                MsgBox("New service added", MsgBoxStyle.Exclamation, "Success")

                EventBus.Publish(Of ServiceAddedEvent, ServiceAddedEventArgs)(Me, New ServiceAddedEvent(Me, New ServiceAddedEventArgs(newServiceId)))

                Close()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub BackToPricingBtn_Click(sender As Object, e As EventArgs) Handles BackToPricingBtn.Click
        AddServiceTabControl.SelectedIndex = PricingTabPage.TabIndex
    End Sub

    Private Sub AddServiceTabControl_Deselecting(sender As Object, e As TabControlCancelEventArgs) Handles AddServiceTabControl.Deselecting
        If e.TabPageIndex = GeneralTabPage.TabIndex AndAlso Not ValidateGeneralTab() Then
            e.Cancel = True
        ElseIf e.TabPageIndex = PricingTabPage.TabIndex AndAlso Not ValidatePricingTab() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub AccountCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountCbo.SelectedIndexChanged
        IsPnLChk.Checked = (Not AccountCbo.SelectedIndex = -1) OrElse (_revenueAccountsDataTable.Select("idsvc = '" & CType(AccountCbo.SelectedItem, KeyValuePair(Of String, String)).Key & "'").First()("ispnl"))
    End Sub
End Class