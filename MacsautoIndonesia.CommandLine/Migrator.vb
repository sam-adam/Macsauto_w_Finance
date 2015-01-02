Imports FluentMigrator
Imports FluentMigrator.Runner.Announcers
Imports FluentMigrator.Runner
Imports FluentMigrator.Runner.Processors.MySql
Imports FluentMigrator.Runner.Initialization
Imports FluentMigrator.Runner.Processors
Imports System.Reflection

Public Class Migrator
    Private ReadOnly _connectionString As String

    Public Sub New(ByVal connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Sub Migrate(ByVal action As Action(Of IMigrationRunner))
        Dim factory As New MySqlProcessorFactory()
        Dim options As New ProcessorOptions()
        Dim announcer As New TextWriterAnnouncer(AddressOf TextWriterHandler)
        Dim migrationContext As New RunnerContext(announcer)

        options.PreviewOnly = False
        options.Timeout = 0

        Dim processor As IMigrationProcessor = factory.Create(_connectionString, announcer, options)
        Dim runner As New MigrationRunner(Assembly.GetExecutingAssembly(), migrationContext, processor)

        action(runner)
    End Sub

    Public Sub TextWriterHandler(ByVal text As String)
        Console.WriteLine(text)
    End Sub
End Class