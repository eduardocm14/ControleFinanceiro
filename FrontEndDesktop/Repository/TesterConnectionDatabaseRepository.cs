using System;

namespace WindowsFormFinanceiro.Util
{
    public class TesterConnectionDatabaseRepository
    {
        private readonly AppDbContext contexto;

        public TesterConnectionDatabaseRepository()
        {
            contexto = new AppDbContext();
        }

        public bool TestarConexao()
        {
            try
            {
                // Tenta abrir a conexão para verificar a conectividade
                contexto.Database.Connection.Open();
                contexto.Database.Connection.Close();
                return true;
            }
            catch (Exception)
            {
                // Log da exceção ou exibição da mensagem de erro
                // MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro de Conexão");
                return false;
            }
        }
    }
}
