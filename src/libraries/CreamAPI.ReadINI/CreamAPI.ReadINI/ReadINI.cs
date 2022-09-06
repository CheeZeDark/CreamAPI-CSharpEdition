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
        public string ReadINIFile(string ini_folder, Encoding enc)
        {
            string read_text;
            read_text = File.ReadAllText(ini_folder, enc);
            return read_text;
        }
    }
}
