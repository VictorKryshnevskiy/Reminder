using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class RemindsTask
    {
        public string TaskText { get;  set; }
        public CheckState CheckStatus { get;  set; }

    public RemindsTask(string text, CheckState taskStatus = default)
        {
            TaskText = text;
            CheckStatus = taskStatus;
        }
        public RemindsTask() { }
    }
}
