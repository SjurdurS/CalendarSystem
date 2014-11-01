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
        /// @post user.GetCalendars().count_beforeRemove = user.GetCalendars().count_afterRemove
        public void Remove(Calendar calendar)
        {
        }
    }
}