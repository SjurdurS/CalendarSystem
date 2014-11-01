using System;

namespace eCal.SyncSubsystem
{
    internal class TestStub<T> : IPersistenceImplementor<T>
    {
        public long SaveObject(T t)
        {
            throw new NotImplementedException();
        }

        public void DeleteObject(long objectId)
        {
            throw new NotImplementedException();
        }

        public T GetObject(long objectId)
        {
            throw new NotImplementedException();
        }
    }
}