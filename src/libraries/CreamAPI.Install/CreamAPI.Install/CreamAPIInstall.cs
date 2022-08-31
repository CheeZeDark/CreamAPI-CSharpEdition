using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CreamAPI.Install
{
    public class InstallCreamAPI
    {
        private void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //This is Very Important Code... DON'T CHANGE THIS!!! 

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }
        public void CreamAPIInstall()
        {
            Directory.CreateDirectory("C:\\Temp");
            Extract("CreamAPI.Install", @"C:\Temp", "Resources", "cream_api.zip");
        }
        public void ExtractCreamAPIToFolderGame(string folder_license_game)
        {
            ZipFile.ExtractToDirectory("C:\\Temp\\cream_api.zip", folder_license_game);
        }
        public void DeleteZIPCreamAPI()
        {
            File.Delete("C:\\Temp\\cream_api.zip");
        }
        public string GetHashSteamDLL_CreamAPI(string steam_dll)
        {
            var md5 = MD5.Create();
            var checkhash = File.OpenRead(steam_dll);
            var x = md5.ComputeHash(checkhash);
            return BitConverter.ToString(x).Replace("-", String.Empty).ToLowerInvariant();
        }
    }
}
