using System;

namespace CalendarApplication.Model
{
    internal class Alarm
    {
        /// <summary>
        /// The date and time that the Client should recieve the notification.
        /// </summary>
        public DateTime DateTime { get; set; }

        public Alarm(DateTime dateTime)
        {
            this.DateTime = dateTime;
        }

        
}
}
