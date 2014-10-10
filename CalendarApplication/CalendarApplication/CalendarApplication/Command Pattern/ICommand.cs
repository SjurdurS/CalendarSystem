using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApplication.Command_Pattern
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
