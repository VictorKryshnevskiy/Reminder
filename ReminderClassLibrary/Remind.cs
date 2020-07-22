using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class Remind
    {
        public const string fileName = "Reminder.json";
        public DateTime StartRemindDate { get; set; }
        public string RemindName { get; set; }
        public string RemindDescription { get; set; }
        public DateTime EndRemindDate { get; set; }
        public List<RemindsTask> TasksList { get; set; }
        private Guid guid = Guid.NewGuid(); 
        public Guid GetGuid { get { return guid; }}
        public DateTime DateToRemind { get; set; }
        public Remind(DateTime startRemindDate = default, string remindName = default,
            DateTime endRemindDate = default, string remindDescription = default,
            List<RemindsTask> tasksList = default, DateTime dateToRemind = default)
        {
            StartRemindDate = startRemindDate;
            RemindName = remindName;
            RemindDescription = remindDescription;
            EndRemindDate = endRemindDate;
            TasksList = tasksList;
            DateToRemind = dateToRemind;
        }
        public Remind()
        { }
    }
}
