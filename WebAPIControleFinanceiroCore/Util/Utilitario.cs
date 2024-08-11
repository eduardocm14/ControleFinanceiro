namespace WebAPIControleFinanceiroCore.Util
{
    public class Utilitario
    {
        public static IniFile GetConfigBancoDadosINI()
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string iniFilePath = System.IO.Path.Combine(projectPath, "config.ini");
            return new IniFile(iniFilePath);
        }
    }
}
