using System;

namespace AMI.Data.DataConnection
{
    public interface IDBConnectionFactory
    {
        IDBConnection CreateConnection();
    }
}
