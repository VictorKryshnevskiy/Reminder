using System.Text.Json;
using System.Text.Unicode;
using System.IO;
using System.Text.Encodings.Web;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public class FileSystem
    {
        public static void SaveRemind(Remind value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            if (IsExist("Reminder.json"))
            {
                var json = File.ReadAllText("Reminder.json");
                var history = JsonSerializer.Deserialize<List<Remind>>(json);
                history.Add(value);
                var jsonString = JsonSerializer.Serialize(history, options);
                File.WriteAllText("Reminder.json", jsonString);
            }
            else
            {
                FileStream fs = File.Create("Reminder.json");
                fs.Close();
                var list = new List<Remind> { value };
                var jsonString = JsonSerializer.Serialize(list, options);
                File.WriteAllText("Reminder.json", jsonString);
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
            File.WriteAllText("Reminder.json", jsonString);
        }
        public static List<Remind> GetRemind()
        {
            var jsonString = File.ReadAllText("Reminder.json");
            var array = JsonSerializer.Deserialize<List<Remind>>(jsonString);
            return array;
        }
        public static bool IsExist(string path)
        {
            return File.Exists(path);
        }
    }
}
