using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Data.DatabaseContext
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext(string connectionString)
            : base(connectionString)
        {

        }
    }
}
