﻿namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     This subclass represents an alarm of type Mail.
    ///     This mail should be sent when the alarm starts.
    /// </summary>
    /// @invariant GetSubject() != null 
    /// @invariant GetAddress() != null
    public class Mail
    {
        /// <summary>
        ///     Instantiate a new Mail.
        /// </summary>
        /// <param name="dateTime">The time the mail should be sent.</param>
        /// <param name="subject">The Subject of the email.</param>
        /// <param name="message">The message body of the mail.</param>
        /// <param name="address">The email address of the mail.</param>
        public Mail(Alarm alarm, string subject, string message, string address)
        {
            Alarm = alarm;
            Subject = subject;
            Text = message;
            Address = address;
        }

        public Alarm Alarm { get; private set; }

        /// <summary>
        ///     The subject of the mail.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        ///     The content of the mail.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     The email address where to send the mail.
        /// </summary>
        public string Address { get; set; }
    }
}