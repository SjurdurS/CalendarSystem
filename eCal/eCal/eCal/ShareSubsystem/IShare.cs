using System.Collections.Generic;
using eCal.CalendarManagement.Model;

namespace eCal.ShareSubsystem
{
    internal interface IShare
    {
        List<Notification> GetNotifications();

        Notification ReceiveNotification();
    }
}