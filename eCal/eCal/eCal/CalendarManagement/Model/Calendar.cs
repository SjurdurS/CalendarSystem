using System;
using System.Collections.Generic;
using eCal.CalendarManagement.View;

namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     This class represents a Calendar in the system. A Calendar has a name and a list of Events.
    /// </summary>
    public class Calendar : ICalendar
    {
        /// <summary>
        ///     Instantiate a new Calendar.
        /// </summary>
        public Calendar(IUser user)
        {
            User = user;
            Name = "Default Calendar Name";
            Color = "Default Calendar Color";
            SharedGroup = new List<string>();
            Events = new List<IEvent>();
        }

        public Calendar(CalendarForm calendarForm)
        {
            Name = calendarForm.Name;
            Color = calendarForm.Color;
            SharedGroup = calendarForm.SharedGroup;
            Events = new List<IEvent>();
        }

        public Calendar(IUser user, string name, string color)
        {
            User = user;
            Name = name;
            Color = color;
            SharedGroup = new List<string>();
            Events = new List<IEvent>();
        }

        /// <summary>
        ///     The user which the calendar is assigned to.
        /// </summary>
        public IUser User { get; private set; }

        /// <summary>
        ///     The name of the Calendar.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The Color of the Calendar. Used to color the calendar in the View.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        ///     The list of events assigned to this Calendar.
        /// </summary>
        public List<IEvent> Events { get; private set; }

        /// <summary>
        ///     List of users (addresses) this Calendar is shared with.
        /// </summary>
        public List<string> SharedGroup { get; set; }


        /// <summary>
        ///     Share the Calendar with another user.
        /// </summary>
        /// <param name="User">The recipient of the Calendar</param>
        public void Share(IUser User)
        {
            // Share Calendar with another user.
        }

        /// <summary>
        ///     Add one event to the calendar.
        /// </summary>
        /// <param name="e">The event to add to the calendar.</param>
        public void AddEvent(IEvent ev)
        {
            Events.Add(ev);
        }

        /// <summary>
        ///     Add a collection of events to the calendar.
        /// </summary>
        /// <param name="events">The Events to add to the calendar.</param>
        public void AddEvents(List<IEvent> events)
        {
            Events.AddRange(events);
        }

        /// <summary>
        ///     Remove an event from the Calendar.
        /// </summary>
        /// <param name="ev">The event to remove.</param>
        /// <returns>Returns true if the event was successfully removed.</returns>
        public bool RemoveEvent(IEvent ev)
        {
            return Events.Remove(ev);
        }

        /// <summary>
        ///     Remove a collection of Events from the calendar.
        /// </summary>
        /// <param name="events">The collection of the events to remove.</param>
        public void RemoveEvents(List<IEvent> events)
        {
            foreach (IEvent ev in events)
            {
                RemoveEvent(ev);
            }
        }

        /// <summary>
        ///     Remove this Calendar from a User.
        /// </summary>
        /// <param name="user">The User to remove this Calendar from.</param>
        public void RemoveFromUser(IUser user)
        {
            user.RemoveCalendar(this);
        }

        /// <summary>
        ///     Add this Calendar to a User.
        /// </summary>
        /// <param name="user">The User to add this Calendar to.</param>
        public void AddToUser(IUser user)
        {
            user.AddCalendar(this);
        }

        public void ShowCalendar()
        {
            throw new NotImplementedException();
        }
    }
}