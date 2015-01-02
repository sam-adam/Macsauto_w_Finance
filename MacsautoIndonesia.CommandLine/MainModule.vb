Imports FluentMigrator.Runner

Module MainModule
    Sub Main()
        Console.ForegroundColor = ConsoleColor.Cyan

        Console.Clear()
        Console.WriteLine("MACSAUTO COMMAND LINE INTERFACE")
        Console.WriteLine("===============================")
        Console.WriteLine("Enter command to run:")
        Console.WriteLine("1. Migration")
        Console.WriteLine("0. Exit command line")
        Console.WriteLine("")
        Console.Write("Command: ")

        Dim selectedCommand = Console.ReadLine()

        If Not IsNumeric(selectedCommand) Then
            Console.WriteLine("Unknown command! Press any key to exit..")
            Console.ReadLine()

            Exit Sub
        End If

        Select Case selectedCommand
            Case 0
                Exit Sub
            Case 1
                Migration()
            Case Else
                Console.WriteLine("Unknown command! Press any key to exit..")
                Console.ReadLine()

                Exit Sub
        End Select

    End Sub

    Private Sub Migration()
        Const connectionStringFormat As String = "Server={0};Uid={1};Pwd={2};Database={3};Convert Zero Datetime=True"

        Dim connectionHost As String = "127.0.0.1"
        Dim connectionUser As String = "root"
        Dim connectionDatabase As String = ""
        Dim connectionPassword As String = ""
        Dim temp As String

        Console.Clear()
        Console.WriteLine("MACSAUTO MIGRATION CLI")
        Console.WriteLine("======================")
        Console.Write("{0,-20}{1,-30}{2,-1}", "Database host", "(Default '127.0.0.1')", ": ")

        temp = Console.ReadLine()

        If Not String.IsNullOrEmpty(temp.Trim()) Then
            connectionHost = temp
        End If

        Console.Write("{0,-20}{1,-30}{2,-1}", "Database username", "(Default 'root')", ": ")

        temp = Console.ReadLine()

        If Not String.IsNullOrEmpty(temp.Trim()) Then
            connectionUser = temp
        End If

        temp = ""

        Do While String.IsNullOrEmpty(temp)
            Console.Write("{0,-20}{1,-30}{2,-1}", "Database name", "", ": ")

            temp = Console.ReadLine()

            connectionDatabase = temp
        Loop

        Console.Write("{0,-20}{1,-30}{2,-1}", "Database password", "", ": ")

        Dim key As ConsoleKeyInfo

        Do While IsNothing(key) OrElse Not key.Key = ConsoleKey.Enter
            key = Console.ReadKey(True)

            If Not key.Key = ConsoleKey.Backspace Then
                connectionPassword &= key.KeyChar
                Console.Write("*")
            Else
                If key.Key = ConsoleKey.Backspace And connectionPassword.Length > 0 Then
                    connectionPassword = connectionPassword.Substring(0, connectionPassword.Length - 1)
                    Console.Write(vbBack)
                    Console.Write(" ")
                    Console.Write(vbBack)
                End If
            End If
        Loop

        Dim migrator As New Migrator(String.Format(connectionStringFormat, connectionHost, connectionUser, connectionPassword, connectionDatabase))

        Console.WriteLine(Environment.NewLine)
        Console.WriteLine("Enter migration direction:")
        Console.WriteLine("1. Up")
        Console.WriteLine("2. Down")
        Console.WriteLine("3. View migrations")
        Console.WriteLine("0. Exit migration")
        Console.WriteLine("")
        Console.Write("Command: ")

        Dim selectedCommand = Console.ReadLine()

        If Not IsNumeric(selectedCommand) Then
            Console.Write("Unknown command! ")

            ExitCli()
        End If

        Try
            Select Case selectedCommand
                Case 0
                    Main()
                    Exit Select
                Case 1
                    migrator.Migrate(
                        Sub(migrationRunner As IMigrationRunner)
                                migrationRunner.MigrateUp()
                            End Sub)
                    Exit Select
                Case 2
                    migrator.Migrate(
                        Sub(migrationRunner As IMigrationRunner)
                                migrationRunner.MigrateDown(0)
                            End Sub)
                    Exit Select
                Case 3
                    migrator.Migrate(
                        Sub(migrationRunner As IMigrationRunner)
                                migrationRunner.ListMigrations()
                            End Sub)
                    Exit Select
                Case Else
                    Console.Write("Unknown command! ")

                    ExitCli()
            End Select
        Catch ex As Exception
            Console.WriteLine("Exceptions occured:")
            Console.WriteLine(ex.Message)

            ExitCli()
        End Try

        ExitCli()
    End Sub

    Private Sub ExitCli()
        Console.WriteLine("")
        Console.WriteLine("Press any key to exit..")
        Console.ReadLine()

        Environment.Exit(0)
    End Sub
End Module