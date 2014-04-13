using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Data.DatabaseContext;
using AMI.Model;

namespace AMI.Data.SeedInformation
{
    public static class CriteriaSeed
    {
        public static void Seed(ABETContext context)
        {
            Criteria criteria = new Criteria();
            criteria.Name = "EAC";
            criteria.Outcomes = new List<Outcome>();

            Outcome outcome = new Outcome();
            outcome.Id = 1;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to apply knowledge of mathematics, science, and engineering.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 2;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to design and conduct experiments, as well as to analyze and interpret data.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 3;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to design a system, component, or process to meet desired needs within realistic constraints such as economic, environmental, social, political, ethical, health and safety, manufacturability, and sustainability.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 4;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to function on multidisciplinary teams.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 5;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to identify, formulate, and solve engineering problems.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 6;
            outcome.Criteria = criteria;
            outcome.Text = "An understanding of professional and ethical responsibility.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 7;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to communicate effectively.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 8;
            outcome.Criteria = criteria;
            outcome.Text = "The broad education necessary to understand the impact of engineering solutions in a global, economic, environmental, and societal context.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 9;
            outcome.Criteria = criteria;
            outcome.Text = "A recognition of the need for, and an ability to engage in life-long learning.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 10;
            outcome.Criteria = criteria;
            outcome.Text = "A knowledge of contemporary issues.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 11;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to use the techniques, skills, and modern engineering tools necessary for engineering practice.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            context.Criterias.Add(criteria);

            criteria = new Criteria();
            criteria.Name = "CAC";
            criteria.Outcomes = new List<Outcome>();

            outcome = new Outcome();
            outcome.Id = 1;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to apply knowledge of computing and mathematics appropriate to the discipline.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 2;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to analyze a problem, and identify and define the computing requirements appropriate to its solution.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 3;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to design, implement, and evaluate a computer-based system, process, component, or program to meet desired needs.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 4;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to function effectively on teams to accomplish a common goal.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 5;
            outcome.Criteria = criteria;
            outcome.Text = "An understanding of professional, ethical, legal, security and social issues and responsibilities.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 6;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to communicate effectively with a range of audiences.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 7;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to analyze the local and global impact of computing on individuals, organizations, and society.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 8;
            outcome.Criteria = criteria;
            outcome.Text = "Recognition of the need for and an ability to engage in continuing professional development.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            outcome = new Outcome();
            outcome.Id = 9;
            outcome.Criteria = criteria;
            outcome.Text = "An ability to use current techniques, skills, and tools necessary for computing practice.";
            outcome.CreatedOn = DateTime.UtcNow;
            outcome.IsActive = true;
            criteria.Outcomes.Add(outcome);

            context.Criterias.Add(criteria);
        }
    }
}
