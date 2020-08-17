using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public enum NotificationPeriod
    {
        [Description ("Минуты")]
        Minutes = 0,
        [Description("Часы")]
        Hours = 1,
        [Description("Дни")]
        Days = 2,
        [Description("")]
        None = 3
    }
}
