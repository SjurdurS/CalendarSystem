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
    }
}