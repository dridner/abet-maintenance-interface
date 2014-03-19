using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class StudentLearningObjectiveRevision : IAuditable
    {
        public int SLOId { get; set; }
        public Class Class { get; set; }
        public string Text { get; set; }

        public bool IsActive { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}
