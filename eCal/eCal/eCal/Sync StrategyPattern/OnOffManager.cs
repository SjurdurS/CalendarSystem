using eCal.Model;

namespace eCal
{
    internal class OnOffManager
    {
        private NetworkConnection netCon;
        private ISynchronizationStrategy netIntf;


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