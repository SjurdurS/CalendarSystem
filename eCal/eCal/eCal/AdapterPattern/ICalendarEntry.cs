namespace eCal.AdapterPattern
{
    /// <summary>
    ///     Part of the adapter pattern, The entry interface
    /// </summary>
    internal interface ICalendarEntry
    {
        void CreateEvent();

        void CreateCalendar();

        void EditEvent();

        void DeleteEvent();

        void ShareEvent();

        void Update();
    }
}