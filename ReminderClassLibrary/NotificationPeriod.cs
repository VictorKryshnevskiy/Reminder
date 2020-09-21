﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public enum NotificationPeriod
    {
        [Description("")]
        None = 0,
        [Description("Минуты")]
        Minutes = 1,
        [Description("Часы")]
        Hours = 2,
        [Description("Дни")]
        Days = 3
    }
}
