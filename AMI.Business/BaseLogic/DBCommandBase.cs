using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DataConnection;

namespace AMI.Business.BaseLogic
{
    public abstract class DBCommandBase<T> : IDBCommand<T>, ICommand<T>
    {
        public T Execute()
        {
            T obj = default(T);
            try
            {
                using (IDBConnection connection = DBConnectionFactory.CreateConnection())
                {
                    obj = this.Execute(connection);
                }
            }
            catch (Exception)
            {
                
            }

            return obj;
        }

        public abstract T Execute(IDBConnection conn);
    }
}
