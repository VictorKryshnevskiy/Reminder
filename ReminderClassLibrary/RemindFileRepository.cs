using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public class RemindFileRepository : IRemindRepository
    {
        public const string fileName = "Reminder.json";
        public List<Remind> GetReminds()
        {
            var jsonString = FileSystem.ReadAllText(fileName);
            var listReminds = JsonHelper.Deserialize<List<Remind>>(jsonString);
            return listReminds;
        }
        public void Save(Remind remind)
        {
            if (FileSystem.IsExist(fileName))
            {
                var jsonString = FileSystem.ReadAllText(fileName);
                var remindsList = JsonHelper.Deserialize<List<Remind>>(jsonString);
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
            var jsonString = JsonHelper.Serialize(remind);
            FileSystem.WriteAllText(fileName, jsonString);
        }
    }
}
