using System;

namespace eCal.CalendarManagement
{
    interface IEvent
    {
        void MoveDate(DateTime timeToMoveDateBy);
    }
}
