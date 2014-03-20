using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace AMI.Data.DataConnection
{
    public class DBConnection : IDBConnection
    {
        private ABETContext _abetContext;
        private UserManager<User> _userManager;
        private readonly string _connectionString;
        private bool _disposed;

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ABETContext ABETContext
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

        public UserManager<User> UserManager
        {
            get
            {
                if (_userManager == null)
                {
                    _userManager = new UserManager<User>(new UserStore<User>(new IdentityDbContext<User>(this._connectionString)));
                }
                return _userManager;
            }
            internal set
            {
                _userManager = value;
            }
        }

        public void SaveAllChanges()
        {
            if (this._abetContext != null)
            {
                this._abetContext.SaveChanges();
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
                    if (_userManager != null)
                    {
                        _userManager.Dispose();
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
