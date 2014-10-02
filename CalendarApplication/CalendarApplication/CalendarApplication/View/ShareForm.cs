using System;
using System.Collections.Generic;

namespace CalendarApplication.Model
{
    /// <summary>
    /// This class holds the data of shareinformation. 
    /// </summary>
    internal class ShareForm
    {
        /// <summary>
        /// The shareform has a list of other users that the calendar is shared with
        /// _Name comes from the the event that is about to be shared.
        /// </summary>
        private List<string> _ShareAddress;
        private string _Name;



        public ShareForm(string Name)
        {
            this._Name = Name;
            this._ShareAddress = new List<string>();
        }

        



    }

}
