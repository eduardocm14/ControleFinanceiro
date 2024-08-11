using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormFinanceiro.Model;
using WindowsFormFinanceiro.Util;
using WindowsFormFinanceiro.View;
using static WindowsFormFinanceiro.Util.Utilitario;

namespace WindowsFormFinanceiro
{
    public partial class FormPrincipal : Form
    {
        private ContaController controlador;
        private readonly Utilitario utilitario = new Utilitario();
        private int _codigoConta = 0;
        private string _descricaoFornecedor = string.Empty;
        private bool _pago;
        private DateTime _dataVencimento;

        public FormPrincipal()
        {
            InitializeComponent();
            OrdemIniciacaoForms();
        }

        public void ExibirContas()
        {
            // dataGridViewRegistros.DataSource = null; // Limpar os dados existentes
            //dataGridViewRegistros.DataSource = controlador.CarregarContas(); // Carregar os dados atualizados
            btnVencimentoMes_Click(null, null);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Utilitario.restartApplication)
            {
                var result = MessageBox.Show("Deseja realmente sair?", "Confirmação de Saída", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Convert.ToString(result) == "Cancel")
                {
                    e.Cancel = true;
                }
            }
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnIncluir.PerformClick();
                    break;
                case Keys.F3:
                    btnEditar.PerformClick();
                    break;
                case Keys.F6:
                    btnExcluir.PerformClick();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AppDbContext"].ConnectionString;

            DatabaseTesterManual tester = new DatabaseTesterManual(connectionString);

