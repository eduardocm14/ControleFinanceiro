using System;
using System.Diagnostics;

namespace BackupPostgreSQL
{
    class PostgreSQLBackup
    {
        private string host;
        private int port;
        private string database;
        private string user;
        private string password;
        private string backupDir;
        private string pgDumpPath;

        public PostgreSQLBackup(string host, int port, string database, string user, string password, string backupDir, string pgDumpPath)
        {
            this.host = host;
            this.port = port;
            this.database = database;
            this.user = user;
            this.password = password;
            this.backupDir = backupDir;
            this.pgDumpPath = pgDumpPath;
        }

        public void FazerBackup()
        {
            try
            {
                string backupFile = $"{backupDir}\\backup_{database}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.sql";

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = pgDumpPath; // Caminho completo para pg_dump
                psi.Arguments = $"-h {host} -p {port} -U {user} -F c -b -v -f \"{backupFile}\" {database}";
                psi.EnvironmentVariables["PGPASSWORD"] = password;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                using (Process process = Process.Start(psi))
                {
                    process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                    process.ErrorDataReceived += (sender, e) => Console.WriteLine("ERROR: " + e.Data);
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();

                    if (process.ExitCode != 0)
                    {
                        Console.WriteLine($"O backup falhou com o código de saída: {process.ExitCode}");
                    }
                    else
                    {
                        Console.WriteLine($"Backup realizado com sucesso: {backupFile}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao fazer o backup: " + ex.Message);
            }
        }
    }
}
