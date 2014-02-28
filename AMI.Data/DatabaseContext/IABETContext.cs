using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AMI.Model;

namespace AMI.Data.DatabaseContext
{
    public interface IABETContext
    {
        IDbSet<Class> Classes { get; set; }
        IDbSet<Outcome> Outcomes { get; set; }
        IDbSet<StudentLearningObjective> StudentLearningObjectives { get; set; }
        IDbSet<CommitteeMember> CommitteeMembers { get; set; }
    }
}
