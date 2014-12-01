namespace eCal.ShareSubsystem
{
    /// <summary>
    ///     Part of the adapter pattern, The entry interface
    /// </summary>
    public interface ICalendarEntry
    {
        void CreateEvent();

        void CreateCalendar();

        void EditEvent();

        void DeleteEvent();

        void ShareEvent();

        void Update();
    }
}