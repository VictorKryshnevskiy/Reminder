using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class TaskScheduler
    {
        List<Remind> RemindList;
        public event EventHandler<RemindEventArgs> EndedRemind;
        public event EventHandler<RemindEventArgs> RemindNotification;
        public TaskScheduler(List<Remind> remindsList)
        {
            RemindList = remindsList;
            //Task task = Task.Factory.StartNew(() => CheckDate());
        }
        public void CheckDate()
        {
            foreach (var remind in RemindList)
            {
                if (remind.EndDate <= DateTime.Now)
                {
                    EndedRemind.Invoke(this, new RemindEventArgs(remind));
                }
            }
        }
        public void CheckNotification()
        {
            foreach (var remind in RemindList)
            {
                foreach (var notification in remind.Notifications)
                {
                    if (notification.Period == NotificationPeriod.Days)
                    {
                        if (remind.EndDate.AddDays(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new RemindEventArgs(remind));
                        }
                    }
                    if (notification.Period == NotificationPeriod.Hours)
                    {
                        if (remind.EndDate.AddHours(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new RemindEventArgs(remind));
                        }
                    }
                    if (notification.Period == NotificationPeriod.Minutes)
                    {
                        if (remind.EndDate.AddMinutes(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new RemindEventArgs(remind));
                        }
                    }
                }
            }
        }
    }
}
