using System.Collections.Generic;

namespace eCal.CalendarManagement.Model
{
    public interface ICalendar
    {
        /// <summary>
        ///     The user which the calendar is assigned to.
        /// </summary>
        IUser User { get; }

        /// <summary>
        ///     The name of the Calendar.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     The Color of the Calendar. Used to color the calendar in the View.
        /// </summary>
        string Color { get; set; }

        /// <summary>
        ///     The list of events assigned to this Calendar.
        /// </summary>
        List<IEvent> Events { get; }

        /// <summary>
        ///     List of users (addresses) this Calendar is shared with.
        /// </summary>
        List<string> SharedGroup { get; set; }

        /// <summary>
        ///     Share the Calendar with another user.
        /// </summary>
        /// <param name="User">The recipient of the Calendar</param>
        void Share(IUser User);

        /// <summary>
        ///     Add one event to the calendar.
        /// </summary>
        /// <param name="e">The event to add to the calendar.</param>
        void AddEvent(IEvent ev);

        /// <summary>
        ///     Remove an event from the Calendar.
        /// </summary>
        /// <param name="ev">The event to remove.</param>
        /// <returns>Returns true if the event was successfully removed.</returns>
        bool RemoveEvent(IEvent ev);

        /// <summary>
        ///     Remove this Calendar from a User.
        /// </summary>
        /// <param name="user">The User to remove this Calendar from.</param>
        void RemoveFromUser(IUser user);

        /// <summary>
        ///     Add this Calendar to a User.
        /// </summary>
        /// <param name="user">The User to add this Calendar to.</param>
        void AddToUser(IUser user);

        void ShowCalendar();
    }
}