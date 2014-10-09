using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApplication.Model;

namespace CalendarApplication.Composite_Pattern
{
    class Composite
    {
        /// <summary>
        /// List of events.
        /// </summary>
        List<IEvent> eventList = new List<IEvent>();

        public void Add(IEvent eventToAdd)
        {
            eventList.Add(eventToAdd);
        }


    }
}
