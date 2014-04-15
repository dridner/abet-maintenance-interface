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
    public static class ClassSeed
    {
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount, UserManager<ApplicationUser> userManager)
        {
            var newClass = CreateClass(context, systemUserAccount, "First Year Design", "EECS", "1010", 
                "Identify the stages of team development and give examples of team behavior that are characteristic of each stage.",
                "Function effectively on a team, with effectiveness being determined by instructor observation, peer ratings, and self-assessment.",
                "Write an effective technical report for a term project.",
                "Propose a solution or critique a proposed solution to an engineering problem, identifying possible negative global or societal consequences and recommending ways to minimize or avoid them.",
                "Understand the professional, ethical, security and social impact and implication of an engineering problem and its solution.",
                "Use state-of-the-art methodologies, techniques, and paradigms.",
                "Use online resources to obtain current literature on engineering components.",
                "Understand the purpose and availability of professional societies and their programs.",
                "Recognize and adopt a code of professional responsibility which will govern their actions as engineers including: their professional responsibility, competency, truthfulness in public statements, and the avoidance of both conflicts of interest and improper solicitation.",
                "Identify contemporary regional, national, or global socio-economic problems that may confront engineers during the course of their professional careers.");

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "weng.kang", CommitteeRank.ViceChair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "jackson.carvalho", CommitteeRank.Member);

            newClass = CreateClass(context, systemUserAccount, "Digital Logic Design", "EECS", "1100", "Conduct an experiment to learn the logic design and prototyping process in order to acquire requisite hands-on skills and report the results through a well-defined and formatted written document",
                "Document the data acquired from an experiment, compare to the expected theoretical values and discuss any differences.",
                "Design a digital module with combinational and sequential logic components to be able to address any problem in the applicable domain and report the results in a typical engineering design document.",
                "Build a prototype of a digital logic circuit and demonstrate that it meets performance specifications, which are limited to functional correctness and resource minimization; i.e., minimal product-of-sums or sum-of-products only for combinational design.",
                "Design an experiment to validate through empirical means one of the following: a hypothesis, a Boolean logic law or identity, dependency among variables, etc. Students will also be able to conduct the designed experiment, measure quantities of interest, collect and compile data, interpret the results and make engineering inferences.",
                "Write an effective technical report for lab experiments.",
                "Use state-of-the-art combinational and sequential logic design methodologies, techniques, and paradigms.",
                "Use tools including a scope and a logic analyzer to prototype, debug and test a combinational and sequential logic circuit at the gate level utilizing the MSI/LSI technology.",
                "Use online resources to obtain current literature on engineering components.");

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mohsin.jamali", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.ViceChair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "brent.nowlin", CommitteeRank.Member);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "devinder.kaur", CommitteeRank.Member);

            newClass = CreateClass(context, systemUserAccount, "Introduction to Programming", "EECS", "1530", "Implement an elementary algorithm by writing a program in the C++ language.",
                "Understand the concept of a variable and the assignment operator.",
                "Understand simple data types.",
                "Understand the array data structure.",
                "Ability to write programmer-defined functions.",
                "Ability to program using branching statements.",
                "Ability to program using looping statements.",
                "Implement a program illustrating the fundamental concepts of the object-oriented paradigm.");

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "ezzatollah.salari", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.ViceChair);
            newClass = CreateClass(context, systemUserAccount, "EECS Professional Development", "EECS", "2000", "1. Understand the differences between patent, copyright, and trademark protection.",
                "Understand modern issues in privacy - understand an issue and discuss as a paper.",
                "Develop an appreciation of professional registration and life-long learning.",
                "Develop an effective resume.",
                "Conduct themselves professionally and effectively in a job interview.",
                "Understand the pertinent issues in developing a business plan.",
                "Learn in a classroom setting both the professional behavior in a work environment as well as the IEEE or ACM professional code of ethics.",
                "Recognize and adopt a code of professional responsibility which will govern their actions as engineers including: their professional responsibility, competency, truthfulness in public statements, and the avoidance of both conflicts of interest and improper solicitation.",
                "Identify contemporary regional, national, or global socio-economic problems that may confront engineers during the course of their professional careers.");

            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "gerald.heuring", CommitteeRank.Chair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "richard.molyet", CommitteeRank.ViceChair);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "mansoor.alam", CommitteeRank.Member);
            CreateCommitteeMemberForClass(context, newClass, systemUserAccount, userManager, "larry.thomas", CommitteeRank.Member);
        }

        private static void CreateCommitteeMemberForClass(ABETContext context, Class newClass, ApplicationUser systemUser, UserManager<ApplicationUser> userManager, string username, CommitteeRank rank)
        {
            ApplicationUser committeeUser = userManager.FindByName(username);

            CommitteeMember member = new CommitteeMember();
            member.Class = newClass; 
            member.User = committeeUser;
            member.CommitteeRank = rank;
            member.IsActive = true;
            member.CreatedOn = DateTime.UtcNow;
            member.CreatedByUser = systemUser;

            newClass.CommitteeMembers.Add(member);
        }

        private static Class CreateClass(ABETContext context, ApplicationUser systemUser, string className, string classPrefix, string classNumber, params string[] learningObjectives)
        {
            Class newClass = new Class();
            newClass.IsActive = true;
            newClass.Name = className;
            newClass.Prefix = classPrefix;
            newClass.Number = classNumber;
            newClass.CreatedOn = DateTime.UtcNow;
            newClass.CreatedByUser = systemUser;
            newClass.LearningObjectives = new List<StudentLearningObjective>();

            foreach (string text in learningObjectives)
            {
                StudentLearningObjective objective = new StudentLearningObjective();
                objective.Class = newClass;
                objective.CreatedOn = DateTime.UtcNow;
                objective.CreatedByUser = systemUser;
                objective.IsActive = true;
                objective.Text = text;
                newClass.LearningObjectives.Add(objective);
            }

            newClass.CommitteeMembers = new List<CommitteeMember>();

            context.Classes.Add(newClass);

            return newClass;
        }
    }
}
