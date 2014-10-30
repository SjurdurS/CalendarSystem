using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.CalendarManagement.Controller
{
    /// <summary>
    ///     Manages updates and synchronizations.
    /// </summary>
    internal class UpdateControl
    {
        private List<Calendar> updateCalendar;
        private List<Event> updateEvent;
        private string status;


        /// <summary>
        ///     Automatically synchronize the calendars with a given time interval.
        /// </summary>
        public void AutoSync()
        {
        }

        /// <summary>
        ///     Synchronize the calendars whenever the User clicks the synchronize button.
        /// </summary>
        public void Sync()
        {
        }

        public void SyncStatus()
        {   
        }

    }
}