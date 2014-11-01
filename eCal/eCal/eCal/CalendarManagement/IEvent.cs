using System;

namespace eCal.CalendarManagement
{
    internal interface IEvent
    {
        void MoveDate(DateTime timeToMoveDateBy);
    }
}