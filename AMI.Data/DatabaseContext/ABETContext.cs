﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Data.DatabaseContext
{
    public class ABETContext : BaseContext<ABETContext>, IABETContext
    {
        protected ABETContext(string connectionString)
            :base(connectionString)
        {

        }

        public IDbSet<Model.Class> Classes { get; set; }
        public IDbSet<Model.Outcome> Outcomes { get; set; }
        public IDbSet<Model.StudentLearningObjective> StudentLearningObjectives { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ABETContext>(new CreateDatabaseIfNotExists<ABETContext>());
        }
    }
}
