using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;

namespace AMI.Data.DataConnection
{
    public class DBConnection : IDBConnection
    {
        private IABETContext _abetContext;
        private ISecurityContext _securityContext;
        private readonly string _connectionString;

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IABETContext ABETContext
        {
            get
            {
                if (_abetContext == null)
                {
                    _abetContext = new ABETContext();
                }
                return _abetContext;
            }
            internal set
            {
                _abetContext = value;
            }
        }

        public ISecurityContext SecurityContext 
        {
            get
            {
                if (_securityContext == null)
                {
                    _securityContext = new SecurityContext();
                }
                return _securityContext;
            }
            internal set
            {
                _securityContext = value;
            }
        }
    }
}
