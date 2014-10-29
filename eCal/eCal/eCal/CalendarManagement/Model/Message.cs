using System;

namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     This subclass of Alarm represents an alarm of type message.
    ///     The User recieves the message when the alarm sets.
    /// </summary>
    internal class Message : Alarm // Extends Alarm
    {
        public Message(DateTime dateTime, string text) : base(dateTime)
        {
            Text = text;
        }

        /// <summary>
        ///     The content of the message.
        /// </summary>
        public string Text { get; set; }
    }
}