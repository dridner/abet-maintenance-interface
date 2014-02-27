using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Model
{
    public class User : IAuditable
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        
        public bool IsActive { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
