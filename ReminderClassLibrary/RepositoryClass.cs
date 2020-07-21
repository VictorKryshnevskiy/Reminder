using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderClassLibrary
{
    class RepositoryClass : IRepository<Remind>
    {
        public RepositoryClass()
        { }

        public void Create(Remind item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Remind GetRemind(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Remind> GetRemindList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Remind item)
        {
            throw new NotImplementedException();
        }
    }
}
