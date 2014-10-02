using System;

namespace CalendarApplication.Model
{
    class Message : Alarm // Extends Alarm
    {
        public string Text;

        public Message(DateTime alarmDateTime, string text) : base(alarmDateTime)
        {
            this.Text = text;
        }

        public string GetText
        {
            get { return Text; }
        }


        public string SetText
        {
            get { return Text; }
            set { Text = value; }
        }
    }
}
