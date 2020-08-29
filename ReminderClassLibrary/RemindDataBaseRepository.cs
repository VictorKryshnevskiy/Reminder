﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class RemindDataBaseRepository : IRemindRepository
    {
        public const string fileName = "Reminder.mdf";
        public List<Remind> GetReminds()
        {
            if (FileSystem.IsExist(fileName))
            {
                using (ReminderContext reminderContext = new ReminderContext())
                {
                    return reminderContext.Reminds.ToList();
                }
            }
            else
            {
                //Database.SetInitializer<ReminderContext>(new DropCreateDatabaseIfModelChanges<ReminderContext>());
                // FileSystem.Create(fileName);
                using (ReminderContext reminderContext = new ReminderContext())
                {
                    return reminderContext.Reminds.ToList();
                }
            }
        }
        public void Save(Remind remind)
        {
            Validate(remind);
            TryUpdateId(remind);
            using (ReminderContext reminderContext = new ReminderContext())
            {
                reminderContext.Reminds.Add(remind);
                reminderContext.SaveChanges();
            }
        }
        public void Save(List<Remind> reminds)
        {
            foreach (var remind in reminds)
            {
                Save(remind);
            }
        }
        private void TryUpdateId(Remind remind)
        {
            if (remind.Id == Guid.Empty)
            {
                remind.Id = Guid.NewGuid();
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