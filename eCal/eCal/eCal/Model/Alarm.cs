using System;

namespace eCal.Model
{
    /// <summary>
    /// Superclass handles alarms that can be set on events. 
    /// </summary>
    public class Alarm
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
