using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Remind Remind { get; set; }
        public Guid RemindId { get; set; }
        public int PeriodAmount { get; set; }
        public NotificationPeriod Period { get; set; }
        public bool ShownNotification;
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
