using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    interface IRepository<Remind> : IDisposable
    {
        IEnumerable<Remind> GetRemindList();
        Remind GetRemind(Guid id); 
        void Create(Remind item); 
        void Update(Remind item);
        void Delete(Guid id); 
        void Save();  
    }
}
