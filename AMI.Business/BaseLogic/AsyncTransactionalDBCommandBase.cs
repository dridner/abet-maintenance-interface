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
            

            return result;
        }

        internal override Task<T> Execute(Data.DataConnection.IDBConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
