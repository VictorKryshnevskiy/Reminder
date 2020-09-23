using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReminderClassLibrary
{
    public class CyclicalNotifications 
    {
        [Key]
        [ForeignKey("Remind")]
        public Guid Id { get; set; }
        public Remind Remind { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CountDate { get; set; }
        public int PeriodAmount { get; set; }
        public NotificationPeriod Period { get; set; }
        public CyclicalNotifications(DateTime start, DateTime end, int timeBeforeRemind, NotificationPeriod period)
        {
            Start = start;
            End = end;
            PeriodAmount = timeBeforeRemind;
            Period = period;
            CountDate = Start;
        }
        //для десериализации
        public CyclicalNotifications()
        { }
    }
}
