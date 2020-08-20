using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class Notification
    {
        public bool ShownNotification;
        public int PeriodAmount{get;  set;}
        public NotificationPeriod Period { get;  set; }
        public Notification(int timeBeforeRemind, NotificationPeriod period)
        {
            PeriodAmount = timeBeforeRemind;
            Period = period;
        }
        //для десериализации
        public Notification()
        { }
    }
}
