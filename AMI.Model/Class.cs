using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class Class
    {
        public int ClassId { get; set; }
        public ClassRevision CurrentRevision { get; set; }
        public ICollection<ClassRevision> Revisions { get; set; }
    }
}
