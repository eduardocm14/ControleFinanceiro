namespace WindowsFormFinanceiro
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelNome = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelProjectPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusBancoDadosPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.labelTiposRegistros = new System.Windows.Forms.Label();
            this.labelDescricaoConta = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescricaoConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPesquisaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpPesquisaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPagamentos = new System.Windows.Forms.GroupBox();
            this.btnPagamentoQuinzeDias = new System.Windows.Forms.Button();
            this.btnPagamentoSeteDias = new System.Windows.Forms.Button();
            this.btnPagamentoMes = new System.Windows.Forms.Button();
            this.btnPagamentoHoje = new System.Windows.Forms.Button();
            this.groupBoxVencimentos = new System.Windows.Forms.GroupBox();
            this.btnVencimentoQuinzeDias = new System.Windows.Forms.Button();
            this.btnVencimentoSeteDias = new System.Windows.Forms.Button();
            this.btnVencimentoMes = new System.Windows.Forms.Button();
            this.btnVencimentoHoje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTiposRegistros = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeConexãoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesBancoDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelValorTotalPago = new System.Windows.Forms.Label();
            this.labelValorTotalPagar = new System.Windows.Forms.Label();
            this.labelTotalRegistros = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dataGridViewRegistros = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarInformadoADataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarContaMêsAtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarContaMêsAtualGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            this.groupBoxPesquisa.SuspendLayout();
            this.groupBoxPagamentos.SuspendLayout();
            this.groupBoxVencimentos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelNome,
            this.statusLabelData,
            this.statusLabelVersao,
            this.statusLabelProjectPath,
            this.toolStripStatusBancoDadosPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 784);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1404, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelNome
            // 
            this.statusLabelNome.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.statusLabelNome.Name = "statusLabelNome";
            this.statusLabelNome.Size = new System.Drawing.Size(137, 17);
            this.statusLabelNome.Text = "Desenv. Eduardo Moraes";
            // 
            // statusLabelData
            // 
            this.statusLabelData.Name = "statusLabelData";
            this.statusLabelData.Size = new System.Drawing.Size(65, 17);
            this.statusLabelData.Text = "21/05/2024";
            // 
            // statusLabelVersao
            // 
            this.statusLabelVersao.Name = "statusLabelVersao";
            this.statusLabelVersao.Size = new System.Drawing.Size(52, 17);
            this.statusLabelVersao.Text = "vrs. 1.0.0";
            // 
            // statusLabelProjectPath
            // 
            this.statusLabelProjectPath.Name = "statusLabelProjectPath";
            this.statusLabelProjectPath.Size = new System.Drawing.Size(118, 17);
            this.statusLabelProjectPath.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusBancoDadosPath
            // 
            this.toolStripStatusBancoDadosPath.Name = "toolStripStatusBancoDadosPath";
            this.toolStripStatusBancoDadosPath.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusBancoDadosPath.Text = "toolStripStatusLabel1";
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPesquisa.Controls.Add(this.groupBoxPesquisa);
            this.panelPesquisa.Controls.Add(this.groupBoxPagamentos);
            this.panelPesquisa.Controls.Add(this.groupBoxVencimentos);
            this.panelPesquisa.Controls.Add(this.label1);
            this.panelPesquisa.Controls.Add(this.comboBoxTiposRegistros);
            this.panelPesquisa.Controls.Add(this.menuStrip1);
            this.panelPesquisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPesquisa.Location = new System.Drawing.Point(0, 0);
            this.panelPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(522, 784);
            this.panelPesquisa.TabIndex = 1;
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPesquisa.Controls.Add(this.labelTiposRegistros);
            this.groupBoxPesquisa.Controls.Add(this.labelDescricaoConta);
            this.groupBoxPesquisa.Controls.Add(this.btnPesquisar);
            this.groupBoxPesquisa.Controls.Add(this.label4);
            this.groupBoxPesquisa.Controls.Add(this.textBoxDescricaoConta);
            this.groupBoxPesquisa.Controls.Add(this.label5);
            this.groupBoxPesquisa.Controls.Add(this.dtpPesquisaFinal);
            this.groupBoxPesquisa.Controls.Add(this.dtpPesquisaInicio);
            this.groupBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesquisa.Location = new System.Drawing.Point(29, 444);
            this.groupBoxPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPesquisa.Size = new System.Drawing.Size(461, 290);
            this.groupBoxPesquisa.TabIndex = 14;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Filtros de Pesquisa";
            // 
            // labelTiposRegistros
            // 
            this.labelTiposRegistros.AutoSize = true;
            this.labelTiposRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiposRegistros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTiposRegistros.Location = new System.Drawing.Point(4, 123);
            this.labelTiposRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiposRegistros.Name = "labelTiposRegistros";
            this.labelTiposRegistros.Size = new System.Drawing.Size(152, 17);
            this.labelTiposRegistros.TabIndex = 2;
            this.labelTiposRegistros.Text = "labelTiposRegistros";
            // 
            // labelDescricaoConta
            // 
            this.labelDescricaoConta.AutoSize = true;
            this.labelDescricaoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricaoConta.Location = new System.Drawing.Point(4, 66);
            this.labelDescricaoConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescricaoConta.Name = "labelDescricaoConta";
            this.labelDescricaoConta.Size = new System.Drawing.Size(136, 17);
            this.labelDescricaoConta.TabIndex = 0;
            this.labelDescricaoConta.Text = "Descrição da Conta:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(23, 206);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(412, 63);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "até:";
            // 
            // textBoxDescricaoConta
            // 
            this.textBoxDescricaoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricaoConta.Location = new System.Drawing.Point(8, 91);
            this.textBoxDescricaoConta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescricaoConta.Name = "textBoxDescricaoConta";
            this.textBoxDescricaoConta.Size = new System.Drawing.Size(444, 23);
            this.textBoxDescricaoConta.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "De:";
            // 
            // dtpPesquisaFinal
            // 
            this.dtpPesquisaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPesquisaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisaFinal.Location = new System.Drawing.Point(288, 161);
            this.dtpPesquisaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPesquisaFinal.Name = "dtpPesquisaFinal";
            this.dtpPesquisaFinal.Size = new System.Drawing.Size(145, 23);
            this.dtpPesquisaFinal.TabIndex = 6;
            // 
            // dtpPesquisaInicio
            // 
            this.dtpPesquisaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPesquisaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisaInicio.Location = new System.Drawing.Point(59, 161);
            this.dtpPesquisaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPesquisaInicio.Name = "dtpPesquisaInicio";
            this.dtpPesquisaInicio.Size = new System.Drawing.Size(145, 23);
            this.dtpPesquisaInicio.TabIndex = 4;
            // 
            // groupBoxPagamentos
            // 
            this.groupBoxPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPagamentos.Controls.Add(this.btnPagamentoQuinzeDias);
            this.groupBoxPagamentos.Controls.Add(this.btnPagamentoSeteDias);
            this.groupBoxPagamentos.Controls.Add(this.btnPagamentoMes);
            this.groupBoxPagamentos.Controls.Add(this.btnPagamentoHoje);
            this.groupBoxPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPagamentos.Location = new System.Drawing.Point(29, 311);
            this.groupBoxPagamentos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPagamentos.Name = "groupBoxPagamentos";
            this.groupBoxPagamentos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPagamentos.Size = new System.Drawing.Size(461, 82);
            this.groupBoxPagamentos.TabIndex = 3;
            this.groupBoxPagamentos.TabStop = false;
            this.groupBoxPagamentos.Text = "Período de pagamento:";
            // 
            // btnPagamentoQuinzeDias
            // 
            this.btnPagamentoQuinzeDias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPagamentoQuinzeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentoQuinzeDias.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPagamentoQuinzeDias.Location = new System.Drawing.Point(347, 26);
            this.btnPagamentoQuinzeDias.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagamentoQuinzeDias.Name = "btnPagamentoQuinzeDias";
            this.btnPagamentoQuinzeDias.Size = new System.Drawing.Size(109, 38);
            this.btnPagamentoQuinzeDias.TabIndex = 3;
            this.btnPagamentoQuinzeDias.Text = "15 Dias";
            this.btnPagamentoQuinzeDias.UseVisualStyleBackColor = false;
            this.btnPagamentoQuinzeDias.Click += new System.EventHandler(this.btnPagamentoQuinzeDias_Click);
            // 
            // btnPagamentoSeteDias
            // 
            this.btnPagamentoSeteDias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPagamentoSeteDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentoSeteDias.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPagamentoSeteDias.Location = new System.Drawing.Point(233, 26);
            this.btnPagamentoSeteDias.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagamentoSeteDias.Name = "btnPagamentoSeteDias";
            this.btnPagamentoSeteDias.Size = new System.Drawing.Size(109, 38);
            this.btnPagamentoSeteDias.TabIndex = 2;
            this.btnPagamentoSeteDias.Text = "7 Dias";
            this.btnPagamentoSeteDias.UseVisualStyleBackColor = false;
            this.btnPagamentoSeteDias.Click += new System.EventHandler(this.btnPagamentoSeteDias_Click);
            // 
            // btnPagamentoMes
            // 
            this.btnPagamentoMes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPagamentoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentoMes.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPagamentoMes.Location = new System.Drawing.Point(119, 26);
            this.btnPagamentoMes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagamentoMes.Name = "btnPagamentoMes";
            this.btnPagamentoMes.Size = new System.Drawing.Size(109, 38);
            this.btnPagamentoMes.TabIndex = 1;
            this.btnPagamentoMes.Text = "Mês";
            this.btnPagamentoMes.UseVisualStyleBackColor = false;
            this.btnPagamentoMes.Click += new System.EventHandler(this.btnPagamentoMes_Click);
            // 
            // btnPagamentoHoje
            // 
            this.btnPagamentoHoje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPagamentoHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentoHoje.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPagamentoHoje.Location = new System.Drawing.Point(5, 26);
            this.btnPagamentoHoje.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagamentoHoje.Name = "btnPagamentoHoje";
            this.btnPagamentoHoje.Size = new System.Drawing.Size(109, 38);
            this.btnPagamentoHoje.TabIndex = 0;
            this.btnPagamentoHoje.Text = "Hoje";
            this.btnPagamentoHoje.UseVisualStyleBackColor = false;
            this.btnPagamentoHoje.Click += new System.EventHandler(this.btnPagamentoHoje_Click);
            // 
            // groupBoxVencimentos
            // 
            this.groupBoxVencimentos.Controls.Add(this.btnVencimentoQuinzeDias);
            this.groupBoxVencimentos.Controls.Add(this.btnVencimentoSeteDias);
            this.groupBoxVencimentos.Controls.Add(this.btnVencimentoMes);
            this.groupBoxVencimentos.Controls.Add(this.btnVencimentoHoje);
            this.groupBoxVencimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVencimentos.Location = new System.Drawing.Point(29, 133);
            this.groupBoxVencimentos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVencimentos.Name = "groupBoxVencimentos";
            this.groupBoxVencimentos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVencimentos.Size = new System.Drawing.Size(461, 81);
            this.groupBoxVencimentos.TabIndex = 2;
            this.groupBoxVencimentos.TabStop = false;
            this.groupBoxVencimentos.Text = "Período de vencimento:";
            // 
            // btnVencimentoQuinzeDias
            // 
            this.btnVencimentoQuinzeDias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVencimentoQuinzeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencimentoQuinzeDias.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVencimentoQuinzeDias.Location = new System.Drawing.Point(347, 26);
            this.btnVencimentoQuinzeDias.Margin = new System.Windows.Forms.Padding(4);
            this.btnVencimentoQuinzeDias.Name = "btnVencimentoQuinzeDias";
            this.btnVencimentoQuinzeDias.Size = new System.Drawing.Size(109, 38);
            this.btnVencimentoQuinzeDias.TabIndex = 3;
            this.btnVencimentoQuinzeDias.Text = "15 Dias";
            this.btnVencimentoQuinzeDias.UseVisualStyleBackColor = false;
            this.btnVencimentoQuinzeDias.Click += new System.EventHandler(this.btnVencimentoQuinzeDias_Click);
            // 
            // btnVencimentoSeteDias
            // 
            this.btnVencimentoSeteDias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVencimentoSeteDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencimentoSeteDias.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVencimentoSeteDias.Location = new System.Drawing.Point(233, 26);
            this.btnVencimentoSeteDias.Margin = new System.Windows.Forms.Padding(4);
            this.btnVencimentoSeteDias.Name = "btnVencimentoSeteDias";
            this.btnVencimentoSeteDias.Size = new System.Drawing.Size(109, 38);
            this.btnVencimentoSeteDias.TabIndex = 2;
            this.btnVencimentoSeteDias.Text = "7 Dias";
            this.btnVencimentoSeteDias.UseVisualStyleBackColor = false;
            this.btnVencimentoSeteDias.Click += new System.EventHandler(this.btnVencimentoSeteDias_Click);
            // 
            // btnVencimentoMes
            // 
            this.btnVencimentoMes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVencimentoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencimentoMes.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVencimentoMes.Location = new System.Drawing.Point(119, 26);
            this.btnVencimentoMes.Margin = new System.Windows.Forms.Padding(4);
            this.btnVencimentoMes.Name = "btnVencimentoMes";
            this.btnVencimentoMes.Size = new System.Drawing.Size(109, 38);
            this.btnVencimentoMes.TabIndex = 1;
            this.btnVencimentoMes.Text = "Mês";
            this.btnVencimentoMes.UseVisualStyleBackColor = false;
            this.btnVencimentoMes.Click += new System.EventHandler(this.btnVencimentoMes_Click);
            // 
            // btnVencimentoHoje
            // 
            this.btnVencimentoHoje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnVencimentoHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencimentoHoje.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVencimentoHoje.Location = new System.Drawing.Point(5, 26);
            this.btnVencimentoHoje.Margin = new System.Windows.Forms.Padding(4);
            this.btnVencimentoHoje.Name = "btnVencimentoHoje";
            this.btnVencimentoHoje.Size = new System.Drawing.Size(109, 38);
            this.btnVencimentoHoje.TabIndex = 0;
            this.btnVencimentoHoje.Text = "Hoje";
            this.btnVencimentoHoje.UseVisualStyleBackColor = false;
            this.btnVencimentoHoje.Click += new System.EventHandler(this.btnVencimentoHoje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de pesquisa nos registros:";
            // 
            // comboBoxTiposRegistros
            // 
            this.comboBoxTiposRegistros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTiposRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTiposRegistros.FormattingEnabled = true;
            this.comboBoxTiposRegistros.Items.AddRange(new object[] {
            "Todas",
            "Contas a Pagar",
            "Contas Pagas",
            "Contas Vencidas"});
            this.comboBoxTiposRegistros.Location = new System.Drawing.Point(29, 68);
            this.comboBoxTiposRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTiposRegistros.Name = "comboBoxTiposRegistros";
            this.comboBoxTiposRegistros.Size = new System.Drawing.Size(460, 24);
            this.comboBoxTiposRegistros.TabIndex = 0;
            this.comboBoxTiposRegistros.SelectedIndexChanged += new System.EventHandler(this.comboBoxTiposRegistros_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeConexãoBancoDeDadosToolStripMenuItem,
            this.configuraçõesBancoDadosToolStripMenuItem,
            this.backupBancoDeDadosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem1.Text = "Configuração";
            // 
            // testeConexãoBancoDeDadosToolStripMenuItem
            // 
            this.testeConexãoBancoDeDadosToolStripMenuItem.Name = "testeConexãoBancoDeDadosToolStripMenuItem";
            this.testeConexãoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.testeConexãoBancoDeDadosToolStripMenuItem.Text = "Teste Conexão Banco de Dados";
            this.testeConexãoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.testeConexãoBancoDeDadosToolStripMenuItem_Click);
            // 
            // configuraçõesBancoDadosToolStripMenuItem
            // 
            this.configuraçõesBancoDadosToolStripMenuItem.Name = "configuraçõesBancoDadosToolStripMenuItem";
            this.configuraçõesBancoDadosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.configuraçõesBancoDadosToolStripMenuItem.Text = "Configurações Banco Dados";
            this.configuraçõesBancoDadosToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesBancoDadosToolStripMenuItem_Click);
            // 
            // backupBancoDeDadosToolStripMenuItem
            // 
            this.backupBancoDeDadosToolStripMenuItem.Name = "backupBancoDeDadosToolStripMenuItem";
            this.backupBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.backupBancoDeDadosToolStripMenuItem.Text = "Backup Banco de Dados";
            this.backupBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.backupBancoDeDadosToolStripMenuItem_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.btnEditar);
            this.panelButtons.Controls.Add(this.btnIncluir);
            this.panelButtons.Controls.Add(this.btnExcluir);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButtons.Location = new System.Drawing.Point(522, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(882, 125);
            this.panelButtons.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(646, 13);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(211, 55);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar(F3)";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(335, 13);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(211, 55);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir(F2)";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(20, 13);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(211, 55);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir(F6)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panelTotal
            // 
            this.panelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotal.Controls.Add(this.labelValorTotalPago);
            this.panelTotal.Controls.Add(this.labelValorTotalPagar);
            this.panelTotal.Controls.Add(this.labelTotalRegistros);
            this.panelTotal.Controls.Add(this.btnSair);
            this.panelTotal.Controls.Add(this.btnExportar);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Location = new System.Drawing.Point(522, 617);
            this.panelTotal.Margin = new System.Windows.Forms.Padding(4);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(882, 167);
            this.panelTotal.TabIndex = 3;
            // 
            // labelValorTotalPago
            // 
            this.labelValorTotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValorTotalPago.AutoSize = true;
            this.labelValorTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalPago.Location = new System.Drawing.Point(630, 22);
            this.labelValorTotalPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorTotalPago.Name = "labelValorTotalPago";
            this.labelValorTotalPago.Size = new System.Drawing.Size(118, 17);
            this.labelValorTotalPago.TabIndex = 12;
            this.labelValorTotalPago.Text = "Valor Total Pago:";
            // 
            // labelValorTotalPagar
            // 
            this.labelValorTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelValorTotalPagar.AutoSize = true;
            this.labelValorTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalPagar.Location = new System.Drawing.Point(333, 22);
            this.labelValorTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorTotalPagar.Name = "labelValorTotalPagar";
            this.labelValorTotalPagar.Size = new System.Drawing.Size(123, 17);
            this.labelValorTotalPagar.TabIndex = 10;
            this.labelValorTotalPagar.Text = "Valor Total Pagar:";
            // 
            // labelTotalRegistros
            // 
            this.labelTotalRegistros.AutoSize = true;
            this.labelTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRegistros.Location = new System.Drawing.Point(27, 22);
            this.labelTotalRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalRegistros.Name = "labelTotalRegistros";
            this.labelTotalRegistros.Size = new System.Drawing.Size(108, 17);
            this.labelTotalRegistros.TabIndex = 8;
            this.labelTotalRegistros.Text = "Total Registros:";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(633, 106);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(211, 55);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair(ESC)";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(30, 106);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(211, 55);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dataGridViewRegistros
            // 
            this.dataGridViewRegistros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.valor,
            this.dataVencimento,
            this.dataPagamento,
            this.pago});
            this.dataGridViewRegistros.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRegistros.Location = new System.Drawing.Point(522, 125);
            this.dataGridViewRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRegistros.MultiSelect = false;
            this.dataGridViewRegistros.Name = "dataGridViewRegistros";
            this.dataGridViewRegistros.ReadOnly = true;
            this.dataGridViewRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewRegistros.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegistros.Size = new System.Drawing.Size(882, 492);
            this.dataGridViewRegistros.TabIndex = 4;
            this.dataGridViewRegistros.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistros_RowEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Descrição/Fornecedor";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 220;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // dataVencimento
            // 
            this.dataVencimento.DataPropertyName = "datavencimento";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataVencimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataVencimento.HeaderText = "Data Vencimento";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.ReadOnly = true;
            this.dataVencimento.Width = 120;
            // 
            // dataPagamento
            // 
            this.dataPagamento.DataPropertyName = "datapagamento";
            dataGridViewCellStyle4.Format = "d";
            this.dataPagamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataPagamento.HeaderText = "Data Pagamento";
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.ReadOnly = true;
            this.dataPagamento.Width = 120;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.pagarInformadoADataToolStripMenuItem,
            this.toolStripMenuItem3,
            this.gerarContaMêsAtualToolStripMenuItem,
            this.gerarContaMêsAtualGridToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(277, 136);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.testeToolStripMenuItem.Text = "Pagar com data corrente";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // pagarInformadoADataToolStripMenuItem
            // 
            this.pagarInformadoADataToolStripMenuItem.Name = "pagarInformadoADataToolStripMenuItem";
            this.pagarInformadoADataToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.pagarInformadoADataToolStripMenuItem.Text = "Pagar informado a data";
            this.pagarInformadoADataToolStripMenuItem.Click += new System.EventHandler(this.pagarInformadoADataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(276, 22);
            this.toolStripMenuItem3.Text = "------------------------------";
            // 
            // gerarContaMêsAtualToolStripMenuItem
            // 
            this.gerarContaMêsAtualToolStripMenuItem.Name = "gerarContaMêsAtualToolStripMenuItem";
            this.gerarContaMêsAtualToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.gerarContaMêsAtualToolStripMenuItem.Text = "Gerar conta próximo mês(Individual)";
            this.gerarContaMêsAtualToolStripMenuItem.Click += new System.EventHandler(this.gerarContaMêsAtualToolStripMenuItem_Click);
            // 
            // gerarContaMêsAtualGridToolStripMenuItem
            // 
            this.gerarContaMêsAtualGridToolStripMenuItem.Name = "gerarContaMêsAtualGridToolStripMenuItem";
            this.gerarContaMêsAtualGridToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.gerarContaMêsAtualGridToolStripMenuItem.Text = "Gerar contas próximo mês(Todas Grid)";
            this.gerarContaMêsAtualGridToolStripMenuItem.Click += new System.EventHandler(this.gerarContaMêsAtualGridToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 806);
            this.Controls.Add(this.dataGridViewRegistros);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelPesquisa);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Contas Pagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            this.groupBoxPagamentos.ResumeLayout(false);
            this.groupBoxVencimentos.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelNome;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelData;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelVersao;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.DataGridView dataGridViewRegistros;
        private System.Windows.Forms.ComboBox comboBoxTiposRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxVencimentos;
        private System.Windows.Forms.Button btnVencimentoHoje;
        private System.Windows.Forms.Button btnVencimentoQuinzeDias;
        private System.Windows.Forms.Button btnVencimentoSeteDias;
        private System.Windows.Forms.Button btnVencimentoMes;
        private System.Windows.Forms.GroupBox groupBoxPagamentos;
        private System.Windows.Forms.Button btnPagamentoQuinzeDias;
        private System.Windows.Forms.Button btnPagamentoSeteDias;
        private System.Windows.Forms.Button btnPagamentoMes;
        private System.Windows.Forms.Button btnPagamentoHoje;
        private System.Windows.Forms.TextBox textBoxDescricaoConta;
        private System.Windows.Forms.Label labelDescricaoConta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelTotalRegistros;
        private System.Windows.Forms.Label labelValorTotalPagar;
        private System.Windows.Forms.Label labelValorTotalPago;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testeConexãoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarInformadoADataToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelProjectPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPesquisaFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPesquisaInicio;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.Label labelTiposRegistros;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesBancoDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusBancoDadosPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.ToolStripMenuItem backupBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gerarContaMêsAtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarContaMêsAtualGridToolStripMenuItem;
    }
}

