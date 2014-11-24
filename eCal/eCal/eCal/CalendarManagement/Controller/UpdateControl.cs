using System;
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
        ///     Takes a list of calendars and automatically synchronize the calendars with a given time interval.
        /// </summary>
        public void AutoSync(List<ICalendar> updateCalendar)
        {
        }

        /// <summary>
        ///     Synchronize the calendars whenever the User clicks the synchronize button.
        /// </summary>
        /// @pre updateCalendar != null
        /// @pre updateCalendar.Count > 0
        /// @post should return true if successfully synchronized, and false otherwise.
        public bool Sync(List<ICalendar> updateCalendar)
        {
            // Preconditions
            if (updateCalendar == null)
            {
                throw new ArgumentNullException("updateCalendar");
            }

            if (updateCalendar.Count == 0)
            {
                throw new ArgumentException("updateCalendar collection is empty. Nothing to sync.");
            }

            bool syncSuccessful = true;
            //Iterate over updateCalendar
            foreach (ICalendar c in updateCalendar)
            {
                //synchronize each calendar.
                // if fails syncSuccessful = false;
            }

            // should return true if successfully synchronized, and false otherwise.
            return syncSuccessful;
        }

        /// <summary>
        ///     Returns the status of synchronization.
        /// </summary>
        /// <param name="status"></param>
        public void SyncStatus(Notification notification)
        {
            notification.UpdateMessage();
        }
    }
}