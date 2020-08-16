using System;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class ObjectEventArgs : EventArgs
    {
        public Remind Remind { get; }
        public Panel Panel { get; }
        public ObjectEventArgs(Remind remind)
        {
            Remind = remind;
        }
        public ObjectEventArgs(Panel panel)
        {
            Panel = panel;
        }
    }
}
