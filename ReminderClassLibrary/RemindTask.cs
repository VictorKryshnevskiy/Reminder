using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderClassLibrary
{
    public class RemindTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Text { get; set; }
        public TaskStatus Status { get; set; }
        public Remind Remind { get; set; }
        public Guid RemindId { get; set; }

        public RemindTask(string text, TaskStatus status = TaskStatus.ToDo)
        {
            Text = text;
            Status = status;
        }
        //для десериализации
        public RemindTask() { }
    }
}
