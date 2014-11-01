namespace eCal.CalendarManagement.Model
{
    internal class Notification
    {
        private Invitation _invite;
        private string _reply;

        public Notification(Invitation invite, string reply)
        {
            _invite = invite;
            _reply = reply;
        }

        public Invitation SendInvite()
        {
            return null;
        }

        public string SendReply()
        {
            return null;
        }

        public string ErrorMessage()
        {
            return null;
        }

        public string UpdateMessage()
        {
        }
    }
}