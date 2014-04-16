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
    public class EECS1530Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "Introduction to Programming", "EECS", "1530");
            
            var eacOutcomes = new List<int>{ 11 };
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Implement an elementary algorithm by writing a program in the C++ language.", eacOutcomes, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the concept of a variable and the assignment operator.", eacOutcomes, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand simple data types.", eacOutcomes, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand the array data structure.", eacOutcomes, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Ability to write programmer-defined functions.", eacOutcomes, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Ability to program using branching statements.", eacOutcomes, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Ability to program using looping statements.", eacOutcomes, new List<int>());
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Implement a program illustrating the fundamental concepts of the object-oriented paradigm.", eacOutcomes, new List<int>());
                
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "ezzatollah.salari", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.ViceChair);
        }
    }
}
