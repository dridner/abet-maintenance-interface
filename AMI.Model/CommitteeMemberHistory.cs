﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class CommitteeMemberHistory : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual CommitteeMember CommitteeMember { get; set; }
        public virtual Class Class { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual ApplicationUser CreatedByUser { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}
