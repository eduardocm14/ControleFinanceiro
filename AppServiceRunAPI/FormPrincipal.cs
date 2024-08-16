using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServiceRunAPI
{
    public partial class FromPrincipal : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiUrl = "http://localhost:5235/api/Conta"; // URL do endpoint da API
        private const string apiProjectDirectory = @"C:\Eduardo\.NET\ControleFinanceiroEntityPostgreSQL\WebAPIControleFinanceiroCore"; // Caminho para o diret�rio do projeto da API
        private const string apiProcessName = "dotnet"; // Nome do processo para identificar

        private Process? apiProcess; // Declara��o como anul�vel

        public FromPrincipal()
        {
            InitializeComponent();
        }

        private async void btnVerificar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Verificando...";

            bool isRunning = await IsApiRunningAsync();

            if (isRunning)
            {
                lblStatus.Text = "A API est� rodando.";
                
                var result = MessageBox.Show("API est� rodando. Deseja parar servi�o?", "Aten��o", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    btnVerificar.Text = "Start";
                    StopApi();
                }
                else
                {
                    btnVerificar.Text = "Stop";

                    // Iniciar o processo dotnet run
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = apiProjectDirectory,
                        FileName = "dotnet",
                        Arguments = "run",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    apiProcess = Process.Start(startInfo);

                    if (apiProcess != null)
                    {
                        // Assinatura dos eventos para capturar a sa�da e erros
                        apiProcess.OutputDataReceived += (sender, e) => AppendOutput(e.Data);
                        apiProcess.ErrorDataReceived += (sender, e) => AppendOutput(e.Data);

                        // Inicia a leitura ass�ncrona da sa�da padr�o e de erro
                        apiProcess.BeginOutputReadLine();
                        apiProcess.BeginErrorReadLine();

                        richTextBox1.Text = $"Data e Hora: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" + Environment.NewLine; ;
                        lblStatus.Text = "API iniciada. Verifique log abaixo.";
                    }
                }
            }
            else
            {
                lblStatus.Text = "A API n�o est� rodando. Iniciando a API...";
                btnVerificar.Text = "Stop";
                StartApi();
            }
        }

        private async Task<bool> IsApiRunningAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        private void StartApi()
        {
            try
            {
                // Verifica se o processo j� est� em execu��o
                if (IsProcessRunning(apiProcessName))
                {
                    lblStatus.Text = "O processo j� est� rodando.";
                    return;
                }

                // Iniciar o processo dotnet run
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WorkingDirectory = apiProjectDirectory,
                    FileName = "dotnet",
                    Arguments = "run",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                apiProcess = Process.Start(startInfo);

                if (apiProcess != null)
                {
                    // Assinatura dos eventos para capturar a sa�da e erros
                    apiProcess.OutputDataReceived += (sender, e) => AppendOutput(e.Data);
                    apiProcess.ErrorDataReceived += (sender, e) => AppendOutput(e.Data);

                    // Inicia a leitura ass�ncrona da sa�da padr�o e de erro
                    apiProcess.BeginOutputReadLine();
                    apiProcess.BeginErrorReadLine();

                    richTextBox1.Text = $"Data e Hora: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}" + Environment.NewLine;
                    lblStatus.Text = "API iniciada. Verifique log abaixo.";
                }
                else
                {
                    lblStatus.Text = "Falha ao iniciar a API.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Erro ao iniciar a API: {ex.Message}";
            }
        }

        private void StopApi()
        {
            try
            {
                // Verifica se o processo est� rodando
                var processes = Process.GetProcessesByName(apiProcessName);
                foreach (var process in processes)
                {
                    // Se o processo estiver rodando, tente par�-lo
                    process.Kill();
                    process.WaitForExit();
                }

                lblStatus.Text = "A API foi parada.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Erro ao parar a API: {ex.Message}";
            }
        }

        private bool IsProcessRunning(string processName)
        {
            var processes = Process.GetProcessesByName(processName);
            return processes.Any();
        }

        private void AppendOutput(string? data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                // Atualiza o RichTextBox com a nova linha de sa�da
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke((MethodInvoker)(() => AppendTextToRichTextBox(data, Color.DarkGreen))); // Altere a cor conforme necess�rio
                }
                else
                {
                    AppendTextToRichTextBox(data, Color.Red); // Altere a cor conforme necess�rio
                }
            }
        }

        private void AppendTextToRichTextBox(string data, Color color)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(data + Environment.NewLine);
            richTextBox1.SelectionColor = richTextBox1.ForeColor; // Restaura a cor padr�o
            richTextBox1.ScrollToCaret(); // Faz o RichTextBox rolar para o final
        }

        private void FromPrincipal_Shown(object sender, EventArgs e)
        {
            btnVerificar.PerformClick();
        }
    }
}
