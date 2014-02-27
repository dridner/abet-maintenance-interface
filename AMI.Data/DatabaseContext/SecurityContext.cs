using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Data.DatabaseContext
{
    public class SecurityContext : BaseContext<SecurityContext>, ISecurityContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SecurityContext>(new CreateDatabaseIfNotExists<SecurityContext>());
        }
    }
}
