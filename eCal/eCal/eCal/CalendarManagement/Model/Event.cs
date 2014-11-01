using System;

namespace eCal.CalendarManagement.Model
{
    public class Event : IEvent
    {
        /// <summary>
        ///     Instantiate a new Event.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        public Event()
        {
            Name = "Default Event Name";
            Color = "Default Event Color";
        }
        
        public Event(string name, string color)
        {
            Name = name;
            Color = color;
        }

        /// <summary>
        ///     The name of the event.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The color of the event.
        /// </summary>
        public string Color { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Alarm Alarm { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }

        public void MoveDate(DateTime timeToMoveDateBy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Share the Event with another user.
        /// </summary>
        /// <param name="otherUser">The other user to share the event with.</param>
        public void Share(string otherUser)
        {
        }

        /// <summary>
        ///     Add This Event to a Calendar.
        /// </summary>
        /// <param name="calendar">The Calendar to add this event to.</param>
        public void AddToCalendar(Calendar calendar)
        {
            calendar.AddEvent(this);
        }

        /// <summary>
        ///     Remove This event from a Calendar.
        /// </summary>
        /// <param name="calendar">The Calendar to remove this event from.</param>
        public void RemoveFromCalendar(Calendar calendar)
        {
            calendar.RemoveEvent(this);
        }
    }
}