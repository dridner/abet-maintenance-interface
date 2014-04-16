using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DataConnection;


namespace AMI.Business.Logic
{
    interface IAsyncDBCommand<T> : IAsyncCommand<T>
    {
        Task<T> Execute(IDBConnection connection);
    }
}
