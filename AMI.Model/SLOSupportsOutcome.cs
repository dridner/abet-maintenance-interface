using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class SLOSupportsOutcome
    {
        public int SSOId { get; set; }
        public SLOSupportsOutcomeRevision CurrentRevision { get; set; }
        public ICollection<SLOSupportsOutcomeRevision> Revisions { get; set; }
    }
}
