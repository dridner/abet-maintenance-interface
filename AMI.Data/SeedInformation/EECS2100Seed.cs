using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;
using AMI.Model.Util;
using Microsoft.AspNet.Identity;

namespace AMI.Data.SeedInformation
{
    public class EECS2100Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "Computer Organization and Assembly Programming", "EECS", "2100");
                
            var eac = new List<int>{1,5};
            var cac = new List<int>{1,3};

            int i = 1;
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Program a simple machine using microcode to implement specific instructions.", eac, cac, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Write programs using assembly language demonstrating an ability to use subprogram linkage, basic processor functions, and control structures.", eac, cac, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand modern computer architecture enhancements and be able to compare and contrast processors.", eac, cac, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the memory hierarchy and its importance and impact on processor performance.", eac, cac, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Know and discuss the major features of RISC and CISC architectures.", eac, cac, i++);

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "gerald.heuring", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "brent.nowlin", CommitteeRank.ViceChair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "devinder.kaur", CommitteeRank.Member);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mohsin.jamali", CommitteeRank.Member);
        }
    }
}
