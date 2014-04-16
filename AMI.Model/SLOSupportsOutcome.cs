using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class SLOSupportsOutcome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SSOId { get; set; }
        public virtual ICollection<StudentLearningObjective> LearningObjectives { get; set; }
        public virtual ICollection<Outcome> Outcomes{ get; set; }
    }
}
