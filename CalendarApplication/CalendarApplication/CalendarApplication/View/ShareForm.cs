using System;
using System.Collections.Generic;

namespace CalendarApplication.Model
{
    internal class ShareForm
    {
        private List<string> ShareAddress;
        private string _Name;



        public ShareForm(string Name)
        {
            this._Name = Name;
            this.ShareAddress = new List<string>();
        }

        



    }

}
