using System.Text.Json;
using System.Text.Unicode;
using System.IO;
using System.Text.Encodings.Web;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public static class FileSystem
    {
        public static bool IsExist(string path)
        {
            return File.Exists(path);
        }
        public static void Create(string fileName)
        {
            using (FileStream fs = File.Create(fileName)) { }
        }
        public static string ReadAllText(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        public static void WriteAllText(string fileName, string value)
        {
            File.WriteAllText(fileName, value);
        }
    }
}
