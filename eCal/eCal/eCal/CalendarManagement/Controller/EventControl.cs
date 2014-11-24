using System;
using System.Collections.Generic;
using eCal.CalendarManagement.Model;
using eCal.CalendarManagement.View;

namespace eCal.CalendarManagement.Controller
{
    /// <summary>
    ///     This controller class is the link between EventForm and Event.
    /// </summary>
    internal class EventControl
    {
        private readonly ICalendar _calendar;

        public EventControl(ICalendar calendar)
        {
            _calendar = calendar;
        }

        /// <summary>
        ///     Creates an EventForm in View.
        /// </summary>
        /// <returns></returns>
        public EventForm CreatEventForm()
        {
            var eventForm = new EventForm();
            return eventForm;
        }

        /// <summary>
        ///     Takes an EventForm and creates an Event.
        /// </summary>
        public IEvent CreateEvent(EventForm eventForm)
        {
            string name = eventForm.Name;
            string color = eventForm.Color;

            var newEvent = new Event(_calendar, name, color);
            return newEvent;
        }

        /// <summary>
        ///     Saves multiple events.
        /// </summary>
        /// @pre events != null
        /// @pre events.count > 0
        /// @post returns true if all events were saved to the database.
        /// <param name="events">List of events to save</param>
        public bool SaveMultiple(List<IEvent> events)
        {
            // Preconditions
            if (events == null)
            {
                throw new ArgumentNullException("events");
            }

            if (events.Count == 0)
            {
                throw new ArgumentException("events param collection is empty");
            }

            // Postcondition
            // should return true if all events were saved to the database.

            throw new NotImplementedException();
        }

        /// <summary>
        ///     This method saves input from EventForm and link it to Event class
        ///     whenever there is clicked edit or save.
        /// </summary>
        public IEvent Save()
        {
            throw new Exception();
        }

        /// <summary>
        ///     This method removes an Event. When the Remove() method is called in EventForm
        ///     the controller links it to a remove method in the client list
        /// </summary>
        /// <returns>Returns true if the event was successfully removed</returns>
        /// @pre event != null
        /// @post calendar.GetEvents().count_beforeRemove > calendar.GetEvents().count_afterRemove
        /// @post returns true if the Event was successfully removed from the Calendar.
        public bool Remove(IEvent ev)
        {
            // Preconditions
            if (ev == null)
            {
                throw new ArgumentNullException("ev");
            }

            // Remove event from Calendar.

            // Postcondition
            // if event removed return True else False;

            throw new NotImplementedException();
        }
    }
}