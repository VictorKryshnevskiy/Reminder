using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class Notification
    {
        public int PeriodAmount{get;  set;}
        public string Period { get;  set; }
        public Notification(int timeBeforeRemind, string period)
        {
            PeriodAmount = timeBeforeRemind;
            Period = period;
        }
        //для десериализации
        public Notification()
        { }
    }
}
