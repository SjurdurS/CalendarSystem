using System;

namespace CalendarApplication.Model
{
    public class Event
    {
        /// <summary>
        /// The name of the event.
        /// </summary>
        public string Name { get; private set; }
        public string Color { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public Alarm Alarm { get; private set; }
        public string Place { get; private set; }
        public string Description { get; private set; }

        public Event()
        {
            this.Name = Properties.Resources.DefaultEventName;
            this.Color = Properties.Resources.DefaultEventColor;
        }

    }


}

