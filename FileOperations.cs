using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Students
{
    public class FileOperations : IFileOperations
    {
        string path = @"./jsonFolder/Students.json";

        public void IsFileExisting()
        {
            if (!File.Exists(path))
                File.Create(path);
        }

        public void WriteToFile(string jsonString)
        {
            File.WriteAllText(path, jsonString);
        }

        public string ReadFromFile()
        {
            return File.ReadAllText(path);
        }
    }
}
