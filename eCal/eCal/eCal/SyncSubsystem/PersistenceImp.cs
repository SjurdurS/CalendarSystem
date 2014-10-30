using System;
using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.SyncSubsystem
{
    internal class PersistenceImp<T> : IPersistence<T>
    {
        private List<Calendar> calendarsToPass;
        private List<Event> eventsToPass;
        private IPersistenceImplementor<T> _implementor;

        public PersistenceImp(IPersistenceImplementor<T> imp)
        {
            _implementor = imp;
        }

        public string Persist(T t)
        {
            throw new NotImplementedException();
        }

        public T FindById(string itemId)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }
    }
}