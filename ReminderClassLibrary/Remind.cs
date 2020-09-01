using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class Remind
    {
        public Guid Id { get; set; }
        public bool shownNotification;
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public List<RemindTask> TasksList { get; set; }
        public List<Notification> Notifications { get; set; }
        public CyclicalNotifications CyclicalNotification { get; set; }

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