            if (tester.TestarConexao())
            {
                MessageBox.Show("Conexão bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha na conexão. Verifique os detalhes da conexão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            var frmCadastroContasNovo = new FormCadastroConta
            {
                tipoOperacao = Utilitario.OperacaoCRUD.Inclusao
            };
            frmCadastroContasNovo.ShowDialog();
            ExibirContas();
            RegistrosPagos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegistros.SelectedRows.Count > 0 && this._codigoConta > 0)
            {
                if (!this._pago)
                {
                    // Exibe a mensagem de confirmação
                    var result = MessageBox.Show($"Deseja excluir o registro[Código:{this._codigoConta} - Fornecedor:{this._descricaoFornecedor}]?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verifica a resposta do usuário
                    if (result == DialogResult.Yes)
                    {
                        controlador.ExcluirConta(this._codigoConta);
                        ExibirContas();
                        RegistrosPagos();
                    }
                }
                else
                {
                    MessageBox.Show("Contas Pagas não podem ser excluídas!", "Ti liga Tchê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ExibirContas();
                RegistrosPagos();
            }
        }

        private void dataGridViewRegistros_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se há linhas selecionadas
            if (dataGridViewRegistros.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dataGridViewRegistros.SelectedRows[0];

                // Obtém os valores das células da linha selecionada
                this._codigoConta = Convert.ToInt32(selectedRow.Cells["id"].Value);
                this._descricaoFornecedor = selectedRow.Cells["nome"].Value.ToString();
                this._pago = Convert.ToBoolean(selectedRow.Cells["pago"].Value);
            }
        }

        private void RegistrosPagos()
        {
            bool registroGreen;
            bool registroRed;

            foreach (DataGridViewRow row in dataGridViewRegistros.Rows)
            {
                this._pago = Convert.ToBoolean(row.Cells["pago"].Value);
                this._dataVencimento = Convert.ToDateTime(row.Cells["datavencimento"].Value);

                registroGreen = (this._pago);
                registroRed = !this._pago & this._dataVencimento < DateTime.Now.Date;

                if (registroGreen)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    // row.DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (registroRed)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            dataGridViewRegistros.Refresh();
        }

        private void TotalizarValores()
        {
            decimal totalPago = 0;
            decimal totalPagar = 0;
            int totalRegistros = 0;

            foreach (DataGridViewRow row in dataGridViewRegistros.Rows)
            {
                // Obtém o valor da célula e soma ao total
                if (row.Cells["Valor"].Value != null)
                {
                    totalPagar +=  (decimal)row.Cells["Valor"].Value;
                }

                if (row.Cells["Valor"].Value != null && Convert.ToBoolean(row.Cells["pago"].Value))
                {
                    totalPago += (decimal)row.Cells["Valor"].Value;
                }

                totalRegistros++;
            }

            labelTotalRegistros.Text = $"Total de Registros:{totalRegistros:D3}";
            labelValorTotalPagar.Text = $"Valor Total Pagar:{totalPagar:C2}";
            labelValorTotalPagar.ForeColor = Color.Red;
            labelValorTotalPago.Text = $"Valor Total Pago:{totalPago:C2}";
            labelValorTotalPago.ForeColor = Color.DarkGreen;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            TiposRegistroFiltrado();
            RegistrosPagos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

            SaveDataGridView saveDataGridView = new SaveDataGridView();
            saveDataGridView.Save(dataGridViewRegistros);

            //SaveFileDialog saveFileDialog = new SaveFileDialog();

            //saveFileDialog.Filter = "OpenDocument Spreadsheet|*.ods";
            //saveFileDialog.Title = "Salvar como Planilha ODS";
            //saveFileDialog.ShowDialog();

            //if (saveFileDialog.FileName != "")
            //{
            //    //Utilitario.ExportToODS(dataGridViewRegistros, saveFileDialog.FileName);
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegistros.SelectedRows.Count > 0 && this._codigoConta > 0)
            {
                if (!this._pago)
                {
                    var frmCadastroContasEditar = new FormCadastroConta
                    {
                        tipoOperacao = Utilitario.OperacaoCRUD.Alteracao,
                        codigoConta = this._codigoConta
                    };
                    frmCadastroContasEditar.ShowDialog();
                    ExibirContas();
                    RegistrosPagos();
                }
                else
                {
                    MessageBox.Show("Contas Pagas não podem ser editadas!", "Ti liga Tchê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void testeConexãoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (utilitario.ValidarConexaoBancoDados())
            {
                MessageBox.Show("Conexão[Entity] - bem-sucedida!", "Teste de Conexão");
            }
            else
            {
                MessageBox.Show("Falha na conexão. Verifique suas configurações.", "Teste de Conexão");
            }
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegistros.SelectedRows.Count > 0 && this._codigoConta > 0)
            {
                if (!this._pago)
                {
                    var conta = controlador.BuscarContaPorId(_codigoConta);

                    // Exibe a mensagem de confirmação
                    var result = MessageBox.Show($"Confirma pagamento da conta[Código:{conta.Id} / Fornecedor:{conta.Nome}]?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verifica a resposta do usuário
                    if (result == DialogResult.Yes)
                    {
                        if (conta != null)
                        {
                            conta.DataPagamento = DateTime.Now;
                            conta.Pago = true;
                        }

                        controlador.AtualizarConta(conta);

                        ExibirContas();
                        RegistrosPagos();
                    }
                }
                else
                {
                    MessageBox.Show("Contas Pagas não podem ser editadas!", "Ti liga Tchê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarContasPorDatasDataGrid(dtpPesquisaInicio.Value, dtpPesquisaFinal.Value, comboBoxTiposRegistros.SelectedIndex, textBoxDescricaoConta.Text);
            RegistrosPagos();
            TotalizarValores();
            //UpdateTotalizadores(dtpPesquisaInicio.Value.Date, dtpPesquisaFinal.Value.Date);
        }

        private void btnVencimentoHoje_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today;
            AtualizarContasPorDatasDataGrid(dataInicio, dataFim, comboBoxTiposRegistros.SelectedIndex);
            RegistrosPagos();
        }

        private void btnVencimentoMes_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime dataFim = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            statusLabelData.Text = $"Período da consulta: {dataInicio.Date}";
            AtualizarContasPorDatasDataGrid(dataInicio, dataFim, comboBoxTiposRegistros.SelectedIndex);
            RegistrosPagos();
        }

        private void btnVencimentoSeteDias_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today.AddDays(7);
            AtualizarContasPorDatasDataGrid(dataInicio, dataFim, comboBoxTiposRegistros.SelectedIndex);
            RegistrosPagos();
        }

        private void btnVencimentoQuinzeDias_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today.AddDays(15);
            AtualizarContasPorDatasDataGrid(dataInicio, dataFim, comboBoxTiposRegistros.SelectedIndex);
            RegistrosPagos();
        }

        private void AtualizarContasPorDatasDataGrid(DateTime dataInicio, DateTime dataFim, int tipoConta, string descricaoConta = "")
        {
            var contas = controlador.GetContasPorDatas(dataInicio, dataFim, tipoConta, descricaoConta);

            dataGridViewRegistros.DataSource = contas;

            TotalizarValores();
        }

        private void AtualizarContasPorDataPagamentoDataGrid(DateTime dataInicio, DateTime dataFim)
        {
            var contas = controlador.GetContasPorDataPagamento(dataInicio, dataFim);
            dataGridViewRegistros.DataSource = contas;
            TotalizarValores();
        }

        private void btnPagamentoHoje_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today;
            AtualizarContasPorDataPagamentoDataGrid(dataInicio, dataFim);
            RegistrosPagos();
        }

        private void btnPagamentoMes_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime dataFim = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            AtualizarContasPorDataPagamentoDataGrid(dataInicio, dataFim);
            RegistrosPagos();
        }

        private void btnPagamentoSeteDias_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today.AddDays(7);
            AtualizarContasPorDataPagamentoDataGrid(dataInicio, dataFim);
            RegistrosPagos();
        }

        private void btnPagamentoQuinzeDias_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Today;
            DateTime dataFim = DateTime.Today.AddDays(15);
            AtualizarContasPorDataPagamentoDataGrid(dataInicio, dataFim);
            RegistrosPagos();
        }

