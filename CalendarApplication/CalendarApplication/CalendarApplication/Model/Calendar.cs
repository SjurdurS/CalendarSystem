using System.Collections.Generic;

namespace CalendarApplication.Model
{
    class Calendar
    {
        /// <summary>
        /// The name of the Calendar.
        /// </summary>
        private string Name;
        
        /// <summary>
        /// The Color of the Calendar. Used to color the calendar in the View.
        /// </summary>
        private string Color;

        /// <summary>
        /// List of users this Calendar is shared with.
        /// </summary>
        private List<OtherUser> SharedGroup; 


        /// <summary>
        /// Instantiate a new Calendar.
        /// </summary>
        public Calendar()
        {
            this.Name = "Calendar 1";
            this.Color = "Blue";
            this.SharedGroup = new List<OtherUser>();
        }

    }
}
