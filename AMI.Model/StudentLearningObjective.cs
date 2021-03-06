﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class StudentLearningObjective : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Order { get; set; }
        public virtual Class Class { get; set; }
        public string Text { get; set; }

        public bool IsActive { get; set; }
        public virtual ApplicationUser CreatedByUser { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Outcome> SupportedOutcomes { get; set; }
    }
}
