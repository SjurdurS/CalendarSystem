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

        public Event(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public void Share(OtherUser otherUser)
        {
            
        }

        /// <summary>
        /// Add This Event to a Calendar.
        /// </summary>
        /// <param name="calendar">The Calendar to add this event to.</param>
        public void AddToCalendar(Calendar calendar)
        {
            calendar.AddEvent(this);
        }

        /// <summary>
        /// Remove This event from a Calendar.
        /// </summary>
        /// <param name="calendar">The Calendar to remove this event from.</param>
        public void RemoveFromCalendar(Calendar calendar)
        {
            calendar.RemoveEvent(this);
        }

    }


}