        private void TiposRegistroFiltrado()
        {
            var itemSelecionado = comboBoxTiposRegistros.SelectedIndex;

            if (itemSelecionado == Utilitario.TipoContas.Todas.GetHashCode())
            {
                labelTiposRegistros.ForeColor = Color.Black;
                labelTiposRegistros.Text = $"Tipo de Registros: {comboBoxTiposRegistros.SelectedItem}";
                dtpPesquisaInicio.Enabled = true;
                dtpPesquisaFinal.Enabled = true;
                dtpPesquisaInicio.Focus();
            }
            else if (itemSelecionado == Utilitario.TipoContas.ContasPagar.GetHashCode())
            {
                labelTiposRegistros.ForeColor = Color.YellowGreen;
                labelTiposRegistros.Text = $"Tipo de Registros: {comboBoxTiposRegistros.SelectedItem}";
                dtpPesquisaInicio.Enabled = true;
                dtpPesquisaFinal.Enabled = true;
                dtpPesquisaInicio.Focus();
            }
            else if (itemSelecionado == Utilitario.TipoContas.ContasPagas.GetHashCode())
            {
                labelTiposRegistros.ForeColor = Color.Green;
                labelTiposRegistros.Text = $"Tipo de Registros: {comboBoxTiposRegistros.SelectedItem}";
                dtpPesquisaInicio.Enabled = true;
                dtpPesquisaFinal.Enabled = true;
                dtpPesquisaInicio.Focus();
            }
            else
            {
                labelTiposRegistros.ForeColor = Color.Red;
                labelTiposRegistros.Text = $"Tipo de Registros: {comboBoxTiposRegistros.SelectedItem}";
                dtpPesquisaInicio.Enabled = false;
                dtpPesquisaFinal.Enabled = false;
                btnPesquisar.Focus();
            }
        }

        private void comboBoxTiposRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            TiposRegistroFiltrado();
        }

