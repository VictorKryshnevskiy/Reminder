using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class CyclicalNotifications : Notification
    {
        public Guid IdCycling { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CountDate { get; set; }
        public CyclicalNotifications(DateTime start, DateTime end, int timeBeforeRemind, NotificationPeriod period)
        {
            Start = start;
            End = end;
            PeriodAmount = timeBeforeRemind;
            Period = period;
            CountDate = Start;
            if (IdCycling == Guid.Empty)
            {
                IdCycling = Guid.NewGuid();
            }
        }
        //для десериализации
        public CyclicalNotifications()
        { }
    }
}
