namespace CalendarApplication.AbstractFactory
{
    internal abstract class AbstractFactory
    {
        public abstract IPersistenceImplementor<T> CreateAbstractTestStub();
        public abstract IPersistenceImplementor<T> CreateAbstractFileStorage();
        public abstract IPersistenceImplementor<T> CreateAbstractDatabaseStorage();
    }
}