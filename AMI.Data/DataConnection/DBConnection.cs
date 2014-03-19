using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AMI.Data.DataConnection
{
    public class DBConnection : IDBConnection
    {
        private IABETContext _abetContext;
        private IdentityDbContext<User> _securityContext;
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
                    _abetContext = new ABETContext(this._connectionString);
                }
                return _abetContext;
            }
            internal set
            {
                _abetContext = value;
            }
        }

        public IdentityDbContext<User> SecurityContext 
        {
            get
            {
                if (_securityContext == null)
                {
                    _securityContext = new IdentityDbContext<User>(this._connectionString);
                }
                return _securityContext;
            }
            internal set
            {
                _securityContext = value;
            }
        }

        public void SaveAllChanges()
        {
            if (this._abetContext != null)
            {
                this._abetContext.SaveChanges();
            }
        }
    }
}
