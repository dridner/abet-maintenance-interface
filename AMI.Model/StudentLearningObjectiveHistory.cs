﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class StudentLearningObjectiveHistory : IAuditable
    {
        public int SLOId { get; set; }
        public Class Class { get; set; }
        public string Text { get; set; }

        public bool IsActive { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}