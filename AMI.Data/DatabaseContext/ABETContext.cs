using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Data.DatabaseContext
{
    public class ABETContext : BaseContext<ABETContext>, IABETContext
    {
        internal ABETContext(string connectionString)
            :base(connectionString)
        {

        }

        public IDbSet<Model.ClassEntity> Classes { get; set; }
        public IDbSet<Model.Outcome> Outcomes { get; set; }
        public IDbSet<Model.StudentLearningObjective> StudentLearningObjectives { get; set; }
        public IDbSet<Model.CommitteeMember> CommitteeMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ABETContext>(new CreateDatabaseIfNotExists<ABETContext>());
        }
    }
}
