using System;

namespace CalendarApplication.Model
{
    class Message : Alarm // Extends Alarm
    {
        public string Text { get; set; }

        public Message(DateTime dateTime, string text) : base(dateTime)
        {
            this.Text = text;
        }

    }
}
