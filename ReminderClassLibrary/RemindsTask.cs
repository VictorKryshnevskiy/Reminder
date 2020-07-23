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
        public CheckStatus CheckStatus { get;  set; }

    public RemindsTask(string text, CheckStatus checkStatus = default)
        {
            TaskText = text;
            CheckStatus = checkStatus;
        }
        public RemindsTask() { }
    }
}
