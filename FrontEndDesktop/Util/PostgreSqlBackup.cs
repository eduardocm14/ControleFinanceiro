using Npgsql;
using System;
using System.Diagnostics;
using System.IO;

public class PostgreSqlBackup
{
    private readonly string _connectionString;

    public DatabaseBackup(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void BackupDatabase(string backupFilePath)
    {
        try
        {
            var builder = new NpgsqlConnectionStringBuilder(_connectionString);
            string database = builder.Database;
            string user = builder.Username;
            string password = builder.Password;
            string host = builder.Host;
            int port = builder.Port;

            // Montar o comando pg_dump
            string dumpCommand = $"pg_dump --host={host} --port={port} --username={user} --format=custom --blobs --file={backupFilePath} {database}";

            // Configurar o processo
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C \"{dumpCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            // Executar o processo
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"Erro ao fazer backup: {error}");
                }
                else
                {
                    Console.WriteLine(output);
                    Console.WriteLine("Backup realizado com sucesso.");
                }
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Falha ao fazer backup do banco de dados.", ex);
        }
    }

    public void RestoreDatabase(string backupFilePath)
    {
        try
        {
            var builder = new NpgsqlConnectionStringBuilder(_connectionString);
            string database = builder.Database;
            string user = builder.Username;
            string password = builder.Password;
            string host = builder.Host;
            int port = builder.Port;

            // Montar o comando pg_restore
            string restoreCommand = $"pg_restore --host={host} --port={port} --username={user} --dbname={database} --clean --create {backupFilePath}";

            // Configurar o processo
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C \"{restoreCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            // Executar o processo
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"Erro ao restaurar: {error}");
                }
                else
                {
                    Console.WriteLine(output);
                    Console.WriteLine("Restauração realizada com sucesso.");
                }
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Falha ao restaurar o banco de dados.", ex);
        }
    }
}
