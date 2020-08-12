using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class TaskScheduler
    {
        Timer timer;
        List<Remind> RemindList;
        public event EventHandler<RemindEventArgs> EndedRemind;
        public event EventHandler<RemindEventArgs> RemindNotification;
        private DateTime countDate;
        public TaskScheduler(List<Remind> remindsList)
        {
            RemindList = remindsList;
            timer = new Timer
            {
                Interval = 1000,
            };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckNotification();
        }
        private void CheckNotification()
        {
            foreach (var remind in RemindList)
            {
                if (remind.EndDate <= DateTime.Now && !remind.shownNotification)
                {
                    EndedRemind.Invoke(this, new RemindEventArgs(remind));
                    remind.shownNotification = true;
                    continue;
                }
                foreach (var notification in remind.Notifications)
                {
                    if (notification.Period == NotificationPeriod.Days && !notification.shownNotification)
                    {
                        if (remind.EndDate.AddDays(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new RemindEventArgs(remind));
                            notification.shownNotification = true;
                        }
                    }
                    if (notification.Period == NotificationPeriod.Hours && !notification.shownNotification)
                    {
                        if (remind.EndDate.AddHours(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new RemindEventArgs(remind));
                            notification.shownNotification = true;
                        }
                    }
                    if (notification.Period == NotificationPeriod.Minutes && !remind.shownNotification)
                    {
                        if (remind.EndDate.AddMinutes(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new RemindEventArgs(remind));
                            notification.shownNotification = true;
                        }
                    }
                }
                if (remind.CyclicalNotification != null)
                {
                    if (remind.CyclicalNotification.Start < DateTime.Now && remind.CyclicalNotification.End > DateTime.Now)
                    {
                        
                        if (remind.CyclicalNotification.Period == NotificationPeriod.Days && !remind.CyclicalNotification.shownNotification)
                        {
                            if (remind.CyclicalNotification.Start.AddDays(remind.CyclicalNotification.PeriodAmount) <= DateTime.Now)
                            {
                                RemindNotification.Invoke(this, new RemindEventArgs(remind));
                                //remind.CyclicalNotification.shownNotification = true;
                            }
                        }
                        if (remind.CyclicalNotification.Period == NotificationPeriod.Hours && !remind.CyclicalNotification.shownNotification)
                        {
                            if (remind.CyclicalNotification.Start.AddHours(remind.CyclicalNotification.PeriodAmount) <= DateTime.Now)
                            {
                                RemindNotification.Invoke(this, new RemindEventArgs(remind));
                                //remind.CyclicalNotification.shownNotification = true;
                            }
                        }
                        if (remind.CyclicalNotification.Period == NotificationPeriod.Minutes && !remind.shownNotification)
                        {
                            if (remind.CyclicalNotification.CountDate.AddMinutes(remind.CyclicalNotification.PeriodAmount) < DateTime.Now)
                            {
                                if (remind.CyclicalNotification.CountDate.AddMinutes(remind.CyclicalNotification.PeriodAmount * 2) > DateTime.Now
                                    && !remind.CyclicalNotification.shownNotification)
                                {
                                    RemindNotification.Invoke(this, new RemindEventArgs(remind));
                                    remind.CyclicalNotification.shownNotification = true;
                                }
                                else
                                {
                                    remind.CyclicalNotification.CountDate = remind.CyclicalNotification.CountDate.AddMinutes(remind.CyclicalNotification.PeriodAmount);
                                    remind.CyclicalNotification.shownNotification = false;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
