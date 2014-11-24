using System.Collections.Generic;

namespace eCal.CalendarManagement.Model
{
    public interface ICalendar
    {
        /// <summary>
        ///     The user which the calendar is assigned to.
        /// </summary>
        User User { get; }

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
        void Share(User User);

        /// <summary>
        ///     Add one event to the calendar.
        /// </summary>
        /// <param name="e">The event to add to the calendar.</param>
        void AddEvent(IEvent ev);

        /// <summary>
        ///     Add a collection of events to the calendar.
        /// </summary>
        /// <param name="events">The Events to add to the calendar.</param>
        void AddEvents(List<IEvent> events);

        /// <summary>
        ///     Remove an event from the Calendar.
        /// </summary>
        /// <param name="ev">The event to remove.</param>
        /// <returns>Returns true if the event was successfully removed.</returns>
        bool RemoveEvent(IEvent ev);

        /// <summary>
        ///     Remove a collection of Events from the calendar.
        /// </summary>
        /// <param name="events">The collection of the events to remove.</param>
        void RemoveEvents(List<IEvent> events);

        /// <summary>
        ///     Remove this Calendar from a User.
        /// </summary>
        /// <param name="user">The User to remove this Calendar from.</param>
        void RemoveFromUser(User user);

        /// <summary>
        ///     Add this Calendar to a User.
        /// </summary>
        /// <param name="user">The User to add this Calendar to.</param>
        void AddToUser(User user);

        void ShowCalendar();
    }
}