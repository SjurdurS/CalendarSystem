using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarApplication.Model;

namespace CalendarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run program from here maybe.");
            Console.WriteLine(Properties.Resources.DefaultCalendarColor);
            Console.WriteLine(Properties.Resources.DefaultCalendarName);


            Calendar c = new Calendar();
            Console.WriteLine(c.Name);
            c.Name = "Hansen";
            Console.WriteLine(c.Name);

            Mail m = new Mail(new DateTime(2014, 10, 2), "Wuuhuuu", "dude@me.com");
            Console.WriteLine(m.DateTime);
        }
    }
}
