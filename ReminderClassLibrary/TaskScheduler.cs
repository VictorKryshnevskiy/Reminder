using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class TaskScheduler
    {
        Timer timer;
        List<Remind> RemindList;
        public event EventHandler<ObjectEventArgs> EndedRemind;
        public event EventHandler<ObjectEventArgs> RemindNotification;
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
                    EndedRemind.Invoke(this, new ObjectEventArgs(remind));
                    remind.shownNotification = true;
                    continue;
                }
                foreach (var notification in remind.Notifications)
                {
                    if (notification.Period == NotificationPeriod.Days && !notification.shownNotification)
                    {
                        if (remind.EndDate.AddDays(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new ObjectEventArgs(remind));
                            notification.shownNotification = true;
                        }
                    }
                    if (notification.Period == NotificationPeriod.Hours && !notification.shownNotification)
                    {
                        if (remind.EndDate.AddHours(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new ObjectEventArgs(remind));
                            notification.shownNotification = true;
                        }
                    }
                    if (notification.Period == NotificationPeriod.Minutes && !remind.shownNotification)
                    {
                        if (remind.EndDate.AddMinutes(notification.PeriodAmount * -1) <= DateTime.Now)
                        {
                            RemindNotification.Invoke(this, new ObjectEventArgs(remind));
                            notification.shownNotification = true;
                        }
                    }
                }
                if (remind.CyclicalNotification != null)
                {
                    if (remind.CyclicalNotification.Start < DateTime.Now && remind.CyclicalNotification.End > DateTime.Now)
                    {
                        
                        if (remind.CyclicalNotification.Period == NotificationPeriod.Days)
                        {
                            if (remind.CyclicalNotification.CountDate.AddDays(remind.CyclicalNotification.PeriodAmount) <= DateTime.Now)
                            {
                                if (remind.CyclicalNotification.CountDate.AddDays(remind.CyclicalNotification.PeriodAmount * 2) > DateTime.Now)
                                {
                                    RemindNotification.Invoke(this, new ObjectEventArgs(remind));
                                    remind.CyclicalNotification.CountDate = remind.CyclicalNotification.CountDate.AddDays(remind.CyclicalNotification.PeriodAmount);
                                }
                                else
                                {
                                    remind.CyclicalNotification.CountDate = remind.CyclicalNotification.CountDate.AddDays(remind.CyclicalNotification.PeriodAmount);
                                }
                            }
                        }
                        if (remind.CyclicalNotification.Period == NotificationPeriod.Hours)
                        {
                            if (remind.CyclicalNotification.CountDate.AddHours(remind.CyclicalNotification.PeriodAmount) < DateTime.Now)
                            {
                                if (remind.CyclicalNotification.CountDate.AddHours(remind.CyclicalNotification.PeriodAmount * 2) > DateTime.Now
                                    && !remind.CyclicalNotification.shownNotification)
                                {
                                    RemindNotification.Invoke(this, new ObjectEventArgs(remind));
                                    remind.CyclicalNotification.CountDate = remind.CyclicalNotification.CountDate.AddHours(remind.CyclicalNotification.PeriodAmount);
                                }
                                else
                                {
                                    remind.CyclicalNotification.CountDate = remind.CyclicalNotification.CountDate.AddHours(remind.CyclicalNotification.PeriodAmount);
                                }
                            }
                        }
                        if (remind.CyclicalNotification.Period == NotificationPeriod.Minutes)
                        {
                            if (remind.CyclicalNotification.CountDate.AddMinutes(remind.CyclicalNotification.PeriodAmount) < DateTime.Now)
                            {
                                if (remind.CyclicalNotification.CountDate.AddMinutes(remind.CyclicalNotification.PeriodAmount * 2) > DateTime.Now)
                                {
                                    RemindNotification.Invoke(this, new ObjectEventArgs(remind));
                                    remind.CyclicalNotification.CountDate = remind.CyclicalNotification.CountDate.AddMinutes(remind.CyclicalNotification.PeriodAmount);
                                }
                                else
                                {
                                    remind.CyclicalNotification.CountDate = remind.CyclicalNotification.CountDate.AddMinutes(remind.CyclicalNotification.PeriodAmount);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
