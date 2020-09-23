using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class RemindDataBaseRepository : IRemindRepository
    {
        public List<Remind> GetReminds()
        {
            using (ReminderContext reminderContext = new ReminderContext())
            {
                reminderContext.Database.CreateIfNotExists();
                return reminderContext.Reminds.Include(x => x.CyclicalNotification).Include(x => x.Notifications).
                    Include(x => x.TasksList).ToList();
            }
        }
        public void Save(Remind remind)
        {
            Validate(remind);
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
            using (ReminderContext context = new ReminderContext())
            {
                var entity = context.Reminds.FirstOrDefault(x => x.Id == remind.Id);
                if (entity != null)
                {
                    entity.Name = remind.Name;
                    entity.Description = remind.Description;
                    entity.EndDate = remind.EndDate;
                    entity.StartDate = remind.StartDate;
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
                var cyclicalNot = context.CyclicalNotifications.FirstOrDefault(p => p.Id == remind.Id);
                if (remind.CyclicalNotification != null && cyclicalNot != null)
                {
                    cyclicalNot.PeriodAmount = remind.CyclicalNotification.PeriodAmount;
                    cyclicalNot.Period = remind.CyclicalNotification.Period;
                    cyclicalNot.PeriodAmount = remind.CyclicalNotification.PeriodAmount;
                    cyclicalNot.PeriodAmount = remind.CyclicalNotification.PeriodAmount;
                    cyclicalNot.PeriodAmount = remind.CyclicalNotification.PeriodAmount;
                    context.Entry(cyclicalNot).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    if (remind.CyclicalNotification == null && cyclicalNot !=null)
                    {
                        context.CyclicalNotifications.Remove(cyclicalNot);
                        context.SaveChanges();
                    }
                    if (cyclicalNot == null && remind.CyclicalNotification != null)
                    {
                        remind.CyclicalNotification.Id = remind.Id;
                        context.CyclicalNotifications.Add(remind.CyclicalNotification);
                        context.SaveChanges();
                    }
                }

                foreach (var notification in remind.Notifications)
                {
                    var not = context.Notifications.FirstOrDefault(p => p.Id == notification.Id);
                    if (notification.Period == NotificationPeriod.None)
                    {
                        context.Notifications.Remove(not);
                        context.SaveChanges();
                    }
                    else
                    {
                        
                        if (not != null)
                        {
                            not.Period = notification.Period;
                            not.PeriodAmount = notification.PeriodAmount;
                            context.SaveChanges();
                        }
                        else
                        {
                            notification.RemindId = remind.Id;
                            context.Notifications.Add(notification);
                            context.SaveChanges();
                        }
                    }
                }
                foreach (var task in remind.TasksList)
                {
                    var taskDB = context.RemindTasks.FirstOrDefault(p => p.Id == task.Id);
                    if (task.Text == "")
                    {
                        context.RemindTasks.Remove(taskDB);
                        context.SaveChanges();
                    }
                    else
                    {
                        if (taskDB != null)
                        {
                            taskDB.Status = task.Status;
                            taskDB.Text = task.Text;
                            context.SaveChanges();
                        }
                        else
                        {
                            task.RemindId = remind.Id;
                            context.RemindTasks.Add(task);
                            context.SaveChanges();
                        }
                    }
                }
                bool saveFailed;
                do
                {
                    saveFailed = false;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        ex.Entries.Single().Reload();
                    }
                } while (saveFailed);
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
