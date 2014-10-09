using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Abstract_Factory
{
    class ConcreteFactoryFileStorage
    {
        AbstractFileStorage createProductA()
        {
            return new FileStorage("filestorage");
        }
    }
}
