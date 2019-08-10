using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Task_5._1
{
    public class BackupMaster
    {
        public string SourcePath { get; set; }
        public string TargetPath { get; set; }

        public string DefineSelectorOnInput(string sourcePath, DateTime inputTime)
        {
            DirectoryInfo logDirectory = new DirectoryInfo(sourcePath);
            FileInfo[] logFiles = logDirectory.GetFiles("*.txt");
            IEnumerable<FileInfo> logs = logFiles.OrderBy(FileInfo => FileInfo.CreationTime);
            if (inputTime > logs.Last().CreationTime) inputTime = logs.Last().CreationTime;
            foreach (FileInfo info in logs)
            {
                if (inputTime == info.CreationTime)
                {
                    inputTime = info.CreationTime;
                    break;
                }
                else if (inputTime < info.CreationTime)
                {
                    inputTime = info.CreationTime;
                    break;
                }
            }
            return inputTime.ToLocalTime().ToString().Replace(':', '.'); ;


        }
        public void CopyBackupFilesAccToSelector(string sourcePath, string targetPath, string selector)
        {
            string[] files = Directory.GetFiles(sourcePath, "*.txt");
            DirectoryInfo filesDirectory = new DirectoryInfo(targetPath);
            FileInfo[] filesinfo = filesDirectory.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (string s in files)
            {
                string fileName = System.IO.Path.GetFileName(s);
                if (selector == fileName.Remove(19)) // Comparison selector and time of creation from backup file name
                {
                    foreach (FileInfo x in filesinfo)
                    {
                        if (fileName.Substring(20) == x.Name) // Remove date and time data from file name
                        {
                            targetPath = x.DirectoryName;
                            string destFile = System.IO.Path.Combine(targetPath, fileName.Substring(20));
                            File.Copy(s, destFile, true);
                        }
                    }
                }
            }
        }
    }
}
