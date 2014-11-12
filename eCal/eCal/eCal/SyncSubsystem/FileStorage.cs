using System;

namespace eCal.SyncSubsystem
{
    public class FileStorage : IPersistenceImplementor
    {
        public long SaveObject(Object obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteObject(long objectId)
        {
            throw new NotImplementedException();
        }

        public Object GetObject(long objectId)
        {
            throw new NotImplementedException();
        }

        private Object ReadObjectFromFile(Object obj)
        {
            throw new NotImplementedException();
        }

        private void WriteObjectToFile(Object obj)
        {
            throw new NotImplementedException();
        }
    }
}