using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class Remind
    {
        public bool shownNotification;
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public List<RemindTask> TasksList { get; set; }
        private Guid guid = Guid.NewGuid(); 
        public Guid GetGuid { get { return guid; }}
        public List<Notification> Notifications { get; set; }

        public Remind(DateTime startRemindDate, string remindName,
            DateTime endRemindDate, string remindDescription,
            List<RemindTask> tasksList)
        {
            StartDate = startRemindDate;
            Name = remindName;
            Description = remindDescription;
            EndDate = endRemindDate;
            TasksList = tasksList;
        }
        //для десериализации
        public Remind() 
        {

        }
    }

}
