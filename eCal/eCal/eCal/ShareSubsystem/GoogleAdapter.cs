using System;
using eCal.CalendarManagement.Controller;
using eCal.CalendarManagement.Model;

namespace eCal.ShareSubsystem
{
    /// <summary>
    ///     Part of adapter pattern (The adapter for google calendar)
    /// </summary>
    internal class GoogleAdapter : ICalendarEntry
    {
     
        private IUser user;

        public void CreateEvent()
        {
            throw new NotImplementedException();
        }

        public void CreateCalendar()
        {
            throw new NotImplementedException();
        }

        public void EditEvent()
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent()
        {
            throw new NotImplementedException();
        }

        public void ShareEvent()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        // Methods from the Google Calendar API
        // delete
        // get
        // insert
        // list
        // patch
        // update
        // watch
    }
}