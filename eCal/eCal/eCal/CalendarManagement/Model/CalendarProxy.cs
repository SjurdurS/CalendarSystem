namespace eCal.CalendarManagement.Model
{
    public class CalendarProxy : ICalendar
    {
        /// <summary>
        ///     Reference to RealSubject
        /// </summary>
        private ICalendar proxifiedCalendar;

        public CalendarProxy(string name)
        {
            Name = name;
        }

        /// <summary>
        ///     Private Proxy name
        /// </summary>
        public string Name { get; private set; }

        public void ShowCalendar()
        {

            // create the full Calendar Object only when the Calendar is required to be shown
            // Logic to load Calendar from Storage og Database.
            //proxifiedCalendar = new Calendar();
        }

    }
}