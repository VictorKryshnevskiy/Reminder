using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using System;

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
        public static ReturningType Deserialize<ReturningType,Parametr>(ref Parametr json) 
        {
            return JsonSerializer.Deserialize<ReturningType>(Convert.ToString(json), options);
        }
    }
}
