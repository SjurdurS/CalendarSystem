using System;

namespace CalendarApplication.Model
{
    internal class Alarm
    {
        public DateTime AlarmDateTime; //The date and time that the Client should recieve the notification.

        public Alarm(DateTime alarmDateTime)
        {
            this.AlarmDateTime = alarmDateTime;
        }

        public DateTime SetAlarmDateTime
        {
            get { return AlarmDateTime; }
            set { AlarmDateTime = value; }
        }

        public DateTime GetAlarmDateTime
        {
            get { return AlarmDateTime; }
        }
}
}
