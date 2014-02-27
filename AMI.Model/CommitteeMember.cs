using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class CommitteeMember
    {
        public int CommitteeMemberId { get; set; }
        public CommitteeMemberRevision CurrentRevision { get; set; }
        public ICollection<CommitteeMemberRevision> Revisions { get; set; }
    }
}
