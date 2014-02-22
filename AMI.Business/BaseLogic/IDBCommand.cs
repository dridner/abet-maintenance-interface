using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DataConnection;

namespace AMI.Business.BaseLogic
{
    public interface IDBCommand<T> : ICommand<T>
    {
        T Execute(IDBConnection connection);
    }
}
