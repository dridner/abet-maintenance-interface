using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Data.DataConnection
{
    public class DBConnectionFactory : IDBConnectionFactory
    {
        private static DBConnectionFactory _instance;
        private static object _lockObject = new object();

        private DBConnectionFactory()
        {

        }

        public static DBConnectionFactory GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new DBConnectionFactory();
                    }
                }
            }

            return _instance;
        }

        public IDBConnection CreateConnection()
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
