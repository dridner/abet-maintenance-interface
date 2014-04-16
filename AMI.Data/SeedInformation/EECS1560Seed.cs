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
    public class EECS1560Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "Introduction to Object-Oriented Programming", "EECS", "1560");

            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Use Eclipse as an IDE.", new List<int> { 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Take a problem and develop the structures to represent objects and the algorithms to perform operations. (major)", new List<int> { 5, 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Apply standards and principles to write truly readable code.", new List<int> { 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Test a program and, if necessary, find mistakes in the program and correct them.", new List<int> { 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn the fundamentals of input and output using the java.io library.", new List<int> { 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Design a class that serves as a program module or package.", new List<int> { 5, 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Understand and demonstrate the concepts of object-oriented design, polymorphism, information hiding, and inheritance.", new List<int> { 5, 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Develop applications using simple graphical user interfaces.", new List<int> { 5, 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Become familiar with some of the common classes available in the Java language.", new List<int> { 11 }, new List<int> { 9 });

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "henry.ledgard", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "larry.thomas", CommitteeRank.ViceChair);
        }
    }
}
