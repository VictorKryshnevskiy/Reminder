using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class Remind
    {
        public DateTime StartRemindDate { get; set; }
        public string RemindName { get; set; }
        public string RemindDescription { get; set; }
        public DateTime EndRemindDate { get; set; }
        public string TasksList { get; set; }
        public const string fileName = "Reminder.json";
        private Guid guid = Guid.NewGuid(); 
        public Guid GetGuid { get { return guid; }}
        public Remind(DateTime startRemindDate = default, string remindName = default,
            DateTime endRemindDate = default, string remindDescription = default,
            string tasksList = default)
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
