using System;
using System.Windows.Forms;
using WindowsFormFinanceiro.View;

namespace WindowsFormFinanceiro
{
    internal static class Program
    {
        public static bool continueRunning = true;
        public static bool conexaoCorretaBancoDados = true;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (conexaoCorretaBancoDados)
                Application.Run(new FormPrincipal());
            else
                Application.Run(new FormDatabaseConfig());
        }
    }
}
