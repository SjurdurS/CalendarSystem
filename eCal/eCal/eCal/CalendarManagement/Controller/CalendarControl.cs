using eCal.CalendarManagement.Model;
using eCal.CalendarManagement.View;

namespace eCal.CalendarManagement.Controller
{
    /// <summary>
    /// This controller class is the link between CalendarForm and Calendar 
    /// </summary>
    class CalendarControl
    {
        /// <summary>
        /// Creates a CalendarForm in View.
        /// </summary>
        /// <returns></returns>
        private CalendarForm CreatCalendarForm()
        {
            CalendarForm calendarForm = new CalendarForm();
            return calendarForm;
        }

        /// <summary>
        /// Takes a CalendarForm and creates a Calendar.
        /// </summary>
        private Calendar CreateCalendar(CalendarForm calendarForm)
        {
            Calendar newCalendar = new Calendar();
            return newCalendar;
        }

       

        /// <summary>
        /// This method saves input from CalendarForm and link it to Calendar class 
        /// whenever there is clicked edit or save.
        /// </summary>
        private void Save(CalendarForm calendarForm, Calendar calendar)
        {
        }

        /// <summary>
        /// This method removes a calendar. When the Remove() method is called in CalendarForm 
        /// the controller links it to a remove method in the client list
        /// </summary>
        private void Remove(Calendar calendar)
        {       
        }
    }
}
