using System.Text.Json;
using System.Text.Unicode;
using System.IO;
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
        public static string SerializeString(object value)
        {
            return JsonSerializer.Serialize(value, options);
        }
    }
}
