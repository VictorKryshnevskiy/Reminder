using System.IO;

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
