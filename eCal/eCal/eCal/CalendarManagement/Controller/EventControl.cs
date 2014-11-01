﻿using System;
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
        public Event CreateEvent(EventForm EventForm)
        {
            var newEvent = new Event();
            return newEvent;
        }

        /// <summary>
        ///     Saves multiple events.
        /// </summary>
        /// @pre eventForm != null
        /// @pre events != null
        /// @pre events.count > 0
        /// @post events.count > 1
        /// @post Event e = events.GetType()
        /// <param name="events"></param>
        public List<Event> SaveMultiple(EventForm eventForm, List<Event> events)
        {
            if (eventForm == null || events == null)
            {
                throw new NullReferenceException();
            }



            throw new NotImplementedException();
        }

        /// <summary>
        ///     This method saves input from EventForm and link it to Event class
        ///     whenever there is clicked edit or save.
        /// </summary>
        public Event Save()
        {
            throw new Exception();
        }

        /// <summary>
        ///     This method removes an Event. When the Remove() method is called in EventForm
        ///     the controller links it to a remove method in the client list
        /// </summary>
        /// @pre Event e = event.GetType()
        /// @pre event != null
        /// @post event = null
        /// @post calendar.GetEvents().count_beforeRemove = calendar.GetEvents().count_afterRemove
        public Event Remove(Event ev)
        {
            return null;
        }
    }
}