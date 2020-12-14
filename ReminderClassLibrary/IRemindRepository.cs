using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public interface IRemindRepository
    {
        List<Remind> GetReminds(); 
        void Save(Remind item);
        void Save(List<Remind> items);
        void Update(Remind remind);
        void Update(List<Remind> items);
        void Delete(Remind remind);
    }
}
