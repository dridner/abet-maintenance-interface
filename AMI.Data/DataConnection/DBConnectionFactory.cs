using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Data.DataConnection
{
    public class DBConnectionFactory
    {
        public static IDBConnection CreateConnection()
        {
            string connectionStringKey = null;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                connectionStringKey = "Local";
            }
            else
            {
                connectionStringKey = "Production";
            }

            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;

            return new DBConnection(connectionString);
        }
    }
}
