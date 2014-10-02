using System;

namespace CalendarApplication.Model
{
    internal class Alarm
    {
        public DateTime alarmDateTime; //The date and time that the Client should recieve the notification.

        public Alarm(DateTime alarmDateTime)
        {
            this.alarmDateTime = alarmDateTime;
        }

        public DateTime SetAlarmDateTime
        {
            get { return alarmDateTime; }
            set { alarmDateTime = value; }
        }

        public DateTime GetAlarmDateTime
        {
            get { return alarmDateTime; }
        }
}
}
