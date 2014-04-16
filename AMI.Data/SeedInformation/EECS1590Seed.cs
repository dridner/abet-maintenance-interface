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
    public class EECS1590Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "Discrete Structures", "EECS", "1590");

            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Develop a vocabulary for and appreciation for mathematical rigor in Computer Science.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn and apply Mathematical Induction to a range of problems.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn fundamental notations for sets, functions, sequences, and summations.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn and apply Number Theory to solve problems in Computer Science.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Develop the mathematical underpinnings required for computer security.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn the elementary principles of Combinatorics.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Solve a limited class of recurrence relations.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Ability to define and construct graphs and trees.", new List<int> { 1 }, new List<int> { 1 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Motivate the relevance of sound mathematics to software development.", new List<int> { 1 }, new List<int> { 1 });

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "henry.ledgard", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "larry.thomas", CommitteeRank.ViceChair);
        }
    }
}
