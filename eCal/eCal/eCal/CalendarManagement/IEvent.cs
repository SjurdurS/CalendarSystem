using System;
using eCal.CalendarManagement.Model;

namespace eCal.CalendarManagement
{
    public interface IEvent
    {
        string Name { get; set; }


        DateTime StartDateTime { get; set; }
        DateTime EndDateTime { get; set; }
        Alarm Alarm { get; set; }
        string Place { get; set; }
        string Description { get; set; } 
        
        void MoveDate(DateTime timeToMoveDateBy);

        void Share(string otherUser);

        void AddToCalendar(ICalendar calendar);

        void RemoveFromCalendar(ICalendar calendar);
    }
}