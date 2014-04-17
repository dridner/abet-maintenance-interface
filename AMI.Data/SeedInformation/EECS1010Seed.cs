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
    public class EECS1010Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "First Year Design", "EECS", "1010");

            int i = 1;
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Identify the stages of team development and give examples of team behavior that are characteristic of each stage.", new List<int>{3}, new List<int>{3}, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Function effectively on a team, with effectiveness being determined by instructor observation, peer ratings, and self-assessment.", new List<int> { 3 }, new List<int> { 3 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Write an effective technical report for a term project.", new List<int> { 7 }, new List<int> { 6 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Propose a solution or critique a proposed solution to an engineering problem, identifying possible negative global or societal consequences and recommending ways to minimize or avoid them.", new List<int> { 8 }, new List<int> { 5, 7 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the professional, ethical, security and social impact and implication of an engineering problem and its solution.", new List<int> { 8 }, new List<int> { 7 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Use state-of-the-art methodologies, techniques, and paradigms.", new List<int> { 10 }, new List<int>(), i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Use online resources to obtain current literature on engineering components.", new List<int> { 9 }, new List<int> { 8 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the purpose and availability of professional societies and their programs.", new List<int> { 9 }, new List<int> { 8 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Recognize and adopt a code of professional responsibility which will govern their actions as engineers including: their professional responsibility, competency, truthfulness in public statements, and the avoidance of both conflicts of interest and improper solicitation.",
                new List<int> { 6, 10 }, new List<int> { 5 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Identify contemporary regional, national, or global socio-economic problems that may confront engineers during the course of their professional careers.",
                new List<int> { 10 }, new List<int>(), i++);

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "weng.kang", CommitteeRank.ViceChair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "jackson.carvalho", CommitteeRank.Member);
        }
    }
}
