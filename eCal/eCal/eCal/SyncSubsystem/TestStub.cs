using System;

namespace eCal.SyncSubsystem
{
    internal class TestStub : IPersistenceImplementor
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
    }
}