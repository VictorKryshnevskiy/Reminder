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
        public Guid Id { get; set; }

        public RemindTask(string text, TaskStatus status = TaskStatus.ToDo)
        {
            Text = text;
            Status = status;
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
        }
        //для десериализации
        public RemindTask() { }
    }
}
