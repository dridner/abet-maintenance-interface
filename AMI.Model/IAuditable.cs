using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public interface IAuditable
    {
        int CreatedByUserId { get; set; }
        DateTime CreatedOn { get; set; }
    }
}
