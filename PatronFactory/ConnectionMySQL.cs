using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class ConnectionMySQL : IConnection
    {
        public void Connection()
        {
            Console.WriteLine("Conexión con MySQL");
        }

        public void Disconnection()
        {
            Console.WriteLine("Desconexión de MySQL");
        }
    }
}
