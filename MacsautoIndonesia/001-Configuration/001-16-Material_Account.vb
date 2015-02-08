Imports MySql.Data.MySqlClient

Public Class _001_16_Material_Account
    Dim word() As String
    Dim sale() As String
    Dim hpp() As String
    Private Sub setData(ByVal query As String, ByVal cbo As ComboBox)
        Dim reader As MySqlDataReader = ExecQueryReader(query)
        reader.Read()

        If reader.HasRows Then
            cbo.Text = (reader(0).ToString + "-" + reader(1).ToString)
        End If
    End Sub
    Private Sub loadAccount(ByVal query As String, ByVal combo As ComboBox)
        reader = ExecQueryReader(query)
        While reader.READ
            combo.Items.Add(reader(0).ToString + "-" + reader(1).ToString)
        End While
    End Sub

    Private Sub _001_16_Material_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadAccount("SELECT glnum, gldes FROM glaccountms WHERE actid = '1'", glact)
        loadAccount("SELECT glnum, gldes FROM glaccountms WHERE actid = '4'", Sales)
        loadAccount("SELECT glnum, gldes FROM glaccountms WHERE actid = '5'", COGS)
        setData("SELECT glnum, gldes FROM mtrac WHERE mtrid = '1'", glact)
        setData("SELECT glnum, gldes FROM mtrac WHERE mtrid = '2'", Sales)
        setData("SELECT glnum, gldes FROM mtrac WHERE mtrid = '3'", COGS)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If glact.SelectedIndex = -1 Or Sales.SelectedIndex = -1 Or COGS.SelectedIndex = -1 Then
            MsgBox("Please complete configuration for product's GL Account")
        Else
            word = glact.SelectedItem.ToString.Split("-")
            sale = Sales.SelectedItem.ToString.Split("-")
            hpp = COGS.SelectedItem.ToString.Split("-")
            If MsgBox("Define GL Account for material transaction?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                ExecQueryNonReader("TRUNCATE TABLE MTRAC")
                ExecQueryNonReader("INSERT INTO MTRAC VALUES('1','" + word(0) + "','" + word(1) + "')")
                ExecQueryNonReader("INSERT INTO MTRAC VALUES('2','" + sale(0) + "','" + sale(1) + "')")
                ExecQueryNonReader("INSERT INTO MTRAC VALUES('3','" + hpp(0) + "','" + hpp(1) + "')")
                MsgBox("GL Account for material transaction successfully defined")

            End If
        End If
    End Sub
End Class