using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    public class RemindContext : DbContext
    {
        public RemindContext() : base("DefaultConnection")
        { }
        public DbSet<Remind> Reminds { get; set; }
    }
}
