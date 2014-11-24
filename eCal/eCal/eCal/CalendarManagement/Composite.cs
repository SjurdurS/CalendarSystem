using System;
using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.CalendarManagement
{
    /// <summary>
    ///     We do not fully understand what to implement in this design pattern
    /// </summary>
    internal class Composite : IEvent
    {
        /// <summary>
        ///     List of events.
        /// </summary>
        private readonly List<IEvent> _eventList = new List<IEvent>();

        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Alarm Alarm { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }

        /// <summary>
        ///     Move dates
        /// </summary>
        /// <param name="timeToMoveDateBy"></param>
        public void MoveDate(DateTime timeToMoveDateBy)
        {
            throw new NotImplementedException();
        }

        public void Share(string otherUser)
        {
            throw new NotImplementedException();
        }

        public void AddToCalendar(ICalendar calendar)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCalendar(ICalendar calendar)
        {
            throw new NotImplementedException();
        }

        public void Add(IEvent eventToAdd)
        {
            _eventList.Add(eventToAdd);
        }
    }
}