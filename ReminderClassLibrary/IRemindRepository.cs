using System;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    interface IRemindRepository : IDisposable
    {
        IEnumerable<Remind> GetRemindList();
        Remind GetRemind(Guid id); 
        void Create(Remind item); 
        void Update(Remind item);
        void Delete(Guid id); 
        void Save(Remind item);  
    }
}
