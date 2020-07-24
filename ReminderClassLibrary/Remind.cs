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
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public List<RemindTask> TasksList { get; set; }
        private Guid guid = Guid.NewGuid(); 
        public Guid GetGuid { get { return guid; }}
        public List<Notification> DateToRimind { get; set; }

        public Remind(DateTime startRemindDate = default, string remindName = default,
            DateTime endRemindDate = default, string remindDescription = default,
            List<RemindTask> tasksList = default, List<DateTime> dateToRemind = default)
        {
            StartDate = startRemindDate;
            Name = remindName;
            Description = remindDescription;
            EndDate = endRemindDate;
            TasksList = tasksList;
           // DateTimeToRemind = dateToRemind;
        }

        //для десериализации
        public Remind() 
        { }
    }
}
