namespace eCal.SyncSubsystem
{
    public interface IPersistenceImplementor<T>
    {
        long SaveObject(T t);

        void DeleteObject(long objectId);

        T GetObject(long objectId);
    }
}