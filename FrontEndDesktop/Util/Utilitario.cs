using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormFinanceiro.Controller;
using WindowsFormFinanceiro.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using static WindowsFormFinanceiro.Util.Utilitario;

namespace WindowsFormFinanceiro.Util
{
    public class Utilitario
    {
        public static bool restartApplication = false;

        public enum OperacaoCRUD
        {
            Inclusao = 1,
            Alteracao = 2,
            Exclusao = 3,
            PagarConta = 4
        }

        public enum TipoContas
        {
            Todas = 0,
            ContasPagar = 1,
            ContasPagas = 2,
            ContasVencidas = 3,
        }

        public static void Moeda(ref TextBox txt)
        {
            string n;
            double v;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");

                if (n.Equals(""))
                    n = "";

                n = n.PadLeft(3, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDouble(n) / 100;

                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static IniFile GetConfigBancoDadosINI()
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string iniFilePath = System.IO.Path.Combine(projectPath, "config.ini");
            return new IniFile(iniFilePath);
        }

        public bool ValidarConexaoBancoDados()
        {
            var controladorTesterConnection = new TesterConnectionDatabaseController();

            bool conexaoBemSucedida = controladorTesterConnection.TestarConexao();

            return conexaoBemSucedida;

        }

        public bool ConexaoCorretaBancoDados()
        {
            var iniFile = GetConfigBancoDadosINI();

            var conexaoOK = (iniFile.Exists() && ValidarConexaoBancoDados());

            Program.conexaoCorretaBancoDados = conexaoOK;

            return conexaoOK;
        }

        public void RestartApplication()
        {
            restartApplication = true;
            Process.Start(Application.ExecutablePath); // Reinicia a aplicação
            Application.Exit();
        }

        public class ExportToPDF
        {
            public void Export(DataGridView dgv, string filePath)
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dgv.Columns.Count);

                // Adiciona os cabeçalhos das colunas
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    table.AddCell(cell);
                }

                // Adiciona as linhas de dados
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow) // Ignora a linha vazia de um novo item
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(cell.Value?.ToString() ?? string.Empty);
                        }
                    }
                }

                document.Add(table);
                document.Close();
            }
        }

        public class ExportToODS
        {
            public void Export(DataGridView dgv, string filePath)
            {
                IWorkbook workbook = new XSSFWorkbook(); // Cria uma nova planilha do Excel
                ISheet sheet = workbook.CreateSheet("Sheet1"); // Cria uma nova aba

                // Adiciona os cabeçalhos das colunas
                IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    ICell cell = headerRow.CreateCell(i);
                    cell.SetCellValue(dgv.Columns[i].HeaderText);
                }

                // Adiciona as linhas de dados
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    IRow dataRow = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        ICell cell = dataRow.CreateCell(j);
                        cell.SetCellValue(dgv.Rows[i].Cells[j].Value?.ToString() ?? string.Empty);
                    }
                }

                // Salva o arquivo
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fs);
                }
            }
        }

        public class SaveDataGridView
        {
            public void Save(DataGridView dgv)
            {
                var result = CustomMessageBox.Show("Você deseja salvar em PDF, ODS ou cancelar?");
                var fileName = "Relatório Contas";

                if (result == CustomMessageBox.CustomDialogResult.PDF)
                {
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        FileName = fileName,
                        Filter = "PDF Files|*.pdf",
                        Title = "Salvar como PDF"
                    };
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportToPDF exportToPDF = new ExportToPDF();
                        exportToPDF.Export(dgv, sfd.FileName);
                        MessageBox.Show("Arquivo salvo com sucesso em PDF!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result == CustomMessageBox.CustomDialogResult.ODS)
                {
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        FileName = fileName,
                        Filter = "ODS Files|*.ods",
                        Title = "Salvar como ODS"
                    };
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportToODS exportToODS = new ExportToODS();
                        exportToODS.Export(dgv, sfd.FileName);
                        MessageBox.Show("Arquivo salvo com sucesso em ODS!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}