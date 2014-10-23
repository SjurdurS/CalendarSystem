using System;

namespace eCal.Model
{
    /// <summary>
    /// This subclass of Alarm represents an alarm of type message. 
    /// The Client recieves the message when the alarm sets.
    /// </summary>
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
