using System.Collections.Generic;

namespace eCal.CalendarManagement.View
{
    public class CalendarForm
    {
        public CalendarForm()
        {
            SharedGroup = new List<string>();
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public List<string> SharedGroup { get; private set; }

        public void Remove()
        {
        }

        public void Edit()
        {
        }

        public void Save()
        {
        }
    }
}