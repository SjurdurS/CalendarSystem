using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    /// <summary>
    /// Part of adapter pattern (The adapter for google calendar)
    /// </summary>
    class GoogleAdapter :ICalendarEntry
    {
        public void CreateEvent()
        {
            throw new NotImplementedException();
        }

        public void CreateCalendar()
        {
            throw new NotImplementedException();
        }

        public void EditEvent()
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent()
        {
            throw new NotImplementedException();
        }

        public void ShareEvent()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
