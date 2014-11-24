using System.Collections.Generic;

namespace eCal.CalendarManagement.Model
{
    public interface IUser
    {
        /// <summary>
        ///     The username of the User.
        /// </summary>
        string Username { get; }

        /// <summary>
        ///     The email address of the client.
        /// </summary>
        string EmailAddress { get; set; }

        /// <summary>
        ///     List of Calendars the client has assigned.
        /// </summary>
        List<ICalendar> Calendars { get; set; }

        /// <summary>
        ///     Remove a Calendar from the Clients list of Calendars.
        /// </summary>
        /// <param name="calendar">The calendar to remove</param>
        /// <returns></returns>
        bool RemoveCalendar(ICalendar calendar);

        /// <summary>
        ///     Remove a Calendar from the Clients list of Calendars.
        /// </summary>
        /// <param name="calendars">The calendars to remove.</param>
        /// <returns></returns>
        void RemoveCalendars(List<ICalendar> calendars);

        /// <summary>
        ///     Add a Calendar to the Calendars list.
        /// </summary>
        /// <param name="calendar">The Calendar to add.</param>
        void AddCalendar(ICalendar calendar);

        /// <summary>
        ///     Add a Collection of Calendars to the Calendars list.
        /// </summary>
        /// <param name="calendars">The Collection of Calendars to add.</param>
        void AddCalendars(List<ICalendar> calendars);
    }
}