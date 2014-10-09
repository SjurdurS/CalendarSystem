namespace CalendarApplication.AbstractFactory
{
    internal class FactoryMaker
    {
        private static AbstractFactory pf;

        private static AbstractFactory GetFactory(string choice)
        {
            if (choice == "stub")
            {
                pf = new ConcreteFactoryStub();
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