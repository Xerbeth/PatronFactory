using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory fabrica = new ConnectionFactory();

            IConnection cx1 = fabrica.GetConnection("ORACLE");
            cx1.Connection();
            cx1.Disconnection();

            IConnection cx2 = fabrica.GetConnection("MySQL");
            cx2.Connection();
            cx2.Disconnection();

            Console.ReadKey();
            
        }
    }
}
