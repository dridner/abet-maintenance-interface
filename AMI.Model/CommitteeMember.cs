using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class CommitteeMember : IAuditable
    {
        public int Id { get; set; }
        public Class Class { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
