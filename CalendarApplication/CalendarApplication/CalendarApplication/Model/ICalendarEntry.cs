using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    /// <summary>
    /// Part of the adapter pattern, The entry interface
    /// </summary>
    interface ICalendarEntry
    {
        void CreateEvent();

        void CreateCalendar();

        void EditEvent();

        void DeleteEvent();

        void ShareEvent();

        void Update();

    }
}
