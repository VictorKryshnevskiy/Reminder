using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public static class JsonHelper
    {
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };
        public static string SerializeObject(object value)
        {
            return JsonSerializer.Serialize(value, options);
        }
        // как сделать обобщение?
        public static List<Remind> DeserializeListRemind(string json) 
        {
            return JsonSerializer.Deserialize<List<Remind>>(json, options);
        }
    }
}
