using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DataConnection;

namespace AMI.Business.Logic
{
    public abstract class AsyncDBCommandBase<T> : AsyncCommandBase<T>
    {
        protected IDBConnectionFactory _connectionFactory = DBConnectionFactory.GetInstance();

        public override async Task<T> Execute()
        {
            T obj = default(T);

            using (IDBConnection connection = this._connectionFactory.CreateConnection())
            {
                obj = await this.Execute(connection);
            }

            return obj;
        }

        internal abstract Task<T> Execute(IDBConnection conn);
    }
}
