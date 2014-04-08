using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model;

namespace AMI.Data.DatabaseContext
{
    public class ABETContext : BaseContext<ABETContext>
    {
        internal ABETContext(string connectionString)
            :base(connectionString)
        {

        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassHistory> ClassHistory { get; set; }

        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<OutcomeHistory> OutcomeHistory { get; set; }

        public DbSet<StudentLearningObjective> StudentLearningObjectives { get; set; }
        public DbSet<StudentLearningObjectiveHistory> StudentLearningObjectiveHistory { get; set; }

        public DbSet<CommitteeMember> CommitteeMembers { get; set; }
        public DbSet<CommitteeMemberHistory> CommitteeMemberHistory { get; set; }

        public DbSet<Program> Programs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ABETContext>(new CreateDatabaseIfNotExists<ABETContext>());
        }
    }
}
