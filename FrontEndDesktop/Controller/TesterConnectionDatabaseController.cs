using WindowsFormFinanceiro.Util;

namespace WindowsFormFinanceiro.Controller
{
    public class TesterConnectionDatabaseController
    {
        private TesterConnectionDatabaseRepository repositorio;

        public TesterConnectionDatabaseController()
        {
            repositorio = new TesterConnectionDatabaseRepository();
        }


        public bool TestarConexao()
        {
            return repositorio.TestarConexao();
        }
    }
}
