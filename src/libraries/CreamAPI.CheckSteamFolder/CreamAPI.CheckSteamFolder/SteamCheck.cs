using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreamAPI.CheckSteamFolder
{
    public class CheckSteam
    {
        public bool SteamCheckFolder()
        {
            if(Directory.Exists(@"C:\Program Files (x86)\Steam"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckGameInSteam(string game)
        {
            if(Directory.Exists($@"C:\Program Files (x86)\Steam\steamapps\common\{game}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string EnumerateFilesInSteam()
        {
            var steam = Directory.EnumerateFiles("C:\\Program Files (x86)\\Steam");
            string enum_files;
            enum_files = steam.FirstOrDefault().ToString();
            return enum_files;
        }
    }
}
