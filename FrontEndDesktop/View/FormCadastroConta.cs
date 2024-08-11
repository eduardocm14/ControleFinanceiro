using System;
using System.Windows.Forms;
using WindowsFormFinanceiro.Model;
using WindowsFormFinanceiro.Util;

namespace WindowsFormFinanceiro.View
{
    public partial class FormCadastroConta : Form
    {
        private ContaController controlador;
        public Utilitario.OperacaoCRUD tipoOperacao { get; set; }
        public int codigoConta { get; set; }

        public FormCadastroConta()
        {
            InitializeComponent();
            controlador = new ContaController();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var conta = controlador.BuscarContaPorId(codigoConta);

            if (conta != null)
            {
                if (this.tipoOperacao == Utilitario.OperacaoCRUD.Alteracao)
                {
                    conta.Nome = textBoxNome.Text;
                    conta.Valor = decimal.Parse(textBoxValor.Text);
                    conta.DataVencimento = dataVencimento.Value.Date;
                }
                else if (this.tipoOperacao == Utilitario.OperacaoCRUD.PagarConta)
                {
                    conta.DataPagamento = dataPagamento.Value.Date;
                    conta.Pago = true;
                }
                controlador.AtualizarConta(conta);
            }
            else if (this.tipoOperacao == Utilitario.OperacaoCRUD.Inclusao)
            {
                var contaInclusao = new Conta
                {
                    Id = codigoConta,
                    Nome = textBoxNome.Text,
                    Valor = decimal.Parse(textBoxValor.Text),
                    DataVencimento = dataVencimento.Value.Date,
                };

                controlador.AdicionarConta(contaInclusao);
            }

            MessageBox.Show("Registro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            Utilitario.Moeda(ref textBoxValor);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Exibe a mensagem de confirmação
            var result = MessageBox.Show("Tem certeza que deseja cancelar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result == DialogResult.Yes)
            {
                this.Close();
                //MessageBox.Show("Registro cancelado com sucesso.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            dataVencimento.Value = DateTime.Now;
            dataPagamento.Value = DateTime.Now;

            if (this.tipoOperacao == Utilitario.OperacaoCRUD.Alteracao)
            {
                labelOperacao.Text = "Alterando cadastro de conta";
                labelPagamento.Visible = false;
                dataPagamento.Visible = false;
                EditarConta();
            }
            else if (this.tipoOperacao == Utilitario.OperacaoCRUD.PagarConta)
            {
                labelOperacao.Text = "Pagamento de conta";
                PagarConta();
            }
            else if (this.tipoOperacao == Utilitario.OperacaoCRUD.Inclusao)
            {
                labelOperacao.Text = "Cadastrando nova conta";
            }
        }

        private void EditarConta()
        {
            var conta = controlador.BuscarContaPorId(codigoConta);

            if (conta != null)
            {
                textBoxNome.Text = conta.Nome;
                textBoxValor.Text = conta.Valor.ToString();
                dataVencimento.Value = conta.DataVencimento;
            }
        }

        private void PagarConta()
        {
            var conta = controlador.BuscarContaPorId(codigoConta);

            if (conta != null)
            {
                textBoxNome.Text = conta.Nome;
                textBoxValor.Text = conta.Valor.ToString();
                dataVencimento.Value = conta.DataVencimento;

                textBoxNome.ReadOnly = true;
                textBoxValor.ReadOnly = true;
                dataVencimento.Enabled = false;
                dataPagamento.Enabled = true;
                dataPagamento.Focus();
            }
        }
    }
}
