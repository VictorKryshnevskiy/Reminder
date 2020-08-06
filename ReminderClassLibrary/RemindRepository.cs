using System;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public class RemindRepository : IRemindRepository
    {
        public const string fileName = "Reminder.json";
        public RemindRepository()
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Remind> GetRemind()
        {
            var jsonString = FileSystem.ReadAllText(fileName);
            var array = JsonHelper.DeserializeListRemind(jsonString);
            return array;
        }
        public void Save(Remind remind)
        {
            if (FileSystem.IsExist(fileName))
            {
                var json = FileSystem.ReadAllText(fileName);
                var history = JsonHelper.DeserializeListRemind(json);
                history.Add(remind);
                var jsonString = JsonHelper.SerializeObject(history);
                FileSystem.WriteAllText(fileName, jsonString);
            }
            else
            {
                FileSystem.FileCreate(fileName);
                var list = new List<Remind> { remind };
                var jsonString = JsonHelper.SerializeObject(list);
                FileSystem.WriteAllText(fileName, jsonString);
            }
        }
        public void Save(List<Remind> remind)
        {
            var jsonString = JsonHelper.SerializeObject(remind);
            FileSystem.WriteAllText(fileName, jsonString);
        }
    }
}
