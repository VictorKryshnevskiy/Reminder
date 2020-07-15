using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class Remind
    {
        public DateTime StartRemindDate{get;}
        public string RemindName { get; }
        public string RemindDescription { get; }
        public DateTime EndRemindDate { get; }
        public string TasksList { get; }

        public Remind(DateTime startRemindDate, string remindName, DateTime endRemindDate, string remindDescription,
            string tasksList )
        {
            StartRemindDate = startRemindDate;
            RemindName = remindName;
            RemindDescription = remindDescription;
            EndRemindDate = endRemindDate;
            TasksList = tasksList;
        }
        public Remind()
        { }
    }
}
