using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class INIHelper
    {
        //[DllImport("kernel32", CharSet = CharSet.Unicode)]
        //static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
        //[DllImport("kernel32", CharSet = CharSet.Unicode)]
        //static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //public static void INIWrite(string section, string key, string value, string filePath)
        //{
        //    WritePrivateProfileString(section, key, value, filePath);
        //}

        //public static string INIRead(string section, string key, string filePath)
        //{
        //    StringBuilder temp = new StringBuilder(255);
        //    GetPrivateProfileString(section, key, "", temp, 255, filePath);
        //    return temp.ToString();
        //}

        private Dictionary<string, Dictionary<string, string>> _iniFile = new Dictionary<string, Dictionary<string, string>>();
        string _filePath;

        public INIHelper(string filePath)
        {
            _filePath = filePath;
            string[] lines = File.ReadAllLines(_filePath);
            string currentSection = null;

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();

                if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith(";"))
                    continue;

                if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    currentSection = trimmedLine.Trim('[', ']');
                    _iniFile[currentSection] = new Dictionary<string, string>();
                }
                else if (currentSection != null)
                {
                    string[] keyValue = trimmedLine.Split(new[] { '=' }, 2);
                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0].Trim();
                        string value = keyValue[1].Trim();
                        _iniFile[currentSection][key] = value;
                    }
                }
            }
        }

        public void WriteIniFile()
        {
            using (var writer = new StreamWriter(_filePath))
            {
                foreach (var section in _iniFile)
                {
                    writer.WriteLine($"[{section.Key}]");
                    foreach (var keyValue in section.Value)
                    {
                        writer.WriteLine($"{keyValue.Key}={keyValue.Value}");
                    }
                    writer.WriteLine();
                }
            }
        }

        public string GetValue(string section, string key)
        {
            if (_iniFile.ContainsKey(section) && _iniFile[section].ContainsKey(key))
            {
                return _iniFile[section][key];
            }
            return null;
        }

        public void SetValue(string section, string key, string value)
        {
            _iniFile[section][key] = value;
        }
    }
}
