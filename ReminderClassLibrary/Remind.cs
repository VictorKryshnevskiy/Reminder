using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class Remind
    {
        public const string fileName = "Reminder.json";
        static Timer timer = new Timer();
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public List<RemindTask> TasksList { get; set; }
        private Guid guid = Guid.NewGuid(); 
        public Guid GetGuid { get { return guid; }}
        public List<Notification> DateToRimind { get; set; }
        public event EventHandler<RemindEventArgs> RemindDateEnd;

        public Remind(DateTime startRemindDate = default, string remindName = default,
            DateTime endRemindDate = default, string remindDescription = default,
            List<RemindTask> tasksList = default)
        {
            StartDate = startRemindDate;
            Name = remindName;
            Description = remindDescription;
            EndDate = endRemindDate;
            TasksList = tasksList;
            timer.Start();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateCheck();
        }

        //для десериализации
        public Remind() 
        {
            timer.Start();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void DateCheck()
        {
            if (EndDate == DateTime.Now.Date)
            {
                RemindDateEnd.Invoke(this, new RemindEventArgs(this));
            }
        }
    }

}
