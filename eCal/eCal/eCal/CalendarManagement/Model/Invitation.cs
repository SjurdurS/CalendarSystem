namespace eCal.CalendarManagement.Model
{
    internal class Invitation
    {
        private Calendar calendar;
        private Event ev;

        public Invitation(string name, string message, Event ev)
        {
            Name = name;
            Message = message;
            this.ev = ev;
        }


        public Invitation(string name, string message, Calendar calendar)
        {
            Name = name;
            Message = message;
            this.calendar = calendar;
        }

        private string Name { get; set; }
        private string Message { get; set; }
    }
}