        private void configuraçõesBancoDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDatabaseConfig = new FormDatabaseConfig();
            formDatabaseConfig.ShowDialog();
        }

        private void OrdemIniciacaoForms()
        {
            try
            {
                comboBoxTiposRegistros.SelectedIndex = Utilitario.TipoContas.Todas.GetHashCode();

                var iniFile = GetConfigBancoDadosINI();

                if (!utilitario.ConexaoCorretaBancoDados())
                {
                    MessageBox.Show("Falha na conexão. Verifique suas configurações.", "Teste de Conexão");

                    var formDatabaseConfig = new FormDatabaseConfig
                    {
                        erroConexaoBanco = true
                    };

                    formDatabaseConfig.ShowDialog();

                    if (!formDatabaseConfig.statusConexaoBanco)
                    {
                        this.Close();
                    }
                }
                else
                {
                    var textServer = iniFile.Read("DatabaseConfig", "Server");
                    var textDatabase = iniFile.Read("DatabaseConfig", "Database");

                    controlador = new ContaController();
                    ExibirContas();
                    statusLabelProjectPath.Text = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    toolStripStatusBancoDadosPath.Text = $"Banco Dados: {textServer}:{textDatabase}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha no método: OrdemIniciacaoForms: {ex.Message}", "Erro Exception");
            }
        }

        private void pagarInformadoADataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewRegistros.SelectedRows.Count > 0 && this._codigoConta > 0)
            {
                if (!this._pago)
                {
                    var frmCadastroContasEditar = new FormCadastroConta
                    {
                        tipoOperacao = Utilitario.OperacaoCRUD.PagarConta,
                        codigoConta = this._codigoConta
                    };
                    frmCadastroContasEditar.ShowDialog();
                    ExibirContas();
                    RegistrosPagos();
                }
                else
                {
                    MessageBox.Show("Contas Pagas não podem ser editadas!", "Ti liga Tchê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void backupBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Caminho para o seu arquivo .bat
            string batFilePath = @"C:\Eduardo\.NET\ControleFinanceiroEntityPostgreSQL\Util\BKP-PostgreSQL.bat";

            try
            {
                // Cria um novo processo
                Process process = new Process();
                process.StartInfo.FileName = batFilePath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                // Inicia o processo
                process.Start();

                // Lê a saída do processo de forma assíncrona
                Task<string> outputTask = process.StandardOutput.ReadToEndAsync();
                Task<string> errorTask = process.StandardError.ReadToEndAsync();

                // Aguarda o processo terminar de forma assíncrona
                await WaitForExitAsync(process);

                // Aguarda as tarefas de leitura concluírem
                string output = await outputTask;
                string error = await errorTask;

                if (string.IsNullOrEmpty(error))
                {
                    // Exibe mensagem de sucesso se não houver erros
                    MessageBox.Show("Backup executado com sucesso.\n" + output, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Exibe os erros (se houver)
                    MessageBox.Show("Erro ao executar Backup:\n" + error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Trata exceções (se houver)
                MessageBox.Show("Erro ao executar Backup: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Task WaitForExitAsync(Process process)
        {
            var tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.SetResult(null);
            if (process.HasExited)
                tcs.SetResult(null);
            return tcs.Task;
        }

        private void gerarContaMêsAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegistros.SelectedRows.Count > 0 && this._codigoConta > 0)
            {
                if (this._pago)
                {
                    if (dataGridViewRegistros.SelectedRows.Count > 0)
                    {
                        // Obtém a linha selecionada
                        DataGridViewRow selectedRow = dataGridViewRegistros.SelectedRows[0];

                        var descricaoFornecedor = selectedRow.Cells["nome"].Value.ToString();
                        var dataVencimento = Convert.ToDateTime(selectedRow.Cells["datavencimento"].Value);
                        var valorPagar = Convert.ToDouble(selectedRow.Cells["valor"].Value);

                        var contaInclusao = new Conta
                        {
                            Nome = descricaoFornecedor,
                            Valor = (decimal)valorPagar,
                            DataVencimento = dataVencimento.Date.AddMonths(1),
                        };

                        controlador.AdicionarConta(contaInclusao);

                        MessageBox.Show("Contas criada no mês atual!", "Sucesso Tchê", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Somente Contas Pagas podem ser copiadas para mês atual!", "Ti liga Tchê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
