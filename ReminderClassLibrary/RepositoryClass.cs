using System;
using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public class RepositoryClass : IRemindRepository
    {
        public RepositoryClass()
        { }

        public void Create(Remind item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Remind> GetRemind()
        {
           return FileSystem.GetRemind();
        }

        public IEnumerable<Remind> GetRemindList()
        {
            throw new NotImplementedException();
        }

        public void Save(Remind remind)
        {
            FileSystem.SaveRemind(remind);
        }
        public void Save(List<Remind> remind)
        {
            FileSystem.SaveRemind(remind);
        }

        public void Update(Remind item)
        {
            throw new NotImplementedException();
        }
    }
}
