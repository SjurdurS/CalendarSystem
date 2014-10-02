using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    class OtherUser
    {
        /// <summary>
        /// The EmailAddress of the OtherUser.
        /// </summary>
        public string EmailAddress { get; set;}

        /// <summary>
        /// Instantiate a new OtherUser object.
        /// </summary>
        /// <param name="emailAddress">The EmailAddress of the OtherUser</param>
        public OtherUser(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }
    }
}
