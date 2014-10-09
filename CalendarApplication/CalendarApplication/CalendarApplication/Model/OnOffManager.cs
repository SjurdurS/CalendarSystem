using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Model
{
    class OnOffManager
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
