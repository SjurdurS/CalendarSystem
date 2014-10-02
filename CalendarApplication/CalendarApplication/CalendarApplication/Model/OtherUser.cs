using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    /// <summary>
    /// This class represents an other user.
    /// </summary>
    class OtherUser
    {
        /// <summary>
        /// The name of the Other user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The EmailAddress of the OtherUser.
        /// </summary>
        public string EmailAddress { get; set;}

        /// <summary>
        /// Instantiate a new OtherUser object.
        /// </summary>
        /// <param name="emailAddress">The EmailAddress of the OtherUser</param>
        public OtherUser(string name, string emailAddress)
        {
            this.Name = name;
            this.EmailAddress = emailAddress;
        }
    }
}
