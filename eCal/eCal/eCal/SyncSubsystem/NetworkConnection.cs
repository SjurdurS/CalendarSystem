using eCal.CalendarManagement.Model;
using System.Collections.Generic;

namespace eCal.SyncSubsystem
{
    internal class NetworkConnection
    {
        private List<Calendar> calendarsToUpdate;
        private List<Event> eventsToUpdate; 
        private ISynchronizationStrategy intf;
        private string status;

        /// <summary>
        /// Gets an offline or online connection available. OnOffManager decides the connection type. 
        /// </summary>
        public void GetConnection()
        {
        }

        /// <summary>
        /// Status on if connection is offline or online.
        /// </summary>
        public void Status()
        {
        }

        /// <summary>
        /// Passes the connection to PersistenceImp.
        /// </summary>
        public void NetworkStorageInformation()
        {
        }




    }
}