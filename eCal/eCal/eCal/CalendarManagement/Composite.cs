using System;
using System.Collections.Generic;

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
        private readonly List<IEvent> eventList = new List<IEvent>();

        /// <summary>
        ///     Move dates
        /// </summary>
        /// <param name="timeToMoveDateBy"></param>
        public void MoveDate(DateTime timeToMoveDateBy)
        {
            throw new NotImplementedException();
        }

        public void Add(IEvent eventToAdd)
        {
            eventList.Add(eventToAdd);
        }
    }
}