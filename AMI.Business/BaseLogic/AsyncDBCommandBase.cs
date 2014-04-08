using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DataConnection;

namespace AMI.Business.BaseLogic
{
    public abstract class AsyncDBCommandBase<T> : AsyncCommandBase<T>
    {
        public override async Task<T> Execute()
        {
            T obj = default(T);
            try
            {
                using (IDBConnection connection = DBConnectionFactory.CreateConnection())
                {
                    obj = await this.Execute(connection);
                }
            }
            catch (Exception)
            {
                
            }

            return obj;
        }

        internal abstract Task<T> Execute(IDBConnection conn);
    }
}
