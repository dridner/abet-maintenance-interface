using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class OutcomeRevision : IAuditable
    {
        public int OutcomeId { get; set; }
        public string Text { get; set; }

        public bool IsActive { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}
