using System;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    interface IRemindRepository : IDisposable
    {
        List<Remind> GetRemind(); 
        void Save(Remind item);  
    }
}
