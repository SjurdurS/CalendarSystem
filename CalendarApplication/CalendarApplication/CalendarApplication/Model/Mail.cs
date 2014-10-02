using System;

namespace CalendarApplication.Model
{
    class Mail : Alarm // Extends Alarm
    {
        private string message;
        private string adress;

        public Mail(DateTime alarmDateTime, string message, string adress) : base(alarmDateTime)
        {
            this.message = message;
            this.adress = adress;
        }
    }
}
