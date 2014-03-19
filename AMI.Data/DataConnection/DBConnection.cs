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
        private bool _disposed;

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
            if (this._securityContext != null)
            {
                this._securityContext.SaveChanges();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    if (_securityContext != null)
                    {
                        _securityContext.Dispose();
                    }
                    if (_abetContext != null)
                    {
                        _abetContext.Dispose();
                    }
                }
            }
            this._disposed = true;
        }
    }
}
