using System.Text.Json;
using System.Text.Unicode;
using System.IO;
using System.Text.Encodings.Web;

namespace ReminderClassLibrary
{
    public class FileSystem
    {
        public static void SaveRemind(object value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(value,options);
            File.WriteAllText("Reminder.json", jsonString);
        }
       
    }
}
