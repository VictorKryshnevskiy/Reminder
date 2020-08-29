using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class TaskScheduler
    {
        private Timer timer;
        private List<Remind> remindList;
        IRemindRepository repository;
        public event EventHandler<RemindEventArgs> EndedRemind;
        public event EventHandler<RemindEventArgs> RemindNotification;
        public TaskScheduler(List<Remind> reminds)
        {
            remindList = reminds;
            timer = new Timer
            {
                Interval = 1000,
            };
            timer.Start();
            timer.Tick += Timer_Tick;
            repository =  new RemindFileRepository();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (remindList != null)
                CheckNotification();
        }
        private void CheckNotification()
        {
            foreach (var remind in remindList)
            {
                if (remind.EndDate <= DateTime.Now && !remind.shownNotification)
                {
                    EndedRemind.Invoke(this, new RemindEventArgs(remind));
                    remind.shownNotification = true;
                    continue;
                }
                if (remind.Notifications != null)
                {


                    foreach (var notification in remind.Notifications)
                    {
                        if (notification.Period == NotificationPeriod.Days && !notification.ShownNotification)
                        {
                            if (remind.EndDate.AddDays(notification.PeriodAmount * -1) <= DateTime.Now)
                            {
                                RemindNotification.Invoke(this, new RemindEventArgs(remind));
                                notification.ShownNotification = true;
                            }
                        }
                        if (notification.Period == NotificationPeriod.Hours && !notification.ShownNotification)
                        {
                            if (remind.EndDate.AddHours(notification.PeriodAmount * -1) <= DateTime.Now)
                            {
                                RemindNotification.Invoke(this, new RemindEventArgs(remind));
                                notification.ShownNotification = true;
                            }
                        }
                        if (notification.Period == NotificationPeriod.Minutes && !remind.shownNotification)
                        {
                            if (remind.EndDate.AddMinutes(notification.PeriodAmount * -1) <= DateTime.Now)
                            {
                                RemindNotification.Invoke(this, new RemindEventArgs(remind));
                                notification.ShownNotification = true;
                            }
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
                                    RemindNotification.Invoke(this, new RemindEventArgs(remind));
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
                                    && !remind.CyclicalNotification.ShownNotification)
                                {
                                    RemindNotification.Invoke(this, new RemindEventArgs(remind));
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
                                    RemindNotification.Invoke(this, new RemindEventArgs(remind));
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
        public void Refresh()
        {
            remindList = repository.GetReminds();
        }
    }
}
