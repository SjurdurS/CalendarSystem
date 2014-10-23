using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Abstract_Factory
{
    class FactoryMaker
    {
        private static AbstractFactory pf = null;

        static AbstractFactory getFactory(string choice)
        {
            if (choice == "stub")
            {
                pf = new ConcreteFactoryStub();
            }
            else if (choice == "filestorage")
            {
                pf = new ConcreteFileStorage();
            }
             else if (choice == "databasestorage")
            {
                pf = new ConcreteDatabaseStorage();
            }
            return pf;

        }
    }
}
