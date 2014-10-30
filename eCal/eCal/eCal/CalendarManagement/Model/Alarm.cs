using System;

namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     Superclass handles alarms that can be set on events.
    /// </summary>
    public class Alarm
    {
        public Alarm(DateTime dateTime)
        {
            DateTime = dateTime;
        }

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