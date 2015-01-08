Imports FluentMigrator.Runner

Module MainModule
    Public Const ConnectionStringFormat As String = "Server={0};Uid={1};Pwd={2};Database={3};Convert Zero Datetime=True"

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Cyan

        If String.IsNullOrEmpty(My.Settings.DatabaseName) Then
            Configuration()
        Else
            Console.Clear()
            Console.WriteLine("MACSAUTO COMMAND LINE INTERFACE")
            Console.WriteLine("===============================")
            Console.WriteLine("Enter command to run:")
            Console.WriteLine("1. Migration")
            Console.WriteLine("2. Import GL Accounts XLS")
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
                    Dim migrator As New Migrator()

                    migrator.Run()
                Case 2
                    Dim importer As New GLAccountImporter()

                    importer.Run()
                Case Else
                    Console.WriteLine("Unknown command! Press any key to exit..")
                    Console.ReadLine()

                    Exit Sub
            End Select
        End If
    End Sub

    Public Sub Configuration()
        Dim temp As String

        Console.Write("{0,-20}{1,-30}{2,-1}", "Database host", "(Default '127.0.0.1')", ": ")

        temp = Console.ReadLine()

        If Not String.IsNullOrEmpty(temp.Trim()) Then
            My.Settings.DatabaseHost = temp
        End If

        Console.Write("{0,-20}{1,-30}{2,-1}", "Database username", "(Default 'root')", ": ")

        temp = Console.ReadLine()

        If Not String.IsNullOrEmpty(temp.Trim()) Then
            My.Settings.DatabaseUser = temp
        End If

        temp = ""

        Do While String.IsNullOrEmpty(temp)
            Console.Write("{0,-20}{1,-30}{2,-1}", "Database name", "", ": ")

            temp = Console.ReadLine()

            My.Settings.DatabaseName = temp
        Loop

        Console.Write("{0,-20}{1,-30}{2,-1}", "Database password", "", ": ")

        Dim key As ConsoleKeyInfo
        Dim newPass = ""
        Do While IsNothing(key) OrElse Not key.Key = ConsoleKey.Enter

            key = Console.ReadKey(True)

            If Not (key.Key = ConsoleKey.Backspace Or key.Key = ConsoleKey.Enter) Then

                newPass &= key.KeyChar
                My.Settings.DatabasePass = newPass
                Console.Write("*")
            Else
                If key.Key = ConsoleKey.Backspace And My.Settings.DatabasePass.Length > 0 Then
                    My.Settings.DatabasePass = My.Settings.DatabasePass.Substring(0, My.Settings.DatabasePass.Length - 1)
                    Console.Write(vbBack)
                    Console.Write(" ")
                    Console.Write(vbBack)
                End If
            End If
        Loop

        My.Settings.Save()

        Main()
    End Sub

    Public Sub ExitCli()
        Console.WriteLine("")
        Console.WriteLine("Press any key to exit..")
        Console.ReadLine()

        Environment.Exit(0)
    End Sub
End Module