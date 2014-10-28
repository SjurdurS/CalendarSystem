namespace eCal.SyncSubsystem
{
    internal class ConcreteFactoryTestStub : AbstractFactory
    {
        public override IPersistenceImplementor<T> CreateAbstractTestStub()
        {
            return new TestStub();
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