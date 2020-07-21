using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetRemindList();
        T GetRemind(int id); 
        void Create(T item); 
        void Update(T item);
        void Delete(int id); 
        void Save();  
    }
}
