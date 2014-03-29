using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class CommitteeMemberHistory : IAuditable
    {
        public CommitteeMember CommitteeMember { get; set; }
        public Class Class { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}
