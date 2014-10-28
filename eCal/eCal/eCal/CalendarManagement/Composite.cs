using System;
using System.Collections.Generic;

namespace eCal.CalendarManagement
{
    /// <summary>
    /// We do not fully understand what to implement in this design pattern
    /// </summary>
    class Composite : IEvent
    {
        /// <summary>
        /// List of events.
        /// </summary>
        List<IEvent> eventList = new List<IEvent>();

        public void Add(IEvent eventToAdd)
        {
            eventList.Add(eventToAdd);
        }

        /// <summary>
        /// Move dates
        /// </summary>
        /// <param name="timeToMoveDateBy"></param>
        public void MoveDate(DateTime timeToMoveDateBy)
        {
            throw new NotImplementedException();
        }
    }
}
