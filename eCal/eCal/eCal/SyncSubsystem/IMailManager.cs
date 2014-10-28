namespace eCal.SyncSubsystem
{
    /// <summary>
    /// This class is used to send mails.
    /// </summary>
    interface IMailManager<T>
    {

        /// <summary>
        /// Send an email.
        /// </summary>
        /// <param name="mail">The mail to send.</param>
        void Send(T mail);
    }
}
