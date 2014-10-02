using System;

namespace CalendarApplication.Model
{
    internal class ShareForm
    {
        private string[] _ShareAdress;
        private string _Name;



        public ShareForm(string Name)
        {
            this._Name = Name;
            this._ShareAdress = new string[5];
        }

        public void Sendinvite()
        {
            
        }



    }

}
