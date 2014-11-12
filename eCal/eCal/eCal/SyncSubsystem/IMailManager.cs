using eCal.CalendarManagement.Model;

namespace eCal.SyncSubsystem
{
    /// <summary>
    ///     This class is used to send mails.
    /// </summary>
    internal interface IMailManager
    {
        /// <summary>
        ///     Send an email.
        /// </summary>
        /// <param name="mail">The mail to send.</param>
        void Send(Mail mail);
    }
}