using System.Text.Json;
using System.Text.Unicode;
using System.IO;
using System.Text.Encodings.Web;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public static class FileSystem
    {
        public static void SaveRemind(Remind value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            if (IsExist(Remind.fileName))
            {
                var json = File.ReadAllText(Remind.fileName);
                var history = JsonSerializer.Deserialize<List<Remind>>(json);
                history.Add(value);
                var jsonString = JsonSerializer.Serialize(history, options);
                File.WriteAllText(Remind.fileName, jsonString);
            }
            else
            {
                using (FileStream fs = File.Create(Remind.fileName)) { }
                var list = new List<Remind> { value };
                var jsonString = JsonSerializer.Serialize(list, options);
                File.WriteAllText(Remind.fileName, jsonString);
            }
        }
        public static void SaveRemind(List<Remind> value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(value, options);
            File.WriteAllText(Remind.fileName, jsonString);
        }
        public static List<Remind> GetRemind()
        {
            var jsonString = File.ReadAllText(Remind.fileName);
            var array = JsonSerializer.Deserialize<List<Remind>>(jsonString);
            return array;
        }
        public static bool IsExist(string path)
        {
            return File.Exists(path);
        }
    }
}
