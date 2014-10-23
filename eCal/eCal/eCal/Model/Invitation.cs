﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace eCal.Model
{
    internal class Invitation
    {
        private string Name { get; set; }
        private string Message { get; set; }
        private Event ev;
        private Calendar calendar;

        public Invitation(string name, string message, Event ev)
        {
            this.Name = name;
            this.Message = message;
            this.ev = ev;
        
         }



        public Invitation(string name, string message, Calendar calendar)
        {
            this.Name = name;
            this.Message = message;
            this.calendar = calendar;
            
        }

    }
}
