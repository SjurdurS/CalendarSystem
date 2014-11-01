namespace eCal.SyncSubsystem
{
    internal class ConcreteFactoryDatabaseStorage<T> : AbstractFactory<T>
    {
        public override IPersistenceImplementor<T> CreateAbstractTestStub()
        {
            return new TestStub<T>();
        }

        public override IPersistenceImplementor<T> CreateAbstractFileStorage()
        {
            return new FileStorage<T>();
        }

        public override IPersistenceImplementor<T> CreateAbstractDatabaseStorage()
        {
            return new RdbmsStorage<T>();
        }
    }
}