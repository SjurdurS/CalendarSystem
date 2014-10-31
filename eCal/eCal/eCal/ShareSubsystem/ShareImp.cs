using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCal.CalendarManagement.Model;

namespace eCal.ShareSubsystem
{
    /// <summary>
    /// Implements IShare. Is dependent on NotifyUserControl.
    /// </summary>
    class ShareImp:IShare
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
