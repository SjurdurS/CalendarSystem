namespace eCal.SyncSubsystem
{
    public class FactoryMaker<Calendar>
    {
        private static AbstractFactory<Calendar> pf;

        private static AbstractFactory<Calendar> GetFactory(string choice)
        {
            if (choice == "teststub")
            {
                pf = new ConcreteFactoryTestStub<Calendar>();
            }
            else if (choice == "fileStorage")
            {
                pf = new ConcreteFactoryFileStorage<Calendar>();
            }
            else if (choice == "databaseStorage")
            {
                pf = new ConcreteFactoryDatabaseStorage<Calendar>();
            }

            return pf;
        }
    }
}