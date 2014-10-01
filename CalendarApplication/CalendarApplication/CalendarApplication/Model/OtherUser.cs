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
        /// The Username of the OtherUser.
        /// </summary>
        public string Username { get; set;}

        /// <summary>
        /// Instantiate a new OtherUser object.
        /// </summary>
        /// <param name="username">The username of the OtherUser</param>
        public OtherUser(string username)
        {
            this.Username = username;
        }
    }
}
