using System;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public class RemindFileRepository : IRemindRepository
    {
        public const string fileName = "Reminder.json";
        public List<Remind> GetReminds()
        {
            var jsonString = FileSystem.ReadAllText(fileName);
            var listReminds = JsonHelper.Deserialize(ref jsonString);
            return listReminds;
        }
        public void Save(Remind remind)
        {
            if (FileSystem.IsExist(fileName))
            {
                var json = FileSystem.ReadAllText(fileName);
                var remindsList = JsonHelper.Deserialize(ref json);
                remindsList.Add(remind);
                Save(remindsList);
            }
            else
            {
                FileSystem.Create(fileName);
                var remindsList = new List<Remind> { remind };
                Save(remindsList);
            }
        }
        public void Save(List<Remind> remind)
        {
            var jsonString = JsonHelper.SerializeObject(remind);
            FileSystem.WriteAllText(fileName, jsonString);
        }
    }
}
