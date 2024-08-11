namespace WindowsFormFinanceiro.View
{
    partial class FormCadastroConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroConta));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.panelTexts = new System.Windows.Forms.Panel();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelPagamento = new System.Windows.Forms.Label();
            this.panelTexts.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(12, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(475, 23);
            this.textBoxNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição/Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(637, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vencimento";
            // 
            // dataVencimento
            // 
            this.dataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVencimento.Location = new System.Drawing.Point(640, 48);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(123, 23);
            this.dataVencimento.TabIndex = 5;
            this.dataVencimento.Value = new System.DateTime(2024, 5, 28, 0, 0, 0, 0);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(505, 48);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 23);
            this.textBoxValor.TabIndex = 4;
            this.textBoxValor.Text = "0,00";
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // panelTexts
            // 
            this.panelTexts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTexts.Controls.Add(this.labelPagamento);
            this.panelTexts.Controls.Add(this.dataPagamento);
            this.panelTexts.Controls.Add(this.textBoxValor);
            this.panelTexts.Controls.Add(this.dataVencimento);
            this.panelTexts.Controls.Add(this.label4);
            this.panelTexts.Controls.Add(this.label3);
            this.panelTexts.Controls.Add(this.label1);
            this.panelTexts.Controls.Add(this.textBoxNome);
            this.panelTexts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTexts.Location = new System.Drawing.Point(0, 123);
            this.panelTexts.Name = "panelTexts";
            this.panelTexts.Size = new System.Drawing.Size(967, 138);
            this.panelTexts.TabIndex = 0;
            // 
            // dataPagamento
            // 
            this.dataPagamento.Enabled = false;
            this.dataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPagamento.Location = new System.Drawing.Point(806, 48);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(123, 23);
            this.dataPagamento.TabIndex = 7;
            this.dataPagamento.Value = new System.DateTime(2024, 5, 28, 0, 0, 0, 0);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(796, 62);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(158, 45);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir(F6)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(399, 62);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar(F5)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(11, 62);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(158, 45);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar(F4)";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperacao.Location = new System.Drawing.Point(9, 17);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(234, 20);
            this.labelOperacao.TabIndex = 3;
            this.labelOperacao.Text = "Cadastro de Contas - Operação";
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.labelOperacao);
            this.panelButtons.Controls.Add(this.btnSalvar);
            this.panelButtons.Controls.Add(this.btnCancelar);
            this.panelButtons.Controls.Add(this.btnExcluir);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(967, 123);
            this.panelButtons.TabIndex = 1;
            // 
            // labelPagamento
            // 
            this.labelPagamento.AutoSize = true;
            this.labelPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagamento.Location = new System.Drawing.Point(803, 29);
            this.labelPagamento.Name = "labelPagamento";
            this.labelPagamento.Size = new System.Drawing.Size(80, 17);
            this.labelPagamento.TabIndex = 8;
            this.labelPagamento.Text = "Pagamento";
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 261);
            this.Controls.Add(this.panelTexts);
            this.Controls.Add(this.panelButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contas";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.panelTexts.ResumeLayout(false);
            this.panelTexts.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataVencimento;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Panel panelTexts;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelOperacao;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.DateTimePicker dataPagamento;
        private System.Windows.Forms.Label labelPagamento;
    }
}