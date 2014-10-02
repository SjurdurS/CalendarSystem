
using CalendarApplication.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalendarApplication
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void CreateNewCalendar_Test1()
        {
            Calendar c = new Calendar("Holiday", "Red");
            Event ev = new Event();

        }
    }
}
