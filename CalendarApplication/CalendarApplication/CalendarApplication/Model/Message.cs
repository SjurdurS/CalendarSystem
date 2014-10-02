using System;

namespace CalendarApplication.Model
{
    class Message : Alarm // Extends Alarm
    {
        /// <summary>
        /// The content of the message.
        /// </summary>
        public string Text { get; set; }

        public Message(DateTime dateTime, string text) : base(dateTime)
        {
            this.Text = text;
        }

    }
}
