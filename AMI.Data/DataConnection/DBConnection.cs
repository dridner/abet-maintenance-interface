using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Data;
using System.Data.Entity;

namespace AMI.Data.DataConnection
{
    public class DBConnection : IDBConnection
    {
        private DbContextTransaction _currentTransaction;
        private ABETContext _abetContext;
        private UserManager<ApplicationUser> _userManager;
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

        public UserManager<ApplicationUser> UserManager
        {
            get
            {
                if (_userManager == null)
                {
                    _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityDbContext<ApplicationUser>(this._connectionString)));
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
                    if (this._currentTransaction != null)
                    {
                        this._currentTransaction.Commit();
                    }
                    if (this._userManager != null)
                    {
                        this._userManager.Dispose();
                    }
                    if (this._abetContext != null)
                    {
                        this._abetContext.Dispose();
                    }
                }
            }
            this._disposed = true;
        }


        public void BeginTransaction()
        {
            this._currentTransaction = this.ABETContext.Database.BeginTransaction(IsolationLevel.Serializable);
        }

        public bool IsTransactionInProgress()
        {
            return this._currentTransaction != null;
        }

        public void Commit()
        {
            if (this._currentTransaction != null)
            {
                this._currentTransaction.Commit();
                this._currentTransaction = null;
            }
        }

        public void Rollback()
        {
            if (this._currentTransaction != null)
            {
                this._currentTransaction.Commit();
                this._currentTransaction = null;
            }
        }
    }
}
