namespace eCal.SyncSubsystem
{
    internal class ConcreteFactoryFileStorage : AbstractFactory
    {
        public override IPersistenceImplementor CreateAbstractTestStub()
        {
            return new TestStub();
        }

        public override IPersistenceImplementor CreateAbstractFileStorage()
        {
            return new FileStorage();
        }

        public override IPersistenceImplementor CreateAbstractDatabaseStorage()
        {
            return new RdbmsStorage();
        }
    }
}