namespace CalendarApplication.AbstractFactory
{
    internal class ConcreteFactoryDatabaseStorage : AbstractFactory
    {
        public override IPersistenceImplementor<T> CreateAbstractStub()
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