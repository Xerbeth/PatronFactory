using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public interface IConnection
    {
        void Connection();

        void Disconnection();
    }
}
