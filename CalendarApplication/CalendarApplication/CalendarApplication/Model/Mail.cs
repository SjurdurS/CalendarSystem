using System;

namespace CalendarApplication.Model
{
    class Mail : Alarm // Extends Alarm
    {
        public string Text;
        public string Adress;

        public Mail(DateTime alarmDateTime, string message, string adress) : base(alarmDateTime)
        {
            this.Text = message;
            this.Adress = adress;
        }


        public string GetAdress
        {
            get { return Adress; }
        }

        public string SetAdress
        {
            get { return Adress; }
            set { Adress = value; }
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
