using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReminderClassLibrary
{
    public class RemindTask
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Remind Remind { get; set; }
        public Guid RemindId { get; set; }
        public string Text { get; set; }
        public TaskStatus Status { get; set; }
        public RemindTask(string text, TaskStatus status = TaskStatus.ToDo)
        {
            Text = text;
            Status = status;
        }
        //для десериализации
        public RemindTask() { }
    }
}
