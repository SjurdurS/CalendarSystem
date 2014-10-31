using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.CalendarManagement.Controller
{
    /// <summary>
    ///     Manages updates and synchronizations.
    /// </summary>
    internal class UpdateControl
    {

        /// <summary>
        ///    Takes a list of calendars and automatically synchronize the calendars with a given time interval.
        /// </summary>
        private void AutoSync(List<Calendar> updateCalendar)
        {
        }

        /// <summary>
        ///     Synchronize the calendars whenever the User clicks the synchronize button.
        /// </summary>
        private void Sync(List<Calendar> updateCalendar)
        {
        }

        /// <summary>
        /// Returns the status of synchronization.
        /// </summary>
        /// <param name="status"></param>
        private void SyncStatus(Notification notification)
        {
            notification.UpdateMessage();
        }

    }
}