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
        public Guid Id { get; set; }
        public int PeriodAmount{get;  set;}
        public NotificationPeriod Period { get;  set; }
        public Notification(int timeBeforeRemind, NotificationPeriod period)
        {
            PeriodAmount = timeBeforeRemind;
            Period = period;
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
        }
        //для десериализации
        public Notification()
        { }
    }
}
