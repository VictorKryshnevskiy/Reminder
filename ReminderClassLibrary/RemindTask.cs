using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class RemindTask
    {
        public string Text { get; set; }
        public TaskStatus Status { get; set; }

        public RemindTask(string text, TaskStatus status = default)
        {
            Text = text;
            Status = status;
        }
        //для десериализации
        public RemindTask() { }
    }
}
