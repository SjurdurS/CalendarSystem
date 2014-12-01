using System;

namespace eCal.SyncSubsystem
{
    /// <summary>
    ///     Online Storage Strategy
    /// </summary>
    internal class OnlineSS : ISynchronizationStrategy
    {
        /// <summary>
        /// Information about if the synchronization should be online or offline(local)
        /// </summary>
        public void SynchronizeConnection()
        {
            throw new NotImplementedException();
        }
    }
}