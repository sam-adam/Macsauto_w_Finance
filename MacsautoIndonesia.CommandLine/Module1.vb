Imports FluentMigrator.Runner

Module Module1

    Sub Main()
        Dim connectionString As String = String.Format("Server=127.0.0.1;Uid={0};Pwd={1};Database={2};Convert Zero Datetime=True", "root", "root", "macsauto")
        Dim migrator As New Migrator(connectionString)

        migrator.Migrate(
            Sub(migrationRunner As IMigrationRunner)
                migrationRunner.MigrateUp()
            End Sub)
    End Sub
End Module