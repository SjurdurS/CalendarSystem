namespace eCal.SyncSubsystem
{
    public class FactoryMaker
    {
        /// <summary>
        /// Takes an 
        /// </summary>
        private IPersistenceImplementor storage;

        private static AbstractFactory pf;

        private static AbstractFactory GetFactory(string choice)
        {
            if (choice == "teststub")
            {
                pf = new ConcreteFactoryTestStub();
            }
            else if (choice == "fileStorage")
            {
                pf = new ConcreteFactoryFileStorage();
            }
            else if (choice == "databaseStorage")
            {
                pf = new ConcreteFactoryDatabaseStorage();
            }

            return pf;
        }
    }
}