using System.Collections.Generic;
using eCal.CalendarManagement.Model;
using eCal.CalendarManagement.View;

namespace eCal.CalendarManagement.Controller
{
    class NotifyUserControl
    {
        /// <summary>
        /// Creates a ShareForm in View.
        /// </summary>
        /// <returns></returns>
        public ShareForm CreateShareForm()
        {
            ShareForm shareForm = new ShareForm();
            return shareForm;
        }

        /// <summary>
        /// Creates a ShareForm and returns a list of invitations. 
        /// </summary>
        /// <param name="shareForm"></param>
        /// <returns></returns>
        public List<Invitation> CreateInvite(ShareForm shareForm )
        {
            List<Invitation> invitations = new List<Invitation>();
            return invitations;
        }


        /// <summary>
        /// Shows and invitation as a notification. 
        /// </summary>
        public Notification InviteNotification()
        {
        }

        /// <summary>
        /// Shows a reply as a notification.
        /// </summary>
        /// <returns></returns>
        public Notification ReplyNotification()
        {   
        }
        


    }
}
