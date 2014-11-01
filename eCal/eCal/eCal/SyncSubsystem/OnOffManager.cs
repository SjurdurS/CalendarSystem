namespace eCal.SyncSubsystem
{
    internal class OnOffManager
    {
        private NetworkConnection netCon;
        private ISynchronizationStrategy netIntf;


        public bool Online { get; set; }

        public void ConnectionStatus()
        {
            if (Online)
            {
                netIntf = new OnlineSS();
            }
            else //Offline
            {
                netIntf = new OfflineSS();
            }
        }
    }
}