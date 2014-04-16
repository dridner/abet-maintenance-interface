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
    public class EECS2000Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "EECS Professional Development", "EECS", "2000");
            
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the differences between patent, copyright, and trademark protection.", new List<int>{6,10}, new List<int>{5});
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand modern issues in privacy - understand an issue and discuss as a paper.", new List<int>{10}, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Develop an appreciation of professional registration and life-long learning.", new List<int>{9}, new List<int>{8});
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Develop an effective resume.", new List<int>{7}, new List<int>{6});
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Conduct themselves professionally and effectively in a job interview.", new List<int>{7}, new List<int>{6});
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the pertinent issues in developing a business plan.", new List<int>{7}, new List<int>{6});
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn in a classroom setting both the professional behavior in a work environment as well as the IEEE or ACM professional code of ethics.", new List<int>{6}, new List<int>{5});
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Recognize and adopt a code of professional responsibility which will govern their actions as engineers including: their professional responsibility, competency, truthfulness in public statements, and the avoidance of both conflicts of interest and improper solicitation.", new List<int>{6, 10}, new List<int>{5});
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Identify contemporary regional, national, or global socio-economic problems that may confront engineers during the course of their professional careers.", new List<int> { 10 }, new List<int> { });

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "gerald.heuring", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.ViceChair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mansoor.alam", CommitteeRank.Member);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "larry.thomas", CommitteeRank.Member);
        }
    }
}
