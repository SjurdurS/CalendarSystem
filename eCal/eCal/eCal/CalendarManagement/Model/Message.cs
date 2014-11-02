namespace eCal.CalendarManagement.Model
{
    /// <summary>
    ///     This subclass of Alarm represents an alarm of type message.
    ///     The User recieves the message when the alarm sets.
    /// </summary>
    public class Message
    {
        public Message(Alarm alarm, string text)
        {
            Alarm = alarm;
            Text = text;
        }
        public Alarm Alarm { get; private set; }

        /// <summary>
        ///     The content of the message.
        /// </summary>
        public string Text { get; set; }
    }
}