using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class StudentLearningObjective
    {
        public int SLOId { get; set; }
        public ClassEntity Class { get; set; }
    }
}
