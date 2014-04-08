using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DataConnection;

namespace AMI.Business.BaseLogic
{
    public abstract class AsyncTransactionalDBCommandBase<T> : AsyncDBCommandBase<T>
    {
        protected bool ForcedRollback { get; set; }

        public override async Task<T> Execute()
        {
            T result = default(T);

            using (IDBConnection connection = this._connectionFactory.CreateConnection())
            {
                try
                {
                    connection.BeginTransaction();

                    result = await this.ExecuteTransaction(connection);

                    if (this.ForcedRollback)
                    {
                        connection.Rollback();
                    }
                    else
                    {
                        connection.Commit();
                    }
                }
                catch (Exception)
                {
                    connection.Rollback();
                    throw;
                }
            }

            return result;
        }

        internal override async Task<T> Execute(IDBConnection conn)
        {
            T result = default(T);

            if (!conn.IsTransactionInProgress())
            {
                try
                {
                    conn.BeginTransaction();

                    result = await this.ExecuteTransaction(conn);

                    if(this.ForcedRollback)
                    {
                        conn.Rollback();
                    }
                    else
                    {
                        conn.Commit();
                    }
                }
                catch (Exception)
                {
                    conn.Rollback();
                    throw;
                }
            }
            else
            {
                result = await this.ExecuteTransaction(conn);
            }

            return result;
        }

        protected abstract Task<T> ExecuteTransaction(IDBConnection conn);
    }
}
