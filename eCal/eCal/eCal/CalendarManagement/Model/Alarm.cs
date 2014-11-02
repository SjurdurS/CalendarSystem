using System;

namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     Superclass handles alarms that can be set on events.
    /// </summary>
    public class Alarm
    {
        public Alarm(Event e, DateTime dateTime)
        {
            Event = e;
            DateTime = dateTime;
        }
        /// <summary>
        /// The event which the alarm assigned to.
        /// </summary>
        public Event Event { get; private set; }

        /// <summary>
        ///     The date and time that the User should recieve the notification.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        ///     Mail to send after the alarm activates
        /// </summary>
        public Mail mail { get; set; }

        /// <summary>
        ///     Message to send afthe the alarm activates.
        /// </summary>
        public Message message { get; set; }
    }
}