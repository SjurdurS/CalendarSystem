namespace eCal.AbstractFactory
{
    public abstract class AbstractFactory<T>
    {
        public abstract IPersistenceImplementor<T> CreateAbstractTestStub();
        public abstract IPersistenceImplementor<T> CreateAbstractFileStorage();
        public abstract IPersistenceImplementor<T> CreateAbstractDatabaseStorage();
    }
}