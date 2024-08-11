using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormFinanceiro.Data
{
    public class IniFile
    {
        public string Path;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string path)
        {
            Path = path;
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, Path);
        }

        public string Read(string section, string key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public bool Exists()
        {
            return System.IO.File.Exists(Path);
        }
    }
}
