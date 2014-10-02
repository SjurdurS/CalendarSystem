using System.Collections.Generic;
using System.Diagnostics;

namespace CalendarApplication.Model
{
    /// <summary>
    /// This class represents a Calendar in the system. A Calendar has a name and a list of Events.
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// The name of the Calendar.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The Color of the Calendar. Used to color the calendar in the View.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The list of events assigned to this Calendar.
        /// </summary>
        public List<Event> Events { get; private set; }

        /// <summary>
        /// List of users this Calendar is shared with.
        /// </summary>
        public List<OtherUser> SharedGroup { get; private set; }


        /// <summary>
        /// Instantiate a new Calendar.
        /// </summary>
        public Calendar()
        {
            this.Name = Properties.Resources.DefaultCalendarName;
            this.Color = Properties.Resources.DefaultCalendarColor;
            this.SharedGroup = new List<OtherUser>();
            this.Events = new List<Event>();
        }

        /// <summary>
        /// Share the Calendar with another user.
        /// </summary>
        /// <param name="otherUser">The recipient of the Calendar</param>
        public void Share(OtherUser otherUser)
        {
            // Share Calendar with another user.
        }

        /// <summary>
        /// Add one event to the calendar.
        /// </summary>
        /// <param name="e">The event to add to the calendar.</param>
        public void AddEvent(Event ev)
        {
            this.Events.Add(ev);
        }

        /// <summary>
        /// Add a collection of events to the calendar.
        /// </summary>
        /// <param name="events">The Events to add to the calendar.</param>
        public void AddEvents(List<Event> events)
        {
            this.Events.AddRange(events);
        }

        /// <summary>
        /// Remove an event from the Calendar.
        /// </summary>
        /// <param name="ev">The event to remove.</param>
        /// <returns>Returns true if the event was successfully removed.</returns>
        public bool RemoveEvent(Event ev)
        {
            return this.Events.Remove(ev);
        }

        /// <summary>
        /// Remove a collection of Events from the calendar.
        /// </summary>
        /// <param name="events">The collection of the events to remove.</param>
        public void RemoveEvents(List<Event> events)
        {
            foreach (Event ev in events)
            {
                RemoveEvent(ev);
            }
        }


    }
}
