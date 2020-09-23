using System;

namespace ReminderClassLibrary
{
    public class RemindEventArgs : EventArgs
    {
        public Remind Remind { get; }
        public RemindEventArgs(Remind remind)
        {
            Remind = remind;
        }
       
    }
}
