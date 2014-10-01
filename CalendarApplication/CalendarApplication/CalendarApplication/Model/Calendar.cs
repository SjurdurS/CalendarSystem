using System.Collections.Generic;

namespace CalendarApplication.Model
{
    /// <summary>
    /// This class represents a Calendar in the system. A Calendar has a name and a list of Events.
    /// </summary>
    class Calendar
    {
        /// <summary>
        /// The name of the Calendar.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The Color of the Calendar. Used to color the calendar in the View.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// List of users this Calendar is shared with.
        /// </summary>
        public List<OtherUser> SharedGroup { get; private set; }


        /// <summary>
        /// Instantiate a new Calendar.
        /// </summary>
        public Calendar()
        {
            this.Name = Properties.Resources.DefaultCalendarName; // Default Calendar name
            this.Color = "Blue";
            this.SharedGroup = new List<OtherUser>();
        }


    }
}
