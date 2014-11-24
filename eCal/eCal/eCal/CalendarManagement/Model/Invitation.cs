namespace eCal.CalendarManagement.Model
{
    internal class Invitation
    {
        private ICalendar calendar;
        private IEvent ev;

        public Invitation(string name, string message, IEvent ev)
        {
            Name = name;
            Message = message;
            this.ev = ev;
        }


        public Invitation(string name, string message, ICalendar calendar)
        {
            Name = name;
            Message = message;
            this.calendar = calendar;
        }

        private string Name { get; set; }
        private string Message { get; set; }
    }
}