using System;
using System.Globalization;
using System.Net.Mime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalendarApplication
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void CreateNewCalendar_Test1()
        {
            CalendarApplication.Model.Calendar c = new CalendarApplication.Model.Calendar();

        }
    }
}
