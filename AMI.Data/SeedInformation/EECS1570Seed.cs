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
    public class EECS1570Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "Linear Data Structures", "EECS", "1570");

            List<int> eacOutcomes = new List<int> { 5, 11 };
            List<int> cacOutcomes = new List<int> { 2, 3 };

            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "When given a problem description, develop a Java solution of moderate complexity based on user-defined classes and standard library functions and classes.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "When given an algorithm, examine its properties, infer the asymptotic runtime, and express its runtime using big-O notation.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand and apply ideas to make a program more useful as regards reuse, readability, and maintenance.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the concept of classical abstract data types (ADTs) and how to express an ADT in Java.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "When given a problem description, choose an appropriate ADT and give a rationale for the choice.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand various data structures in Computer Science and how they can be applied in a variety of problems of recurring interest.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand basic concepts of algorithm analysis.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Write programs using Lists, Stacks, Queues, and Hash tables.", eacOutcomes, cacOutcomes);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "When given a collection of unordered data, understand and use various sorting algorithms.", eacOutcomes, cacOutcomes);

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "henry.ledgard", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "larry.thomas", CommitteeRank.ViceChair);
        }
    }
}
