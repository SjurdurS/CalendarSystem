using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract IPersistenceImplementor<T> CreateAbstractTestStub();
        public abstract IPersistenceImplementor<T> CreateAbstractFileStorage();
        public abstract IPersistenceImplementor<T> CreateAbstractDatabaseStorage();
    }
}
