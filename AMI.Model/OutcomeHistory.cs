using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class OutcomeHistory : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Text { get; set; }

        public bool IsActive { get; set; }
        public virtual ApplicationUser CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastActiveDate { get; set; }
        
        public virtual Outcome Outcome { get; set; }
        public virtual Criteria Criteria { get; set; }
    }
}
