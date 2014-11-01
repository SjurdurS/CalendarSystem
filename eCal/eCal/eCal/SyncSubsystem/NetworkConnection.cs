using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.SyncSubsystem
{
    /// <summary>
    ///     Gets the available connection. Either offline or online.
    /// </summary>
    /// @invariant GetConnection() =! null
    internal class NetworkConnection
    {
        private List<Calendar> calendarsToUpdate;
        private List<Event> eventsToUpdate;
        private ISynchronizationStrategy intf;
        private string status;

        /// <summary>
        ///     Gets an offline or online connection available. OnOffManager decides the connection type.
        /// </summary>
        public ISynchronizationStrategy GetConnection()
        {
        }

        /// <summary>
        ///     Status on if connection is offline or online.
        /// </summary>
        public void Status()
        {
        }

        /// <summary>
        ///     Passes the connection to PersistenceImp.
        /// </summary>
        public void NetworkStorageInformation()
        {
        }
    }
}