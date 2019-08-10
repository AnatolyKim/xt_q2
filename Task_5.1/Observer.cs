using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_5._1
{
    class Observer
    {
        private static Observer instance;
        private Observer() { }

        public static Observer getInstance()
        {
            if (instance == null) instance = new Observer();
            return instance;
        }
        public static string SourcePath { get; set; }
        public static FileSystemWatcher watcher = new FileSystemWatcher();

        public static void SwitchWatcher(int selection)
        {
            switch (selection)
            {
                case 0:
                    {
                        watcher.Path = SourcePath;
                        watcher.NotifyFilter = NotifyFilters.LastWrite;
                        watcher.Filter = "*.txt";
                        watcher.EnableRaisingEvents = true;
                        watcher.IncludeSubdirectories = true;
                        watcher.Changed += Observer.OnChangedHandler;
                        break;
                    }
                case 1:
                    {
                        watcher.EnableRaisingEvents = false;
                        watcher.Changed -= Observer.OnChangedHandler;
                        break;
                    }
            }
        }
        public static void OnChangedHandler(object source, FileSystemEventArgs e)
        {
            try
            {
                if (Directory.Exists(SourcePath + @"\Logs") == false)
                {
                    DirectoryInfo targetDirectory = Directory.CreateDirectory(SourcePath + @"\Logs");
                }
            }
            catch (NullReferenceException)
            {
               throw;
            }
            string targetPath = SourcePath + @"\Logs";
            var files = Directory.GetFiles(SourcePath, "*.txt", SearchOption.AllDirectories).Where(d => !d.StartsWith(@"D:\Sample\Logs")).ToArray();

            foreach (string s in files)
            {
                string fileName = System.IO.Path.GetFileName(s);
                string destFile = System.IO.Path.Combine(targetPath, DateTime.Now.ToLocalTime().ToString().Replace(':', '.') + "." + fileName);
                File.Copy(s, destFile, true);
            }

        }
    }
}
