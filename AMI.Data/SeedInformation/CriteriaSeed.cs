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
        public static void Seed(ABETContext context, ApplicationUser systemUserAccount)
        {
            CreateCriteria(context, systemUserAccount, "Criteria for Accrediting Engineering Programs", "EAC",
                "An ability to apply knowledge of mathematics, science, and engineering.",
                "An ability to design and conduct experiments, as well as to analyze and interpret data.",
                "An ability to design a system, component, or process to meet desired needs within realistic constraints such as economic, environmental, social, political, ethical, health and safety, manufacturability, and sustainability.",
                "An ability to function on multidisciplinary teams.",
                "An ability to identify, formulate, and solve engineering problems.",
                "An understanding of professional and ethical responsibility.",
                "An ability to communicate effectively.",
                "The broad education necessary to understand the impact of engineering solutions in a global, economic, environmental, and societal context.",
                "A recognition of the need for, and an ability to engage in life-long learning.",
                "A knowledge of contemporary issues.",
                "An ability to use the techniques, skills, and modern engineering tools necessary for engineering practice."
                );

            CreateCriteria(context, systemUserAccount, "Criteria for Accrediting Computing Programs", "CAC", 
                "An ability to apply knowledge of computing and mathematics appropriate to the discipline.",
                "An ability to analyze a problem, and identify and define the computing requirements appropriate to its solution.",
                "An ability to design, implement, and evaluate a computer-based system, process, component, or program to meet desired needs.",
                "An ability to function effectively on teams to accomplish a common goal.",
                "An understanding of professional, ethical, legal, security and social issues and responsibilities.",
                "An ability to communicate effectively with a range of audiences.",
                "An ability to analyze the local and global impact of computing on individuals, organizations, and society.",
                "Recognition of the need for and an ability to engage in continuing professional development.",
                "An ability to use current techniques, skills, and tools necessary for computing practice."
                );
        }

        private static void CreateCriteria(ABETContext context, ApplicationUser systemUserAccount, string criteriaName, string criteriaAbbreviation, params string[] outcomeTexts)
        {
            
            Criteria criteria = new Criteria();
            criteria.Name = criteriaName;
            criteria.Abbreviation = criteriaAbbreviation;
            criteria.Outcomes = new List<Outcome>();

            for (int i = 0; i < outcomeTexts.Length; i++)
            {
                Outcome outcome = new Outcome();
                outcome.Id = i + 1;
                outcome.Criteria = criteria;
                outcome.Text = outcomeTexts[i];
                outcome.CreatedOn = DateTime.UtcNow;
                outcome.CreatedByUser = systemUserAccount;
                outcome.IsActive = true;

                criteria.Outcomes.Add(outcome);
            }

            context.Criterias.Add(criteria);
        }
    }
}
