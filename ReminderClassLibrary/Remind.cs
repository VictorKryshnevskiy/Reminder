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
        private List<string> TasksList;

        public Remind(DateTime startRemindDate, string remindName, string remindDescription,
            DateTime endRemindDate, List<string> tasksList)
        {
            StartRemindDate = startRemindDate;
            RemindName = remindName;
            RemindDescription = remindDescription;
            EndRemindDate = endRemindDate;
            TasksList = tasksList;
        }
    }
}
