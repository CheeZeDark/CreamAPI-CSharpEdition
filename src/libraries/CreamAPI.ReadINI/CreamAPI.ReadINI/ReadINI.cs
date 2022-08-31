using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreamAPI.ReadINI
{
    public class INIRead
    {
        public void ReadINIFile(string ini_folder, Encoding enc)
        {
            File.ReadAllText(ini_folder, enc);
        }
    }
}
