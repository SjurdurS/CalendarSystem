using System;

namespace CalendarApplication
{
    class RdbmsStorage<T> : IPersistenceImplementor<T>
    {
        public long SaveObject(T t)
        {
            // open database connection
            // create records for fields inside the object
            throw new NotImplementedException();
        }

        public void DeleteObject(long objectId)
        {
            // open database connection
            // remove record
            throw new NotImplementedException();
        }

        public T GetObject(long objectId)
        {
            // open database connection
            // read records
            // create object from record
            throw new NotImplementedException();
        }
    }
}
