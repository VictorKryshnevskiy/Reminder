﻿using System.Collections.Generic;

namespace ReminderClassLibrary
{
    public interface IRemindRepository
    {
        List<Remind> GetReminds(); 
        void Save(Remind item);
        void Save(List<Remind> item);
    }
}
