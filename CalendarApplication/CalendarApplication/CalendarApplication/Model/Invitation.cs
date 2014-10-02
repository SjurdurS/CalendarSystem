using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    internal class Invitation
    {
        private string _Name { get; set; }
        private string _Message { get; set; }
        private Event _Event;
        private Calendar _Calendar;

        public Invitation(string Name, string Message, Event _event)
    {
        this._Name = Name;
        this._Message = Message;
        this._Event = _event;
        
    }



        public Invitation(string Name, string Message, Calendar _calendar)
        {
            this._Name = Name;
            this._Message = Message;
            this._Calendar = _calendar;
            
        }

    }
}
