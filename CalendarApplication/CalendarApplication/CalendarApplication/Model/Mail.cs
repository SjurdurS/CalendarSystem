using System;

namespace CalendarApplication.Model
{
    class Mail : Alarm // Extends Alarm
    {
        public string Text { get; set; }
        public string Address { get; set; }

        public Mail(DateTime dateTime, string message, string address) : base(dateTime)
        {
            this.Text = message;
            this.Address = address;
        }

    }
}
