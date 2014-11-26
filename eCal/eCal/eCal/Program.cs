using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using eCal.CalendarManagement.Controller;
using eCal.CalendarManagement.Model;
using eCal.CalendarManagement.View;

namespace eCal
{
    class Program
    {
        /// <summary>
        /// The first time User starts eCal.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            //Set up a new user
            if (args.Length == 2)
            {
                var username = args[1];
                var mail = args[2];
                IUser user = new User(username, mail);

                //Set up controllers
                var updateControl = new UpdateControl();
                var calendarControl = new CalendarControl();
                
                //Set up initial calendar
                var calendarForm = calendarControl.CreatCalendarForm();
                var calendar = calendarControl.CreateCalendar(calendarForm);
                user.Calendars.Add(calendar);

                //Set up synchronizer
                updateControl.AutoSync(user.Calendars);
            }
            else if (args.Length == 0)
            {
                // A Login window opens.
                // The user logs in with his credentials
                // If we are online use the RdbmsStorage class to get the User object and load his Calendars.
                // If we are offline we load the User from localstorage using FileStorage class.
                // If no User is found with the above credentials the user is prompted with a New User window.

            }
            else
            {
                throw new ArgumentException("Wrong number of parameters.");
            }
        }
    }
}
