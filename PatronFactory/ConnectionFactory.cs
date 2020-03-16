using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class ConnectionFactory
    {
        enum DataBases
        {
            ORACLE,
            MySQL,
            PostgreSQL,
            SqlServer,
            H2
        }
        public IConnection GetConnection(string connection) 
        {
            if (connection.Equals(DataBases.ORACLE.ToString()))
            { 
                ConnetionOracle connectionOracle = new ConnetionOracle();
                return connectionOracle;
            }
            else if (connection.Equals(DataBases.MySQL.ToString()))
            {
                ConnectionMySQL connectionMySQL = new ConnectionMySQL();
                return connectionMySQL;
            }
            else {
                return null;            
            }
          
        }
    }
}
