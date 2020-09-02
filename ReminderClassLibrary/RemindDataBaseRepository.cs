using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class RemindDataBaseRepository : IRemindRepository
    {
        public const string fileName = "DbConnection.mdf";
        public List<Remind> GetReminds()
        {
            using (ReminderContext reminderContext = new ReminderContext())
            {
                reminderContext.Database.CreateIfNotExists();
                return reminderContext.Reminds.Include(x => x.CyclicalNotification).Include(x=>x.Notifications).
                    Include(x=>x.TasksList).ToList();
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
        public void Update(Remind remind)
        {
            using (ReminderContext reminderContext = new ReminderContext())
            {
                reminderContext.Entry(remind).State = EntityState.Modified;
                reminderContext.SaveChanges();
            }
        }
        public void Update(List<Remind> reminds)
        {
            foreach (var remind in reminds)
            {
                Update(remind);
            }
        }
        public void Delete(Remind remind)
        {
            using (ReminderContext reminderContext = new ReminderContext())
            {
                reminderContext.Reminds.Attach(remind);
                reminderContext.RemindTasks.RemoveRange(remind.TasksList);
                reminderContext.Notifications.RemoveRange(remind.Notifications);
                reminderContext.Reminds.Remove(remind);
                reminderContext.SaveChanges();
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
