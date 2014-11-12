using System;

namespace eCal.SyncSubsystem
{
    internal class RdbmsStorage : IPersistenceImplementor
    {
        public long SaveObject(Object obj)
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

        public Object GetObject(long objectId)
        {
            // open database connection
            // read records
            // create object from record
            throw new NotImplementedException();
        }
    }
}