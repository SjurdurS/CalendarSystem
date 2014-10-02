using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApplication.Model;

namespace CalendarApplication
{
    class Event
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public Alarm Alarm { get; private set; }
        public string Place { get; private set; }
        public string Description { get; private set; }

        public Event()
        {
            this.Name = Properties.Resources.DefaultCalendarName;
            this.Color = Properties.Resources.DefaultCalendarColor;
        }
    }


}

