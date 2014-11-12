using System;

namespace eCal.SyncSubsystem
{
    public interface IPersistenceImplementor
    {
        long SaveObject(Object t);

        void DeleteObject(long objectId);

        Object GetObject(long objectId);
    }
}