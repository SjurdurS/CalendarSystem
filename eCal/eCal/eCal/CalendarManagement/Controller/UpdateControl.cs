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
        public void AutoSync(List<Calendar> updateCalendar)
        {
        }

        /// <summary>
        ///     Synchronize the calendars whenever the User clicks the synchronize button.
        /// </summary>
        /// @pre updateCalendar != null
        /// @pre Calendar c = updateCalendar.GetType()
        /// @pre count = 0
        /// @post count > 0
        /// @post updateCalendar.count = count
        public void Sync(List<Calendar> updateCalendar)
        {
            //Iterate over updateCalendar
            foreach (Calendar c in updateCalendar)
            {
                //synchronize each calendar.
                //count++;
            }
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