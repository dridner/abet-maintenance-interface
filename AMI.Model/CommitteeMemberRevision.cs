using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class CommitteeMemberRevision : IAuditable
    {
        public int RevisionId { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
