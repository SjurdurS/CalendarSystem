namespace eCal.CalendarManagement
{
    /// <summary>
    ///     The 'Command abstract class
    /// </summary>
    internal interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}