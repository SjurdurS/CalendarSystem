using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace eCal.CalendarManagement
{
    /// <summary>
    /// The 'Command abstract class
    /// </summary>
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
