using System;
using System.Collections.Generic;

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

        public IUser User { get; private set; }

        string ICalendar.Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Color { get; set; }
        public List<IEvent> Events { get; private set; }
        public List<string> SharedGroup { get; set; }

        public void Share(IUser User)
        {
            throw new NotImplementedException();
        }

        public void AddEvent(IEvent ev)
        {
            throw new NotImplementedException();
        }

        public bool RemoveEvent(IEvent ev)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromUser(IUser user)
        {
            throw new NotImplementedException();
        }

        public void AddToUser(IUser user)
        {
            throw new NotImplementedException();
        }

        public void ShowCalendar()
        {
            // create the full Calendar Object only when the Calendar is required to be shown
            // Logic to load Calendar from Storage og Database.
            //proxifiedCalendar = new Calendar();
        }
    }
}