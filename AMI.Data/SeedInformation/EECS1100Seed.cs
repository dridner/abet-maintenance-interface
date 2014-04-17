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
    public class EECS1100Seed : ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "Digital Logic Design", "EECS", "1100");

            int i = 1;
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Conduct an experiment to learn the logic design and prototyping process in order to acquire requisite hands-on skills and report the results through a well-defined and formatted written document", new List<int> { 2 }, new List<int> { 2 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Document the data acquired from an experiment, compare to the expected theoretical values and discuss any differences.", new List<int> { 2 }, new List<int> { 6 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Design a digital module with combinational and sequential logic components to be able to address any problem in the applicable domain and report the results in a typical engineering design document.", new List<int> { 3 }, new List<int> { 3 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Build a prototype of a digital logic circuit and demonstrate that it meets performance specifications, which are limited to functional correctness and resource minimization; i.e., minimal product-of-sums or sum-of-products only for combinational design.", new List<int> { 3 }, new List<int> { 3 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Design an experiment to validate through empirical means one of the following: a hypothesis, a Boolean logic law or identity, dependency among variables, etc. Students will also be able to conduct the designed experiment, measure quantities of interest, collect and compile data, interpret the results and make engineering inferences.", new List<int> { 2 }, new List<int> { 3 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Write an effective technical report for lab experiments.", new List<int> { 7 }, new List<int> { 6 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Use state-of-the-art combinational and sequential logic design methodologies, techniques, and paradigms.", new List<int> { 11 }, new List<int> { 2 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Use tools including a scope and a logic analyzer to prototype, debug and test a combinational and sequential logic circuit at the gate level utilizing the MSI/LSI technology.", new List<int> { 11 }, new List<int> { 9 }, i++);
            CreateSLOForClassWithOutcome(context, newClass, systemUserAccount, "Use online resources to obtain current literature on engineering components.", new List<int> { 11 }, new List<int> { 9 }, i++);

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mohsin.jamali", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.ViceChair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "brent.nowlin", CommitteeRank.Member);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "devinder.kaur", CommitteeRank.Member);
        }
    }
}
