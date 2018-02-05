using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianyuHelper.Handler
{
    public class FileHandler
    {
        private List<Tuple<string, string>> fileScripts;
        private List<Tuple<string, string>> fileSettings;

        public FileHandler()
        {
            fileScripts = new List<Tuple<string, string>>();
            fileSettings = new List<Tuple<string, string>>();
            initalize();
        }

        private void initalize()
        {
            fileScripts = setDirectoryFiles(Const.PATH_SCRIPTS, "txt");
            fileSettings = setDirectoryFiles(Const.PATH_SETTINGS, "txt");
        }

        private List<Tuple<string, string>> setDirectoryFiles(string directoryPath, string fileType)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath).ToString();
            }
            string[] fileScriptPath = Directory.GetFiles(Const.PATH_SCRIPTS, "*." + fileType);
            List<Tuple<string, string>> files = new List<Tuple<string, string>>();
            foreach (string path in fileScriptPath)
            {
                files.Add(new Tuple<string,string>(Path.GetFileNameWithoutExtension(path), path));
            }
            return files;
        }

        public List<string> getFileScripts()
        {
            List<string> fileNames = new List<string>();
            foreach (Tuple<string, string> fileScript in fileScripts)
            {
                fileNames.Add(fileScript.Item1);
            }
            return fileNames;
        }

        public List<string> getFileSettings()
        {
            List<string> fileNames = new List<string>();
            foreach (Tuple<string, string> fileSetting in fileSettings)
            {
                fileNames.Add(fileSetting.Item1);
            }
            return fileNames;
        }

        public string[] readScript(int index)
        {
           return File.ReadAllLines(fileScripts[index].Item2);
        }

    }
}
