using System;

namespace CalendarApplication.Model
{
    internal class Alarm
    {
        public DateTime DateTime { get; set; } //The date and time that the Client should recieve the notification.

        public Alarm(DateTime dateTime)
        {
            this.DateTime = dateTime;
        }

        public void NotifyClient()
        {
            
        }
}
}
