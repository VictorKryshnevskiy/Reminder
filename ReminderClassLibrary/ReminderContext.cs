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
    }
}
