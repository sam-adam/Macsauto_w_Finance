Imports FluentMigrator
Imports FluentMigrator.Runner.Announcers
Imports FluentMigrator.Runner
Imports FluentMigrator.Runner.Processors.MySql
Imports FluentMigrator.Runner.Initialization
Imports FluentMigrator.Runner.Processors
Imports System.Reflection

Public Class Migrator
    Inherits CommandLine

    Public Overrides Sub Run()
        Dim connectionString As String = String.Format(ConnectionStringFormat, My.Settings.DatabaseHost, My.Settings.DatabaseUser, My.Settings.DatabasePass, My.Settings.DatabaseName)

        Console.Clear()
        Console.WriteLine("MACSAUTO MIGRATION CLI")
        Console.WriteLine("======================")
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
                    Migrate(connectionString,
                        Sub(migrationRunner As IMigrationRunner)
                            migrationRunner.MigrateUp()
                        End Sub)
                    Exit Select
                Case 2
                    Migrate(connectionString,
                        Sub(migrationRunner As IMigrationRunner)
                            migrationRunner.MigrateDown(0)
                        End Sub)
                    Exit Select
                Case 3
                    Migrate(connectionString,
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

    Private Sub Migrate(ByVal connectionString As String, ByVal action As Action(Of IMigrationRunner))
        Dim factory As New MySqlProcessorFactory()
        Dim options As New ProcessorOptions()
        Dim announcer As New TextWriterAnnouncer(AddressOf TextWriterHandler)
        Dim migrationContext As New RunnerContext(announcer)

        options.PreviewOnly = False
        options.Timeout = 0

        Dim processor As IMigrationProcessor = factory.Create(connectionString, announcer, options)
        Dim runner As New MigrationRunner(Assembly.GetExecutingAssembly(), migrationContext, processor)

        action(runner)
    End Sub

    Public Sub TextWriterHandler(ByVal text As String)
        Console.WriteLine(text)
    End Sub
End Class