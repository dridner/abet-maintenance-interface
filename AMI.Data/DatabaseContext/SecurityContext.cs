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
        protected SecurityContext(string connectionString)
            :base(connectionString)
        {

        }
        
        public IDbSet<Model.User> Users { get; set; }
        public IDbSet<Model.Role> Roles { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SecurityContext>(new CreateDatabaseIfNotExists<SecurityContext>());
        }
    }
}
