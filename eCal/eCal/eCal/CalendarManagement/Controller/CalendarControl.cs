﻿using System;
using eCal.CalendarManagement.Model;
using eCal.CalendarManagement.View;

namespace eCal.CalendarManagement.Controller
{
    /// <summary>
    ///     This controller class is the link between CalendarForm and Calendar
    /// </summary>
    internal class CalendarControl
    {
        /// <summary>
        ///     Creates a CalendarForm in View.
        /// </summary>
        /// <returns></returns>
        public CalendarForm CreatCalendarForm()
        {
            var calendarForm = new CalendarForm();
            return calendarForm;
        }

        /// <summary>
        ///     Takes a CalendarForm and creates a Calendar.
        /// </summary>
        public Calendar CreateCalendar(CalendarForm calendarForm)
        {
            var newCalendar = new Calendar();
            return newCalendar;
        }


        /// <summary>
        ///     This method saves input from CalendarForm and link it to Calendar class
        ///     whenever there is clicked edit or save.
        /// </summary>
        public void Save(CalendarForm calendarForm, Calendar calendar)
        {
        }

        /// <summary>
        ///     This method removes a calendar. When the Remove() method is called in CalendarForm
        ///     the controller links it to a remove method in the client list
        /// </summary>
        /// @pre Calendar c = calendar.GetType()
        /// @pre calendar != null
        /// @post calendar = null
        /// @post user.GetCalendars().count_beforeRemove > user.GetCalendars().count_afterRemove
        public void Remove(Calendar calendar)
        {
            // Preconditions
            Calendar c = new Calendar();
            if (c.GetType() != calendar.GetType())
            {
                throw new InvalidOperationException("calendar param has wrong type.");
            }

            if (calendar == null)
            {
                throw new ArgumentNullException("calendar");
            }
            User user;


            var calendars_before = user.Calendars.Count;


            // Logic to remove calendars.

            var calendars_after = user.Calendars.Count;
            

            // Postconditions
            if (calendars_before > calendars_after)
            {
                throw new InvalidOperationException("No calendars seem to have been removed.");
            }
        }
    }
}