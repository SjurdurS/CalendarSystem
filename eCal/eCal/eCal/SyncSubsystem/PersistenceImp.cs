using System;
using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.SyncSubsystem
{
    internal class PersistenceImp : IPersistence
    {
        private IPersistenceImplementor _implementor;
        private List<Calendar> calendarsToPass;
        private List<Event> eventsToPass;

        public PersistenceImp(IPersistenceImplementor imp)
        {
            _implementor = imp;
        }

        public string Persist(Object obj)
        {
            throw new NotImplementedException();
        }

        public Object FindById(string itemId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the available networkconnection. Information is used to determine which storage is to be used. 
        /// </summary>
        public NetworkConnection GetNetworkConnection()
        {
            
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }
    }
}