using System.Collections.Generic;
using CalendarApplication.Model;

namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     This class represents a Calendar in the system. A Calendar has a name and a list of Events.
    /// </summary>
    public class Calendar
    {
        /// <summary>
        ///     Instantiate a new Calendar.
        /// </summary>
        public Calendar(string name, string color)
        {
            Name = name;
            Color = color;
            SharedGroup = new List<OtherUser>();
            Events = new List<Event>();
        }

        /// <summary>
        ///     The name of the Calendar.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        ///     The Color of the Calendar. Used to color the calendar in the View.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        ///     The list of events assigned to this Calendar.
        /// </summary>
        public List<Event> Events { get; private set; }

        /// <summary>
        ///     List of users this Calendar is shared with.
        /// </summary>
        public List<OtherUser> SharedGroup { get; private set; }


        /// <summary>
        ///     Share the Calendar with another user.
        /// </summary>
        /// <param name="otherUser">The recipient of the Calendar</param>
        private void Share(OtherUser otherUser)
        {
            // Share Calendar with another user.
        }

        /// <summary>
        ///     Add one event to the calendar.
        /// </summary>
        /// <param name="e">The event to add to the calendar.</param>
        private void AddEvent(Event ev)
        {
            Events.Add(ev);
        }

        /// <summary>
        ///     Add a collection of events to the calendar.
        /// </summary>
        /// <param name="events">The Events to add to the calendar.</param>
        private void AddEvents(List<Event> events)
        {
            Events.AddRange(events);
        }

        /// <summary>
        ///     Remove an event from the Calendar.
        /// </summary>
        /// <param name="ev">The event to remove.</param>
        /// <returns>Returns true if the event was successfully removed.</returns>
        private bool RemoveEvent(Event ev)
        {
            return Events.Remove(ev);
        }

        /// <summary>
        ///     Remove a collection of Events from the calendar.
        /// </summary>
        /// <param name="events">The collection of the events to remove.</param>
        private void RemoveEvents(List<Event> events)
        {
            foreach (Event ev in events)
            {
                RemoveEvent(ev);
            }
        }

        /// <summary>
        ///     Remove this Calendar from a User.
        /// </summary>
        /// <param name="user">The User to remove this Calendar from.</param>
        private void RemoveFromClient(User user)
        {
            user.RemoveCalendar(this);
        }

        /// <summary>
        ///     Add this Calendar to a User.
        /// </summary>
        /// <param name="user">The User to add this Calendar to.</param>
        private void AddToClient(User user)
        {
            user.AddCalendar(this);
        }
    }
}