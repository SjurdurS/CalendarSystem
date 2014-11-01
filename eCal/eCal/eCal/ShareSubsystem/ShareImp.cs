using System;
using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.ShareSubsystem
{
    /// <summary>
    ///     Implements IShare. Is dependent on NotifyUserControl.
    /// </summary>
    internal class ShareImp : IShare
    {
        public List<Notification> GetNotifications()
        {
            throw new NotImplementedException();
        }

        public Notification ReceiveNotification()
        {
            throw new NotImplementedException();
        }
    }
}