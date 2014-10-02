using System;

namespace CalendarApplication.Model
{
    class Mail : Alarm // Extends Alarm
    {
        public string Text;
        public string Address;

        public Mail(DateTime alarmDateTime, string message, string address) : base(alarmDateTime)
        {
            this.Text = message;
            this.Address = address;
        }


        public string GetAddress
        {
            get { return Address; }
        }

        public string SetAddress
        {
            get { return Address; }
            set { Address = value; }
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
