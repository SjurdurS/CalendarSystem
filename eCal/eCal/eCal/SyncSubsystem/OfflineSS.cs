using System;

namespace eCal.SyncSubsystem
{
    /// <summary>
    ///     Offline Storage Strategy
    /// </summary>
    internal class OfflineSS : ISynchronizationStrategy
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