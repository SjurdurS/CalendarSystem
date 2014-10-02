using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    /// <summary>
    /// This class represents a client. A client can have one or more Calendars assigned.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The username of the Client.
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// The email address of the client.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// List of Calendars the client has assigned.
        /// </summary>
        public List<Calendar> Calendars { get; set; }

        /// <summary>
        /// Instantiate a Client with a username and an empty Calendars list.
        /// </summary>
        /// <param name="username">The username of the Client</param>
        public Client(string username)
        {
            this.Username = username;
            this.Calendars = new List<Calendar>();
        }

        /// <summary>
        /// Instantiate a Client with a username and an empty Calendars list.
        /// </summary>
        /// <param name="username">The username of the Client</param>
        /// <param name="emailAddress">The emailaddress of the client.</param>
        public Client(string username, string emailAddress)
        {
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.Calendars = new List<Calendar>();
        }

        /// <summary>
        /// Instantiate a Client with a username and Calendars list.
        /// </summary>
        /// <param name="username">The username of the Client</param>
        /// <param name="calendars">The list of Calendars this client is assigned to</param>
        public Client(string username, List<Calendar> calendars )
        {
            if (Calendars == null) throw new ArgumentNullException("calendars");
            this.Username = username;
            this.Calendars = Calendars;
        }

        /// <summary>
        /// Instantiate a Client with a username and Calendars list.
        /// </summary>
        /// <param name="username">The username of the Client</param>
        /// <param name="emailAddress">The emailaddress of the client.</param>
        /// <param name="calendars">The list of Calendars this client is assigned to</param>
        public Client(string username, string emailAddress, List<Calendar> calendars )
        {
            if (Calendars == null) throw new ArgumentNullException("calendars");
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.Calendars = Calendars;
        }

        /// <summary>
        /// Remove a Calendar from the Clients list of Calendars.
        /// </summary>
        /// <param name="calendar">The calendar to remove</param>
        /// <returns></returns>
        public bool RemoveCalendar(Calendar calendar)
        {
            return this.Calendars.Remove(calendar);
        }      
        
        /// <summary>
        /// Remove a Calendar from the Clients list of Calendars.
        /// </summary>
        /// <param name="calendars">The calendars to remove.</param>
        /// <returns></returns>
        public void RemoveCalendars(List<Calendar> calendars)
        {
            foreach (Calendar calendar in calendars)
            {
                RemoveCalendar(calendar);
            }
        }

        /// <summary>
        /// Add a Calendar to the Calendars list.
        /// </summary>
        /// <param name="calendar">The Calendar to add.</param>
        public void AddCalendar(Calendar calendar)
        {
            this.Calendars.Add(calendar);
        }

        /// <summary>
        /// Add a Collection of Calendars to the Calendars list.
        /// </summary>
        /// <param name="calendars">The Collection of Calendars to add.</param>
        public void AddCalendars(List<Calendar> calendars)
        {
            foreach (Calendar calendar in calendars)
            {
                AddCalendar(calendar);
            }
        }
    }
}
