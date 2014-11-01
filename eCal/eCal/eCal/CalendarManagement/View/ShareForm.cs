using System.Collections.Generic;

namespace eCal.CalendarManagement.View
{
    /// <summary>
    ///     This class holds the data of shareinformation.
    /// </summary>
    internal class ShareForm
    {
        /// <summary>
        ///     The shareform has a list of other users that the calendar is shared with
        ///     _Name comes from the the event that is about to be shared.
        /// </summary>
        private readonly List<string> _shareAddress;

        public ShareForm()
        {
            _shareAddress = new List<string>();
        }

        public string Name { get; set; }

        public List<string> ShareAddress
        {
            get { return _shareAddress; }
        }
    }
}