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
    public class EECS1580Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "Non-Linear Data Structures", "EECS", "1580");

            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Use Microsoft’s Visual Studio as an IDE.", new List<int> { 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn how to construct and apply a binary (and n-ary) tree to the storage, organization, and lookup of data using C++.", new List<int> { 5, 11 }, new List<int> { 1, 3, 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn how to implement special cases of binary trees, such as heaps, priority queues, and height-balanced trees, to solve problems.", new List<int> { 5, 11 }, new List<int> { 1, 3, 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn how to apply advanced sorting methods to data (Quicksort, Heapsort, Mergesort, and Radix Sort).", new List<int> { 11 }, new List<int> { 1, 3, 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn the fundamentals of input and output using streams in C++.", new List<int> { 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn how to use pointers in C++ effectively.", new List<int> { 11 }, new List<int> { 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn how to solve a limited class of recurrence relations.", new List<int> { 1, 11 }, new List<int> { 1, 9 });
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Learn how to apply graphs and their related algorithms to solve practical problems.", new List<int> { 5, 11 }, new List<int> { 1, 3, 9 });

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "larry.thomas", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "henry.ledgard", CommitteeRank.ViceChair);
        }
    }
}
