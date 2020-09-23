using System;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public class RemindFileRepository : IRemindRepository
    {
        public const string fileName = "Reminder.json";

        public void Delete(Remind remind)
        {
            throw new NotImplementedException();
        }

        public List<Remind> GetReminds()
        {
            if (FileSystem.IsExist(fileName))
            {
                var jsonString = FileSystem.ReadAllText(fileName);
                var listReminds = JsonHelper.Deserialize<List<Remind>>(jsonString);
                return listReminds;
            }
            else
            {
                FileSystem.Create(fileName);
                FileSystem.WriteAllText(fileName, JsonHelper.Serialize(new List<Remind> { }));
                return new List<Remind> { };
            }
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
            TryUpdateId(reminds);
            var jsonString = JsonHelper.Serialize(reminds);
            FileSystem.WriteAllText(fileName, jsonString);
        }

        public void Update(Remind remind)
        {
            throw new NotImplementedException();
        }

        public void Update(List<Remind> items)
        {
            throw new NotImplementedException();
        }

        private void TryUpdateId(List<Remind> reminds)
        {
            foreach (var remind in reminds)
            {
                if (remind.Id == Guid.Empty)
                {
                    remind.Id = Guid.NewGuid();
                }
            }
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
