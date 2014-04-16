using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class SLOSupportsOutcomeHistory
    {
        [Key]
        public int Id { get; set; }
        public SLOSupportsOutcome SLOSupportsOutcome { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}
