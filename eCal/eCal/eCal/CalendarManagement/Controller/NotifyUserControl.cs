﻿using System;
using System.Collections.Generic;
using eCal.CalendarManagement.Model;
using eCal.CalendarManagement.View;

namespace eCal.CalendarManagement.Controller
{
    internal class NotifyUserControl
    {
        /// <summary>
        ///     Creates a ShareForm in View.
        /// </summary>
        /// <returns></returns>
        public ShareForm CreateShareForm()
        {
            var shareForm = new ShareForm();
            return shareForm;
        }

        /// <summary>
        ///     Creates a ShareForm and returns a list of invitations.
        /// </summary>
        /// @pre ShareForm != null
        /// @pre shareForm.ShareAddress.count > 0
        /// @post invitations.count > 0
        /// @post shareForm.ShareAddress.count == invitations.count
        /// <param name="shareForm"></param>
        /// <returns></returns>
        public List<Invitation> CreateInvite(ShareForm shareForm)
        {
            // Preconditions
            if (shareForm == null)
            {
                throw new ArgumentNullException("shareForm");
            }

            if (shareForm.ShareAddress.Count == 0)
            {
                throw new ArgumentException("shareForm share address collection is empty. No address to share with.");

            }


            var invitations = new List<Invitation>();
            return invitations;
            

        }


        /// <summary>
        ///     Shows and invitation as a notification.
        /// </summary>
        public Notification InviteNotification()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Shows a reply as a notification.
        /// </summary>
        /// <returns></returns>
        public Notification ReplyNotification()
        {
            throw new NotImplementedException();
        }
    }
}