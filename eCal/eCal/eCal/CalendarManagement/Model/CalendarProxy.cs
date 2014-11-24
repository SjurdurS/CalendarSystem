﻿using System.Collections.Generic;

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

        public User User { get; private set; }
        string ICalendar.Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Color { get; set; }
        public List<IEvent> Events { get; private set; }
        public List<string> SharedGroup { get; set; }
        public void Share(User User)
        {
            throw new System.NotImplementedException();
        }

        public void AddEvent(IEvent ev)
        {
            throw new System.NotImplementedException();
        }

        public void AddEvents(List<IEvent> events)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveEvent(IEvent ev)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveEvents(List<IEvent> events)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveFromUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void AddToUser(User user)
        {
            throw new System.NotImplementedException();
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