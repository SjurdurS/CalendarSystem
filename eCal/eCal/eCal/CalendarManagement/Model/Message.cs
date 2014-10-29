﻿using System;

namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     This subclass of Alarm represents an alarm of type message.
    ///     The User recieves the message when the alarm sets.
    /// </summary>
    public  class Message
    {
        public Message(string text)
        {
            Text = text;
        }

        /// <summary>
        ///     The content of the message.
        /// </summary>
        public string Text { get; set; }
    }
}