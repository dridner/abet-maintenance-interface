using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;

namespace AMI.Data.SeedInformation
{
    public static class EECS1010Seed
    {
        public static void Seed(ABETContext context)
        {
            Class eecs1010 = new Class();
            eecs1010.IsActive = true;
            eecs1010.Name = "First Year Design";
            eecs1010.Prefix = "EECS";
            eecs1010.Number = "1010";
            eecs1010.CreatedOn = DateTime.UtcNow;
            eecs1010.LearningObjectives = new List<StudentLearningObjective>();

            StudentLearningObjective objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Identify the stages of team development and give examples of team behavior that are characteristic of each stage.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Function effectively on a team, with effectiveness being determined by instructor observation, peer ratings, and self-assessment.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Write an effective technical report for a term project.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Propose a solution or critique a proposed solution to an engineering problem, identifying possible negative global or societal consequences and recommending ways to minimize or avoid them.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Understand the professional, ethical, security and social impact and implication of an engineering problem and its solution.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Use state-of-the-art methodologies, techniques, and paradigms.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Use online resources to obtain current literature on engineering components.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Understand the purpose and availability of professional societies and their programs.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Recognize and adopt a code of professional responsibility which will govern their actions as engineers including: their professional responsibility, competency, truthfulness in public statements, and the avoidance of both conflicts of interest and improper solicitation.";
            eecs1010.LearningObjectives.Add(objective);

            objective = new StudentLearningObjective();
            objective.Class = eecs1010;
            objective.CreatedOn = DateTime.UtcNow;
            objective.IsActive = true;
            objective.Text = "Identify contemporary regional, national, or global socio-economic problems that may confront engineers during the course of their professional careers.";
            eecs1010.LearningObjectives.Add(objective);

            context.Classes.Add(eecs1010);
        }
    }
}
