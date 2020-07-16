using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
