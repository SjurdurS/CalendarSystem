using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCal.CalendarManagement.Model;

namespace eCal.ShareSubsystem
{
    interface IShare
    {
        List<Notification> GetNotifications();

        Notification ReceiveNotification();
    }
}
