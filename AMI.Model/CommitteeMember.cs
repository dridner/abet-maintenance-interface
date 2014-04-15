using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMI.Model.Util;

namespace AMI.Model
{
    public class CommitteeMember : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Class Class { get; set; }
        public virtual ApplicationUser User { get; set; }
        public CommitteeRank CommitteeRank { get; set; }

        public bool IsActive { get; set; }
        public virtual ApplicationUser CreatedByUser { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
