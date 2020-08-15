using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            Validate(remind);
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
        public void Save(List<Remind> reminds)
        {
            var jsonString = JsonHelper.Serialize(reminds);
            FileSystem.WriteAllText(fileName, jsonString);
        }

        private void Validate(Remind remind)
        {
            if (remind.StartDate > remind.EndDate)
            {
                throw new Exception("Дата начала события не может быть позже даты конца события");
            }
            if (remind.Description.Length > 100)
            {
                throw new Exception("Описание событие не может быть длинее 100 символов");
            }
            if (remind.EndDate < DateTime.Now)
            {
                throw new Exception("Дата конца события не может быть в прошлом");
            }
        }
    }
}
