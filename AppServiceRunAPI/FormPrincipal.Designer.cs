namespace AppServiceRunAPI
{
    partial class FromPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromPrincipal));
            lblStatus = new Label();
            btnVerificar = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.Location = new Point(12, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(201, 19);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status Serviço API .NET Core";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(600, 9);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(166, 31);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Start/Stop";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(754, 215);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // FromPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 267);
            Controls.Add(richTextBox1);
            Controls.Add(btnVerificar);
            Controls.Add(lblStatus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FromPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start/Stop API .NET Core";
            Shown += FromPrincipal_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnVerificar;
        private RichTextBox richTextBox1;
    }
}
