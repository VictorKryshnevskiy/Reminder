using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class Remind
    {
        private DateTime StartRemindDate;
        private string RemindName;
        private string RemindDescription;
        private DateTime EndRemindDate;
        private string TasksList;

        public Remind(DateTime startRemindDate, string remindName, DateTime endRemindDate, string remindDescription,
            string tasksList )
        {
            StartRemindDate = startRemindDate;
            RemindName = remindName;
            RemindDescription = remindDescription;
            EndRemindDate = endRemindDate;
            TasksList = tasksList;
        }
        public string GetRemindString()
        {
            return StartRemindDate.ToString() + " " + RemindName + " " + EndRemindDate.ToString() + " " + RemindDescription + " "
                + TasksList;
        }
    }
}
