namespace eCal.CalendarManagement
{
    /// <summary>
    /// The 'Command abstract class
    /// </summary>
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
