using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;

namespace AMI.Data.DatabaseContext
{
    public class ABETContext : BaseContext<ABETContext>, IABETContext
    {
        internal ABETContext(string connectionString)
            :base(connectionString)
        {

        }

        public IDbSet<Class> Classes { get; set; }
        public IDbSet<Outcome> Outcomes { get; set; }
        public IDbSet<StudentLearningObjective> StudentLearningObjectives { get; set; }
        public IDbSet<CommitteeMember> CommitteeMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ABETContext>(new CreateDatabaseIfNotExists<ABETContext>());
        }
    }
}
