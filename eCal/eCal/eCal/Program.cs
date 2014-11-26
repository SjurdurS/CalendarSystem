using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
            //Set up user
            if (args.Length == 2)
            {
                IUser user = new User(args[1], args[2]);
                //Set up calendars
                CalendarForm calendarForm = new CalendarForm();
                Calendar calendar = new Calendar(calendarForm);
                user.Calendars.Add(calendar);

                //Set up controllers
                UpdateControl updateControl = new UpdateControl();
                NotifyUserControl notifyUserControl = new NotifyUserControl();
                CalendarControl calendarControl = new CalendarControl();

                //Set up synchronizer
                updateControl.AutoSync(user.Calendars);
            }
            else
            {
                //Error message.
                throw new NotImplementedException();
            }
        }
    }
}
