using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApplication.Model;

namespace CalendarApplication.Composite_Pattern
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
