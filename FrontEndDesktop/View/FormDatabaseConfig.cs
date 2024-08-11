using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormFinanceiro.Data;
using WindowsFormFinanceiro.Util;

namespace WindowsFormFinanceiro.View
{
    public partial class FormDatabaseConfig : Form
    {
        private readonly IniFile iniFile = Utilitario.GetConfigBancoDadosINI();
        private readonly Utilitario utilitario = new Utilitario();
        public bool statusConexaoBanco { get; set; }
        public bool erroConexaoBanco { get; set; }
        public FormDatabaseConfig()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            textBoxServer.Text = iniFile.Read("DatabaseConfig", "Server");
            textBoxDatabase.Text = iniFile.Read("DatabaseConfig", "Database");
            textBoxUser.Text = iniFile.Read("DatabaseConfig", "User");
            textBoxPassword.Text = iniFile.Read("DatabaseConfig", "Password");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveConfigurations();

            if (TestDatabaseConnection())
            {
                statusConexaoBanco = true;
                ShowSuccessMessageAndRestart();
            }
            else
            {
                statusConexaoBanco = false;
                ShowFailureMessage();
                HighlightTextBoxes();
            }
        }

        private void FormDatabaseConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!statusConexaoBanco)
            {
                var result = MessageBox.Show("Sair sem configurar conexão com banco de dados?", "Confirmação de Saída", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SaveConfigurations()
        {
            iniFile.Write("DatabaseConfig", "Server", textBoxServer.Text);
            iniFile.Write("DatabaseConfig", "Database", textBoxDatabase.Text);
            iniFile.Write("DatabaseConfig", "User", textBoxUser.Text);
            iniFile.Write("DatabaseConfig", "Password", textBoxPassword.Text);
        }

        private bool TestDatabaseConnection()
        {
            return utilitario.ValidarConexaoBancoDados();
        }

        private void ShowSuccessMessageAndRestart()
        {
            MessageBox.Show("Configurações salvas com sucesso. Aplicação será reiniciada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            utilitario.RestartApplication();
        }

        private void ShowFailureMessage()
        {
            MessageBox.Show("Falha na conexão. Verifique suas configurações.", "Teste de Conexão");
        }

        private void HighlightTextBoxes()
        {
            textBoxServer.ForeColor = Color.Red;
            textBoxDatabase.ForeColor = Color.Red;
            textBoxUser.ForeColor = Color.Red;
            textBoxPassword.ForeColor = Color.Red;
        }

        private void FormDatabaseConfig_Load(object sender, EventArgs e)
        {
            if (this.erroConexaoBanco)
            {
                HighlightTextBoxes();
            }
        }
    }
}
