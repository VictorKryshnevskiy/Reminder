using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class DateToRimind
    {
        public int TimeBeforeRemind{get;  set;}
        public string Period { get;  set; }
        public DateToRimind(int timeBeforeRemind, string period)
        {
            TimeBeforeRemind = timeBeforeRemind;
            Period = period;
        }
        public DateToRimind()
        { }
    }
}
