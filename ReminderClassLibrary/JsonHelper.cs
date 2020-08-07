using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;

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
        public static T Deserialize<T>(string json) 
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
