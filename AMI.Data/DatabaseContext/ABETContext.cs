using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.SeedInformation;
using AMI.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AMI.Data.DatabaseContext
{
    public class ABETContext : DbContext
    {
        public ABETContext()
        {

        }

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

        public DbSet<Criteria> Criterias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(l => l.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            modelBuilder.Entity<Outcome>().HasKey(o => new { o.Id, o.CriteriaId });
            Database.SetInitializer<ABETContext>(new CreateABETDatabaseIfNotExists());
        }

        private class CreateABETDatabaseIfNotExists : CreateDatabaseIfNotExists<ABETContext>
        {
            protected override void Seed(ABETContext context)
            {
                CriteriaSeed.Seed(context);
                EECS1010Seed.Seed(context);
            }
        }
    }
}
