using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    /// <summary>
    /// This class is used to send mails.
    /// </summary>
    interface IMailManager<T>
    {

        /// <summary>
        /// Send an email.
        /// </summary>
        /// <param name="mail">The mail to send.</param>
        void Send(T mail);
    }
}
