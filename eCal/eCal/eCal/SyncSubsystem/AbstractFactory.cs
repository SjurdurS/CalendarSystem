namespace eCal.SyncSubsystem
{
    public abstract class AbstractFactory
    {
        public abstract IPersistenceImplementor CreateAbstractTestStub();
        public abstract IPersistenceImplementor CreateAbstractFileStorage();
        public abstract IPersistenceImplementor CreateAbstractDatabaseStorage();
    }
}