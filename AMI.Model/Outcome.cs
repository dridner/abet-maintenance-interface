﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class Outcome : IAuditable
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        [ForeignKey("Criteria"), Column(Order = 1)]
        public int CriteriaId { get; set; }
        public string Text { get; set; }

        public bool IsActive { get; set; }
        public virtual ApplicationUser CreatedByUser { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual Criteria Criteria { get; set; }
        public virtual ICollection<StudentLearningObjective> SupportedLearningObjectives { get; set; }
    }
}
