using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ReminderClassLibrary
{
    public class ReminderContext : DbContext
    {
        public ReminderContext() : base("DbConnection")
        { }
        public DbSet<Remind> Reminds { get; set; }
        public DbSet<CyclicalNotifications> CyclicalNotifications { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<RemindTask> RemindTasks { get; set; }
    }
}
