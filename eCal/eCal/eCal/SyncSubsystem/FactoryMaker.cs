namespace eCal.SyncSubsystem
{
    public class FactoryMaker<T>
    {
        private static AbstractFactory<T> pf;

        private static AbstractFactory<T> GetFactory(string choice)
        {
            if (choice == "teststub")
            {
                pf = new ConcreteFactoryTestStub<T>();
            }
            else if (choice == "fileStorage")
            {
                pf = new ConcreteFactoryFileStorage<T>();
            }
            else if (choice == "databaseStorage")
            {
                pf = new ConcreteFactoryDatabaseStorage<T>();
            }

            return pf;
        }
    }
}